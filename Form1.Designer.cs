﻿
namespace ConsultarSelosPA
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttBuscar = new System.Windows.Forms.Button();
            this.buttLimpar = new System.Windows.Forms.Button();
            this.tBNumeroS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBSeguraca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cBTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cBSerie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.wBrowser = new System.Windows.Forms.WebBrowser();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(641, 490);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttBuscar);
            this.tabPage1.Controls.Add(this.buttLimpar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.tBNumeroS);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tBSeguraca);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cBTipo);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cBSerie);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(633, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consultar Selo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttBuscar
            // 
            this.buttBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttBuscar.Location = new System.Drawing.Point(385, 184);
            this.buttBuscar.Name = "buttBuscar";
            this.buttBuscar.Size = new System.Drawing.Size(114, 30);
            this.buttBuscar.TabIndex = 10;
            this.buttBuscar.Text = "Buscar";
            this.buttBuscar.UseVisualStyleBackColor = true;
            this.buttBuscar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttBuscar_MouseClick);
            // 
            // buttLimpar
            // 
            this.buttLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttLimpar.Location = new System.Drawing.Point(505, 184);
            this.buttLimpar.Name = "buttLimpar";
            this.buttLimpar.Size = new System.Drawing.Size(114, 30);
            this.buttLimpar.TabIndex = 9;
            this.buttLimpar.Text = "Limpar";
            this.buttLimpar.UseVisualStyleBackColor = true;
            this.buttLimpar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttLimpar_MouseClick);
            // 
            // tBNumeroS
            // 
            this.tBNumeroS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBNumeroS.Location = new System.Drawing.Point(197, 128);
            this.tBNumeroS.Name = "tBNumeroS";
            this.tBNumeroS.Size = new System.Drawing.Size(422, 29);
            this.tBNumeroS.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número Selo:";
            // 
            // tBSeguraca
            // 
            this.tBSeguraca.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBSeguraca.Location = new System.Drawing.Point(197, 79);
            this.tBSeguraca.Name = "tBSeguraca";
            this.tBSeguraca.Size = new System.Drawing.Size(422, 29);
            this.tBSeguraca.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código de Segurança:";
            // 
            // cBTipo
            // 
            this.cBTipo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cBTipo.FormattingEnabled = true;
            this.cBTipo.Items.AddRange(new object[] {
            "SELO DIGITAL GERAL",
            "SELO DIGITAL GRATUITO",
            "SELO DIGITAL RECONHECIMENTO",
            "SELO DIGITAL AUTENTICAÇÃO",
            "SELO DIGITAL CERTIDÃO",
            "SELO DIGITAL PROCURAÇÃO PÚBLICA",
            "SELO DIGITAL ESCRITURA PÚBLICA",
            "SELO DIGITAL CERTIDÃO DE NASCIMENTO 1ª VIA",
            "SELO DIGITAL CERTIDÃO DE ÓBITO 1ª VIA",
            "SELO DIGITAL CERTIDÃO DE NASCIMENTO 2ª VIA",
            "SELO DIGITAL CERTIDÃO DE ÓBITO 2ª VIA",
            "SELO DIGITAL DE POSTECIPAÇÃO"});
            this.cBTipo.Location = new System.Drawing.Point(299, 26);
            this.cBTipo.Name = "cBTipo";
            this.cBTipo.Size = new System.Drawing.Size(320, 29);
            this.cBTipo.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo:";
            // 
            // cBSerie
            // 
            this.cBSerie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cBSerie.FormattingEnabled = true;
            this.cBSerie.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cBSerie.Location = new System.Drawing.Point(76, 26);
            this.cBSerie.MinimumSize = new System.Drawing.Size(50, 0);
            this.cBSerie.Name = "cBSerie";
            this.cBSerie.Size = new System.Drawing.Size(121, 29);
            this.cBSerie.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Serie:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(633, 411);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Consultar Arquivo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // wBrowser
            // 
            this.wBrowser.Location = new System.Drawing.Point(6, 28);
            this.wBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.wBrowser.Name = "wBrowser";
            this.wBrowser.ScriptErrorsSuppressed = true;
            this.wBrowser.Size = new System.Drawing.Size(605, 196);
            this.wBrowser.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.wBrowser);
            this.groupBox1.Location = new System.Drawing.Point(6, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 230);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultado";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 502);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximumSize = new System.Drawing.Size(681, 541);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Consutar Selos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tBNumeroS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBSeguraca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cBTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBSerie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttBuscar;
        private System.Windows.Forms.Button buttLimpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.WebBrowser wBrowser;
    }
}

