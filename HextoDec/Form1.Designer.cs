namespace HextoDec
{
    partial class btnConv
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtVal = new System.Windows.Forms.TextBox();
            this.rbDecHex = new System.Windows.Forms.RadioButton();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.rbHexDec = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVal
            // 
            this.txtVal.Location = new System.Drawing.Point(12, 12);
            this.txtVal.Name = "txtVal";
            this.txtVal.Size = new System.Drawing.Size(129, 20);
            this.txtVal.TabIndex = 0;
            this.txtVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbDecHex
            // 
            this.rbDecHex.AutoSize = true;
            this.rbDecHex.Location = new System.Drawing.Point(12, 64);
            this.rbDecHex.Name = "rbDecHex";
            this.rbDecHex.Size = new System.Drawing.Size(97, 17);
            this.rbDecHex.TabIndex = 1;
            this.rbDecHex.TabStop = true;
            this.rbDecHex.Text = "Decimal - Hexa";
            this.rbDecHex.UseVisualStyleBackColor = true;
            this.rbDecHex.CheckedChanged += new System.EventHandler(this.rbDecHex_CheckedChanged);
            // 
            // txtShow
            // 
            this.txtShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShow.Location = new System.Drawing.Point(12, 38);
            this.txtShow.Name = "txtShow";
            this.txtShow.ReadOnly = true;
            this.txtShow.Size = new System.Drawing.Size(129, 20);
            this.txtShow.TabIndex = 2;
            this.txtShow.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rbHexDec
            // 
            this.rbHexDec.AutoSize = true;
            this.rbHexDec.Location = new System.Drawing.Point(12, 87);
            this.rbHexDec.Name = "rbHexDec";
            this.rbHexDec.Size = new System.Drawing.Size(97, 17);
            this.rbHexDec.TabIndex = 3;
            this.rbHexDec.TabStop = true;
            this.rbHexDec.Text = "Hexa - Decimal";
            this.rbHexDec.UseVisualStyleBackColor = true;
            this.rbHexDec.CheckedChanged += new System.EventHandler(this.rbHexDec_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnConv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 142);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rbHexDec);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.rbDecHex);
            this.Controls.Add(this.txtVal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "btnConv";
            this.Text = "Convert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVal;
        private System.Windows.Forms.RadioButton rbDecHex;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.RadioButton rbHexDec;
        private System.Windows.Forms.Button button1;
    }
}

