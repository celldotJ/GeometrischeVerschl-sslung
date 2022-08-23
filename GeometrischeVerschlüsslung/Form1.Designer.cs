namespace GeometrischeVerschlüsslung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputTxtBx = new System.Windows.Forms.TextBox();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.resultLbl = new System.Windows.Forms.Label();
            this.resultTxtBx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputTxtBx
            // 
            this.inputTxtBx.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTxtBx.Location = new System.Drawing.Point(12, 12);
            this.inputTxtBx.Name = "inputTxtBx";
            this.inputTxtBx.Size = new System.Drawing.Size(849, 93);
            this.inputTxtBx.TabIndex = 0;
            this.inputTxtBx.Text = "TESTWORD";
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(867, 12);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(150, 40);
            this.encryptBtn.TabIndex = 1;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(867, 65);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(150, 40);
            this.decryptBtn.TabIndex = 2;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.Location = new System.Drawing.Point(12, 117);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 32);
            this.resultLbl.TabIndex = 3;
            // 
            // resultTxtBx
            // 
            this.resultTxtBx.Location = new System.Drawing.Point(12, 117);
            this.resultTxtBx.Name = "resultTxtBx";
            this.resultTxtBx.Size = new System.Drawing.Size(1005, 39);
            this.resultTxtBx.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 167);
            this.Controls.Add(this.resultTxtBx);
            this.Controls.Add(this.resultLbl);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.inputTxtBx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inputTxtBx;
        private Button encryptBtn;
        private Button decryptBtn;
        private Label resultLbl;
        private TextBox resultTxtBx;
    }
}