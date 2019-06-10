namespace Tren.Views {
	partial class CalculoViabilidadeView {
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
			this.lb_calculoViabilidadeTitulo = new MetroFramework.Controls.MetroLabel();
			this.bt_realizarCalculo = new MetroFramework.Controls.MetroButton();
			this.bt_final_voltar = new MetroFramework.Controls.MetroButton();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// lb_calculoViabilidadeTitulo
			// 
			this.lb_calculoViabilidadeTitulo.AutoSize = true;
			this.lb_calculoViabilidadeTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lb_calculoViabilidadeTitulo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lb_calculoViabilidadeTitulo.Location = new System.Drawing.Point(352, 9);
			this.lb_calculoViabilidadeTitulo.Name = "lb_calculoViabilidadeTitulo";
			this.lb_calculoViabilidadeTitulo.Size = new System.Drawing.Size(106, 25);
			this.lb_calculoViabilidadeTitulo.TabIndex = 52;
			this.lb_calculoViabilidadeTitulo.Text = "Finalização";
			// 
			// bt_realizarCalculo
			// 
			this.bt_realizarCalculo.Location = new System.Drawing.Point(458, 393);
			this.bt_realizarCalculo.Name = "bt_realizarCalculo";
			this.bt_realizarCalculo.Size = new System.Drawing.Size(237, 45);
			this.bt_realizarCalculo.TabIndex = 3;
			this.bt_realizarCalculo.Text = "Gerar Relatório";
			this.bt_realizarCalculo.Click += new System.EventHandler(this.bt_realizarCalculo_Click);
			// 
			// bt_final_voltar
			// 
			this.bt_final_voltar.Location = new System.Drawing.Point(110, 393);
			this.bt_final_voltar.Name = "bt_final_voltar";
			this.bt_final_voltar.Size = new System.Drawing.Size(237, 45);
			this.bt_final_voltar.TabIndex = 4;
			this.bt_final_voltar.Text = "Voltar";
			this.bt_final_voltar.Click += new System.EventHandler(this.bt_final_voltar_Click);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.metroLabel1.Location = new System.Drawing.Point(282, 205);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(248, 25);
			this.metroLabel1.TabIndex = 54;
			this.metroLabel1.Text = "Dados inseridos com sucesso!";
			// 
			// CalculoViabilidadeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.bt_final_voltar);
			this.Controls.Add(this.bt_realizarCalculo);
			this.Controls.Add(this.lb_calculoViabilidadeTitulo);
			this.Name = "CalculoViabilidadeView";
			this.Text = "CalculoEstudoView";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel lb_calculoViabilidadeTitulo;
		private MetroFramework.Controls.MetroButton bt_realizarCalculo;
		private MetroFramework.Controls.MetroButton bt_final_voltar;
		private MetroFramework.Controls.MetroLabel metroLabel1;
	}
}