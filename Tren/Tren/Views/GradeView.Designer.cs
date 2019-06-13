namespace Tren.Views {
    partial class GradeView {
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
			this.cb_tipoGrade = new System.Windows.Forms.ComboBox();
			this.bt_grade_voltar = new MetroFramework.Controls.MetroButton();
			this.bt_grade_avancar = new MetroFramework.Controls.MetroButton();
			this.lb_tipoGrade = new MetroFramework.Controls.MetroLabel();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.txb_espessura = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.txb_espacamento = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
			this.lb_centralTitulo = new MetroFramework.Controls.MetroLabel();
			this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
			this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
			this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
			this.SuspendLayout();
			// 
			// cb_tipoGrade
			// 
			this.cb_tipoGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_tipoGrade.FormattingEnabled = true;
			this.cb_tipoGrade.Items.AddRange(new object[] {
            "Grossa",
            "Média",
            "Fina"});
			this.cb_tipoGrade.Location = new System.Drawing.Point(383, 117);
			this.cb_tipoGrade.Name = "cb_tipoGrade";
			this.cb_tipoGrade.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.cb_tipoGrade.Size = new System.Drawing.Size(238, 21);
			this.cb_tipoGrade.TabIndex = 0;
			this.cb_tipoGrade.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// bt_grade_voltar
			// 
			this.bt_grade_voltar.Location = new System.Drawing.Point(110, 393);
			this.bt_grade_voltar.Name = "bt_grade_voltar";
			this.bt_grade_voltar.Size = new System.Drawing.Size(237, 45);
			this.bt_grade_voltar.TabIndex = 6;
			this.bt_grade_voltar.Text = "Voltar";
			this.bt_grade_voltar.Click += new System.EventHandler(this.bt_grade_voltar_Click);
			// 
			// bt_grade_avancar
			// 
			this.bt_grade_avancar.Location = new System.Drawing.Point(453, 393);
			this.bt_grade_avancar.Name = "bt_grade_avancar";
			this.bt_grade_avancar.Size = new System.Drawing.Size(237, 45);
			this.bt_grade_avancar.TabIndex = 5;
			this.bt_grade_avancar.Text = "Avançar";
			this.bt_grade_avancar.Click += new System.EventHandler(this.bt_grade_avancar_Click);
			// 
			// lb_tipoGrade
			// 
			this.lb_tipoGrade.AutoSize = true;
			this.lb_tipoGrade.Location = new System.Drawing.Point(160, 117);
			this.lb_tipoGrade.Name = "lb_tipoGrade";
			this.lb_tipoGrade.Size = new System.Drawing.Size(94, 19);
			this.lb_tipoGrade.TabIndex = 56;
			this.lb_tipoGrade.Text = "Tipo de Grade";
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(160, 219);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(65, 19);
			this.metroLabel1.TabIndex = 57;
			this.metroLabel1.Text = "Espessura";
			// 
			// txb_espessura
			// 
			this.txb_espessura.Location = new System.Drawing.Point(383, 215);
			this.txb_espessura.Name = "txb_espessura";
			this.txb_espessura.Size = new System.Drawing.Size(238, 23);
			this.txb_espessura.TabIndex = 3;
			this.txb_espessura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_numeros);
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(627, 215);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(33, 19);
			this.metroLabel2.TabIndex = 60;
			this.metroLabel2.Text = "mm";
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(627, 269);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(33, 19);
			this.metroLabel3.TabIndex = 63;
			this.metroLabel3.Text = "mm";
			// 
			// txb_espacamento
			// 
			this.txb_espacamento.Location = new System.Drawing.Point(383, 265);
			this.txb_espacamento.Name = "txb_espacamento";
			this.txb_espacamento.Size = new System.Drawing.Size(238, 23);
			this.txb_espacamento.TabIndex = 4;
			this.txb_espacamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_numeros);
			// 
			// metroLabel4
			// 
			this.metroLabel4.AutoSize = true;
			this.metroLabel4.Location = new System.Drawing.Point(160, 269);
			this.metroLabel4.Name = "metroLabel4";
			this.metroLabel4.Size = new System.Drawing.Size(87, 19);
			this.metroLabel4.TabIndex = 61;
			this.metroLabel4.Text = "Espaçamento";
			// 
			// lb_centralTitulo
			// 
			this.lb_centralTitulo.AutoSize = true;
			this.lb_centralTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
			this.lb_centralTitulo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lb_centralTitulo.Location = new System.Drawing.Point(321, 9);
			this.lb_centralTitulo.Name = "lb_centralTitulo";
			this.lb_centralTitulo.Size = new System.Drawing.Size(161, 25);
			this.lb_centralTitulo.TabIndex = 64;
			this.lb_centralTitulo.Text = "Entrada de Dados";
			// 
			// metroLabel5
			// 
			this.metroLabel5.AutoSize = true;
			this.metroLabel5.Location = new System.Drawing.Point(160, 168);
			this.metroLabel5.Name = "metroLabel5";
			this.metroLabel5.Size = new System.Drawing.Size(107, 19);
			this.metroLabel5.TabIndex = 66;
			this.metroLabel5.Text = "Tipo de Limpeza";
			// 
			// metroRadioButton1
			// 
			this.metroRadioButton1.AutoSize = true;
			this.metroRadioButton1.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.metroRadioButton1.Location = new System.Drawing.Point(383, 168);
			this.metroRadioButton1.Name = "metroRadioButton1";
			this.metroRadioButton1.Size = new System.Drawing.Size(97, 19);
			this.metroRadioButton1.TabIndex = 1;
			this.metroRadioButton1.TabStop = true;
			this.metroRadioButton1.Text = "Mecanizada";
			this.metroRadioButton1.UseVisualStyleBackColor = true;
			// 
			// metroRadioButton2
			// 
			this.metroRadioButton2.AutoSize = true;
			this.metroRadioButton2.FontSize = MetroFramework.MetroLinkSize.Medium;
			this.metroRadioButton2.Location = new System.Drawing.Point(517, 168);
			this.metroRadioButton2.Name = "metroRadioButton2";
			this.metroRadioButton2.Size = new System.Drawing.Size(71, 19);
			this.metroRadioButton2.TabIndex = 2;
			this.metroRadioButton2.TabStop = true;
			this.metroRadioButton2.Text = "Manual";
			this.metroRadioButton2.UseVisualStyleBackColor = true;
			// 
			// GradeView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.metroRadioButton2);
			this.Controls.Add(this.metroRadioButton1);
			this.Controls.Add(this.metroLabel5);
			this.Controls.Add(this.lb_centralTitulo);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.txb_espacamento);
			this.Controls.Add(this.metroLabel4);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.txb_espessura);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.lb_tipoGrade);
			this.Controls.Add(this.bt_grade_voltar);
			this.Controls.Add(this.bt_grade_avancar);
			this.Controls.Add(this.cb_tipoGrade);
			this.Name = "GradeView";
			this.Text = "Grade";
			this.Load += new System.EventHandler(this.Grade_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
		private MetroFramework.Controls.MetroButton bt_grade_voltar;
		private MetroFramework.Controls.MetroButton bt_grade_avancar;
        private MetroFramework.Controls.MetroLabel lb_tipoGrade;
        private System.Windows.Forms.ComboBox cb_tipoGrade;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txb_espessura;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txb_espacamento;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lb_centralTitulo;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
    }
}