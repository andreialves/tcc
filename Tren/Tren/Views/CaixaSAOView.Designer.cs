namespace Tren.Views {
	partial class CaixaSAOView {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.bt_central2_voltar = new MetroFramework.Controls.MetroButton();
			this.bt_central1_avancar = new MetroFramework.Controls.MetroButton();
			this.lb_SeqPreliminarTitulo = new MetroFramework.Controls.MetroLabel();
			this.txb_turbulencia = new MetroFramework.Controls.MetroTextBox();
			this.lb_turbulência = new MetroFramework.Controls.MetroLabel();
			this.txb_viscosidadeABS = new MetroFramework.Controls.MetroTextBox();
			this.lb_viscosidadeABS = new MetroFramework.Controls.MetroLabel();
			this.txb_densidadeOleo = new MetroFramework.Controls.MetroTextBox();
			this.lb_densidadeOleo = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// bt_central2_voltar
			// 
			this.bt_central2_voltar.Location = new System.Drawing.Point(110, 393);
			this.bt_central2_voltar.Name = "bt_central2_voltar";
			this.bt_central2_voltar.Size = new System.Drawing.Size(237, 45);
			this.bt_central2_voltar.TabIndex = 5;
			this.bt_central2_voltar.Text = "Voltar";
			this.bt_central2_voltar.Click += new System.EventHandler(this.bt_central2_voltar_Click);
			// 
			// bt_central1_avancar
			// 
			this.bt_central1_avancar.Location = new System.Drawing.Point(453, 393);
			this.bt_central1_avancar.Name = "bt_central1_avancar";
			this.bt_central1_avancar.Size = new System.Drawing.Size(237, 45);
			this.bt_central1_avancar.TabIndex = 4;
			this.bt_central1_avancar.Text = "Avançar";
			this.bt_central1_avancar.Click += new System.EventHandler(this.bt_central1_avancar_Click);
			// 
			// lb_SeqPreliminarTitulo
			// 
			this.lb_SeqPreliminarTitulo.AutoSize = true;
			this.lb_SeqPreliminarTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lb_SeqPreliminarTitulo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lb_SeqPreliminarTitulo.Location = new System.Drawing.Point(268, 9);
			this.lb_SeqPreliminarTitulo.Name = "lb_SeqPreliminarTitulo";
			this.lb_SeqPreliminarTitulo.Size = new System.Drawing.Size(266, 25);
			this.lb_SeqPreliminarTitulo.TabIndex = 51;
			this.lb_SeqPreliminarTitulo.Text = "Entrada de Dados - Caixa SAO";
			// 
			// txb_turbulencia
			// 
			this.txb_turbulencia.Location = new System.Drawing.Point(400, 267);
			this.txb_turbulencia.Name = "txb_turbulencia";
			this.txb_turbulencia.Size = new System.Drawing.Size(238, 23);
			this.txb_turbulencia.TabIndex = 3;
			this.txb_turbulencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_numeros);
			// 
			// lb_turbulência
			// 
			this.lb_turbulência.AutoSize = true;
			this.lb_turbulência.Location = new System.Drawing.Point(162, 271);
			this.lb_turbulência.Name = "lb_turbulência";
			this.lb_turbulência.Size = new System.Drawing.Size(127, 19);
			this.lb_turbulência.TabIndex = 49;
			this.lb_turbulência.Text = "Fator de Turbulência";
			// 
			// txb_viscosidadeABS
			// 
			this.txb_viscosidadeABS.Location = new System.Drawing.Point(400, 130);
			this.txb_viscosidadeABS.Name = "txb_viscosidadeABS";
			this.txb_viscosidadeABS.Size = new System.Drawing.Size(238, 23);
			this.txb_viscosidadeABS.TabIndex = 1;
			this.txb_viscosidadeABS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_numeros);
			// 
			// lb_viscosidadeABS
			// 
			this.lb_viscosidadeABS.AutoSize = true;
			this.lb_viscosidadeABS.Location = new System.Drawing.Point(162, 134);
			this.lb_viscosidadeABS.Name = "lb_viscosidadeABS";
			this.lb_viscosidadeABS.Size = new System.Drawing.Size(132, 19);
			this.lb_viscosidadeABS.TabIndex = 47;
			this.lb_viscosidadeABS.Text = "Viscosidade Absoluta";
			// 
			// txb_densidadeOleo
			// 
			this.txb_densidadeOleo.Location = new System.Drawing.Point(400, 197);
			this.txb_densidadeOleo.Name = "txb_densidadeOleo";
			this.txb_densidadeOleo.Size = new System.Drawing.Size(238, 23);
			this.txb_densidadeOleo.TabIndex = 2;
			this.txb_densidadeOleo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_numeros);
			// 
			// lb_densidadeOleo
			// 
			this.lb_densidadeOleo.AutoSize = true;
			this.lb_densidadeOleo.Location = new System.Drawing.Point(162, 201);
			this.lb_densidadeOleo.Name = "lb_densidadeOleo";
			this.lb_densidadeOleo.Size = new System.Drawing.Size(103, 19);
			this.lb_densidadeOleo.TabIndex = 54;
			this.lb_densidadeOleo.Text = "Densidade Óleo";
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(644, 201);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(45, 19);
			this.metroLabel1.TabIndex = 58;
			this.metroLabel1.Text = "g/cm³";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(644, 134);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(59, 19);
			this.metroLabel3.TabIndex = 56;
			this.metroLabel3.Text = "g/(cm*s)";
			// 
			// CaixaSAOView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.txb_densidadeOleo);
			this.Controls.Add(this.lb_densidadeOleo);
			this.Controls.Add(this.bt_central2_voltar);
			this.Controls.Add(this.bt_central1_avancar);
			this.Controls.Add(this.lb_SeqPreliminarTitulo);
			this.Controls.Add(this.txb_turbulencia);
			this.Controls.Add(this.lb_turbulência);
			this.Controls.Add(this.txb_viscosidadeABS);
			this.Controls.Add(this.lb_viscosidadeABS);
			this.Name = "CaixaSAOView";
			this.Text = "CaixaSAO";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroButton bt_central1_avancar;
		private MetroFramework.Controls.MetroLabel lb_SeqPreliminarTitulo;
		private MetroFramework.Controls.MetroTextBox txb_turbulencia;
		private MetroFramework.Controls.MetroLabel lb_turbulência;
		private MetroFramework.Controls.MetroTextBox txb_viscosidadeABS;
		private MetroFramework.Controls.MetroLabel lb_viscosidadeABS;
		private MetroFramework.Controls.MetroTextBox txb_densidadeOleo;
		private MetroFramework.Controls.MetroLabel lb_densidadeOleo;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroButton bt_central2_voltar;
	}
}