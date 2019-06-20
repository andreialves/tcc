namespace Tren.Views {
    partial class LagoaMaturacaoView {
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
			this.bt_lagoMaturacao_voltar = new MetroFramework.Controls.MetroButton();
			this.bt_lagoaMaturacao_avancar = new MetroFramework.Controls.MetroButton();
			this.lb_dbo = new MetroFramework.Controls.MetroLabel();
			this.coliformesInicias = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
			this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
			this.temperaturaLiquido = new MetroFramework.Controls.MetroTextBox();
			this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
			this.SuspendLayout();
			// 
			// bt_lagoMaturacao_voltar
			// 
			this.bt_lagoMaturacao_voltar.Location = new System.Drawing.Point(110, 390);
			this.bt_lagoMaturacao_voltar.Name = "bt_lagoMaturacao_voltar";
			this.bt_lagoMaturacao_voltar.Size = new System.Drawing.Size(237, 45);
			this.bt_lagoMaturacao_voltar.TabIndex = 3;
			this.bt_lagoMaturacao_voltar.Text = "Voltar";
			this.bt_lagoMaturacao_voltar.Click += new System.EventHandler(this.bt_lagoMaturacao_voltar_Click);
			// 
			// bt_lagoaMaturacao_avancar
			// 
			this.bt_lagoaMaturacao_avancar.Location = new System.Drawing.Point(453, 390);
			this.bt_lagoaMaturacao_avancar.Name = "bt_lagoaMaturacao_avancar";
			this.bt_lagoaMaturacao_avancar.Size = new System.Drawing.Size(237, 45);
			this.bt_lagoaMaturacao_avancar.TabIndex = 4;
			this.bt_lagoaMaturacao_avancar.Text = "Avançar";
			this.bt_lagoaMaturacao_avancar.Click += new System.EventHandler(this.bt_lagoaMaturacao_avancar_Click);
			// 
			// lb_dbo
			// 
			this.lb_dbo.AutoSize = true;
			this.lb_dbo.Location = new System.Drawing.Point(99, 157);
			this.lb_dbo.Name = "lb_dbo";
			this.lb_dbo.Size = new System.Drawing.Size(218, 19);
			this.lb_dbo.TabIndex = 60;
			this.lb_dbo.Text = "Concentração de Coliformes Iniciais";
			// 
			// coliformesInicias
			// 
			this.coliformesInicias.Location = new System.Drawing.Point(362, 153);
			this.coliformesInicias.Name = "coliformesInicias";
			this.coliformesInicias.Size = new System.Drawing.Size(238, 23);
			this.coliformesInicias.TabIndex = 1;
			this.coliformesInicias.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_numeros);
			// 
			// metroLabel1
			// 
			this.metroLabel1.AutoSize = true;
			this.metroLabel1.Location = new System.Drawing.Point(633, 157);
			this.metroLabel1.Name = "metroLabel1";
			this.metroLabel1.Size = new System.Drawing.Size(64, 19);
			this.metroLabel1.TabIndex = 62;
			this.metroLabel1.Text = "CF/100ml";
			// 
			// metroLabel2
			// 
			this.metroLabel2.AutoSize = true;
			this.metroLabel2.Location = new System.Drawing.Point(99, 233);
			this.metroLabel2.Name = "metroLabel2";
			this.metroLabel2.Size = new System.Drawing.Size(169, 19);
			this.metroLabel2.TabIndex = 63;
			this.metroLabel2.Text = "Temperatura do Líquido (T)";
			// 
			// temperaturaLiquido
			// 
			this.temperaturaLiquido.Location = new System.Drawing.Point(362, 229);
			this.temperaturaLiquido.Name = "temperaturaLiquido";
			this.temperaturaLiquido.Size = new System.Drawing.Size(238, 23);
			this.temperaturaLiquido.TabIndex = 2;
			this.temperaturaLiquido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_numeros);
			// 
			// metroLabel3
			// 
			this.metroLabel3.AutoSize = true;
			this.metroLabel3.Location = new System.Drawing.Point(633, 233);
			this.metroLabel3.Name = "metroLabel3";
			this.metroLabel3.Size = new System.Drawing.Size(24, 19);
			this.metroLabel3.TabIndex = 65;
			this.metroLabel3.Text = "ºC";
			// 
			// LagoaMaturacaoView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.metroLabel3);
			this.Controls.Add(this.temperaturaLiquido);
			this.Controls.Add(this.metroLabel2);
			this.Controls.Add(this.metroLabel1);
			this.Controls.Add(this.coliformesInicias);
			this.Controls.Add(this.lb_dbo);
			this.Controls.Add(this.bt_lagoMaturacao_voltar);
			this.Controls.Add(this.bt_lagoaMaturacao_avancar);
			this.Name = "LagoaMaturacaoView";
			this.Text = "LagoaMaturacaoView";
			this.Load += new System.EventHandler(this.LagoaMaturacaoView_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton bt_lagoMaturacao_voltar;
        private MetroFramework.Controls.MetroButton bt_lagoaMaturacao_avancar;
        private MetroFramework.Controls.MetroLabel lb_dbo;
        private MetroFramework.Controls.MetroTextBox coliformesInicias;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox temperaturaLiquido;
        private MetroFramework.Controls.MetroLabel metroLabel3;
    }
}