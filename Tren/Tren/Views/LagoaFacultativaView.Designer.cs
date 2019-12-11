namespace Tren.Views {
	partial class LagoaFacultativaView {
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
			this.bt_lagoFacul_voltar = new MetroFramework.Controls.MetroButton();
			this.bt_lagoaFacul_avancar = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txb_tempMesFrio = new MetroFramework.Controls.MetroTextBox();
			this.lb_tempMesFrio = new MetroFramework.Controls.MetroLabel();
			this.lb_LagFaculTitulo = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// bt_lagoFacul_voltar
			// 
			this.bt_lagoFacul_voltar.Location = new System.Drawing.Point(110, 393);
			this.bt_lagoFacul_voltar.Name = "bt_lagoFacul_voltar";
			this.bt_lagoFacul_voltar.Size = new System.Drawing.Size(237, 45);
			this.bt_lagoFacul_voltar.TabIndex = 2;
			this.bt_lagoFacul_voltar.Text = "Voltar";
			this.bt_lagoFacul_voltar.Click += new System.EventHandler(this.bt_lagoFacul_voltar_Click);
			// 
			// bt_lagoaFacul_avancar
			// 
			this.bt_lagoaFacul_avancar.Location = new System.Drawing.Point(453, 393);
			this.bt_lagoaFacul_avancar.Name = "bt_lagoaFacul_avancar";
			this.bt_lagoaFacul_avancar.Size = new System.Drawing.Size(237, 45);
			this.bt_lagoaFacul_avancar.TabIndex = 1;
			this.bt_lagoaFacul_avancar.Text = "Avançar";
			this.bt_lagoaFacul_avancar.Click += new System.EventHandler(this.bt_lagoaFacul_avancar_Click);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(620, 202);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(23, 19);
			this.metroLabel1.TabIndex = 74;
			this.metroLabel1.Text = "°C";
			// 
			// txb_tempMesFrio
			// 
			this.txb_tempMesFrio.Location = new System.Drawing.Point(376, 198);
			this.txb_tempMesFrio.Name = "txb_tempMesFrio";
			this.txb_tempMesFrio.Size = new System.Drawing.Size(238, 23);
			this.txb_tempMesFrio.TabIndex = 0;
			this.txb_tempMesFrio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_numeros);
			// 
			// lb_tempMesFrio
			// 
			this.lb_tempMesFrio.AutoSize = true;
			this.lb_tempMesFrio.Location = new System.Drawing.Point(138, 202);
			this.lb_tempMesFrio.Name = "lb_tempMesFrio";
			this.lb_tempMesFrio.Size = new System.Drawing.Size(169, 19);
			this.lb_tempMesFrio.TabIndex = 0;
			this.lb_tempMesFrio.Text = "Temperatura Mês Mais Frio";
			// 
			// lb_LagFaculTitulo
			// 
			this.lb_LagFaculTitulo.AutoSize = true;
			this.lb_LagFaculTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lb_LagFaculTitulo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lb_LagFaculTitulo.Location = new System.Drawing.Point(236, 9);
			this.lb_LagFaculTitulo.Name = "lb_LagFaculTitulo";
			this.lb_LagFaculTitulo.Size = new System.Drawing.Size(324, 25);
			this.lb_LagFaculTitulo.TabIndex = 71;
			this.lb_LagFaculTitulo.Text = "Entrada de Dados - Lagoa Facultativa";
			// 
			// LagoaFacultativaView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.bt_lagoFacul_voltar);
			this.Controls.Add(this.bt_lagoaFacul_avancar);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.txb_tempMesFrio);
			this.Controls.Add(this.lb_tempMesFrio);
			this.Controls.Add(this.lb_LagFaculTitulo);
			this.Name = "LagoaFacultativaView";
			this.Text = "LagoaFacultativaView2";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroButton bt_lagoFacul_voltar;
		private MetroFramework.Controls.MetroButton bt_lagoaFacul_avancar;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox txb_tempMesFrio;
		private MetroFramework.Controls.MetroLabel lb_tempMesFrio;
		private MetroFramework.Controls.MetroLabel lb_LagFaculTitulo;
	}
}