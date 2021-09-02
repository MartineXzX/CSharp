namespace Ejercicio25
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDecimal = new System.Windows.Forms.TextBox();
            this.txtBinario = new System.Windows.Forms.TextBox();
            this.btnBinToDec = new System.Windows.Forms.Button();
            this.btnDecToBin = new System.Windows.Forms.Button();
            this.txtResultadoBin = new System.Windows.Forms.TextBox();
            this.txtResultadoDec = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Binario a Decimal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Decimal a Binario";
            // 
            // txtDecimal
            // 
            this.txtDecimal.Location = new System.Drawing.Point(180, 84);
            this.txtDecimal.Name = "txtDecimal";
            this.txtDecimal.Size = new System.Drawing.Size(119, 26);
            this.txtDecimal.TabIndex = 1;
            // 
            // txtBinario
            // 
            this.txtBinario.Location = new System.Drawing.Point(180, 48);
            this.txtBinario.Name = "txtBinario";
            this.txtBinario.Size = new System.Drawing.Size(119, 26);
            this.txtBinario.TabIndex = 1;
            // 
            // btnBinToDec
            // 
            this.btnBinToDec.Location = new System.Drawing.Point(313, 46);
            this.btnBinToDec.Name = "btnBinToDec";
            this.btnBinToDec.Size = new System.Drawing.Size(98, 28);
            this.btnBinToDec.TabIndex = 2;
            this.btnBinToDec.Text = "->";
            this.btnBinToDec.UseVisualStyleBackColor = true;
            this.btnBinToDec.Click += new System.EventHandler(this.btnBinToDec_Click);
            // 
            // btnDecToBin
            // 
            this.btnDecToBin.Location = new System.Drawing.Point(313, 84);
            this.btnDecToBin.Name = "btnDecToBin";
            this.btnDecToBin.Size = new System.Drawing.Size(98, 29);
            this.btnDecToBin.TabIndex = 2;
            this.btnDecToBin.Text = "->";
            this.btnDecToBin.UseVisualStyleBackColor = true;
            this.btnDecToBin.Click += new System.EventHandler(this.btnDecToBin_Click);
            // 
            // txtResultadoBin
            // 
            this.txtResultadoBin.Enabled = false;
            this.txtResultadoBin.Location = new System.Drawing.Point(434, 85);
            this.txtResultadoBin.Name = "txtResultadoBin";
            this.txtResultadoBin.Size = new System.Drawing.Size(129, 26);
            this.txtResultadoBin.TabIndex = 3;
            // 
            // txtResultadoDec
            // 
            this.txtResultadoDec.Enabled = false;
            this.txtResultadoDec.Location = new System.Drawing.Point(434, 46);
            this.txtResultadoDec.Name = "txtResultadoDec";
            this.txtResultadoDec.Size = new System.Drawing.Size(129, 26);
            this.txtResultadoDec.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 156);
            this.Controls.Add(this.txtResultadoDec);
            this.Controls.Add(this.txtResultadoBin);
            this.Controls.Add(this.btnDecToBin);
            this.Controls.Add(this.btnBinToDec);
            this.Controls.Add(this.txtBinario);
            this.Controls.Add(this.txtDecimal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conversor Numerico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDecimal;
        private System.Windows.Forms.TextBox txtBinario;
        private System.Windows.Forms.Button btnBinToDec;
        private System.Windows.Forms.Button btnDecToBin;
        private System.Windows.Forms.TextBox txtResultadoBin;
        private System.Windows.Forms.TextBox txtResultadoDec;
    }
}

