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
			this.SuspendLayout();
			// 
			// lb_calculoViabilidadeTitulo
			// 
			this.lb_calculoViabilidadeTitulo.AutoSize = true;
			this.lb_calculoViabilidadeTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lb_calculoViabilidadeTitulo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lb_calculoViabilidadeTitulo.Location = new System.Drawing.Point(352, 9);
			this.lb_calculoViabilidadeTitulo.Name = "lb_calculoViabilidadeTitulo";
			this.lb_calculoViabilidadeTitulo.Size = new System.Drawing.Size(97, 25);
			this.lb_calculoViabilidadeTitulo.TabIndex = 52;
			this.lb_calculoViabilidadeTitulo.Text = "Exibir PDF";
			// 
			// CalculoViabilidadeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lb_calculoViabilidadeTitulo);
			this.Name = "CalculoViabilidadeView";
			this.Text = "CalculoEstudoView";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel lb_calculoViabilidadeTitulo;
	}
}