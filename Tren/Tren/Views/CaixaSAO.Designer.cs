namespace Tren.Views {
	partial class CaixaSAO {
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
			this.SuspendLayout();
			// 
			// bt_central2_voltar
			// 
			this.bt_central2_voltar.Location = new System.Drawing.Point(110, 393);
			this.bt_central2_voltar.Name = "bt_central2_voltar";
			this.bt_central2_voltar.Size = new System.Drawing.Size(237, 45);
			this.bt_central2_voltar.TabIndex = 53;
			this.bt_central2_voltar.Text = "Voltar";
			this.bt_central2_voltar.Click += new System.EventHandler(this.bt_central2_voltar_Click);
			// 
			// bt_central1_avancar
			// 
			this.bt_central1_avancar.Location = new System.Drawing.Point(453, 393);
			this.bt_central1_avancar.Name = "bt_central1_avancar";
			this.bt_central1_avancar.Size = new System.Drawing.Size(237, 45);
			this.bt_central1_avancar.TabIndex = 52;
			this.bt_central1_avancar.Text = "Avançar";
			this.bt_central1_avancar.Click += new System.EventHandler(this.bt_central1_avancar_Click);
			// 
			// lb_SeqPreliminarTitulo
			// 
			this.lb_SeqPreliminarTitulo.AutoSize = true;
			this.lb_SeqPreliminarTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lb_SeqPreliminarTitulo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lb_SeqPreliminarTitulo.Location = new System.Drawing.Point(321, 9);
			this.lb_SeqPreliminarTitulo.Name = "lb_SeqPreliminarTitulo";
			this.lb_SeqPreliminarTitulo.Size = new System.Drawing.Size(161, 25);
			this.lb_SeqPreliminarTitulo.TabIndex = 51;
			this.lb_SeqPreliminarTitulo.Text = "Entrada de Dados";
			// 
			// txb_turbulencia
			// 
			this.txb_turbulencia.Location = new System.Drawing.Point(400, 267);
			this.txb_turbulencia.Name = "txb_turbulencia";
			this.txb_turbulencia.Size = new System.Drawing.Size(238, 23);
			this.txb_turbulencia.TabIndex = 50;
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
			this.txb_viscosidadeABS.TabIndex = 48;
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
			this.txb_densidadeOleo.TabIndex = 55;
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
			// CaixaSAO
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txb_densidadeOleo);
			this.Controls.Add(this.lb_densidadeOleo);
			this.Controls.Add(this.bt_central2_voltar);
			this.Controls.Add(this.bt_central1_avancar);
			this.Controls.Add(this.lb_SeqPreliminarTitulo);
			this.Controls.Add(this.txb_turbulencia);
			this.Controls.Add(this.lb_turbulência);
			this.Controls.Add(this.txb_viscosidadeABS);
			this.Controls.Add(this.lb_viscosidadeABS);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "CaixaSAO";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "CaixaSAO";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton bt_central2_voltar;
		private MetroFramework.Controls.MetroButton bt_central1_avancar;
		private MetroFramework.Controls.MetroLabel lb_SeqPreliminarTitulo;
		private MetroFramework.Controls.MetroTextBox txb_turbulencia;
		private MetroFramework.Controls.MetroLabel lb_turbulência;
		private MetroFramework.Controls.MetroTextBox txb_viscosidadeABS;
		private MetroFramework.Controls.MetroLabel lb_viscosidadeABS;
		private MetroFramework.Controls.MetroTextBox txb_densidadeOleo;
		private MetroFramework.Controls.MetroLabel lb_densidadeOleo;
	}
}