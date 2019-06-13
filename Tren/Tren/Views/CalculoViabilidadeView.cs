using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tren.Classes;

using System.IO;

using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)

namespace Tren.Views {
	public partial class CalculoViabilidadeView : View {
		Dictionary<string, string> dados;
		public CalculoViabilidadeView(Dictionary<string, string> d, InicioView pai) : base(pai) {
			InitializeComponent();
			dados = d;
		}

		private void bt_realizarCalculo_Click(object sender, EventArgs e) {
			foreach (var dado in dados)
				Console.WriteLine(dado.ToString());

			double vazaoMax = double.Parse(dados["vazaoMax"]);
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
				CentralTratamento ct = new CentralTratamento(vazaoMax, vazaoMed, vazaoMin, vazaoMaxFut, vazaoMedFut, vazaoMinFut, populacao, populacaoFut);
				SequenciaPreliminar sp = new SequenciaPreliminar(ct);
				ct.adicionar(sp);

				CalhaParshall cp = new CalhaParshall(sp);
				sp.adicionar(cp);

				Grade gr = new Grade(espessura, espacamento, tipoGrade, tipoLimpeza, sp);
				gr.CalculoEficiencia();
				gr.CalculaAreaUtil();
				gr.CalculaAreaUtilLinha();
				gr.CalculaSecaoCanal();
                gr.CalculaSecaoCanalLinha();
				gr.CalculaLarguraCanal();
                gr.CalculaLarguraCanalLinha();
				gr.CalculaSecaoCanalLinha();
				gr.CalculaVelocidadeLinha();
				gr.CalculaVelAproxMax();
				gr.CalculaVelAproxMin();
				gr.CalculaPerdaCarga();
				gr.CalculaPerdaCargaTotal();
				gr.CalculaBarras();
				gr.CalculaCorrecaoEspaco();
				gr.CalculaDiferencaEspaco();
				gr.CalculaComprimento();
				sp.adicionar(gr);

				Desarenador ds = new Desarenador(velocidadeEfluente, taxaAreiaDiaria, sp);
				ds.CalculaLarguraDesarenador();
				ds.CalculaAreaSecao();
				if (!ds.VerificaVH()) {
					ds.corrigeVelocidade(velocidadeEfluente);
				}
				ds.CalculaComprimento();
				ds.calculaAreaSuperficial();
				ds.CalculaTAS();
				if (!ds.VerificaTAS()) {
					ds.corrigeVelocidade(velocidadeEfluente);
				}
				ds.calculaFrequenciaLimpeza();
				sp.adicionar(ds);

				//CaixaSAO cs = new CaixaSAO(viscosidadeABS, densidadeOleo, turbulencia, sp);
				//sp.adicionar(cs);

				SequenciaSecundaria ss = new SequenciaSecundaria(ct);
				ct.adicionar(ss);
				LagoaFacultativa lf = new LagoaFacultativa(dboEntrada, tempMesFrio, ss);
				ss.adicionarEmSerie(lf);

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
                Console.WriteLine("num barras" + (gr.NumEspacamento - 1));
                Console.WriteLine("num espacamento " + gr.NumEspacamento);
                Console.WriteLine("correção " + gr.CorrecaoEspacamento);



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
                

				Console.WriteLine("\n\n______Calha Parshall______:");
				Console.WriteLine("w " + cp.getW);
				Console.WriteLine("n " + cp.getN);
				Console.WriteLine("k " + cp.getK);
				Console.WriteLine("HMin " + cp.getHMin);
				Console.WriteLine("HMax " + cp.getHMax);
				Console.WriteLine("hMin " + cp.getPertenceASeq.gethMin);
				Console.WriteLine("hMax " + cp.getPertenceASeq.gethMax);



				Console.WriteLine("\n\n______Lagoa Facultativa______");
				Console.WriteLine("Carga Max " + lf.getCargaMax);
				Console.WriteLine("Carga Aflue " + lf.getCargaAfluente);
				Console.WriteLine("Area " + lf.getArea);
				Console.WriteLine("Volume " + lf.getVolume);
				Console.WriteLine("tempo Det " + lf.getTempoDetencao);
				Console.WriteLine("dbo saida " + lf.getTempoDetencao);

                ///////////////////////////////////////////// Criação do pdf
                ///

                Document relatorio = new Document(PageSize.A4);
                relatorio.SetMargins(40, 40, 40, 40);
                relatorio.AddCreationDate();

                string caminho = AppDomain.CurrentDomain.BaseDirectory + @"\Relatorio.pdf";

                PdfWriter writer = PdfWriter.GetInstance(relatorio, new FileStream(caminho, FileMode.Create));

                relatorio.Open();

                PdfPTable dadoss = new PdfPTable(8);
				//iTextSharp.text.Font fonte = FontFactory.GetFont(BaseFont.TIMES_ROMAN, 9);

				////////////////////////////
				//var fontPath = Environment.GetEnvironmentVariable("SystemRoot") + "\\fonts\\tahoma.ttf";
				var fontName = "Arial";
				if (!FontFactory.IsRegistered(fontName)) {
					var fontPath = Environment.GetEnvironmentVariable("SystemRoot") + "\\fonts\\arial.ttf";
					FontFactory.Register(fontPath);
				}
				iTextSharp.text.Font fonte = FontFactory.GetFont(fontName, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
				// n entendi mt bem q q ta acontecendo com essas funçoes ainda, mas ta funcionando
				/////////////////////////////


				Paragraph result = new Paragraph("Resultados", FontFactory.GetFont(fontName, 20));
                Paragraph dado = new Paragraph("Dados", FontFactory.GetFont(fontName, 16));
                result.Alignment = Element.ALIGN_CENTER;
                dado.Alignment = Element.ALIGN_CENTER;

				Paragraph[] col = new Paragraph[8];

                col[0] = new Paragraph("Qmín, L/s", fonte);
                col[1] = new Paragraph("Qmáx, L/s", fonte);
                col[2] = new Paragraph("Qméd, L/s", fonte);
                col[3] = new Paragraph("Qmín 20 anos, L/s", fonte);
                col[4] = new Paragraph("Qmáx 20 anos, L/s", fonte);
                col[5] = new Paragraph("Qméd 20 anos, L/s", fonte);
                col[6] = new Paragraph("Pop atual", fonte);
                col[7] = new Paragraph("Pop 20 anos", fonte);


                Paragraph[] lin = new Paragraph[8];

                lin[0] = new Paragraph(Convert.ToString(ct.getVazaoMin), fonte);
                lin[1] = new Paragraph(Convert.ToString(ct.getVazaoMax), fonte);
                lin[2] = new Paragraph(Convert.ToString(ct.getVazaoMed), fonte);
                lin[3] = new Paragraph(Convert.ToString(ct.getVazaoMinFut), fonte);
                lin[4] = new Paragraph(Convert.ToString(ct.getVazaoMaxFut), fonte);
                lin[5] = new Paragraph(Convert.ToString(ct.getVazaoMedFut), fonte);
                lin[6] = new Paragraph(Convert.ToString(ct.getPopulacao), fonte);
                lin[7] = new Paragraph(Convert.ToString(ct.getPopulacaoFut), fonte);


                var cel = new PdfPCell[8];
                var cel2 = new PdfPCell[8];
				for (int i = 0; i < 8; i++) {
					cel[i] = new PdfPCell();
                    cel[i].AddElement(col[i]);
                    dadoss.AddCell(cel[i]);
                }
                for(int i = 0; i < 8; i++) {
                    cel2[i] = new PdfPCell();
                    cel2[i].AddElement(lin[i]);
                    dadoss.AddCell(cel2[i]);
                }

                var d = new PdfPCell();
				relatorio.Add(result);
                relatorio.Add(dado);
                relatorio.Add(new Paragraph());
                relatorio.Add(dadoss);

                relatorio.Close();

				//////////////////////////////Final do gerador de pdf
				

				PDFView n = new PDFView();
                n.Show();

			} catch (Exception erro) {
				MessageBox.Show(erro.Message);
			}
		}

		private void bt_final_voltar_Click(object sender, EventArgs e) {
			Pai.voltaView();
			Hide();
		}

    }
}
