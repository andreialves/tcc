using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tren.Classes;
using System.IO;
using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)
using Image = iTextSharp.text.Image;

namespace Tren.Views {
	public partial class CalculoViabilidadeView : View {
		Dictionary<string, string> dados;
		public CalculoViabilidadeView(Dictionary<string, string> d, InicioView pai) : base(pai) {
			InitializeComponent();
			dados = d;
		}

		private void bt_realizarCalculo_Click(object sender, EventArgs e) {
			try {
				Document relatorio = new Document(PageSize.A4);
				relatorio.SetMargins(25, 25, 25, 25);
				relatorio.AddCreationDate();

				string caminho = AppDomain.CurrentDomain.BaseDirectory + @"\Relatorio.pdf";

				PdfWriter writer = PdfWriter.GetInstance(relatorio, new FileStream(caminho, FileMode.Create));

				relatorio.Open();

				VisitorPDF geraPDF = new VisitorPDF(relatorio);
				geraPDF.visit(Pai.Centrais);

				relatorio.Close();

				PDFView n = new PDFView();
				n.Show();

			} catch (Exception erro) {
				MessageBox.Show(erro.Message);
			}


			{

				/*double vazaoMax = double.Parse(dados["vazaoMax"]);
				double vazaoMed = double.Parse(dados["vazaoMed"]);
				double vazaoMin = double.Parse(dados["vazaoMin"]);
				double vazaoMaxFut = double.Parse(dados["vazaoMaxFut"]);
				double vazaoMedFut = double.Parse(dados["vazaoMedFut"]);
				double vazaoMinFut = double.Parse(dados["vazaoMinFut"]);
				int populacao = int.Parse(dados["populacao"]);
				int populacaoFut = int.Parse(dados["populacaoFut"]);
				int tipoGrade = int.Parse(dados["tipoGrade"]);
				int tipoLimpeza = int.Parse(dados["tipoLimpeza"]);
				double espessura = double.Parse(dados["espessura"]);
				double espacamento = double.Parse(dados["espacamento"]);
				double velocidadeEfluente = double.Parse(dados["velocidadeEfluente"]);
				double taxaAreiaDiaria = double.Parse(dados["taxaAreiaDiaria"]);
				//double viscosidadeABS = double.Parse(dados["viscosidadeABS"]);
				//double densidadeOleo = double.Parse(dados["densidadeOleo"]);
				//double turbulencia = double.Parse(dados["turbulencia"]);
				double dboEntrada = double.Parse(dados["dboEntrada"]);
				double tempMesFrio = double.Parse(dados["tempMesFrio"]);

				Console.WriteLine("velocidade " + velocidadeEfluente);

				try {
					Grade gr = (Grade)(((SequenciaPreliminar)(Pai.Centrais[0].getSequencia[0])).getSeqPreliminar[2]);
					{

						Console.WriteLine("\n\n______Grade______:");
						Console.WriteLine("vazao maxFut " + gr.getPertenceASeq.getCentral.getVazaoMaxFut);
						Console.WriteLine("vazao minFut " + gr.getPertenceASeq.getCentral.getVazaoMinFut);
						Console.WriteLine("hMax " + gr.getPertenceASeq.gethMax);
						Console.WriteLine("hMin " + gr.getPertenceASeq.gethMin);
						Console.WriteLine("sessao Canal min " + gr.SecaoCanalMin);
						Console.WriteLine("sessao Canal max " + gr.SecaoCanalMax);
						Console.WriteLine("area util max " + gr.AreaUtilMax);
						Console.WriteLine("area util min " + gr.AreaUtilMin);
						Console.WriteLine("v " + gr.VelocidadeInformada);
						Console.WriteLine("v' " + gr.VelocidadeLinha);
						Console.WriteLine("velocidade max " + gr.VelocidadeAproximacaoMax);
						Console.WriteLine("velocidade min " + gr.VelocidadeAproximacaoMin);
						Console.WriteLine("hf, max " + gr.PerdaCargaMax);
						Console.WriteLine("hf, min " + gr.PerdaCargaMin);
						Console.WriteLine("hf, max obs " + gr.PerdaCargaMaxObs);
						Console.WriteLine("hf, min obs " + gr.PerdaCargaMinObs);
						Console.WriteLine("hu " + gr.PerdaCargaTotal);
						Console.WriteLine("espaçamento " + gr.Espacamento);
						Console.WriteLine("espessura " + gr.Espessura);
						Console.WriteLine("eficienci " + gr.Eficiencia);
						Console.WriteLine("comprimento " + gr.Comprimento);
						Console.WriteLine("largura qmax " + gr.LarguraMax);
						Console.WriteLine("largura qmin " + gr.LarguraMin);
						Console.WriteLine("num barras " + (gr.NumEspacamento - 1));
						Console.WriteLine("num barras min " + (gr.NumEspacamentoMin - 1));
						Console.WriteLine("num espacamento " + gr.NumEspacamento);
						Console.WriteLine("num espacamento min " + gr.NumEspacamento);
						Console.WriteLine("correção " + gr.CorrecaoEspacamento);
						Console.WriteLine("correção min " + gr.CorrecaoEspacamentoMin);
						Console.WriteLine("tipo limpeza " + gr.TipoLimpeza);
					}

					Desarenador ds = (Desarenador)(((SequenciaPreliminar)(Pai.Centrais[0].getSequencia[0])).getSeqPreliminar[1]);
					{

						Console.WriteLine("\n\n______Desarenador______:");
						Console.WriteLine("largura " + ds.Largura);
						Console.WriteLine("comprimennto " + ds.Comprimento);
						Console.WriteLine("velocidade " + ds.Velocidade);
						Console.WriteLine("hMax " + ds.getPertenceASeq.gethMax);
						Console.WriteLine("hMin " + ds.getPertenceASeq.gethMin);
						Console.WriteLine("tas " + ds.TaxaAplicacao);
						Console.WriteLine("altura por dia " + ds.AlturaAreia);
						Console.WriteLine("intervalo limpeza " + ds.IntervaloLimpeza);
						Console.WriteLine("area superficial " + ds.AreaSuperficial);
						Console.WriteLine("altura areia " + ds.AlturaAreia);
						Console.WriteLine("volume areia " + ds.VolumeDiario);

					}
					CalhaParshall cp = (CalhaParshall)(((SequenciaPreliminar)(Pai.Centrais[0].getSequencia[0])).getSeqPreliminar[0]);
					{

						Console.WriteLine("\n\n______Calha Parshall______:");
						Console.WriteLine("w " + cp.getWpol);
						Console.WriteLine("n " + cp.getN);
						Console.WriteLine("k " + cp.getK);
						Console.WriteLine("HMin " + cp.getHMin);
						Console.WriteLine("HMax " + cp.getHMax);
						Console.WriteLine("hMin " + cp.getPertenceASeq.gethMin);
						Console.WriteLine("hMax " + cp.getPertenceASeq.gethMax);
					}

					LagoaFacultativa lf = (LagoaFacultativa)(((SequenciaSecundaria)(Pai.Centrais[2].getSequencia[1])).getSeqSecundaria[0][0]);
					{

						Console.WriteLine("\n\n______Lagoa Facultativa______");
						Console.WriteLine("Carga Max " + lf.getCargaMax);
						Console.WriteLine("Carga Aflue " + lf.getCargaAfluente);
						Console.WriteLine("Area " + lf.getArea);
						Console.WriteLine("Volume " + lf.getVolume);
						Console.WriteLine("tempo Det " + lf.getTempoDetencao);
						Console.WriteLine("dbo saida " + lf.getDBOSaida);
					}

					LagoaAnaerobia la = (LagoaAnaerobia)(((SequenciaSecundaria)(Pai.Centrais[0].getSequencia[1])).getSeqSecundaria[0][0]);
					LagoaMaturacao lm = (LagoaMaturacao)(((SequenciaSecundaria)(Pai.Centrais[1].getSequencia[1])).getSeqSecundaria[2][0]);

					///////////////////////////////////////////// Criação do pdf

					Document relatorio = new Document(PageSize.A4);
					relatorio.SetMargins(25, 25, 25, 25);
					relatorio.AddCreationDate();

					string caminho = AppDomain.CurrentDomain.BaseDirectory + @"\Relatorio.pdf";

					PdfWriter writer = PdfWriter.GetInstance(relatorio, new FileStream(caminho, FileMode.Create));

					relatorio.Open();

					PdfPTable dadoss = new PdfPTable(9);

					var fontName = "Arial";
					if (!FontFactory.IsRegistered(fontName)) {
						var fontPath = Environment.GetEnvironmentVariable("SystemRoot") + "\\fonts\\arial.ttf";
						FontFactory.Register(fontPath);
					}
					iTextSharp.text.Font fonte = FontFactory.GetFont(fontName, 10);

					// Logo Tren
					Image image = Image.GetInstance(AppDomain.CurrentDomain.BaseDirectory + @"\Imagens\4.png");
					image.Alignment = Image.ALIGN_CENTER;
					image.ScalePercent(35f);
					relatorio.Add(image);


					Paragraph result = new Paragraph("Resultados\n\n", FontFactory.GetFont(fontName, 18));
					Paragraph dado = new Paragraph("Dados\n\n", FontFactory.GetFont(fontName, 14));
					result.Alignment = Element.ALIGN_CENTER;
					dado.Alignment = Element.ALIGN_CENTER;

					Paragraph[] labels = new Paragraph[9];
					Paragraph[] lin = new Paragraph[9];

					// Dados iniciais
					{
						labels[0] = new Paragraph("Vazão Máxima (L/s)", fonte);
						labels[1] = new Paragraph("Vazão Média (L/s)", fonte);
						labels[2] = new Paragraph("Vazão Mínima (L/s)", fonte);
						labels[3] = new Paragraph("Vazão Máxima Futura (L/s)", fonte);
						labels[4] = new Paragraph("Vazão Média Futura (L/s)", fonte);
						labels[5] = new Paragraph("Vazão Mínima Futura (L/s)", fonte);
						labels[6] = new Paragraph("Pup", fonte);
						labels[7] = new Paragraph("Pop Fut", fonte);
						labels[8] = new Paragraph("DBO (mg/L)", fonte);


						CentralTratamento ct = Pai.Centrais[0];

						lin[0] = new Paragraph(Math.Round(ct.getVazaoMax, 2).ToString(), fonte);
						lin[1] = new Paragraph(Math.Round(ct.getVazaoMed, 2).ToString(), fonte);
						lin[2] = new Paragraph(Math.Round(ct.getVazaoMin, 2).ToString(), fonte);
						lin[3] = new Paragraph(Math.Round(ct.getVazaoMaxFut, 2).ToString(), fonte);
						lin[4] = new Paragraph(Math.Round(ct.getVazaoMedFut, 2).ToString(), fonte);
						lin[5] = new Paragraph(Math.Round(ct.getVazaoMinFut, 2).ToString(), fonte);
						lin[6] = new Paragraph(ct.getPopulacao.ToString(), fonte);
						lin[7] = new Paragraph(ct.getPopulacaoFut.ToString(), fonte);
						lin[8] = new Paragraph(Math.Round(la.DBOEntrada, 2).ToString(), fonte);


						var cel = new PdfPCell[9];
						var cel2 = new PdfPCell[9];
						for (int i = 0; i < 9; i++) {
							cel[i] = new PdfPCell();
							cel[i].AddElement(labels[i]);
							dadoss.AddCell(cel[i]);
						}
						for (int i = 0; i < 9; i++) {
							cel2[i] = new PdfPCell();
							cel2[i].AddElement(lin[i]);
							dadoss.AddCell(cel2[i]);
						}

						var d = new PdfPCell();
						relatorio.Add(result);
						result = new Paragraph("Sequências: P + LF / P + LA + LF / P + LA + LF + LM\n\n", FontFactory.GetFont(fontName, 14));
						result.Alignment = Element.ALIGN_CENTER;
						relatorio.Add(result);
						relatorio.Add(dado);
						relatorio.Add(new Paragraph());
						relatorio.Add(dadoss);
					}
					Paragraph titulo = new Paragraph("\n\nTratamento Preliminar\n", FontFactory.GetFont(fontName, 16));
					titulo.Alignment = Element.ALIGN_CENTER;
					relatorio.Add(titulo);

					titulo = new Paragraph("\nGrades\n\n", FontFactory.GetFont(fontName, 14));
					titulo.Alignment = Element.ALIGN_CENTER;
					relatorio.Add(titulo);

					PdfPTable tabela = new PdfPTable(7);
					var cell = new PdfPCell[7];

					// Tabela Grade 1
					{

						labels = new Paragraph[7];
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

						lin = new Paragraph[7];
						lin[0] = new Paragraph("Vazão Máxima", fonte);
						lin[1] = new Paragraph(Math.Round(Convert.ToDouble(gr.Espacamento), 2).ToString(), fonte);
						lin[2] = new Paragraph(Math.Round(Convert.ToDouble(gr.Espessura), 2).ToString(), fonte);
						lin[3] = new Paragraph(Math.Round(Convert.ToDouble(gr.Eficiencia), 2).ToString(), fonte);
						lin[4] = new Paragraph(Math.Round(Convert.ToDouble(gr.VelocidadeLinha), 2).ToString(), fonte);
						lin[5] = new Paragraph(Math.Round(Convert.ToDouble(gr.SecaoCanalMax), 2).ToString(), fonte);
						lin[6] = new Paragraph(Math.Round(Convert.ToDouble(gr.VelocidadeAproximacaoMax), 2).ToString(), fonte);

						cell = new PdfPCell[7];
						for (int i = 0; i < 7; i++) {
							cell[i] = new PdfPCell();
							cell[i].AddElement(lin[i]);
							tabela.AddCell(cell[i]);
						}

						lin = new Paragraph[7];
						lin[0] = new Paragraph("Vazão Mínima", fonte);
						lin[1] = new Paragraph(Math.Round(Convert.ToDouble(gr.Espacamento), 2).ToString(), fonte);
						lin[2] = new Paragraph(Math.Round(Convert.ToDouble(gr.Espessura), 2).ToString(), fonte);
						lin[3] = new Paragraph(Math.Round(Convert.ToDouble(gr.Eficiencia), 2).ToString(), fonte);
						lin[4] = new Paragraph(Math.Round(Convert.ToDouble(gr.VelocidadeLinha), 2).ToString(), fonte);
						lin[5] = new Paragraph(Math.Round(Convert.ToDouble(gr.SecaoCanalMin), 2).ToString(), fonte);
						lin[6] = new Paragraph(Math.Round(Convert.ToDouble(gr.VelocidadeAproximacaoMin), 2).ToString(), fonte);

						cell = new PdfPCell[7];
						for (int i = 0; i < 7; i++) {
							cell[i] = new PdfPCell();
							cell[i].AddElement(lin[i]);
							tabela.AddCell(cell[i]);
						}
					}
					relatorio.Add(tabela);
					relatorio.Add(new Paragraph("\n"));
					tabela = new PdfPTable(7);

					// Tabela Grade 2
					{

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
						lin[1] = new Paragraph(Math.Round(Convert.ToDouble(gr.PerdaCargaMax), 2).ToString(), fonte);
						lin[2] = new Paragraph(Math.Round(Convert.ToDouble(gr.PerdaCargaMaxObs), 2).ToString(), fonte);
						lin[3] = new Paragraph(Math.Round(Convert.ToDouble(gr.getPertenceASeq.gethMax), 2).ToString(), fonte);
						lin[4] = new Paragraph(Math.Round(Convert.ToDouble(gr.PerdaCargaTotal), 2).ToString(), fonte);
						lin[5] = new Paragraph(Math.Round(Convert.ToDouble(gr.AreaUtilMax), 2).ToString(), fonte);
						if (gr.TipoLimpeza == 1)
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
						lin[1] = new Paragraph(Math.Round(Convert.ToDouble(gr.PerdaCargaMin), 2).ToString(), fonte);
						lin[2] = new Paragraph(Math.Round(Convert.ToDouble(gr.PerdaCargaMinObs), 2).ToString(), fonte);
						lin[3] = new Paragraph(Math.Round(Convert.ToDouble(gr.getPertenceASeq.gethMax), 2).ToString(), fonte);
						lin[4] = new Paragraph(Math.Round(Convert.ToDouble(gr.PerdaCargaTotal), 2).ToString(), fonte);
						lin[5] = new Paragraph(Math.Round(Convert.ToDouble(gr.AreaUtilMin), 2).ToString(), fonte);
						if (gr.TipoLimpeza == 1)
							lin[6] = new Paragraph("70", fonte);
						else
							lin[6] = new Paragraph("60", fonte);

						cell = new PdfPCell[7];
						for (int i = 0; i < 7; i++) {
							cell[i] = new PdfPCell();
							cell[i].AddElement(lin[i]);
							tabela.AddCell(cell[i]);
						}
					}
					relatorio.Add(tabela);
					relatorio.Add(new Paragraph("\n"));
					tabela = new PdfPTable(7);

					// Tabela Grade 3
					{

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
						lin[1] = new Paragraph(Math.Round(Convert.ToDouble(gr.Comprimento), 2).ToString(), fonte);
						lin[2] = new Paragraph(Math.Round(Convert.ToDouble(gr.LarguraMax), 2).ToString(), fonte);
						lin[3] = new Paragraph(Math.Round(Convert.ToDouble((gr.NumEspacamento - 1)), 2).ToString(), fonte);
						lin[4] = new Paragraph(Math.Round(Convert.ToDouble(gr.NumEspacamento), 2).ToString(), fonte);
						lin[5] = new Paragraph(Math.Round(Convert.ToDouble(gr.CorrecaoEspacamento), 2).ToString(), fonte);
						lin[6] = new Paragraph("35", fonte);

						cell = new PdfPCell[7];
						for (int i = 0; i < 7; i++) {
							cell[i] = new PdfPCell();
							cell[i].AddElement(lin[i]);
							tabela.AddCell(cell[i]);
						}

						lin = new Paragraph[7];
						lin[0] = new Paragraph("Vazão Mínima", fonte);
						lin[1] = new Paragraph(Math.Round(Convert.ToDouble(gr.Comprimento), 2).ToString(), fonte);
						lin[2] = new Paragraph(Math.Round(Convert.ToDouble(gr.LarguraMin), 2).ToString(), fonte);
						lin[3] = new Paragraph(Math.Round(Convert.ToDouble((gr.NumEspacamentoMin - 1)), 2).ToString(), fonte);
						lin[4] = new Paragraph(Math.Round(Convert.ToDouble(gr.NumEspacamentoMin), 2).ToString(), fonte);
						lin[5] = new Paragraph(Math.Round(Convert.ToDouble(gr.CorrecaoEspacamentoMin), 2).ToString(), fonte);
						lin[6] = new Paragraph("35", fonte);

						cell = new PdfPCell[7];
						for (int i = 0; i < 7; i++) {
							cell[i] = new PdfPCell();
							cell[i].AddElement(lin[i]);
							tabela.AddCell(cell[i]);
						}
					}
					relatorio.Add(tabela);
					relatorio.Add(new Paragraph("\n"));

					titulo = new Paragraph("\nCalha Parshall\n\n", FontFactory.GetFont(fontName, 14));
					titulo.Alignment = Element.ALIGN_CENTER;
					relatorio.Add(titulo);

					tabela = new PdfPTable(5);

					// Tabela Calha Parshall 1
					{

						labels = new Paragraph[5];
						labels[0] = new Paragraph("W (pol)", fonte);
						labels[1] = new Paragraph("W (mm)", fonte);
						labels[2] = new Paragraph("N", fonte);
						labels[3] = new Paragraph("K", fonte);
						labels[4] = new Paragraph("Hmin (m)", fonte);

						cell = new PdfPCell[5];
						for (int i = 0; i < 5; i++) {
							cell[i] = new PdfPCell();
							cell[i].AddElement(labels[i]);
							tabela.AddCell(cell[i]);
						}

						lin = new Paragraph[5];
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
					}
					relatorio.Add(tabela);
					relatorio.Add(new Paragraph("\n"));
					tabela = new PdfPTable(4);

					// Tabela Calha Parshall 2
					{

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
					}
					relatorio.Add(tabela);
					relatorio.Add(new Paragraph("\n"));

					titulo = new Paragraph("\nDesarenador\n\n", FontFactory.GetFont(fontName, 14));
					titulo.Alignment = Element.ALIGN_CENTER;
					relatorio.Add(titulo);


					tabela = new PdfPTable(6);

					// Tabela Desarenador 1
					{

						labels = new Paragraph[6];
						labels[0] = new Paragraph("Vh (m/s)", fonte);
						labels[1] = new Paragraph("Largura (m)", fonte);
						labels[2] = new Paragraph("Comprimento (m)", fonte);
						labels[3] = new Paragraph("hmax (m)", fonte);
						labels[4] = new Paragraph("hmin (m)", fonte);
						labels[5] = new Paragraph("Área Superficial (m²)", fonte);

						cell = new PdfPCell[6];
						for (int i = 0; i < 6; i++) {
							cell[i] = new PdfPCell();
							cell[i].AddElement(labels[i]);
							tabela.AddCell(cell[i]);
						}

						lin = new Paragraph[6];
						lin[0] = new Paragraph(Math.Round(Convert.ToDouble(ds.Velocidade), 2).ToString(), fonte);
						lin[1] = new Paragraph(Math.Round(Convert.ToDouble(ds.Largura), 2).ToString(), fonte);
						lin[2] = new Paragraph(Math.Round(Convert.ToDouble(ds.Comprimento), 2).ToString(), fonte);
						lin[3] = new Paragraph(Math.Round(Convert.ToDouble(cp.getPertenceASeq.gethMax), 2).ToString(), fonte);
						lin[4] = new Paragraph(Math.Round(Convert.ToDouble(cp.getPertenceASeq.gethMin), 2).ToString(), fonte);
						lin[5] = new Paragraph(Math.Round(Convert.ToDouble(ds.AreaSuperficial), 2).ToString(), fonte);

						cell = new PdfPCell[6];
						for (int i = 0; i < 6; i++) {
							cell[i] = new PdfPCell();
							cell[i].AddElement(lin[i]);
							tabela.AddCell(cell[i]);
						}
					}

					relatorio.Add(tabela);
					relatorio.Add(new Paragraph("\n"));
					tabela = new PdfPTable(5);

					// Tabela Desarenador 2
					{

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
						lin[0] = new Paragraph(Math.Round(Convert.ToDouble(ds.AreaSecao), 2).ToString(), fonte);
						lin[1] = new Paragraph(Math.Round(Convert.ToDouble(ds.TaxaAplicacao), 2).ToString(), fonte);
						lin[2] = new Paragraph(Math.Round(Convert.ToDouble(ds.VolumeDiario), 2).ToString(), fonte);
						lin[3] = new Paragraph(Math.Round(Convert.ToDouble(ds.AlturaAreia), 2).ToString(), fonte);
						lin[4] = new Paragraph(Math.Round(Convert.ToDouble(ds.IntervaloLimpeza), 2).ToString(), fonte);

						cell = new PdfPCell[5];
						for (int i = 0; i < 5; i++) {
							cell[i] = new PdfPCell();
							cell[i].AddElement(lin[i]);
							tabela.AddCell(cell[i]);
						}
					}

					relatorio.Add(tabela);
					relatorio.Add(new Paragraph("\n"));

					titulo = new Paragraph("\n\nTratamento Secundário\n\n", FontFactory.GetFont(fontName, 16));
					titulo.Alignment = Element.ALIGN_CENTER;
					relatorio.Add(titulo);

					titulo = new Paragraph("P + LF\n", FontFactory.GetFont(fontName, 16));
					titulo.Alignment = Element.ALIGN_CENTER;
					relatorio.Add(titulo);

					titulo = new Paragraph("\nLagoa Facultativa\n\n", FontFactory.GetFont(fontName, 14));
					titulo.Alignment = Element.ALIGN_CENTER;
					relatorio.Add(titulo);

					tabela = new PdfPTable(6);

					// Primeira Sequência
					lf = (LagoaFacultativa)(((SequenciaSecundaria)(Pai.Centrais[2].getSequencia[1])).getSeqSecundaria[0][0]);
					double area1 = lf.getArea;
					double volume1 = lf.getVolume;
					double tdh1 = lf.getTempoDetencao;

					// Tabela Lagoa Facultativa
					{

						labels = new Paragraph[6];
						labels[0] = new Paragraph("Cmax (KgDBO/ha*dia)", fonte);
						labels[1] = new Paragraph("Ca (KgDBO/dia)", fonte);
						labels[2] = new Paragraph("Área (m²)", fonte);
						labels[3] = new Paragraph("Volume (m³)", fonte);
						labels[4] = new Paragraph("Tempo de Detenção (dias)", fonte);
						labels[5] = new Paragraph("DBO Saída (mg/L)", fonte);

						cell = new PdfPCell[6];
						for (int i = 0; i < 6; i++) {
							cell[i] = new PdfPCell();
							cell[i].AddElement(labels[i]);
							tabela.AddCell(cell[i]);
						}

						lin = new Paragraph[6];
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
					}

					relatorio.Add(tabela);
					relatorio.Add(new Paragraph("\n"));

					titulo = new Paragraph("P + LA + LF\n", FontFactory.GetFont(fontName, 16));
					titulo.Alignment = Element.ALIGN_CENTER;
					relatorio.Add(titulo);

					titulo = new Paragraph("\nLagoa Anaeróbia\n\n", FontFactory.GetFont(fontName, 14));
					titulo.Alignment = Element.ALIGN_CENTER;
					relatorio.Add(titulo);

					tabela = new PdfPTable(9);

					// Segunda Sequência
					la = (LagoaAnaerobia)(((SequenciaSecundaria)(Pai.Centrais[0].getSequencia[1])).getSeqSecundaria[0][0]);
					lf = (LagoaFacultativa)(((SequenciaSecundaria)(Pai.Centrais[0].getSequencia[1])).getSeqSecundaria[1][0]);
					double area2 = la.getQtdLagoas * la.getArea + lf.getArea;
					double volume2 = la.getQtdLagoas *  la.getVolume + lf.getVolume;
					double tdh2 = la.getTempoDetHidr + lf.getTempoDetencao;

					// Tabela Lagoa Anaeróbia
					{

						labels = new Paragraph[9];
						labels[0] = new Paragraph("Número de Lagoas)", fonte);
						labels[1] = new Paragraph("TDH (dias)", fonte);
						labels[2] = new Paragraph("Volume Unitário (m³)", fonte);
						labels[3] = new Paragraph("Área Unitária (m²)", fonte);
						labels[4] = new Paragraph("Comp e Largura Unitários (m)", fonte);
						labels[5] = new Paragraph("DBO Saída (Mg/L)", fonte);
						labels[6] = new Paragraph("Lodo Anual (m³/ano)", fonte);
						labels[7] = new Paragraph("Esp Anual (m/ano)", fonte);
						labels[8] = new Paragraph("Esp Futura (m/ano)", fonte);

						cell = new PdfPCell[9];
						for (int i = 0; i < 9; i++) {
							cell[i] = new PdfPCell();
							cell[i].AddElement(labels[i]);
							tabela.AddCell(cell[i]);
						}

						lin = new Paragraph[9];
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
					}

					relatorio.Add(tabela);
					relatorio.Add(new Paragraph("\n"));

					titulo = new Paragraph("\nLagoa Facultativa\n\n", FontFactory.GetFont(fontName, 14));
					titulo.Alignment = Element.ALIGN_CENTER;
					relatorio.Add(titulo);

					tabela = new PdfPTable(6);

					// Tabela Lagoa Facultativa
					{

						labels = new Paragraph[6];
						labels[0] = new Paragraph("Cmax (KgDBO/ha*dia)", fonte);
						labels[1] = new Paragraph("Ca (KgDBO/dia)", fonte);
						labels[2] = new Paragraph("Área (m²)", fonte);
						labels[3] = new Paragraph("Volume (m³)", fonte);
						labels[4] = new Paragraph("Tempo de Detenção (dias)", fonte);
						labels[5] = new Paragraph("DBO Saída (mg/L)", fonte);

						cell = new PdfPCell[6];
						for (int i = 0; i < 6; i++) {
							cell[i] = new PdfPCell();
							cell[i].AddElement(labels[i]);
							tabela.AddCell(cell[i]);
						}

						lin = new Paragraph[6];
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
					}

					relatorio.Add(tabela);
					relatorio.Add(new Paragraph("\n"));

					titulo = new Paragraph("P + LA + LF + LM\n", FontFactory.GetFont(fontName, 16));
					titulo.Alignment = Element.ALIGN_CENTER;
					relatorio.Add(titulo);

					tabela = new PdfPTable(9);

					titulo = new Paragraph("\nLagoa Anaeróbia\n\n", FontFactory.GetFont(fontName, 14));
					titulo.Alignment = Element.ALIGN_CENTER;
					relatorio.Add(titulo);

					// Terceira Sequência
					la = (LagoaAnaerobia)(((SequenciaSecundaria)(Pai.Centrais[1].getSequencia[1])).getSeqSecundaria[0][0]);
					lf = (LagoaFacultativa)(((SequenciaSecundaria)(Pai.Centrais[1].getSequencia[1])).getSeqSecundaria[1][0]);
					lm = (LagoaMaturacao)(((SequenciaSecundaria)(Pai.Centrais[1].getSequencia[1])).getSeqSecundaria[2][0]);
					double area3 = la.getQtdLagoas * la.getArea + lf.getArea + (double)lm.AreaSuperficialTotal;
					double volume3 = la.getQtdLagoas * la.getVolume + lf.getVolume + (double)lm.Volume;
					double tdh3 = la.getTempoDetHidr + lf.getTempoDetencao + 12;

					// Tabela Lagoa Anaeróbia
					{
						labels = new Paragraph[9];
						labels[0] = new Paragraph("Número de Lagoas)", fonte);
						labels[1] = new Paragraph("TDH (dias)", fonte);
						labels[2] = new Paragraph("Volume Unitário (m³)", fonte);
						labels[3] = new Paragraph("Área Unitária (m²)", fonte);
						labels[4] = new Paragraph("Comp e Largura Unitários (m)", fonte);
						labels[5] = new Paragraph("DBO Saída (Mg/L)", fonte);
						labels[6] = new Paragraph("Lodo Anual (m³/ano)", fonte);
						labels[7] = new Paragraph("Esp Anual (m/ano)", fonte);
						labels[8] = new Paragraph("Esp Futura (m/ano)", fonte);

						cell = new PdfPCell[9];
						for (int i = 0; i < 9; i++) {
							cell[i] = new PdfPCell();
							cell[i].AddElement(labels[i]);
							tabela.AddCell(cell[i]);
						}

						lin = new Paragraph[9];
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
					}

					relatorio.Add(tabela);
					relatorio.Add(new Paragraph("\n"));

					titulo = new Paragraph("\nLagoa Facultativa\n\n", FontFactory.GetFont(fontName, 14));
					titulo.Alignment = Element.ALIGN_CENTER;
					relatorio.Add(titulo);

					tabela = new PdfPTable(6);

					// Tabela Lagoa Facultativa
					{

						labels = new Paragraph[6];
						labels[0] = new Paragraph("Cmax (KgDBO/ha*dia)", fonte);
						labels[1] = new Paragraph("Ca (KgDBO/dia)", fonte);
						labels[2] = new Paragraph("Área (m²)", fonte);
						labels[3] = new Paragraph("Volume (m³)", fonte);
						labels[4] = new Paragraph("Tempo de Detenção (dias)", fonte);
						labels[5] = new Paragraph("DBO Saída (mg/L)", fonte);

						cell = new PdfPCell[6];
						for (int i = 0; i < 6; i++) {
							cell[i] = new PdfPCell();
							cell[i].AddElement(labels[i]);
							tabela.AddCell(cell[i]);
						}

						lin = new Paragraph[6];
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
					}

					relatorio.Add(tabela);
					relatorio.Add(new Paragraph("\n"));

					tabela = new PdfPTable(8);

					titulo = new Paragraph("\nLagoa de Maturação\n\n", FontFactory.GetFont(fontName, 14));
					titulo.Alignment = Element.ALIGN_CENTER;
					relatorio.Add(titulo);

					// Tabela Lagoa de Maturação
					{
						labels = new Paragraph[8];
						labels[0] = new Paragraph("Número de Lagoas)", fonte);
						labels[1] = new Paragraph("Volume Unitário (m³)", fonte);
						labels[2] = new Paragraph("Área Unitária (m²)", fonte);
						labels[3] = new Paragraph("Área Total(m²)", fonte);
						labels[4] = new Paragraph("Largura (m)", fonte);
						labels[5] = new Paragraph("Comp (m)", fonte);
						labels[6] = new Paragraph("Conc de E.coli Saída (CF/100ml)", fonte);
						labels[7] = new Paragraph("Eficiência do Sistema (%)", fonte);

						cell = new PdfPCell[8];
						for (int i = 0; i < 8; i++) {
							cell[i] = new PdfPCell();
							cell[i].AddElement(labels[i]);
							tabela.AddCell(cell[i]);
						}

						lin = new Paragraph[8];
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
					}

					relatorio.Add(tabela);
					relatorio.Add(new Paragraph("\n"));

					titulo = new Paragraph("\n\nGráficos Comparativos\n\n", FontFactory.GetFont(fontName, 16));
					titulo.Alignment = Element.ALIGN_CENTER;
					relatorio.Add(titulo);

					string[] nome = { "P + LF", "P + LA + LF", "P + LA + LF + LM" };
					// Grafico 1
					Chart grafico = new Chart();
					grafico.Titles.Add("Área (m²)");

					grafico.ChartAreas.Add(new ChartArea());
					grafico.ChartAreas[0].AxisX.Interval = 1;
					grafico.Series.Add("serie");
					grafico.Series["serie"].Points.AddXY("P + LF", area1);
					grafico.Series["serie"].Points.AddXY("P + LA + LF", area2);
					grafico.Series["serie"].Points.AddXY("P + LA + LF + LM", area3);

					MemoryStream memoryStream = new MemoryStream();
					grafico.SaveImage(memoryStream, ChartImageFormat.Png);
					image = Image.GetInstance(memoryStream.GetBuffer());
					image.Alignment = Image.ALIGN_CENTER;
					image.ScalePercent(75f);
					relatorio.Add(image);

					relatorio.Add(new Paragraph("\n\n"));
					// Grafico 2
					{
						grafico = new Chart();
						grafico.Titles.Add("Volume (m³)");

						grafico.ChartAreas.Add(new ChartArea());
						grafico.ChartAreas[0].AxisX.Interval = 1;
						grafico.Series.Add("serie");
						grafico.Series["serie"].Points.AddXY("P + LF", volume1);
						grafico.Series["serie"].Points.AddXY("P + LA + LF", volume2);
						grafico.Series["serie"].Points.AddXY("P + LA + LF + LM", volume3);


						memoryStream = new MemoryStream();
						grafico.SaveImage(memoryStream, ChartImageFormat.Png);
						image = Image.GetInstance(memoryStream.GetBuffer());
						image.Alignment = Image.ALIGN_CENTER;
						image.ScalePercent(75f);
						relatorio.Add(image);
					}

					relatorio.Add(new Paragraph("\n\n"));
					// Grafico 3
					{
						grafico = new Chart();
						grafico.Titles.Add("TDH (dias)");

						grafico.ChartAreas.Add(new ChartArea());
						grafico.ChartAreas[0].AxisX.Interval = 1;
						grafico.Series.Add("serie");
						grafico.Series["serie"].Points.AddXY("P + LF", tdh1);
						grafico.Series["serie"].Points.AddXY("P + LA + LF", tdh2);
						grafico.Series["serie"].Points.AddXY("P + LA + LF + LM", tdh3);

						memoryStream = new MemoryStream();
						grafico.SaveImage(memoryStream, ChartImageFormat.Png);
						image = Image.GetInstance(memoryStream.GetBuffer());
						image.Alignment = Image.ALIGN_CENTER;
						image.ScalePercent(75f);
						relatorio.Add(image);
					}

					relatorio.Add(new Paragraph("\n\n"));
					// Grafico 4
					{
						grafico = new Chart();
						grafico.Titles.Add("Eficiência (%)");

						grafico.ChartAreas.Add(new ChartArea());
						grafico.ChartAreas[0].AxisX.Interval = 1;
						grafico.Series.Add("serie");
						grafico.Series["serie"].Points.AddXY("P + LF", 80);
						grafico.Series["serie"].Points.AddXY("P + LA + LF", 90);
						grafico.Series["serie"].Points.AddXY("P + LA + LF + LM", 90);

						memoryStream = new MemoryStream();
						grafico.SaveImage(memoryStream, ChartImageFormat.Png);
						image = Image.GetInstance(memoryStream.GetBuffer());
						image.Alignment = Image.ALIGN_CENTER;
						image.ScalePercent(75f);
						relatorio.Add(image);
					}

					relatorio.Close();

					//////////////////////////////Final do gerador de pdf


					PDFView n = new PDFView();
					n.Show();

				} catch (Exception erro) {
					MessageBox.Show(erro.Message);
				}*/
			}
		}

		private void bt_final_voltar_Click(object sender, EventArgs e) {
			Pai.voltaView();
			Hide();
		}

    }
}
