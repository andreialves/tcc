namespace Tren.Views
{
    partial class ReatorUASBView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_centralTitulo = new MetroFramework.Controls.MetroLabel();
            this.lb_tipoGrade = new MetroFramework.Controls.MetroLabel();
            this.txb_dbo = new MetroFramework.Controls.MetroTextBox();
            this.bt_uasb_voltar = new MetroFramework.Controls.MetroButton();
            this.bt_uasb_avancar = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txb_dqo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txb_sst = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txb_temp = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lb_centralTitulo
            // 
            this.lb_centralTitulo.AutoSize = true;
            this.lb_centralTitulo.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_centralTitulo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_centralTitulo.Location = new System.Drawing.Point(249, 9);
            this.lb_centralTitulo.Name = "lb_centralTitulo";
            this.lb_centralTitulo.Size = new System.Drawing.Size(271, 25);
            this.lb_centralTitulo.TabIndex = 65;
            this.lb_centralTitulo.Text = "Entrada de Dados - Reator UASB";
            // 
            // lb_tipoGrade
            // 
            this.lb_tipoGrade.AutoSize = true;
            this.lb_tipoGrade.Location = new System.Drawing.Point(163, 108);
            this.lb_tipoGrade.Name = "lb_tipoGrade";
            this.lb_tipoGrade.Size = new System.Drawing.Size(141, 19);
            this.lb_tipoGrade.TabIndex = 66;
            this.lb_tipoGrade.Text = "Concentração de DBO";
            // 
            // txb_dbo
            // 
            this.txb_dbo.Location = new System.Drawing.Point(358, 104);
            this.txb_dbo.Name = "txb_dbo";
            this.txb_dbo.Size = new System.Drawing.Size(238, 23);
            this.txb_dbo.TabIndex = 67;
            // 
            // bt_uasb_voltar
            // 
            this.bt_uasb_voltar.Location = new System.Drawing.Point(96, 365);
            this.bt_uasb_voltar.Name = "bt_uasb_voltar";
            this.bt_uasb_voltar.Size = new System.Drawing.Size(237, 45);
            this.bt_uasb_voltar.TabIndex = 69;
            this.bt_uasb_voltar.Text = "Voltar";
            this.bt_uasb_voltar.Click += new System.EventHandler(this.bt_uasb_voltar_Click);
            // 
            // bt_uasb_avancar
            // 
            this.bt_uasb_avancar.Location = new System.Drawing.Point(439, 365);
            this.bt_uasb_avancar.Name = "bt_uasb_avancar";
            this.bt_uasb_avancar.Size = new System.Drawing.Size(237, 45);
            this.bt_uasb_avancar.TabIndex = 68;
            this.bt_uasb_avancar.Text = "Avançar";
            this.bt_uasb_avancar.Click += new System.EventHandler(this.bt_uasb_avancar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(602, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 70;
            this.metroLabel1.Text = "g/hab*d";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(358, 134);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(190, 17);
            this.checkBox1.TabIndex = 71;
            this.checkBox1.Text = "Adotar Valor Típico de 50 g/hab*d";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(358, 187);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(196, 17);
            this.checkBox2.TabIndex = 75;
            this.checkBox2.Text = "Adotar Valor Típico de 100 g/hab*d";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(602, 161);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 74;
            this.metroLabel2.Text = "g/hab*d";
            // 
            // txb_dqo
            // 
            this.txb_dqo.Location = new System.Drawing.Point(358, 157);
            this.txb_dqo.Name = "txb_dqo";
            this.txb_dqo.Size = new System.Drawing.Size(238, 23);
            this.txb_dqo.TabIndex = 73;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(163, 161);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(144, 19);
            this.metroLabel3.TabIndex = 72;
            this.metroLabel3.Text = "Concentração de DQO";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(358, 240);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(196, 17);
            this.checkBox3.TabIndex = 79;
            this.checkBox3.Text = "Adotar Valor Típico de 180 g/hab*d";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(602, 214);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(57, 19);
            this.metroLabel4.TabIndex = 78;
            this.metroLabel4.Text = "g/hab*d";
            // 
            // txb_sst
            // 
            this.txb_sst.Location = new System.Drawing.Point(358, 210);
            this.txb_sst.Name = "txb_sst";
            this.txb_sst.Size = new System.Drawing.Size(238, 23);
            this.txb_sst.TabIndex = 77;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(163, 214);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(134, 19);
            this.metroLabel5.TabIndex = 76;
            this.metroLabel5.Text = "Concentração de SST";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(602, 267);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(24, 19);
            this.metroLabel6.TabIndex = 82;
            this.metroLabel6.Text = "ºC";
            // 
            // txb_temp
            // 
            this.txb_temp.Location = new System.Drawing.Point(358, 263);
            this.txb_temp.Name = "txb_temp";
            this.txb_temp.Size = new System.Drawing.Size(238, 23);
            this.txb_temp.TabIndex = 81;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(163, 267);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(189, 19);
            this.metroLabel7.TabIndex = 80;
            this.metroLabel7.Text = "Temperatura do Mês mais Frio";
            // 
            // ReatorUASBView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txb_temp);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.txb_sst);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.txb_dqo);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.bt_uasb_voltar);
            this.Controls.Add(this.bt_uasb_avancar);
            this.Controls.Add(this.txb_dbo);
            this.Controls.Add(this.lb_tipoGrade);
            this.Controls.Add(this.lb_centralTitulo);
            this.Name = "ReatorUASBView";
            this.Text = "ReatorUASBView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lb_centralTitulo;
        private MetroFramework.Controls.MetroLabel lb_tipoGrade;
        private MetroFramework.Controls.MetroTextBox txb_dbo;
        private MetroFramework.Controls.MetroButton bt_uasb_voltar;
        private MetroFramework.Controls.MetroButton bt_uasb_avancar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txb_dqo;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.CheckBox checkBox3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txb_sst;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txb_temp;
        private MetroFramework.Controls.MetroLabel metroLabel7;
    }
}