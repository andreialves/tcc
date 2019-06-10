﻿namespace Tren.Views {
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
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.txb_tempMesFrio = new MetroFramework.Controls.MetroTextBox();
			this.lb_tempMesFrio = new MetroFramework.Controls.MetroLabel();
			this.lb_LagFaculTitulo = new MetroFramework.Controls.MetroLabel();
			this.txb_dboEntrada = new MetroFramework.Controls.MetroTextBox();
			this.lb_dbo = new MetroFramework.Controls.MetroLabel();
			this.bt_lagoFacul_voltar = new MetroFramework.Controls.MetroButton();
			this.bt_lagoaFacul_avancar = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(604, 240);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(23, 19);
			this.metroLabel1.TabIndex = 65;
			this.metroLabel1.Text = "°C";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(604, 173);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(72, 19);
			this.metroLabel3.TabIndex = 64;
			this.metroLabel3.Text = "mg DBO/L";
			// 
			// txb_tempMesFrio
			// 
			this.txb_tempMesFrio.Location = new System.Drawing.Point(360, 236);
			this.txb_tempMesFrio.Name = "txb_tempMesFrio";
			this.txb_tempMesFrio.Size = new System.Drawing.Size(238, 23);
			this.txb_tempMesFrio.TabIndex = 1;
			// 
			// lb_tempMesFrio
			// 
			this.lb_tempMesFrio.AutoSize = true;
			this.lb_tempMesFrio.Location = new System.Drawing.Point(122, 240);
			this.lb_tempMesFrio.Name = "lb_tempMesFrio";
			this.lb_tempMesFrio.Size = new System.Drawing.Size(169, 19);
			this.lb_tempMesFrio.TabIndex = 62;
			this.lb_tempMesFrio.Text = "Temperatura Mês Mais Frio";
			// 
			// lb_LagFaculTitulo
			// 
			this.lb_LagFaculTitulo.AutoSize = true;
			this.lb_LagFaculTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lb_LagFaculTitulo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lb_LagFaculTitulo.Location = new System.Drawing.Point(289, 9);
			this.lb_LagFaculTitulo.Name = "lb_LagFaculTitulo";
			this.lb_LagFaculTitulo.Size = new System.Drawing.Size(161, 25);
			this.lb_LagFaculTitulo.TabIndex = 61;
			this.lb_LagFaculTitulo.Text = "Entrada de Dados";
			// 
			// txb_dboEntrada
			// 
			this.txb_dboEntrada.Location = new System.Drawing.Point(360, 169);
			this.txb_dboEntrada.Name = "txb_dboEntrada";
			this.txb_dboEntrada.Size = new System.Drawing.Size(238, 23);
			this.txb_dboEntrada.TabIndex = 0;
			// 
			// lb_dbo
			// 
			this.lb_dbo.AutoSize = true;
			this.lb_dbo.Location = new System.Drawing.Point(122, 173);
			this.lb_dbo.Name = "lb_dbo";
			this.lb_dbo.Size = new System.Drawing.Size(37, 19);
			this.lb_dbo.TabIndex = 59;
			this.lb_dbo.Text = "DBO";
			// 
			// bt_lagoFacul_voltar
			// 
			this.bt_lagoFacul_voltar.Location = new System.Drawing.Point(110, 393);
			this.bt_lagoFacul_voltar.Name = "bt_lagoFacul_voltar";
			this.bt_lagoFacul_voltar.Size = new System.Drawing.Size(237, 45);
			this.bt_lagoFacul_voltar.TabIndex = 3;
			this.bt_lagoFacul_voltar.Text = "Voltar";
			this.bt_lagoFacul_voltar.Click += new System.EventHandler(this.bt_lagoFacul_voltar_Click);
			// 
			// bt_lagoaFacul_avancar
			// 
			this.bt_lagoaFacul_avancar.Location = new System.Drawing.Point(453, 393);
			this.bt_lagoaFacul_avancar.Name = "bt_lagoaFacul_avancar";
			this.bt_lagoaFacul_avancar.Size = new System.Drawing.Size(237, 45);
			this.bt_lagoaFacul_avancar.TabIndex = 2;
			this.bt_lagoaFacul_avancar.Text = "Avançar";
			this.bt_lagoaFacul_avancar.Click += new System.EventHandler(this.bt_lagoaFacul_avancar_Click);
			// 
			// LagoaFacultativaView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.bt_lagoFacul_voltar);
			this.Controls.Add(this.bt_lagoaFacul_avancar);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.txb_tempMesFrio);
			this.Controls.Add(this.lb_tempMesFrio);
			this.Controls.Add(this.lb_LagFaculTitulo);
			this.Controls.Add(this.txb_dboEntrada);
			this.Controls.Add(this.lb_dbo);
			this.Name = "LagoaFacultativaView";
			this.Text = "LagoaFacultativa";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel metroLabel3;
		private MetroFramework.Controls.MetroTextBox txb_tempMesFrio;
		private MetroFramework.Controls.MetroLabel lb_tempMesFrio;
		private MetroFramework.Controls.MetroLabel lb_LagFaculTitulo;
		private MetroFramework.Controls.MetroTextBox txb_dboEntrada;
		private MetroFramework.Controls.MetroLabel lb_dbo;
		private MetroFramework.Controls.MetroButton bt_lagoFacul_voltar;
		private MetroFramework.Controls.MetroButton bt_lagoaFacul_avancar;
	}
}