namespace Tren.Views {
	partial class CentralDeTratamento0View {
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
			this.lb_CentralEscolhaTitulo = new MetroFramework.Controls.MetroLabel();
			this.bt_central0_sim = new MetroFramework.Controls.MetroButton();
			this.bt_central0_nao = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// lb_CentralEscolhaTitulo
			// 
			this.lb_CentralEscolhaTitulo.AutoSize = true;
			this.lb_CentralEscolhaTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lb_CentralEscolhaTitulo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lb_CentralEscolhaTitulo.Location = new System.Drawing.Point(210, 191);
			this.lb_CentralEscolhaTitulo.Name = "lb_CentralEscolhaTitulo";
			this.lb_CentralEscolhaTitulo.Size = new System.Drawing.Size(396, 25);
			this.lb_CentralEscolhaTitulo.TabIndex = 36;
			this.lb_CentralEscolhaTitulo.Text = "Possui os dados de vazão atuais e de projeto?";
			// 
			// bt_central0_sim
			// 
			this.bt_central0_sim.Location = new System.Drawing.Point(110, 393);
			this.bt_central0_sim.Name = "bt_central0_sim";
			this.bt_central0_sim.Size = new System.Drawing.Size(237, 45);
			this.bt_central0_sim.TabIndex = 1;
			this.bt_central0_sim.Text = "Sim";
			this.bt_central0_sim.Click += new System.EventHandler(this.bt_central0_sim_Click);
			// 
			// bt_central0_nao
			// 
			this.bt_central0_nao.Location = new System.Drawing.Point(453, 393);
			this.bt_central0_nao.Name = "bt_central0_nao";
			this.bt_central0_nao.Size = new System.Drawing.Size(237, 45);
			this.bt_central0_nao.TabIndex = 2;
			this.bt_central0_nao.Text = "Não";
			this.bt_central0_nao.Click += new System.EventHandler(this.bt_central0_nao_Click);
			// 
			// CentralDeTratamento0View
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.bt_central0_sim);
			this.Controls.Add(this.bt_central0_nao);
			this.Controls.Add(this.lb_CentralEscolhaTitulo);
			this.Name = "CentralDeTratamento0View";
			this.Text = "CentralDeTratamento0";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel lb_CentralEscolhaTitulo;
		private MetroFramework.Controls.MetroButton bt_central0_sim;
		private MetroFramework.Controls.MetroButton bt_central0_nao;
	}
}