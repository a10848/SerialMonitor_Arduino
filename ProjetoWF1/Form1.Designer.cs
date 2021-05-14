
namespace ProjetoWF1
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSalvarLog = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.ferramentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAbrirPorta = new System.Windows.Forms.ToolStripMenuItem();
            this.itemFecharPorta = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVelocidade = new System.Windows.Forms.ToolStripMenuItem();
            this.itemAutoScroll = new System.Windows.Forms.ToolStripMenuItem();
            this.itemQuebraLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.itemLimparLog = new System.Windows.Forms.ToolStripMenuItem();
            this.itemSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEnviar = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.ferramentasToolStripMenuItem,
            this.itemSobre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemSalvarLog,
            this.itemSair});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // itemSalvarLog
            // 
            this.itemSalvarLog.Name = "itemSalvarLog";
            this.itemSalvarLog.Size = new System.Drawing.Size(128, 22);
            this.itemSalvarLog.Text = "Salvar Log";
            this.itemSalvarLog.Click += new System.EventHandler(this.itemSalvarLog_Click);
            // 
            // itemSair
            // 
            this.itemSair.Name = "itemSair";
            this.itemSair.Size = new System.Drawing.Size(128, 22);
            this.itemSair.Text = "Sair";
            this.itemSair.Click += new System.EventHandler(this.itemSair_Click);
            // 
            // ferramentasToolStripMenuItem
            // 
            this.ferramentasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAbrirPorta,
            this.itemFecharPorta,
            this.itemVelocidade,
            this.itemAutoScroll,
            this.itemQuebraLinha,
            this.itemLimparLog});
            this.ferramentasToolStripMenuItem.Name = "ferramentasToolStripMenuItem";
            this.ferramentasToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ferramentasToolStripMenuItem.Text = "Ferramentas";
            // 
            // itemAbrirPorta
            // 
            this.itemAbrirPorta.Name = "itemAbrirPorta";
            this.itemAbrirPorta.Size = new System.Drawing.Size(215, 22);
            this.itemAbrirPorta.Text = "Abrir Porta";
            // 
            // itemFecharPorta
            // 
            this.itemFecharPorta.Name = "itemFecharPorta";
            this.itemFecharPorta.Size = new System.Drawing.Size(215, 22);
            this.itemFecharPorta.Text = "Fechar Porta";
            this.itemFecharPorta.Click += new System.EventHandler(this.itemFecharPorta_Click);
            // 
            // itemVelocidade
            // 
            this.itemVelocidade.Name = "itemVelocidade";
            this.itemVelocidade.Size = new System.Drawing.Size(215, 22);
            this.itemVelocidade.Text = "Velocidade";
            // 
            // itemAutoScroll
            // 
            this.itemAutoScroll.Name = "itemAutoScroll";
            this.itemAutoScroll.Size = new System.Drawing.Size(215, 22);
            this.itemAutoScroll.Text = "Auto Scroll";
            this.itemAutoScroll.Click += new System.EventHandler(this.itemAutoScroll_Click);
            // 
            // itemQuebraLinha
            // 
            this.itemQuebraLinha.Name = "itemQuebraLinha";
            this.itemQuebraLinha.Size = new System.Drawing.Size(215, 22);
            this.itemQuebraLinha.Text = "Adicionar Quebra de Linha";
            this.itemQuebraLinha.Click += new System.EventHandler(this.itemQuebraLinha_Click);
            // 
            // itemLimparLog
            // 
            this.itemLimparLog.Name = "itemLimparLog";
            this.itemLimparLog.Size = new System.Drawing.Size(215, 22);
            this.itemLimparLog.Text = "Limpar o Log";
            this.itemLimparLog.Click += new System.EventHandler(this.itemLimparLog_Click);
            // 
            // itemSobre
            // 
            this.itemSobre.Name = "itemSobre";
            this.itemSobre.Size = new System.Drawing.Size(49, 20);
            this.itemSobre.Text = "Sobre";
            this.itemSobre.Click += new System.EventHandler(this.itemSobre_Click);
            // 
            // txtEnviar
            // 
            this.txtEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnviar.Location = new System.Drawing.Point(12, 27);
            this.txtEnviar.Name = "txtEnviar";
            this.txtEnviar.Size = new System.Drawing.Size(479, 20);
            this.txtEnviar.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnviar.Location = new System.Drawing.Point(497, 27);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Location = new System.Drawing.Point(12, 53);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(560, 496);
            this.txtLog.TabIndex = 3;
            this.txtLog.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtEnviar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Multicolor Monitor Serial";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemSalvarLog;
        private System.Windows.Forms.ToolStripMenuItem itemSair;
        private System.Windows.Forms.ToolStripMenuItem ferramentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itemAbrirPorta;
        private System.Windows.Forms.ToolStripMenuItem itemFecharPorta;
        private System.Windows.Forms.ToolStripMenuItem itemAutoScroll;
        private System.Windows.Forms.ToolStripMenuItem itemQuebraLinha;
        private System.Windows.Forms.ToolStripMenuItem itemLimparLog;
        private System.Windows.Forms.ToolStripMenuItem itemSobre;
        private System.Windows.Forms.TextBox txtEnviar;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.ToolStripMenuItem itemVelocidade;
    }
}

