namespace Tren.Views {
    partial class Grade {
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
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.bt_grade_voltar = new MetroFramework.Controls.MetroButton();
			this.bt_grade_avancar = new MetroFramework.Controls.MetroButton();
			this.SuspendLayout();
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Grossa",
            "Média",
            "Fina"});
			this.comboBox1.Location = new System.Drawing.Point(128, 69);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 0;
			this.comboBox1.Text = "Tipo Grade";
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// bt_grade_voltar
			// 
			this.bt_grade_voltar.Location = new System.Drawing.Point(110, 393);
			this.bt_grade_voltar.Name = "bt_grade_voltar";
			this.bt_grade_voltar.Size = new System.Drawing.Size(237, 45);
			this.bt_grade_voltar.TabIndex = 55;
			this.bt_grade_voltar.Text = "Voltar";
			this.bt_grade_voltar.Click += new System.EventHandler(this.bt_grade_voltar_Click);
			// 
			// bt_grade_avancar
			// 
			this.bt_grade_avancar.Location = new System.Drawing.Point(453, 393);
			this.bt_grade_avancar.Name = "bt_grade_avancar";
			this.bt_grade_avancar.Size = new System.Drawing.Size(237, 45);
			this.bt_grade_avancar.TabIndex = 54;
			this.bt_grade_avancar.Text = "Avançar";
			this.bt_grade_avancar.Click += new System.EventHandler(this.bt_grade_avancar_Click);
			// 
			// Grade
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.bt_grade_voltar);
			this.Controls.Add(this.bt_grade_avancar);
			this.Controls.Add(this.comboBox1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Grade";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Grade";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
		private MetroFramework.Controls.MetroButton bt_grade_voltar;
		private MetroFramework.Controls.MetroButton bt_grade_avancar;
	}
}