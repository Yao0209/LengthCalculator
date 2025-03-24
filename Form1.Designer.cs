namespace LengthCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCM = new System.Windows.Forms.TextBox();
            this.txtM = new System.Windows.Forms.TextBox();
            this.txtKM = new System.Windows.Forms.TextBox();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.txtFt = new System.Windows.Forms.TextBox();
            this.txtYard = new System.Windows.Forms.TextBox();
            this.btnAllClear = new System.Windows.Forms.Button();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(94, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "公分 (cm)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(315, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "公尺 (m)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(498, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "公里 (km)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(94, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "英吋 (in)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(512, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 35);
            this.label5.TabIndex = 4;
            this.label5.Text = "碼 (yd)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(315, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "英呎 (ft)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCM
            // 
            this.txtCM.BackColor = System.Drawing.SystemColors.Window;
            this.txtCM.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCM.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtCM.Location = new System.Drawing.Point(41, 199);
            this.txtCM.Name = "txtCM";
            this.txtCM.Size = new System.Drawing.Size(213, 39);
            this.txtCM.TabIndex = 6;
            this.txtCM.TextChanged += new System.EventHandler(this.txtCM_TextChanged);
            this.txtCM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCM_KeyUp);
            // 
            // txtM
            // 
            this.txtM.BackColor = System.Drawing.SystemColors.Window;
            this.txtM.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtM.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtM.Location = new System.Drawing.Point(261, 199);
            this.txtM.Name = "txtM";
            this.txtM.Size = new System.Drawing.Size(208, 39);
            this.txtM.TabIndex = 7;
            this.txtM.TextChanged += new System.EventHandler(this.txtM_TextChanged);
            this.txtM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtM_KeyUp);
            // 
            // txtKM
            // 
            this.txtKM.BackColor = System.Drawing.SystemColors.Window;
            this.txtKM.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtKM.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtKM.Location = new System.Drawing.Point(475, 199);
            this.txtKM.Name = "txtKM";
            this.txtKM.Size = new System.Drawing.Size(187, 39);
            this.txtKM.TabIndex = 8;
            this.txtKM.TextChanged += new System.EventHandler(this.txtKM_TextChanged);
            this.txtKM.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKM_KeyUp);
            // 
            // txtIn
            // 
            this.txtIn.BackColor = System.Drawing.SystemColors.Window;
            this.txtIn.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtIn.Location = new System.Drawing.Point(41, 300);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(213, 39);
            this.txtIn.TabIndex = 9;
            this.txtIn.TextChanged += new System.EventHandler(this.txtIn_TextChanged);
            this.txtIn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIn_KeyUp);
            // 
            // txtFt
            // 
            this.txtFt.BackColor = System.Drawing.SystemColors.Window;
            this.txtFt.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtFt.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtFt.Location = new System.Drawing.Point(260, 300);
            this.txtFt.Name = "txtFt";
            this.txtFt.Size = new System.Drawing.Size(209, 39);
            this.txtFt.TabIndex = 10;
            this.txtFt.TextChanged += new System.EventHandler(this.txtFt_TextChanged);
            this.txtFt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFt_KeyUp);
            // 
            // txtYard
            // 
            this.txtYard.BackColor = System.Drawing.SystemColors.Window;
            this.txtYard.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtYard.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtYard.Location = new System.Drawing.Point(475, 300);
            this.txtYard.Name = "txtYard";
            this.txtYard.Size = new System.Drawing.Size(187, 39);
            this.txtYard.TabIndex = 11;
            this.txtYard.TextChanged += new System.EventHandler(this.txtYard_TextChanged);
            this.txtYard.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtYard_KeyUp);
            // 
            // btnAllClear
            // 
            this.btnAllClear.BackColor = System.Drawing.Color.Red;
            this.btnAllClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllClear.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAllClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAllClear.Location = new System.Drawing.Point(282, 51);
            this.btnAllClear.Name = "btnAllClear";
            this.btnAllClear.Size = new System.Drawing.Size(153, 86);
            this.btnAllClear.TabIndex = 16;
            this.btnAllClear.Text = "清除 (delete)";
            this.btnAllClear.UseVisualStyleBackColor = false;
            this.btnAllClear.Click += new System.EventHandler(this.btnAllClear_Click);
            // 
            // txtInfo
            // 
            this.txtInfo.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtInfo.Location = new System.Drawing.Point(41, 451);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(572, 36);
            this.txtInfo.TabIndex = 17;
            this.txtInfo.TextChanged += new System.EventHandler(this.txtInfo_TextChanged);
            this.txtInfo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInfo_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(66, 401);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 47);
            this.label12.TabIndex = 19;
            this.label12.Text = "說明文字";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 750);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.btnAllClear);
            this.Controls.Add(this.txtYard);
            this.Controls.Add(this.txtFt);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.txtKM);
            this.Controls.Add(this.txtM);
            this.Controls.Add(this.txtCM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCM;
        private System.Windows.Forms.TextBox txtM;
        private System.Windows.Forms.TextBox txtKM;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.TextBox txtFt;
        private System.Windows.Forms.TextBox txtYard;
        private System.Windows.Forms.Button btnAllClear;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Label label12;
    }
}

