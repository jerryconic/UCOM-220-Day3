namespace Ap14
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtASCII = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtUpper = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLower = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDigit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(48, 41);
            this.txtA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(457, 27);
            this.txtA.TabIndex = 0;
            this.txtA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtA_KeyPress);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(48, 136);
            this.txtB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(457, 27);
            this.txtB.TabIndex = 1;
            this.txtB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtB_KeyDown);
            // 
            // txtASCII
            // 
            this.txtASCII.Location = new System.Drawing.Point(48, 75);
            this.txtASCII.Name = "txtASCII";
            this.txtASCII.Size = new System.Drawing.Size(118, 27);
            this.txtASCII.TabIndex = 2;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(48, 170);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(118, 27);
            this.txtCode.TabIndex = 3;
            // 
            // txtUpper
            // 
            this.txtUpper.Location = new System.Drawing.Point(112, 224);
            this.txtUpper.MaxLength = 10;
            this.txtUpper.Name = "txtUpper";
            this.txtUpper.Size = new System.Drawing.Size(304, 27);
            this.txtUpper.TabIndex = 4;
            this.txtUpper.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUpper_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Upper:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Lower:";
            // 
            // txtLower
            // 
            this.txtLower.Location = new System.Drawing.Point(112, 257);
            this.txtLower.Name = "txtLower";
            this.txtLower.Size = new System.Drawing.Size(304, 27);
            this.txtLower.TabIndex = 6;
            this.txtLower.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLower_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "0 ~ 9:";
            // 
            // txtDigit
            // 
            this.txtDigit.Location = new System.Drawing.Point(112, 290);
            this.txtDigit.Name = "txtDigit";
            this.txtDigit.Size = new System.Drawing.Size(304, 27);
            this.txtDigit.TabIndex = 8;
            this.txtDigit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDigit_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "A ~ Z:";
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(112, 323);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(304, 27);
            this.txtLetter.TabIndex = 10;
            this.txtLetter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLetter_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 393);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDigit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLower);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUpper);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.txtASCII);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtASCII;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtUpper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLower;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDigit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLetter;
    }
}

