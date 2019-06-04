namespace Tren.Views {
	partial class SequenciaPreliminar {
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
			this.txb_hMax = new MetroFramework.Controls.MetroTextBox();
			this.lb_hMax = new MetroFramework.Controls.MetroLabel();
			this.txb_hMin = new MetroFramework.Controls.MetroTextBox();
			this.lb_hMin = new MetroFramework.Controls.MetroLabel();
			this.lb_SeqPreliminarTitulo = new MetroFramework.Controls.MetroLabel();
			this.bt_central2_voltar = new MetroFramework.Controls.MetroButton();
			this.bt_central1_avancar = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// txb_hMax
			// 
			this.txb_hMax.Location = new System.Drawing.Point(400, 235);
			this.txb_hMax.Name = "txb_hMax";
			this.txb_hMax.Size = new System.Drawing.Size(238, 23);
			this.txb_hMax.TabIndex = 13;
			// 
			// lb_hMax
			// 
			this.lb_hMax.AutoSize = true;
			this.lb_hMax.Location = new System.Drawing.Point(162, 239);
			this.lb_hMax.Name = "lb_hMax";
			this.lb_hMax.Size = new System.Drawing.Size(41, 19);
			this.lb_hMax.TabIndex = 12;
			this.lb_hMax.Text = "hMax";
			// 
			// txb_hMin
			// 
			this.txb_hMin.Location = new System.Drawing.Point(400, 154);
			this.txb_hMin.Name = "txb_hMin";
			this.txb_hMin.Size = new System.Drawing.Size(238, 23);
			this.txb_hMin.TabIndex = 11;
			// 
			// lb_hMin
			// 
			this.lb_hMin.AutoSize = true;
			this.lb_hMin.Location = new System.Drawing.Point(162, 158);
			this.lb_hMin.Name = "lb_hMin";
			this.lb_hMin.Size = new System.Drawing.Size(38, 19);
			this.lb_hMin.TabIndex = 10;
			this.lb_hMin.Text = "hMin";
			// 
			// lb_SeqPreliminarTitulo
			// 
			this.lb_SeqPreliminarTitulo.AutoSize = true;
			this.lb_SeqPreliminarTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lb_SeqPreliminarTitulo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lb_SeqPreliminarTitulo.Location = new System.Drawing.Point(321, 9);
			this.lb_SeqPreliminarTitulo.Name = "lb_SeqPreliminarTitulo";
			this.lb_SeqPreliminarTitulo.Size = new System.Drawing.Size(161, 25);
			this.lb_SeqPreliminarTitulo.TabIndex = 35;
			this.lb_SeqPreliminarTitulo.Text = "Entrada de Dados";
			// 
			// bt_central2_voltar
			// 
			this.bt_central2_voltar.Location = new System.Drawing.Point(110, 393);
			this.bt_central2_voltar.Name = "bt_central2_voltar";
			this.bt_central2_voltar.Size = new System.Drawing.Size(237, 45);
			this.bt_central2_voltar.TabIndex = 46;
			this.bt_central2_voltar.Text = "Voltar";
			this.bt_central2_voltar.Click += new System.EventHandler(this.bt_central2_voltar_Click);
			// 
			// bt_central1_avancar
			// 
			this.bt_central1_avancar.Location = new System.Drawing.Point(453, 393);
			this.bt_central1_avancar.Name = "bt_central1_avancar";
			this.bt_central1_avancar.Size = new System.Drawing.Size(237, 45);
			this.bt_central1_avancar.TabIndex = 45;
			this.bt_central1_avancar.Text = "Avançar";
			this.bt_central1_avancar.Click += new System.EventHandler(this.bt_central1_avancar_Click);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(644, 239);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(50, 19);
			this.metroLabel1.TabIndex = 48;
			this.metroLabel1.Text = "metros";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(644, 158);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(50, 19);
			this.metroLabel2.TabIndex = 47;
			this.metroLabel2.Text = "metros";
			// 
			// SequenciaPreliminar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.bt_central2_voltar);
			this.Controls.Add(this.bt_central1_avancar);
			this.Controls.Add(this.lb_SeqPreliminarTitulo);
			this.Controls.Add(this.txb_hMax);
			this.Controls.Add(this.lb_hMax);
			this.Controls.Add(this.txb_hMin);
			this.Controls.Add(this.lb_hMin);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SequenciaPreliminar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Sequencia Preliminar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroTextBox txb_hMax;
		private MetroFramework.Controls.MetroLabel lb_hMax;
		private MetroFramework.Controls.MetroTextBox txb_hMin;
		private MetroFramework.Controls.MetroLabel lb_hMin;
		private MetroFramework.Controls.MetroLabel lb_SeqPreliminarTitulo;
		private MetroFramework.Controls.MetroButton bt_central2_voltar;
		private MetroFramework.Controls.MetroButton bt_central1_avancar;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel2;
	}
}