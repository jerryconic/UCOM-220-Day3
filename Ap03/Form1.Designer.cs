namespace Ap03
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoNo1 = new System.Windows.Forms.RadioButton();
            this.rdoNo2 = new System.Windows.Forms.RadioButton();
            this.rdoNo3 = new System.Windows.Forms.RadioButton();
            this.chkCream = new System.Windows.Forms.CheckBox();
            this.chkPie = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNo3);
            this.groupBox1.Controls.Add(this.rdoNo2);
            this.groupBox1.Controls.Add(this.rdoNo1);
            this.groupBox1.Location = new System.Drawing.Point(30, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "主餐";
            // 
            // rdoNo1
            // 
            this.rdoNo1.AutoSize = true;
            this.rdoNo1.Location = new System.Drawing.Point(32, 38);
            this.rdoNo1.Name = "rdoNo1";
            this.rdoNo1.Size = new System.Drawing.Size(78, 20);
            this.rdoNo1.TabIndex = 0;
            this.rdoNo1.TabStop = true;
            this.rdoNo1.Text = "No1(95)";
            this.rdoNo1.UseVisualStyleBackColor = true;
            // 
            // rdoNo2
            // 
            this.rdoNo2.AutoSize = true;
            this.rdoNo2.Location = new System.Drawing.Point(32, 64);
            this.rdoNo2.Name = "rdoNo2";
            this.rdoNo2.Size = new System.Drawing.Size(86, 20);
            this.rdoNo2.TabIndex = 1;
            this.rdoNo2.TabStop = true;
            this.rdoNo2.Text = "No2(105)";
            this.rdoNo2.UseVisualStyleBackColor = true;
            // 
            // rdoNo3
            // 
            this.rdoNo3.AutoSize = true;
            this.rdoNo3.Location = new System.Drawing.Point(32, 90);
            this.rdoNo3.Name = "rdoNo3";
            this.rdoNo3.Size = new System.Drawing.Size(86, 20);
            this.rdoNo3.TabIndex = 2;
            this.rdoNo3.TabStop = true;
            this.rdoNo3.Text = "No3(120)";
            this.rdoNo3.UseVisualStyleBackColor = true;
            // 
            // chkCream
            // 
            this.chkCream.AutoSize = true;
            this.chkCream.Location = new System.Drawing.Point(58, 185);
            this.chkCream.Name = "chkCream";
            this.chkCream.Size = new System.Drawing.Size(116, 20);
            this.chkCream.TabIndex = 1;
            this.chkCream.Text = "Ice Cream(15)";
            this.chkCream.UseVisualStyleBackColor = true;
            // 
            // chkPie
            // 
            this.chkPie.AutoSize = true;
            this.chkPie.Location = new System.Drawing.Point(58, 211);
            this.chkPie.Name = "chkPie";
            this.chkPie.Size = new System.Drawing.Size(113, 20);
            this.chkPie.TabIndex = 2;
            this.chkPie.Text = "Apple Pie(25)";
            this.chkPie.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "小計:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(83, 268);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(109, 27);
            this.txtTotal.TabIndex = 4;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(65, 313);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(109, 36);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "計算";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 372);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkPie);
            this.Controls.Add(this.chkCream);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "點餐系統";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoNo3;
        private System.Windows.Forms.RadioButton rdoNo2;
        private System.Windows.Forms.RadioButton rdoNo1;
        private System.Windows.Forms.CheckBox chkCream;
        private System.Windows.Forms.CheckBox chkPie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalc;
    }
}

