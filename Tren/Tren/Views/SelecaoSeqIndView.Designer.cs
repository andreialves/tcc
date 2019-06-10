namespace Tren.Views {
	partial class SelecaoSeqIndView {
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
			this.cbx_Cs = new MetroFramework.Controls.MetroCheckBox();
			this.cbx_TsFa = new MetroFramework.Controls.MetroCheckBox();
			this.cbx_PTsFaW = new MetroFramework.Controls.MetroCheckBox();
			this.bt_SelecaoSeqInd_voltar = new MetroFramework.Controls.MetroButton();
			this.bt_SelecaoSeqInd_avancar = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// lb_SelecaoSeqColTitulo
			// 
			this.lb_SelecaoSeqColTitulo.AutoSize = true;
			this.lb_SelecaoSeqColTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lb_SelecaoSeqColTitulo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lb_SelecaoSeqColTitulo.Location = new System.Drawing.Point(193, 9);
			this.lb_SelecaoSeqColTitulo.Name = "lb_SelecaoSeqColTitulo";
			this.lb_SelecaoSeqColTitulo.Size = new System.Drawing.Size(401, 25);
			this.lb_SelecaoSeqColTitulo.TabIndex = 36;
			this.lb_SelecaoSeqColTitulo.Text = "Selecione as  sequências que deseja comparar";
			// 
			// cbx_Cs
			// 
			this.cbx_Cs.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.cbx_Cs.Location = new System.Drawing.Point(181, 233);
			this.cbx_Cs.Name = "cbx_Cs";
			this.cbx_Cs.Size = new System.Drawing.Size(463, 33);
			this.cbx_Cs.TabIndex = 2;
			this.cbx_Cs.Text = "Caixa SAO";
			this.cbx_Cs.UseVisualStyleBackColor = true;
			// 
			// cbx_TsFa
			// 
			this.cbx_TsFa.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.cbx_TsFa.Location = new System.Drawing.Point(181, 184);
			this.cbx_TsFa.Name = "cbx_TsFa";
			this.cbx_TsFa.Size = new System.Drawing.Size(463, 33);
			this.cbx_TsFa.TabIndex = 1;
			this.cbx_TsFa.Text = "Tanque Séptico + Filtro Anaeróbio";
			this.cbx_TsFa.UseVisualStyleBackColor = true;
			// 
			// cbx_PTsFaW
			// 
			this.cbx_PTsFaW.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.cbx_PTsFaW.Location = new System.Drawing.Point(181, 135);
			this.cbx_PTsFaW.Name = "cbx_PTsFaW";
			this.cbx_PTsFaW.Size = new System.Drawing.Size(463, 33);
			this.cbx_PTsFaW.TabIndex = 0;
			this.cbx_PTsFaW.Text = "Preliminar + Tanque Séptico + Filtro Anaeróbio + Wetland";
			this.cbx_PTsFaW.UseVisualStyleBackColor = true;
			// 
			// bt_SelecaoSeqInd_voltar
			// 
			this.bt_SelecaoSeqInd_voltar.Location = new System.Drawing.Point(110, 393);
			this.bt_SelecaoSeqInd_voltar.Name = "bt_SelecaoSeqInd_voltar";
			this.bt_SelecaoSeqInd_voltar.Size = new System.Drawing.Size(237, 45);
			this.bt_SelecaoSeqInd_voltar.TabIndex = 4;
			this.bt_SelecaoSeqInd_voltar.Text = "Voltar";
			this.bt_SelecaoSeqInd_voltar.Click += new System.EventHandler(this.bt_SelecaoSeqInd_voltar_Click);
			// 
			// bt_SelecaoSeqInd_avancar
			// 
			this.bt_SelecaoSeqInd_avancar.Location = new System.Drawing.Point(453, 393);
			this.bt_SelecaoSeqInd_avancar.Name = "bt_SelecaoSeqInd_avancar";
			this.bt_SelecaoSeqInd_avancar.Size = new System.Drawing.Size(237, 45);
			this.bt_SelecaoSeqInd_avancar.TabIndex = 3;
			this.bt_SelecaoSeqInd_avancar.Text = "Avançar";
			this.bt_SelecaoSeqInd_avancar.Click += new System.EventHandler(this.bt_SelecaoSeqInd_avancar_Click);
			// 
			// SelecaoSeqIndView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cbx_Cs);
			this.Controls.Add(this.cbx_TsFa);
			this.Controls.Add(this.cbx_PTsFaW);
			this.Controls.Add(this.bt_SelecaoSeqInd_voltar);
			this.Controls.Add(this.bt_SelecaoSeqInd_avancar);
			this.Controls.Add(this.lb_SelecaoSeqColTitulo);
			this.Name = "SelecaoSeqIndView";
			this.Text = "SelecaoSeqIndView";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel lb_SelecaoSeqColTitulo;
		private MetroFramework.Controls.MetroCheckBox cbx_Cs;
		private MetroFramework.Controls.MetroCheckBox cbx_TsFa;
		private MetroFramework.Controls.MetroCheckBox cbx_PTsFaW;
		private MetroFramework.Controls.MetroButton bt_SelecaoSeqInd_voltar;
		private MetroFramework.Controls.MetroButton bt_SelecaoSeqInd_avancar;
	}
}