namespace 複製字串
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.output = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.times = new System.Windows.Forms.NumericUpDown();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.inputLenth = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.RichTextBox();
            this.timesLeft = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.times)).BeginInit();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.output.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(12, 12);
            this.output.Name = "output";
            this.output.ReadOnly = true;
            this.output.Size = new System.Drawing.Size(1012, 354);
            this.output.TabIndex = 0;
            this.output.TabStop = false;
            this.output.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "字串";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.label3.Location = new System.Drawing.Point(613, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "重複次數";
            // 
            // times
            // 
            this.times.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.times.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.times.Location = new System.Drawing.Point(783, 146);
            this.times.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.times.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(241, 55);
            this.times.TabIndex = 6;
            this.times.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.inputLenth);
            this.groupBox.Controls.Add(this.input);
            this.groupBox.Controls.Add(this.timesLeft);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.start);
            this.groupBox.Controls.Add(this.times);
            this.groupBox.Controls.Add(this.label1);
            this.groupBox.Location = new System.Drawing.Point(0, 372);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(1040, 263);
            this.groupBox.TabIndex = 7;
            this.groupBox.TabStop = false;
            // 
            // inputLenth
            // 
            this.inputLenth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.inputLenth.AutoSize = true;
            this.inputLenth.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.inputLenth.Location = new System.Drawing.Point(346, 213);
            this.inputLenth.Name = "inputLenth";
            this.inputLenth.Size = new System.Drawing.Size(76, 40);
            this.inputLenth.TabIndex = 12;
            this.inputLenth.Text = "0 字";
            // 
            // input
            // 
            this.input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.input.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.input.Location = new System.Drawing.Point(104, 28);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(920, 107);
            this.input.TabIndex = 11;
            this.input.Text = "";
            this.input.TextChanged += new System.EventHandler(this.input_TextChanged);
            // 
            // timesLeft
            // 
            this.timesLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.timesLeft.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timesLeft.Enabled = false;
            this.timesLeft.Font = new System.Drawing.Font("微軟正黑體", 16F);
            this.timesLeft.Location = new System.Drawing.Point(797, 213);
            this.timesLeft.Name = "timesLeft";
            this.timesLeft.ReadOnly = true;
            this.timesLeft.Size = new System.Drawing.Size(237, 43);
            this.timesLeft.TabIndex = 9;
            this.timesLeft.TabStop = false;
            this.timesLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // start
            // 
            this.start.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.start.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.start.Location = new System.Drawing.Point(6, 213);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(172, 47);
            this.start.TabIndex = 8;
            this.start.TabStop = false;
            this.start.Text = "開始複製";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 647);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "複製字串";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.times)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox output;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown times;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.TextBox timesLeft;
        private System.Windows.Forms.RichTextBox input;
        private System.Windows.Forms.Label inputLenth;
    }
}

