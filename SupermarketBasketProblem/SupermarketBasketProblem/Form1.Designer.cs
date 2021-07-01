namespace SupermarketBasketProblem
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lsbFieldNames = new System.Windows.Forms.ListBox();
            this.lsbRules = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 12);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(525, 36);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "HESAPLA";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lsbFieldNames
            // 
            this.lsbFieldNames.FormattingEnabled = true;
            this.lsbFieldNames.Location = new System.Drawing.Point(12, 54);
            this.lsbFieldNames.Name = "lsbFieldNames";
            this.lsbFieldNames.Size = new System.Drawing.Size(334, 355);
            this.lsbFieldNames.TabIndex = 1;
            // 
            // lsbRules
            // 
            this.lsbRules.FormattingEnabled = true;
            this.lsbRules.Location = new System.Drawing.Point(352, 54);
            this.lsbRules.Name = "lsbRules";
            this.lsbRules.Size = new System.Drawing.Size(730, 355);
            this.lsbRules.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 454);
            this.Controls.Add(this.lsbRules);
            this.Controls.Add(this.lsbFieldNames);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox lsbFieldNames;
        private System.Windows.Forms.ListBox lsbRules;
    }
}

