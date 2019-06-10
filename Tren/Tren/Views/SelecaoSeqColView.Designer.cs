namespace Tren.Views {
	partial class SelecaoSeqColView {
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
			this.lb_SelecaoSeqColTitulo = new MetroFramework.Controls.MetroLabel();
			this.bt_central2_voltar = new MetroFramework.Controls.MetroButton();
			this.bt_central1_avancar = new MetroFramework.Controls.MetroButton();
			this.cbx_PLaLfLm = new MetroFramework.Controls.MetroCheckBox();
			this.cbx_PRuW = new MetroFramework.Controls.MetroCheckBox();
			this.cbx_PRuLf = new MetroFramework.Controls.MetroCheckBox();
			this.cbx_PLf = new MetroFramework.Controls.MetroCheckBox();
			this.cbx_PRuLfLm = new MetroFramework.Controls.MetroCheckBox();
			this.cbx_PRu = new MetroFramework.Controls.MetroCheckBox();
			this.cbx_PLaLf = new MetroFramework.Controls.MetroCheckBox();
			this.SuspendLayout();
			// 
			// lb_SelecaoSeqColTitulo
			// 
			this.lb_SelecaoSeqColTitulo.AutoSize = true;
			this.lb_SelecaoSeqColTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lb_SelecaoSeqColTitulo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lb_SelecaoSeqColTitulo.Location = new System.Drawing.Point(192, 9);
			this.lb_SelecaoSeqColTitulo.Name = "lb_SelecaoSeqColTitulo";
			this.lb_SelecaoSeqColTitulo.Size = new System.Drawing.Size(401, 25);
			this.lb_SelecaoSeqColTitulo.TabIndex = 35;
			this.lb_SelecaoSeqColTitulo.Text = "Selecione as  sequências que deseja comparar";
			// 
			// bt_central2_voltar
			// 
			this.bt_central2_voltar.Location = new System.Drawing.Point(110, 393);
			this.bt_central2_voltar.Name = "bt_central2_voltar";
			this.bt_central2_voltar.Size = new System.Drawing.Size(237, 45);
			this.bt_central2_voltar.TabIndex = 9;
			this.bt_central2_voltar.Text = "Voltar";
			this.bt_central2_voltar.Click += new System.EventHandler(this.bt_central2_voltar_Click);
			// 
			// bt_central1_avancar
			// 
			this.bt_central1_avancar.Location = new System.Drawing.Point(453, 393);
			this.bt_central1_avancar.Name = "bt_central1_avancar";
			this.bt_central1_avancar.Size = new System.Drawing.Size(237, 45);
			this.bt_central1_avancar.TabIndex = 8;
			this.bt_central1_avancar.Text = "Avançar";
			this.bt_central1_avancar.Click += new System.EventHandler(this.bt_central1_avancar_Click);
			// 
			// cbx_PLaLfLm
			// 
			this.cbx_PLaLfLm.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.cbx_PLaLfLm.Location = new System.Drawing.Point(174, 113);
			this.cbx_PLaLfLm.Name = "cbx_PLaLfLm";
			this.cbx_PLaLfLm.Size = new System.Drawing.Size(479, 33);
			this.cbx_PLaLfLm.TabIndex = 2;
			this.cbx_PLaLfLm.Text = "Preliminar + Lagoa Anaeróbia + Lagoa Facultativa + Lagoa de Maturação";
			this.cbx_PLaLfLm.UseVisualStyleBackColor = true;
			// 
			// cbx_PRuW
			// 
			this.cbx_PRuW.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.cbx_PRuW.Location = new System.Drawing.Point(174, 152);
			this.cbx_PRuW.Name = "cbx_PRuW";
			this.cbx_PRuW.Size = new System.Drawing.Size(479, 33);
			this.cbx_PRuW.TabIndex = 3;
			this.cbx_PRuW.Text = "Preliminar + Reator UASB + Wetland";
			this.cbx_PRuW.UseVisualStyleBackColor = true;
			// 
			// cbx_PRuLf
			// 
			this.cbx_PRuLf.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.cbx_PRuLf.Location = new System.Drawing.Point(174, 191);
			this.cbx_PRuLf.Name = "cbx_PRuLf";
			this.cbx_PRuLf.Size = new System.Drawing.Size(479, 33);
			this.cbx_PRuLf.TabIndex = 4;
			this.cbx_PRuLf.Text = "Preliminar + Reator UASB + Lagoa Facultativa";
			this.cbx_PRuLf.UseVisualStyleBackColor = true;
			// 
			// cbx_PLf
			// 
			this.cbx_PLf.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.cbx_PLf.Location = new System.Drawing.Point(174, 230);
			this.cbx_PLf.Name = "cbx_PLf";
			this.cbx_PLf.Size = new System.Drawing.Size(479, 33);
			this.cbx_PLf.TabIndex = 5;
			this.cbx_PLf.Text = "Preliminar + Lagoa Facultativa";
			this.cbx_PLf.UseVisualStyleBackColor = true;
			// 
			// cbx_PRuLfLm
			// 
			this.cbx_PRuLfLm.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.cbx_PRuLfLm.Location = new System.Drawing.Point(174, 269);
			this.cbx_PRuLfLm.Name = "cbx_PRuLfLm";
			this.cbx_PRuLfLm.Size = new System.Drawing.Size(479, 33);
			this.cbx_PRuLfLm.TabIndex = 6;
			this.cbx_PRuLfLm.Text = "Preliminar + Reator UASB + Lagoa Facultativa + Lagoa de Maturação";
			this.cbx_PRuLfLm.UseVisualStyleBackColor = true;
			// 
			// cbx_PRu
			// 
			this.cbx_PRu.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.cbx_PRu.Location = new System.Drawing.Point(174, 308);
			this.cbx_PRu.Name = "cbx_PRu";
			this.cbx_PRu.Size = new System.Drawing.Size(479, 33);
			this.cbx_PRu.TabIndex = 7;
			this.cbx_PRu.Text = "Preliminar + Reator UASB";
			this.cbx_PRu.UseVisualStyleBackColor = true;
			// 
			// cbx_PLaLf
			// 
			this.cbx_PLaLf.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.cbx_PLaLf.Location = new System.Drawing.Point(174, 74);
			this.cbx_PLaLf.Name = "cbx_PLaLf";
			this.cbx_PLaLf.Size = new System.Drawing.Size(479, 33);
			this.cbx_PLaLf.TabIndex = 1;
			this.cbx_PLaLf.Text = "Preliminar + Lagoa Anaeróbia + Lagoa Facultativa";
			this.cbx_PLaLf.UseVisualStyleBackColor = true;
			// 
			// SelecaoSeqColView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbx_PLaLf);
			this.Controls.Add(this.cbx_PRu);
			this.Controls.Add(this.cbx_PRuLfLm);
			this.Controls.Add(this.cbx_PLf);
			this.Controls.Add(this.cbx_PRuLf);
			this.Controls.Add(this.cbx_PRuW);
			this.Controls.Add(this.cbx_PLaLfLm);
			this.Controls.Add(this.bt_central2_voltar);
			this.Controls.Add(this.bt_central1_avancar);
			this.Controls.Add(this.lb_SelecaoSeqColTitulo);
			this.Name = "SelecaoSeqColView";
			this.Text = "Sequencia Preliminar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private MetroFramework.Controls.MetroLabel lb_SelecaoSeqColTitulo;
		private MetroFramework.Controls.MetroButton bt_central2_voltar;
		private MetroFramework.Controls.MetroButton bt_central1_avancar;
		private MetroFramework.Controls.MetroCheckBox cbx_PLaLfLm;
		private MetroFramework.Controls.MetroCheckBox cbx_PRuW;
		private MetroFramework.Controls.MetroCheckBox cbx_PRuLf;
		private MetroFramework.Controls.MetroCheckBox cbx_PLf;
		private MetroFramework.Controls.MetroCheckBox cbx_PRuLfLm;
		private MetroFramework.Controls.MetroCheckBox cbx_PRu;
		private MetroFramework.Controls.MetroCheckBox cbx_PLaLf;
	}
}