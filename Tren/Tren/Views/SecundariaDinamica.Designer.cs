namespace Tren.Views {
	partial class SecundariaDinamica {
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
			this.lb_DinamicaTitulo = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// lb_DinamicaTitulo
			// 
			this.lb_DinamicaTitulo.AutoSize = true;
			this.lb_DinamicaTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lb_DinamicaTitulo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lb_DinamicaTitulo.Location = new System.Drawing.Point(320, 9);
			this.lb_DinamicaTitulo.Name = "lb_DinamicaTitulo";
			this.lb_DinamicaTitulo.Size = new System.Drawing.Size(161, 25);
			this.lb_DinamicaTitulo.TabIndex = 62;
			this.lb_DinamicaTitulo.Text = "Entrada de Dados";
			// 
			// SecundariaDinamica
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.lb_DinamicaTitulo);
			this.Name = "SecundariaDinamica";
			this.Text = "SecundariaDinamica";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MetroFramework.Controls.MetroLabel lb_DinamicaTitulo;
	}
}