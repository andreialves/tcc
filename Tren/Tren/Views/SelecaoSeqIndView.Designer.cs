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
			this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
			this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
			this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
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
			// metroCheckBox3
			// 
			this.metroCheckBox3.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.metroCheckBox3.Location = new System.Drawing.Point(181, 233);
			this.metroCheckBox3.Name = "metroCheckBox3";
			this.metroCheckBox3.Size = new System.Drawing.Size(463, 33);
			this.metroCheckBox3.TabIndex = 59;
			this.metroCheckBox3.Text = "Caixa SAO";
			this.metroCheckBox3.UseVisualStyleBackColor = true;
			// 
			// metroCheckBox2
			// 
			this.metroCheckBox2.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.metroCheckBox2.Location = new System.Drawing.Point(181, 184);
			this.metroCheckBox2.Name = "metroCheckBox2";
			this.metroCheckBox2.Size = new System.Drawing.Size(463, 33);
			this.metroCheckBox2.TabIndex = 58;
			this.metroCheckBox2.Text = "Tanque Séptico + Filtro Anaeróbio";
			this.metroCheckBox2.UseVisualStyleBackColor = true;
			// 
			// metroCheckBox1
			// 
			this.metroCheckBox1.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.metroCheckBox1.Location = new System.Drawing.Point(181, 135);
			this.metroCheckBox1.Name = "metroCheckBox1";
			this.metroCheckBox1.Size = new System.Drawing.Size(463, 33);
			this.metroCheckBox1.TabIndex = 57;
			this.metroCheckBox1.Text = "Preliminar + Tanque Séptico + Filtro Anaeróbio + Wetland";
			this.metroCheckBox1.UseVisualStyleBackColor = true;
			// 
			// bt_SelecaoSeqInd_voltar
			// 
			this.bt_SelecaoSeqInd_voltar.Location = new System.Drawing.Point(110, 393);
			this.bt_SelecaoSeqInd_voltar.Name = "bt_SelecaoSeqInd_voltar";
			this.bt_SelecaoSeqInd_voltar.Size = new System.Drawing.Size(237, 45);
			this.bt_SelecaoSeqInd_voltar.TabIndex = 56;
			this.bt_SelecaoSeqInd_voltar.Text = "Voltar";
			this.bt_SelecaoSeqInd_voltar.Click += new System.EventHandler(this.bt_SelecaoSeqInd_voltar_Click);
			// 
			// bt_SelecaoSeqInd_avancar
			// 
			this.bt_SelecaoSeqInd_avancar.Location = new System.Drawing.Point(453, 393);
			this.bt_SelecaoSeqInd_avancar.Name = "bt_SelecaoSeqInd_avancar";
			this.bt_SelecaoSeqInd_avancar.Size = new System.Drawing.Size(237, 45);
			this.bt_SelecaoSeqInd_avancar.TabIndex = 55;
			this.bt_SelecaoSeqInd_avancar.Text = "Avançar";
			this.bt_SelecaoSeqInd_avancar.Click += new System.EventHandler(this.bt_SelecaoSeqInd_avancar_Click);
			// 
			// SelecaoSeqIndView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.metroCheckBox3);
			this.Controls.Add(this.metroCheckBox2);
			this.Controls.Add(this.metroCheckBox1);
			this.Controls.Add(this.bt_SelecaoSeqInd_voltar);
			this.Controls.Add(this.bt_SelecaoSeqInd_avancar);
			this.Controls.Add(this.lb_SelecaoSeqColTitulo);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SelecaoSeqIndView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "SelecaoSeqIndView";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel lb_SelecaoSeqColTitulo;
		private MetroFramework.Controls.MetroCheckBox metroCheckBox3;
		private MetroFramework.Controls.MetroCheckBox metroCheckBox2;
		private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
		private MetroFramework.Controls.MetroButton bt_SelecaoSeqInd_voltar;
		private MetroFramework.Controls.MetroButton bt_SelecaoSeqInd_avancar;
	}
}