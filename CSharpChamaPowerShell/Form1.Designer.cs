namespace CSharpChamaPowerShell
{
    partial class Form1
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
            this.btnCallPowerShell = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCallPowerShell
            // 
            this.btnCallPowerShell.Location = new System.Drawing.Point(179, 150);
            this.btnCallPowerShell.Name = "btnCallPowerShell";
            this.btnCallPowerShell.Size = new System.Drawing.Size(126, 23);
            this.btnCallPowerShell.TabIndex = 0;
            this.btnCallPowerShell.Text = "Chama PowerShell";
            this.btnCallPowerShell.UseVisualStyleBackColor = true;
            this.btnCallPowerShell.Click += new System.EventHandler(this.btnCallPowerShell_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 333);
            this.Controls.Add(this.btnCallPowerShell);
            this.Name = "Form1";
            this.Text = "Form1";            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCallPowerShell;
    }
}

