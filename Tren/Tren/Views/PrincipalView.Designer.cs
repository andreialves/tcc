namespace Tren.Views {
    partial class PrincipalView {
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
            MetroFramework.Controls.MetroLabel metroLabel1;
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.bt_SeqIndividual = new MetroFramework.Controls.MetroButton();
            this.bt_SeqColetiva = new MetroFramework.Controls.MetroButton();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            metroLabel1.AutoSize = true;
            metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            metroLabel1.Location = new System.Drawing.Point(172, 51);
            metroLabel1.Name = "metroLabel1";
            metroLabel1.Size = new System.Drawing.Size(386, 25);
            metroLabel1.TabIndex = 4;
            metroLabel1.Text = "Selecione de acordo com seu empreendimento";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(2, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(800, 450);
            this.metroTabControl1.TabIndex = 0;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(metroLabel1);
            this.metroTabPage1.Controls.Add(this.bt_SeqIndividual);
            this.metroTabPage1.Controls.Add(this.bt_SeqColetiva);
            this.metroTabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(792, 411);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Início";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // bt_SeqIndividual
            // 
            this.bt_SeqIndividual.AllowDrop = true;
            this.bt_SeqIndividual.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_SeqIndividual.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_SeqIndividual.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_SeqIndividual.Location = new System.Drawing.Point(429, 124);
            this.bt_SeqIndividual.Name = "bt_SeqIndividual";
            this.bt_SeqIndividual.Size = new System.Drawing.Size(166, 74);
            this.bt_SeqIndividual.TabIndex = 3;
            this.bt_SeqIndividual.Text = "Sequência Individual";
            this.bt_SeqIndividual.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // bt_SeqColetiva
            // 
            this.bt_SeqColetiva.AllowDrop = true;
            this.bt_SeqColetiva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bt_SeqColetiva.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bt_SeqColetiva.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_SeqColetiva.Location = new System.Drawing.Point(147, 124);
            this.bt_SeqColetiva.Name = "bt_SeqColetiva";
            this.bt_SeqColetiva.Size = new System.Drawing.Size(166, 74);
            this.bt_SeqColetiva.TabIndex = 2;
            this.bt_SeqColetiva.Text = "Sequência Coletiva";
            this.bt_SeqColetiva.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.webBrowser1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 35);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(792, 411);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Material de Apoio";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(792, 411);
            this.webBrowser1.TabIndex = 2;
            // 
            // PrincipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "PrincipalView";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroButton bt_SeqColetiva;
        private MetroFramework.Controls.MetroButton bt_SeqIndividual;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}