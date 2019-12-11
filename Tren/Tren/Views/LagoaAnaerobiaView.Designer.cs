namespace Tren.Views {
	partial class LagoaAnaerobiaView {
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
			this.lb_LagoaAnaerobiaTitulo = new MetroFramework.Controls.MetroLabel();
			this.bt_LagoaAnaerobia_voltar = new MetroFramework.Controls.MetroButton();
			this.bt_lagoaAnaerobia_avancar = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.lb_taxaVolumetrica = new MetroFramework.Controls.MetroLabel();
			this.lb_aviso = new MetroFramework.Controls.MetroLabel();
			this.cb_taxaVolumetrica = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lb_LagoaAnaerobiaTitulo
			// 
			this.lb_LagoaAnaerobiaTitulo.AutoSize = true;
			this.lb_LagoaAnaerobiaTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lb_LagoaAnaerobiaTitulo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lb_LagoaAnaerobiaTitulo.Location = new System.Drawing.Point(239, 9);
			this.lb_LagoaAnaerobiaTitulo.Name = "lb_LagoaAnaerobiaTitulo";
			this.lb_LagoaAnaerobiaTitulo.Size = new System.Drawing.Size(322, 25);
			this.lb_LagoaAnaerobiaTitulo.TabIndex = 52;
			this.lb_LagoaAnaerobiaTitulo.Text = "Entrada de Dados - Lagoa Anaeróbia";
			// 
			// bt_LagoaAnaerobia_voltar
			// 
			this.bt_LagoaAnaerobia_voltar.Location = new System.Drawing.Point(110, 393);
			this.bt_LagoaAnaerobia_voltar.Name = "bt_LagoaAnaerobia_voltar";
			this.bt_LagoaAnaerobia_voltar.Size = new System.Drawing.Size(237, 45);
			this.bt_LagoaAnaerobia_voltar.TabIndex = 3;
			this.bt_LagoaAnaerobia_voltar.Text = "Voltar";
			this.bt_LagoaAnaerobia_voltar.Click += new System.EventHandler(this.bt_LagoaAnaerobia_voltar_Click);
			// 
			// bt_lagoaAnaerobia_avancar
			// 
			this.bt_lagoaAnaerobia_avancar.Location = new System.Drawing.Point(453, 393);
			this.bt_lagoaAnaerobia_avancar.Name = "bt_lagoaAnaerobia_avancar";
			this.bt_lagoaAnaerobia_avancar.Size = new System.Drawing.Size(237, 45);
			this.bt_lagoaAnaerobia_avancar.TabIndex = 2;
			this.bt_lagoaAnaerobia_avancar.Text = "Avançar";
			this.bt_lagoaAnaerobia_avancar.Click += new System.EventHandler(this.bt_lagoaAnaerobia_avancar_Click);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(583, 196);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(62, 19);
			this.metroLabel1.TabIndex = 71;
			this.metroLabel1.Text = "Kg/(m³d)";
			// 
			// lb_taxaVolumetrica
			// 
			this.lb_taxaVolumetrica.AutoSize = true;
			this.lb_taxaVolumetrica.Location = new System.Drawing.Point(175, 196);
			this.lb_taxaVolumetrica.Name = "lb_taxaVolumetrica";
			this.lb_taxaVolumetrica.Size = new System.Drawing.Size(107, 19);
			this.lb_taxaVolumetrica.TabIndex = 69;
			this.lb_taxaVolumetrica.Text = "Taxa Volumétrica";
			// 
			// lb_aviso
			// 
			this.lb_aviso.AutoSize = true;
			this.lb_aviso.CustomForeColor = true;
			this.lb_aviso.ForeColor = System.Drawing.Color.Red;
			this.lb_aviso.Location = new System.Drawing.Point(332, 218);
			this.lb_aviso.Name = "lb_aviso";
			this.lb_aviso.Size = new System.Drawing.Size(252, 19);
			this.lb_aviso.TabIndex = 72;
			this.lb_aviso.Text = "Tente outro valor para a Taxa Volumétrica";
			this.lb_aviso.Visible = false;
			// 
			// cb_taxaVolumetrica
			// 
			this.cb_taxaVolumetrica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_taxaVolumetrica.FormattingEnabled = true;
			this.cb_taxaVolumetrica.Items.AddRange(new object[] {
            "0,1",
            "0,2",
            "0,3"});
			this.cb_taxaVolumetrica.Location = new System.Drawing.Point(339, 194);
			this.cb_taxaVolumetrica.Name = "cb_taxaVolumetrica";
			this.cb_taxaVolumetrica.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_taxaVolumetrica.Size = new System.Drawing.Size(238, 21);
			this.cb_taxaVolumetrica.TabIndex = 1;
			this.cb_taxaVolumetrica.DropDown += new System.EventHandler(this.cb_changed);
			// 
			// LagoaAnaerobiaView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cb_taxaVolumetrica);
			this.Controls.Add(this.lb_aviso);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.lb_taxaVolumetrica);
			this.Controls.Add(this.bt_LagoaAnaerobia_voltar);
			this.Controls.Add(this.bt_lagoaAnaerobia_avancar);
			this.Controls.Add(this.lb_LagoaAnaerobiaTitulo);
			this.Name = "LagoaAnaerobiaView";
			this.Text = "LagoaAnaerobiaView";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel lb_LagoaAnaerobiaTitulo;
		private MetroFramework.Controls.MetroButton bt_LagoaAnaerobia_voltar;
		private MetroFramework.Controls.MetroButton bt_lagoaAnaerobia_avancar;
		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroLabel lb_taxaVolumetrica;
		private MetroFramework.Controls.MetroLabel lb_aviso;
		private System.Windows.Forms.ComboBox cb_taxaVolumetrica;
	}
}