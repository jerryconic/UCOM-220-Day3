namespace Ap06
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
            this.btnRoll = new System.Windows.Forms.Button();
            this.pct4 = new System.Windows.Forms.PictureBox();
            this.pct3 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.lblPoint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoll
            // 
            this.btnRoll.Location = new System.Drawing.Point(859, 267);
            this.btnRoll.Margin = new System.Windows.Forms.Padding(4);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(213, 53);
            this.btnRoll.TabIndex = 9;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // pct4
            // 
            this.pct4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct4.Location = new System.Drawing.Point(823, 40);
            this.pct4.Margin = new System.Windows.Forms.Padding(4);
            this.pct4.Name = "pct4";
            this.pct4.Size = new System.Drawing.Size(247, 197);
            this.pct4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct4.TabIndex = 8;
            this.pct4.TabStop = false;
            // 
            // pct3
            // 
            this.pct3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct3.Location = new System.Drawing.Point(565, 40);
            this.pct3.Margin = new System.Windows.Forms.Padding(4);
            this.pct3.Name = "pct3";
            this.pct3.Size = new System.Drawing.Size(247, 197);
            this.pct3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct3.TabIndex = 7;
            this.pct3.TabStop = false;
            // 
            // pct2
            // 
            this.pct2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct2.Location = new System.Drawing.Point(307, 40);
            this.pct2.Margin = new System.Windows.Forms.Padding(4);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(247, 197);
            this.pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct2.TabIndex = 6;
            this.pct2.TabStop = false;
            // 
            // pct1
            // 
            this.pct1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pct1.Location = new System.Drawing.Point(49, 40);
            this.pct1.Margin = new System.Windows.Forms.Padding(4);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(247, 197);
            this.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct1.TabIndex = 5;
            this.pct1.TabStop = false;
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.Font = new System.Drawing.Font("Goudy Stout", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lblPoint.Location = new System.Drawing.Point(69, 283);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(209, 37);
            this.lblPoint.TabIndex = 10;
            this.lblPoint.Text = "0 Point";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1124, 548);
            this.Controls.Add(this.lblPoint);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.pct4);
            this.Controls.Add(this.pct3);
            this.Controls.Add(this.pct2);
            this.Controls.Add(this.pct1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "擲骰子(判斷點數)";
            ((System.ComponentModel.ISupportInitialize)(this.pct4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.PictureBox pct4;
        private System.Windows.Forms.PictureBox pct3;
        private System.Windows.Forms.PictureBox pct2;
        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.Label lblPoint;
    }
}

