namespace Tren.Views {
	partial class DBOView {
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
			this.txb_dbo = new MetroFramework.Controls.MetroTextBox();
			this.lb_dbo = new MetroFramework.Controls.MetroLabel();
			this.bt_dbo_voltar = new MetroFramework.Controls.MetroButton();
			this.bt_dbo_avancar = new MetroFramework.Controls.MetroButton();
			this.lb_dboTitulo = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(644, 201);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(40, 19);
			this.metroLabel1.TabIndex = 69;
			this.metroLabel1.Text = "mg/L";
			// 
			// txb_dbo
			// 
			this.txb_dbo.Location = new System.Drawing.Point(400, 197);
			this.txb_dbo.Name = "txb_dbo";
			this.txb_dbo.Size = new System.Drawing.Size(238, 23);
			this.txb_dbo.TabIndex = 60;
			this.txb_dbo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_numeros);
			// 
			// lb_dbo
			// 
			this.lb_dbo.AutoSize = true;
			this.lb_dbo.Location = new System.Drawing.Point(162, 201);
			this.lb_dbo.Name = "lb_dbo";
			this.lb_dbo.Size = new System.Drawing.Size(37, 19);
			this.lb_dbo.TabIndex = 67;
			this.lb_dbo.Text = "DBO";
			// 
			// bt_dbo_voltar
			// 
			this.bt_dbo_voltar.Location = new System.Drawing.Point(110, 393);
			this.bt_dbo_voltar.Name = "bt_dbo_voltar";
			this.bt_dbo_voltar.Size = new System.Drawing.Size(237, 45);
			this.bt_dbo_voltar.TabIndex = 63;
			this.bt_dbo_voltar.Text = "Voltar";
			this.bt_dbo_voltar.Click += new System.EventHandler(this.bt_dbo_voltar_Click);
			// 
			// bt_dbo_avancar
			// 
			this.bt_dbo_avancar.Location = new System.Drawing.Point(453, 393);
			this.bt_dbo_avancar.Name = "bt_dbo_avancar";
			this.bt_dbo_avancar.Size = new System.Drawing.Size(237, 45);
			this.bt_dbo_avancar.TabIndex = 62;
			this.bt_dbo_avancar.Text = "Avançar";
			this.bt_dbo_avancar.Click += new System.EventHandler(this.bt_dbo_avancar_Click);
			// 
			// lb_dboTitulo
			// 
			this.lb_dboTitulo.AutoSize = true;
			this.lb_dboTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lb_dboTitulo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lb_dboTitulo.Location = new System.Drawing.Point(321, 9);
			this.lb_dboTitulo.Name = "lb_dboTitulo";
			this.lb_dboTitulo.Size = new System.Drawing.Size(161, 25);
			this.lb_dboTitulo.TabIndex = 66;
			this.lb_dboTitulo.Text = "Entrada de Dados";
			// 
			// DBOView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.txb_dbo);
			this.Controls.Add(this.lb_dbo);
			this.Controls.Add(this.bt_dbo_voltar);
			this.Controls.Add(this.bt_dbo_avancar);
			this.Controls.Add(this.lb_dboTitulo);
			this.Name = "DBOView";
			this.Text = "DBOView";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel metroLabel1;
		private MetroFramework.Controls.MetroTextBox txb_dbo;
		private MetroFramework.Controls.MetroLabel lb_dbo;
		private MetroFramework.Controls.MetroButton bt_dbo_voltar;
		private MetroFramework.Controls.MetroButton bt_dbo_avancar;
		private MetroFramework.Controls.MetroLabel lb_dboTitulo;
	}
}