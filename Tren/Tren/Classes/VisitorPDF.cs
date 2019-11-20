using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tren.Interfaces;
using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)
using Image = iTextSharp.text.Image;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;

namespace Tren.Classes {
	public class VisitorPDF : Visitor {
		private Document pdf;
		private Font fonte;
		private Font fonteTitulo;
		private double areaTotCentral, volumeTotCentral, tdhTotCentral, eficienciaTotCentral;
		private Chart graficoArea, graficoVolume, graficoTDH, graficoEficiencia;
		private bool foiPreliminar;
		private int cont;


		public VisitorPDF(Document doc) {
			pdf = doc;

			if (!FontFactory.IsRegistered("Arial")) {
				var fontPath = Environment.GetEnvironmentVariable("SystemRoot") + "\\fonts\\arial.ttf";
				FontFactory.Register(fontPath);
			}
			fonte = FontFactory.GetFont("Arial", 10);
			fonteTitulo = FontFactory.GetFont("Arial", 14);

		}

		public Document Document {
			set {
				pdf = value;
			}
		}

		public void visit(CaixaSAO cs) {
			Paragraph titulo = new Paragraph("\n\nCaixa SAO\n\n", fonteTitulo);
			titulo.Alignment = Element.ALIGN_CENTER;
			pdf.Add(titulo);

			// INICIO TABELA
			PdfPTable tabela = new PdfPTable(8);

			Paragraph[] labels = new Paragraph[8];
			labels[0] = new Paragraph("V Vertical (cm/s)", fonte);
			labels[1] = new Paragraph("V Horizontal (cm/s)", fonte);
			labels[2] = new Paragraph("Área Transv (m²)", fonte);
			labels[3] = new Paragraph("Largura (m)", fonte);
			labels[4] = new Paragraph("Profundidade (m)", fonte);
			labels[5] = new Paragraph("Comprimento (m)", fonte);
			labels[6] = new Paragraph("Vol (m³)", fonte);
			labels[7] = new Paragraph("TDH (min)", fonte);

			PdfPCell[] cell = new PdfPCell[8];
			for (int i = 0; i < 8; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(labels[i]);
				tabela.AddCell(cell[i]);
			}

			Paragraph[] lin = new Paragraph[8];
			lin[0] = new Paragraph(Math.Round(cs.getVVertical, 2).ToString(), fonte);
			lin[1] = new Paragraph(Math.Round(cs.getVHorizontal, 2).ToString(), fonte);
			lin[2] = new Paragraph(Math.Round(cs.getAreaTransv, 2).ToString(), fonte);
			lin[3] = new Paragraph(Math.Round(cs.getLargura, 2).ToString(), fonte);
			lin[4] = new Paragraph(Math.Round(cs.getProfundidade, 2).ToString(), fonte);
			lin[5] = new Paragraph(Math.Round(cs.getComprimento, 2).ToString(), fonte);
			lin[6] = new Paragraph(Math.Round(cs.getVolume, 2).ToString(), fonte);
			lin[7] = new Paragraph(Math.Round(cs.getTempoRes, 2).ToString(), fonte);

			cell = new PdfPCell[8];
			for (int i = 0; i < 8; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(lin[i]);
				tabela.AddCell(cell[i]);
			}

			pdf.Add(tabela);
			// FIM TABELA

			pdf.Add(new Paragraph("\n"));
		}

		public void visit(CalhaParshall cp) {
			Paragraph titulo = new Paragraph("\n\nCalha Parshall\n\n", fonteTitulo);
			titulo.Alignment = Element.ALIGN_CENTER;
			pdf.Add(titulo);

			// INICIO TABELA 1
			PdfPTable tabela = new PdfPTable(5);

			Paragraph[] labels = new Paragraph[5];
			labels[0] = new Paragraph("W (pol)", fonte);
			labels[1] = new Paragraph("W (mm)", fonte);
			labels[2] = new Paragraph("N", fonte);
			labels[3] = new Paragraph("K", fonte);
			labels[4] = new Paragraph("Hmin (m)", fonte);

			PdfPCell[] cell = new PdfPCell[5];
			for (int i = 0; i < 5; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(labels[i]);
				tabela.AddCell(cell[i]);
			}

			Paragraph[] lin = new Paragraph[5];
			lin[0] = new Paragraph(cp.getWpol.ToString(), fonte);
			lin[1] = new Paragraph(cp.getWmm.ToString(), fonte);
			lin[2] = new Paragraph(cp.getN.ToString(), fonte);
			lin[3] = new Paragraph(cp.getK.ToString(), fonte);
			lin[4] = new Paragraph(Math.Round(cp.getHMin, 2).ToString(), fonte);

			cell = new PdfPCell[5];
			for (int i = 0; i < 5; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(lin[i]);
				tabela.AddCell(cell[i]);
			}

			pdf.Add(tabela);
			// FIM TABELA 1

			pdf.Add(new Paragraph("\n"));

			// INICIO TABELA 2
			tabela = new PdfPTable(4);

			labels = new Paragraph[4];
			labels[0] = new Paragraph("Hmax (m)", fonte);
			labels[1] = new Paragraph("Z (m)", fonte);
			labels[2] = new Paragraph("hmin (m)", fonte);
			labels[3] = new Paragraph("hmax (m)", fonte);

			cell = new PdfPCell[4];
			for (int i = 0; i < 4; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(labels[i]);
				tabela.AddCell(cell[i]);
			}

			lin = new Paragraph[4];
			lin[0] = new Paragraph(Math.Round(cp.getHMax, 2).ToString(), fonte);
			lin[1] = new Paragraph(Math.Round(cp.getDesnivel, 2).ToString(), fonte);
			lin[2] = new Paragraph(Math.Round((double)cp.getPertenceASeq.gethMin, 2).ToString(), fonte);
			lin[3] = new Paragraph(Math.Round((double)cp.getPertenceASeq.gethMax, 2).ToString(), fonte);

			cell = new PdfPCell[4];
			for (int i = 0; i < 4; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(lin[i]);
				tabela.AddCell(cell[i]);
			}

			pdf.Add(tabela);
			// FIM TABELA 2

			pdf.Add(new Paragraph("\n"));
		}

		public void visit(Desarenador d) {
			Paragraph titulo = new Paragraph("\nDesarenador\n\n", fonteTitulo);
			titulo.Alignment = Element.ALIGN_CENTER;
			pdf.Add(titulo);

			// INICIO TABELA 1
			PdfPTable tabela = new PdfPTable(6);

			Paragraph[] labels = new Paragraph[6];
			labels[0] = new Paragraph("Vh (m/s)", fonte);
			labels[1] = new Paragraph("Largura (m)", fonte);
			labels[2] = new Paragraph("Comprimento (m)", fonte);
			labels[3] = new Paragraph("hmax (m)", fonte);
			labels[4] = new Paragraph("hmin (m)", fonte);
			labels[5] = new Paragraph("Área Superficial (m²)", fonte);

			PdfPCell[] cell = new PdfPCell[6];
			for (int i = 0; i < 6; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(labels[i]);
				tabela.AddCell(cell[i]);
			}

			Paragraph[] lin = new Paragraph[6];
			lin[0] = new Paragraph(Math.Round(Convert.ToDouble(d.Velocidade), 2).ToString(), fonte);
			lin[1] = new Paragraph(Math.Round(Convert.ToDouble(d.Largura), 2).ToString(), fonte);
			lin[2] = new Paragraph(Math.Round(Convert.ToDouble(d.Comprimento), 2).ToString(), fonte);
			lin[3] = new Paragraph(Math.Round(Convert.ToDouble(d.getPertenceASeq.gethMax), 2).ToString(), fonte);
			lin[4] = new Paragraph(Math.Round(Convert.ToDouble(d.getPertenceASeq.gethMin), 2).ToString(), fonte);
			lin[5] = new Paragraph(Math.Round(Convert.ToDouble(d.AreaSuperficial), 2).ToString(), fonte);

			cell = new PdfPCell[6];
			for (int i = 0; i < 6; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(lin[i]);
				tabela.AddCell(cell[i]);
			}

			pdf.Add(tabela);
			// FIM TABELA 1

			pdf.Add(new Paragraph("\n"));

			// INICIO TABELA 2
			tabela = new PdfPTable(5);

			labels = new Paragraph[5];
			labels[0] = new Paragraph("Área Transversal (m²)", fonte);
			labels[1] = new Paragraph("TAS (m²/(m³d))", fonte);
			labels[2] = new Paragraph("Volume Areia (L/dia)", fonte);
			labels[3] = new Paragraph("Altura de Areia (m/dia)", fonte);
			labels[4] = new Paragraph("Intervalo de Limpeza (dias)", fonte);

			cell = new PdfPCell[5];
			for (int i = 0; i < 5; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(labels[i]);
				tabela.AddCell(cell[i]);
			}

			lin = new Paragraph[5];
			lin[0] = new Paragraph(Math.Round(Convert.ToDouble(d.AreaSecao), 2).ToString(), fonte);
			lin[1] = new Paragraph(Math.Round(Convert.ToDouble(d.TaxaAplicacao), 2).ToString(), fonte);
			lin[2] = new Paragraph(Math.Round(Convert.ToDouble(d.VolumeDiario), 2).ToString(), fonte);
			lin[3] = new Paragraph(Math.Round(Convert.ToDouble(d.AlturaAreia), 2).ToString(), fonte);
			lin[4] = new Paragraph(Math.Round(Convert.ToDouble(d.IntervaloLimpeza), 2).ToString(), fonte);

			cell = new PdfPCell[5];
			for (int i = 0; i < 5; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(lin[i]);
				tabela.AddCell(cell[i]);
			}

			pdf.Add(tabela);
			// FIM TABELA 2

			pdf.Add(new Paragraph("\n"));
		}

		public void visit(Grade g) {
			Paragraph titulo = new Paragraph("\nGrades\n\n", fonteTitulo);
			titulo.Alignment = Element.ALIGN_CENTER;
			pdf.Add(titulo);

			// INICIO TABELA 1
			PdfPTable tabela = new PdfPTable(7);
			PdfPCell[] cell = new PdfPCell[7];

			Paragraph[] labels = new Paragraph[7];
			labels[0] = new Paragraph(" ", fonte);
			labels[1] = new Paragraph("Esp (mm)", fonte);
			labels[2] = new Paragraph("Espessura (mm)", fonte);
			labels[3] = new Paragraph("Eficiência (%)", fonte);
			labels[4] = new Paragraph("Velocidade Máxima (m/s)", fonte);
			labels[5] = new Paragraph("Seção do Canal (m²)", fonte);
			labels[6] = new Paragraph("Velocidade de Aprox (m/s)", fonte);

			for (int i = 0; i < 7; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(labels[i]);
				tabela.AddCell(cell[i]);
			}

			Paragraph[] lin = new Paragraph[7];
			lin[0] = new Paragraph("Vazão Máxima", fonte);
			lin[1] = new Paragraph(Math.Round(Convert.ToDouble(g.Espacamento), 2).ToString(), fonte);
			lin[2] = new Paragraph(Math.Round(Convert.ToDouble(g.Espessura), 2).ToString(), fonte);
			lin[3] = new Paragraph(Math.Round(Convert.ToDouble(g.Eficiencia), 2).ToString(), fonte);
			lin[4] = new Paragraph(Math.Round(Convert.ToDouble(g.VelocidadeLinha), 2).ToString(), fonte);
			lin[5] = new Paragraph(Math.Round(Convert.ToDouble(g.SecaoCanalMax), 2).ToString(), fonte);
			lin[6] = new Paragraph(Math.Round(Convert.ToDouble(g.VelocidadeAproximacaoMax), 2).ToString(), fonte);

			cell = new PdfPCell[7];
			for (int i = 0; i < 7; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(lin[i]);
				tabela.AddCell(cell[i]);
			}

			lin = new Paragraph[7];
			lin[0] = new Paragraph("Vazão Mínima", fonte);
			lin[1] = new Paragraph(Math.Round(Convert.ToDouble(g.Espacamento), 2).ToString(), fonte);
			lin[2] = new Paragraph(Math.Round(Convert.ToDouble(g.Espessura), 2).ToString(), fonte);
			lin[3] = new Paragraph(Math.Round(Convert.ToDouble(g.Eficiencia), 2).ToString(), fonte);
			lin[4] = new Paragraph(Math.Round(Convert.ToDouble(g.VelocidadeLinha), 2).ToString(), fonte);
			lin[5] = new Paragraph(Math.Round(Convert.ToDouble(g.SecaoCanalMin), 2).ToString(), fonte);
			lin[6] = new Paragraph(Math.Round(Convert.ToDouble(g.VelocidadeAproximacaoMin), 2).ToString(), fonte);

			cell = new PdfPCell[7];
			for (int i = 0; i < 7; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(lin[i]);
				tabela.AddCell(cell[i]);
			}

			pdf.Add(tabela);
			// FIM TABELA 1

			pdf.Add(new Paragraph("\n"));

			// INICIO TABELA 2
			tabela = new PdfPTable(7);

			labels = new Paragraph[7];
			labels[0] = new Paragraph(" ", fonte);
			labels[1] = new Paragraph("Hf Grade Limpa (m)", fonte);
			labels[2] = new Paragraph("Hf Grade 50% Suja (m)", fonte);
			labels[3] = new Paragraph("hmáx (m)", fonte);
			labels[4] = new Paragraph("Hu (m)", fonte);
			labels[5] = new Paragraph("Área Útil (m²)", fonte);
			labels[6] = new Paragraph("Ângulo Inclinação (°)", fonte);

			cell = new PdfPCell[7];
			for (int i = 0; i < 7; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(labels[i]);
				tabela.AddCell(cell[i]);
			}

			lin = new Paragraph[7];
			lin[0] = new Paragraph("Vazão Máxima", fonte);
			lin[1] = new Paragraph(Math.Round(Convert.ToDouble(g.PerdaCargaMax), 2).ToString(), fonte);
			lin[2] = new Paragraph(Math.Round(Convert.ToDouble(g.PerdaCargaMaxObs), 2).ToString(), fonte);
			lin[3] = new Paragraph(Math.Round(Convert.ToDouble(g.getPertenceASeq.gethMax), 2).ToString(), fonte);
			lin[4] = new Paragraph(Math.Round(Convert.ToDouble(g.PerdaCargaTotal), 2).ToString(), fonte);
			lin[5] = new Paragraph(Math.Round(Convert.ToDouble(g.AreaUtilMax), 2).ToString(), fonte);
			if (g.TipoLimpeza == 1)
				lin[6] = new Paragraph("70", fonte);
			else
				lin[6] = new Paragraph("60", fonte);

			cell = new PdfPCell[7];
			for (int i = 0; i < 7; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(lin[i]);
				tabela.AddCell(cell[i]);
			}

			lin = new Paragraph[7];
			lin[0] = new Paragraph("Vazão Mínima", fonte);
			lin[1] = new Paragraph(Math.Round(Convert.ToDouble(g.PerdaCargaMin), 2).ToString(), fonte);
			lin[2] = new Paragraph(Math.Round(Convert.ToDouble(g.PerdaCargaMinObs), 2).ToString(), fonte);
			lin[3] = new Paragraph(Math.Round(Convert.ToDouble(g.getPertenceASeq.gethMax), 2).ToString(), fonte);
			lin[4] = new Paragraph(Math.Round(Convert.ToDouble(g.PerdaCargaTotal), 2).ToString(), fonte);
			lin[5] = new Paragraph(Math.Round(Convert.ToDouble(g.AreaUtilMin), 2).ToString(), fonte);
			if (g.TipoLimpeza == 1)
				lin[6] = new Paragraph("70", fonte);
			else
				lin[6] = new Paragraph("60", fonte);

			cell = new PdfPCell[7];
			for (int i = 0; i < 7; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(lin[i]);
				tabela.AddCell(cell[i]);
			}

			pdf.Add(tabela);
			// FIM TABELA 2

			pdf.Add(new Paragraph("\n"));

			//INICIO TABELA 3
			tabela = new PdfPTable(7);

			labels = new Paragraph[7];
			labels[0] = new Paragraph(" ", fonte);
			labels[1] = new Paragraph("Comp (m)", fonte);
			labels[2] = new Paragraph("Largura (m)", fonte);
			labels[3] = new Paragraph("Número de Barras", fonte);
			labels[4] = new Paragraph("Nº Esp", fonte);
			labels[5] = new Paragraph("Correção (mm)", fonte);
			labels[6] = new Paragraph("e (mm)", fonte);

			cell = new PdfPCell[7];
			for (int i = 0; i < 7; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(labels[i]);
				tabela.AddCell(cell[i]);
			}

			lin = new Paragraph[7];
			lin[0] = new Paragraph("Vazão Máxima", fonte);
			lin[1] = new Paragraph(Math.Round(Convert.ToDouble(g.Comprimento), 2).ToString(), fonte);
			lin[2] = new Paragraph(Math.Round(Convert.ToDouble(g.LarguraMax), 2).ToString(), fonte);
			lin[3] = new Paragraph(Math.Round(Convert.ToDouble((g.NumEspacamento - 1)), 2).ToString(), fonte);
			lin[4] = new Paragraph(Math.Round(Convert.ToDouble(g.NumEspacamento), 2).ToString(), fonte);
			lin[5] = new Paragraph(Math.Round(Convert.ToDouble(g.CorrecaoEspacamento), 2).ToString(), fonte);
			lin[6] = new Paragraph("35", fonte);

			cell = new PdfPCell[7];
			for (int i = 0; i < 7; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(lin[i]);
				tabela.AddCell(cell[i]);
			}

			lin = new Paragraph[7];
			lin[0] = new Paragraph("Vazão Mínima", fonte);
			lin[1] = new Paragraph(Math.Round(Convert.ToDouble(g.Comprimento), 2).ToString(), fonte);
			lin[2] = new Paragraph(Math.Round(Convert.ToDouble(g.LarguraMin), 2).ToString(), fonte);
			lin[3] = new Paragraph(Math.Round(Convert.ToDouble((g.NumEspacamentoMin - 1)), 2).ToString(), fonte);
			lin[4] = new Paragraph(Math.Round(Convert.ToDouble(g.NumEspacamentoMin), 2).ToString(), fonte);
			lin[5] = new Paragraph(Math.Round(Convert.ToDouble(g.CorrecaoEspacamentoMin), 2).ToString(), fonte);
			lin[6] = new Paragraph("35", fonte);

			cell = new PdfPCell[7];
			for (int i = 0; i < 7; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(lin[i]);
				tabela.AddCell(cell[i]);
			}

			pdf.Add(tabela);
			// FIM TABELA 3

			pdf.Add(new Paragraph("\n"));
		}

		public void visit(LagoaAnaerobia la) {
			Paragraph titulo = new Paragraph("\nLagoa Anaeróbia\n\n", fonteTitulo);
			titulo.Alignment = Element.ALIGN_CENTER;
			pdf.Add(titulo);

			// INICIO TABELA
			PdfPTable tabela = new PdfPTable(9);

			Paragraph[] labels = new Paragraph[9];
			labels[0] = new Paragraph("Número de Lagoas)", fonte);
			labels[1] = new Paragraph("TDH (dias)", fonte);
			labels[2] = new Paragraph("Volume Unitário (m³)", fonte);
			labels[3] = new Paragraph("Área Unitária (m²)", fonte);
			labels[4] = new Paragraph("Comp e Largura Unitários (m)", fonte);
			labels[5] = new Paragraph("DBO Saída (Mg/L)", fonte);
			labels[6] = new Paragraph("Lodo Anual (m³/ano)", fonte);
			labels[7] = new Paragraph("Esp Anual (m/ano)", fonte);
			labels[8] = new Paragraph("Esp Futura (m/ano)", fonte);

			PdfPCell[] cell = new PdfPCell[9];
			for (int i = 0; i < 9; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(labels[i]);
				tabela.AddCell(cell[i]);
			}

			Paragraph[] lin = new Paragraph[9];
			lin[0] = new Paragraph(la.getQtdLagoas.ToString(), fonte);
			lin[1] = new Paragraph(Math.Round(la.getTempoDetHidr, 2).ToString(), fonte);
			lin[2] = new Paragraph(Math.Round(la.getVolume, 2).ToString(), fonte);
			lin[3] = new Paragraph(Math.Round(la.getArea, 2).ToString(), fonte);
			lin[4] = new Paragraph(Math.Round(la.getLargura, 2).ToString(), fonte);
			lin[5] = new Paragraph(Math.Round(la.getDBOSaida, 2).ToString(), fonte);
			lin[6] = new Paragraph(Math.Round(la.getLodoAnual, 2).ToString(), fonte);
			lin[7] = new Paragraph(Math.Round(la.getEspessura, 2).ToString(), fonte);
			lin[8] = new Paragraph(Math.Round(la.getEspessuraFut, 2).ToString(), fonte);

			cell = new PdfPCell[9];
			for (int i = 0; i < 9; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(lin[i]);
				tabela.AddCell(cell[i]);
			}

			pdf.Add(tabela);
			// FIM TABELA

			pdf.Add(new Paragraph("\n"));

			areaTotCentral += la.getQtdLagoas * la.getArea;
			volumeTotCentral += la.getQtdLagoas * la.getVolume;
			tdhTotCentral += la.getTempoDetHidr;
			eficienciaTotCentral += (100 - eficienciaTotCentral) * 0.5;
		}

		public void visit(LagoaFacultativa lf) {
			Paragraph titulo = new Paragraph("\nLagoa Facultativa\n\n", fonteTitulo);
			titulo.Alignment = Element.ALIGN_CENTER;
			pdf.Add(titulo);

			// INICIO TABELA
			PdfPTable tabela = new PdfPTable(6);

			Paragraph[] labels = new Paragraph[6];
			labels[0] = new Paragraph("Cmax (KgDBO/ha*dia)", fonte);
			labels[1] = new Paragraph("Ca (KgDBO/dia)", fonte);
			labels[2] = new Paragraph("Área (m²)", fonte);
			labels[3] = new Paragraph("Volume (m³)", fonte);
			labels[4] = new Paragraph("Tempo de Detenção (dias)", fonte);
			labels[5] = new Paragraph("DBO Saída (mg/L)", fonte);

			PdfPCell[] cell = new PdfPCell[6];
			for (int i = 0; i < 6; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(labels[i]);
				tabela.AddCell(cell[i]);
			}

			Paragraph[] lin = new Paragraph[6];
			lin[0] = new Paragraph(Math.Round(lf.getCargaMax, 2).ToString(), fonte);
			lin[1] = new Paragraph(Math.Round(lf.getCargaAfluente, 2).ToString(), fonte);
			lin[2] = new Paragraph(Math.Round(lf.getArea, 2).ToString(), fonte);
			lin[3] = new Paragraph(Math.Round(lf.getVolume, 2).ToString(), fonte);
			lin[4] = new Paragraph(Math.Round(lf.getTempoDetencao, 2).ToString(), fonte);
			lin[5] = new Paragraph(Math.Round(lf.getDBOSaida, 2).ToString(), fonte);

			cell = new PdfPCell[6];
			for (int i = 0; i < 6; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(lin[i]);
				tabela.AddCell(cell[i]);
			}

			pdf.Add(tabela);
			// FIM TABELA

			pdf.Add(new Paragraph("\n"));

			areaTotCentral += lf.getArea;
			volumeTotCentral += lf.getVolume;
			tdhTotCentral += lf.getTempoDetencao;
			eficienciaTotCentral += (100 - eficienciaTotCentral) * 0.8;
		}

		public void visit(LagoaMaturacao lm) {
			Paragraph titulo = new Paragraph("\nLagoa de Maturação\n\n", fonteTitulo);
			titulo.Alignment = Element.ALIGN_CENTER;
			pdf.Add(titulo);

			// INICIO TABELA
			PdfPTable tabela = new PdfPTable(8);
			Paragraph[] labels = new Paragraph[8];
			labels[0] = new Paragraph("Número de Lagoas)", fonte);
			labels[1] = new Paragraph("Volume Unitário (m³)", fonte);
			labels[2] = new Paragraph("Área Unitária (m²)", fonte);
			labels[3] = new Paragraph("Área Total(m²)", fonte);
			labels[4] = new Paragraph("Largura (m)", fonte);
			labels[5] = new Paragraph("Comp (m)", fonte);
			labels[6] = new Paragraph("Conc de E.coli Saída (CF/100ml)", fonte);
			labels[7] = new Paragraph("Eficiência do Sistema (%)", fonte);

			PdfPCell[] cell = new PdfPCell[8];
			for (int i = 0; i < 8; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(labels[i]);
				tabela.AddCell(cell[i]);
			}

			Paragraph[] lin = new Paragraph[8];
			lin[0] = new Paragraph("3", fonte);
			lin[1] = new Paragraph(Math.Round(Convert.ToDouble(lm.Volume), 2).ToString(), fonte);
			lin[2] = new Paragraph(Math.Round(Convert.ToDouble(lm.AreaSuperficial), 2).ToString(), fonte);
			lin[3] = new Paragraph(Math.Round(Convert.ToDouble(lm.AreaSuperficialTotal), 2).ToString(), fonte);
			lin[4] = new Paragraph(Math.Round(Convert.ToDouble(lm.Largura), 2).ToString(), fonte);
			lin[5] = new Paragraph(Math.Round(Convert.ToDouble(lm.Comprimento), 2).ToString(), fonte);
			lin[6] = new Paragraph(Math.Round(Convert.ToDouble(lm.ConcentracaoColiformesFinais), 2).ToString(), fonte);
			lin[7] = new Paragraph(Math.Round(Convert.ToDouble(lm.Eficiencia), 5).ToString(), fonte);

			cell = new PdfPCell[8];
			for (int i = 0; i < 8; i++) {
				cell[i] = new PdfPCell();
				cell[i].AddElement(lin[i]);
				tabela.AddCell(cell[i]);
			}

			pdf.Add(tabela);
			// FIM TABELA

			pdf.Add(new Paragraph("\n"));

			areaTotCentral += (double)lm.AreaSuperficialTotal;
			volumeTotCentral += (double)lm.Volume;
			tdhTotCentral += 12;
			eficienciaTotCentral += (100 - eficienciaTotCentral) * 0;
		}

		public void visit(TanqueSeptico ts) {
			throw new NotImplementedException();
		}

        public void visit(ReatorUASB reatorUASB) {

            Paragraph titulo = new Paragraph("\nReator UASB\n\n", fonteTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            pdf.Add(titulo);


            // INICIO TABELA

            PdfPTable tabela = new PdfPTable(7);
            Paragraph[] labels = new Paragraph[7];
            labels[0] = new Paragraph("Volume Total (m³)", fonte);
            labels[1] = new Paragraph("Área requerida (m²)", fonte);
            labels[2] = new Paragraph("Número de Reatores", fonte);
            labels[3] = new Paragraph("Produção de Lodo (m³/d)", fonte);
            labels[4] = new Paragraph("Produção de Gás(m³/d)", fonte);
            labels[5] = new Paragraph("DBO Final (mg/L)", fonte);
            labels[6] = new Paragraph("DQO Final (mg/L)", fonte);

            PdfPCell[] cell = new PdfPCell[7];
            for (int i = 0; i < 7; i++) {
                cell[i] = new PdfPCell();
                cell[i].AddElement(labels[i]);
                tabela.AddCell(cell[i]);
            }

            Paragraph[] lin = new Paragraph[7];
            lin[0] = new Paragraph(Math.Round(Convert.ToDouble(reatorUASB.VolumeTotal), 2).ToString(), fonte);
            lin[1] = new Paragraph(Math.Round(Convert.ToDouble(reatorUASB.AreaRequerida), 2).ToString(), fonte);
            lin[2] = new Paragraph(Math.Round(Convert.ToDouble(reatorUASB.NumReatores), 2).ToString(), fonte);
            lin[3] = new Paragraph(Math.Round(Convert.ToDouble(reatorUASB.ProducaoLodo), 2).ToString(), fonte);
            lin[4] = new Paragraph(Math.Round(Convert.ToDouble(reatorUASB.ProducaoGas), 2).ToString(), fonte);
            lin[5] = new Paragraph(Math.Round(Convert.ToDouble(reatorUASB.DboFinal), 2).ToString(), fonte);
            lin[6] = new Paragraph(Math.Round(Convert.ToDouble(reatorUASB.DqoFinal), 2).ToString(), fonte);


            cell = new PdfPCell[7];
            for (int i = 0; i < 7; i++) {
                cell[i] = new PdfPCell();
                cell[i].AddElement(lin[i]);
                tabela.AddCell(cell[i]);
            }

            pdf.Add(tabela);
            // FIM TABELA

            // colocar os valores de area, volume, tdh e eficiencia nas variaveis do grafico

            pdf.Add(new Paragraph("\n"));

            areaTotCentral += (double)reatorUASB.AreaRequerida;
            volumeTotCentral += (double)reatorUASB.VolumeTotal;
            tdhTotCentral += ((double)reatorUASB.detencaoHidraulica/24);
            eficienciaTotCentral += (100 - eficienciaTotCentral) * 0.65;
        }

		public void visit(List<CentralTratamento> listC) {
			Image image = Image.GetInstance(AppDomain.CurrentDomain.BaseDirectory + @"\Imagens\4.png");
			image.Alignment = Image.ALIGN_CENTER;
			image.ScalePercent(35f);
			pdf.Add(image);

			Paragraph titulo = new Paragraph("Resultados\n\n", FontFactory.GetFont("Arial", 18));
			titulo.Alignment = Element.ALIGN_CENTER;
			pdf.Add(titulo);

			
			titulo = new Paragraph("Dados\n\n", fonteTitulo);
			titulo.Alignment = Element.ALIGN_CENTER;
			pdf.Add(titulo);

			pdf.Add(new Paragraph("\n"));

			// INICIO TABELA
			PdfPTable tabela = new PdfPTable(9);

			Paragraph[] labels = new Paragraph[9];
			labels[0] = new Paragraph("Vazão Máxima (L/s)", fonte);
			labels[1] = new Paragraph("Vazão Média (L/s)", fonte);
			labels[2] = new Paragraph("Vazão Mínima (L/s)", fonte);
			labels[3] = new Paragraph("Vazão Máxima Futura (L/s)", fonte);
			labels[4] = new Paragraph("Vazão Média Futura (L/s)", fonte);
			labels[5] = new Paragraph("Vazão Mínima Futura (L/s)", fonte);
			labels[6] = new Paragraph("Pop", fonte);
			labels[7] = new Paragraph("Pop Fut", fonte);
			labels[8] = new Paragraph("DBO (mg/L)", fonte);

			CentralTratamento ct = listC[0];

			Paragraph[] lin = new Paragraph[9];
			lin[0] = new Paragraph(Math.Round(ct.getVazaoMax, 2).ToString(), fonte);
			lin[1] = new Paragraph(Math.Round(ct.getVazaoMed, 2).ToString(), fonte);
			lin[2] = new Paragraph(Math.Round(ct.getVazaoMin, 2).ToString(), fonte);
			lin[3] = new Paragraph(Math.Round(ct.getVazaoMaxFut, 2).ToString(), fonte);
			lin[4] = new Paragraph(Math.Round(ct.getVazaoMedFut, 2).ToString(), fonte);
			lin[5] = new Paragraph(Math.Round(ct.getVazaoMinFut, 2).ToString(), fonte);
			lin[6] = new Paragraph(ct.getPopulacao.ToString(), fonte);
			lin[7] = new Paragraph(ct.getPopulacaoFut.ToString(), fonte);
			//lin[8] = new Paragraph(Math.Round(la.DBOEntrada, 2).ToString(), fonte);
			lin[8] = new Paragraph(ct.DBOEntrada.ToString(), fonte);

			var cel = new PdfPCell[9];
			for (int i = 0; i < 9; i++) {
				cel[i] = new PdfPCell();
				cel[i].AddElement(labels[i]);
				tabela.AddCell(cel[i]);
			}
			for (int i = 0; i < 9; i++) {
				cel[i] = new PdfPCell();
				cel[i].AddElement(lin[i]);
				tabela.AddCell(cel[i]);
			}

			pdf.Add(tabela);
			// FIM TABELA
			

			graficoArea = new Chart();
			graficoArea.Titles.Add("Área (m²)");
			graficoArea.ChartAreas.Add(new ChartArea());
			graficoArea.ChartAreas[0].AxisX.Interval = 1;
			graficoArea.Series.Add("serie");

			graficoVolume = new Chart();
			graficoVolume.Titles.Add("Volume (m³)");
			graficoVolume.ChartAreas.Add(new ChartArea());
			graficoVolume.ChartAreas[0].AxisX.Interval = 1;
			graficoVolume.Series.Add("serie");

			graficoTDH = new Chart();
			graficoTDH.Titles.Add("TDH (Dias)");
			graficoTDH.ChartAreas.Add(new ChartArea());
			graficoTDH.ChartAreas[0].AxisX.Interval = 1;
			graficoTDH.Series.Add("serie");

			graficoEficiencia = new Chart();
			graficoEficiencia.Titles.Add("Eficiência (%)");
			graficoEficiencia.ChartAreas.Add(new ChartArea());
			graficoEficiencia.ChartAreas[0].AxisX.Interval = 1;
			graficoEficiencia.Series.Add("serie");

			foiPreliminar = false;
			cont = 1;
			foreach (CentralTratamento c in listC) {
				areaTotCentral = 0;
				volumeTotCentral = 0;
				tdhTotCentral = 0;
				eficienciaTotCentral = 0;
				foreach (Sequencia s in c.getSequencia)
					s.accept(this);
				cont++;
			}

			titulo = new Paragraph("\n\nGráficos Comparativos\n\n", fonteTitulo);
			titulo.Alignment = Element.ALIGN_CENTER;
			pdf.Add(titulo);

			MemoryStream memoryStream = new MemoryStream();
			graficoArea.SaveImage(memoryStream, ChartImageFormat.Png);
			image = Image.GetInstance(memoryStream.GetBuffer());
			image.Alignment = Image.ALIGN_CENTER;
			image.ScalePercent(75f);
			pdf.Add(image);

			pdf.Add(new Paragraph("\n\n"));

			memoryStream = new MemoryStream();
			graficoVolume.SaveImage(memoryStream, ChartImageFormat.Png);
			image = Image.GetInstance(memoryStream.GetBuffer());
			image.Alignment = Image.ALIGN_CENTER;
			image.ScalePercent(75f);
			pdf.Add(image);

			pdf.Add(new Paragraph("\n\n"));

			memoryStream = new MemoryStream();
			graficoTDH.SaveImage(memoryStream, ChartImageFormat.Png);
			image = Image.GetInstance(memoryStream.GetBuffer());
			image.Alignment = Image.ALIGN_CENTER;
			image.ScalePercent(75f);
			pdf.Add(image);

			pdf.Add(new Paragraph("\n\n"));

			memoryStream = new MemoryStream();
			graficoEficiencia.SaveImage(memoryStream, ChartImageFormat.Png);
			image = Image.GetInstance(memoryStream.GetBuffer());
			image.Alignment = Image.ALIGN_CENTER;
			image.ScalePercent(75f);
			pdf.Add(image);
		}

		public void visit(SequenciaPreliminar sp) {
			if (foiPreliminar)
				return;

			foiPreliminar = true;

			foreach (UnidadePreliminar up in sp.getSeqPreliminar) {
				up.accept(this);
			}
		}

		public void visit(SequenciaSecundaria ss) {
			Paragraph numSeq = new Paragraph("Sequência " + cont + "\n\n");
			numSeq.Alignment = Element.ALIGN_CENTER;
			pdf.Add(numSeq);
			foreach (List<UnidadeSecundaria> lus in ss.getSeqSecundaria) {
				foreach (UnidadeSecundaria us in lus) {
					us.accept(this);
				}
			}
			string label = "Sequência " + cont;
			graficoArea.Series["serie"].Points.AddXY(label, areaTotCentral);
			graficoVolume.Series["serie"].Points.AddXY(label, volumeTotCentral);
			graficoTDH.Series["serie"].Points.AddXY(label, tdhTotCentral);
			graficoEficiencia.Series["serie"].Points.AddXY(label, eficienciaTotCentral);
		}
	}
}
