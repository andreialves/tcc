namespace Tren.Views {
    partial class DesarenadorView {
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
            this.lb_centralTitulo = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txb_taxaAreia = new MetroFramework.Controls.MetroTextBox();
            this.lb_taxaInfiltracaoFut = new MetroFramework.Controls.MetroLabel();
            this.bt_grade_voltar = new MetroFramework.Controls.MetroButton();
            this.bt_grade_avancar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txb_velocidade = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lb_centralTitulo
            // 
            this.lb_centralTitulo.AutoSize = true;
            this.lb_centralTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_centralTitulo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_centralTitulo.Location = new System.Drawing.Point(321, 9);
            this.lb_centralTitulo.Name = "lb_centralTitulo";
            this.lb_centralTitulo.Size = new System.Drawing.Size(154, 25);
            this.lb_centralTitulo.TabIndex = 74;
            this.lb_centralTitulo.Text = "Entrada de Dados";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(589, 229);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(107, 19);
            this.metroLabel2.TabIndex = 70;
            this.metroLabel2.Text = "m³ areia/1000m³";
            // 
            // txb_taxaAreia
            // 
            this.txb_taxaAreia.Location = new System.Drawing.Point(345, 229);
            this.txb_taxaAreia.Name = "txb_taxaAreia";
            this.txb_taxaAreia.Size = new System.Drawing.Size(238, 23);
            this.txb_taxaAreia.TabIndex = 2;
            this.txb_taxaAreia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_numeros);
            // 
            // lb_taxaInfiltracaoFut
            // 
            this.lb_taxaInfiltracaoFut.AutoSize = true;
            this.lb_taxaInfiltracaoFut.Location = new System.Drawing.Point(122, 155);
            this.lb_taxaInfiltracaoFut.Name = "lb_taxaInfiltracaoFut";
            this.lb_taxaInfiltracaoFut.Size = new System.Drawing.Size(156, 19);
            this.lb_taxaInfiltracaoFut.TabIndex = 68;
            this.lb_taxaInfiltracaoFut.Text = "Velocidade no Canal (Vh)";
            // 
            // bt_grade_voltar
            // 
            this.bt_grade_voltar.Location = new System.Drawing.Point(110, 395);
            this.bt_grade_voltar.Name = "bt_grade_voltar";
            this.bt_grade_voltar.Size = new System.Drawing.Size(237, 45);
            this.bt_grade_voltar.TabIndex = 31;
            this.bt_grade_voltar.Text = "Voltar";
            this.bt_grade_voltar.Click += new System.EventHandler(this.bt_grade_voltar_Click);
            // 
            // bt_grade_avancar
            // 
            this.bt_grade_avancar.Location = new System.Drawing.Point(453, 395);
            this.bt_grade_avancar.Name = "bt_grade_avancar";
            this.bt_grade_avancar.Size = new System.Drawing.Size(237, 45);
            this.bt_grade_avancar.TabIndex = 30;
            this.bt_grade_avancar.Text = "Avançar";
            this.bt_grade_avancar.Click += new System.EventHandler(this.bt_grade_avancar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(122, 229);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(126, 19);
            this.metroLabel1.TabIndex = 75;
            this.metroLabel1.Text = "Taxa de Areia Diária";
            // 
            // txb_velocidade
            // 
            this.txb_velocidade.Location = new System.Drawing.Point(345, 155);
            this.txb_velocidade.Name = "txb_velocidade";
            this.txb_velocidade.Size = new System.Drawing.Size(238, 23);
            this.txb_velocidade.TabIndex = 1;
            this.txb_velocidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_numeros);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(589, 155);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(94, 19);
            this.metroLabel5.TabIndex = 77;
            this.metroLabel5.Text = "[0,2 ... 0,4] m/s";
            // 
            // DesarenadorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.txb_velocidade);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lb_centralTitulo);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txb_taxaAreia);
            this.Controls.Add(this.lb_taxaInfiltracaoFut);
            this.Controls.Add(this.bt_grade_voltar);
            this.Controls.Add(this.bt_grade_avancar);
            this.Name = "DesarenadorView";
            this.Text = "Desarenador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lb_centralTitulo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txb_taxaAreia;
        private MetroFramework.Controls.MetroLabel lb_taxaInfiltracaoFut;
        private MetroFramework.Controls.MetroButton bt_grade_voltar;
        private MetroFramework.Controls.MetroButton bt_grade_avancar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txb_velocidade;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}