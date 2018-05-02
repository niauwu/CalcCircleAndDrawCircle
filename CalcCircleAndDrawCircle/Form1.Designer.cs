namespace CalcCircleAndDrawCircle
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
            this.circumferenceLabel = new System.Windows.Forms.Label();
            this.circumferenceTextBox = new System.Windows.Forms.TextBox();
            this.clearCircleButton = new System.Windows.Forms.Button();
            this.diameterTextBox = new System.Windows.Forms.TextBox();
            this.diameterLabel = new System.Windows.Forms.Label();
            this.radiusTextBox = new System.Windows.Forms.TextBox();
            this.radiusLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // circumferenceLabel
            // 
            this.circumferenceLabel.AutoSize = true;
            this.circumferenceLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.circumferenceLabel.Location = new System.Drawing.Point(15, 312);
            this.circumferenceLabel.Name = "circumferenceLabel";
            this.circumferenceLabel.Size = new System.Drawing.Size(372, 48);
            this.circumferenceLabel.TabIndex = 7;
            this.circumferenceLabel.Text = "圓周長(0-3140)：";
            // 
            // circumferenceTextBox
            // 
            this.circumferenceTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.circumferenceTextBox.Location = new System.Drawing.Point(397, 301);
            this.circumferenceTextBox.MaxLength = 7;
            this.circumferenceTextBox.Name = "circumferenceTextBox";
            this.circumferenceTextBox.Size = new System.Drawing.Size(862, 65);
            this.circumferenceTextBox.TabIndex = 2;
            // 
            // clearCircleButton
            // 
            this.clearCircleButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearCircleButton.Location = new System.Drawing.Point(1291, 8);
            this.clearCircleButton.Name = "clearCircleButton";
            this.clearCircleButton.Size = new System.Drawing.Size(231, 86);
            this.clearCircleButton.TabIndex = 4;
            this.clearCircleButton.Text = "清除圓";
            this.clearCircleButton.UseVisualStyleBackColor = true;
            this.clearCircleButton.Click += new System.EventHandler(this.clearCircleButton_Click);
            // 
            // diameterTextBox
            // 
            this.diameterTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.diameterTextBox.Location = new System.Drawing.Point(397, 211);
            this.diameterTextBox.MaxLength = 7;
            this.diameterTextBox.Name = "diameterTextBox";
            this.diameterTextBox.Size = new System.Drawing.Size(862, 65);
            this.diameterTextBox.TabIndex = 1;
            // 
            // diameterLabel
            // 
            this.diameterLabel.AutoSize = true;
            this.diameterLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.diameterLabel.Location = new System.Drawing.Point(15, 219);
            this.diameterLabel.Name = "diameterLabel";
            this.diameterLabel.Size = new System.Drawing.Size(324, 48);
            this.diameterLabel.TabIndex = 6;
            this.diameterLabel.Text = "直徑(0-1000)：";
            // 
            // radiusTextBox
            // 
            this.radiusTextBox.BackColor = System.Drawing.Color.White;
            this.radiusTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radiusTextBox.Location = new System.Drawing.Point(397, 118);
            this.radiusTextBox.MaxLength = 7;
            this.radiusTextBox.Name = "radiusTextBox";
            this.radiusTextBox.Size = new System.Drawing.Size(862, 65);
            this.radiusTextBox.TabIndex = 0;
            // 
            // radiusLabel
            // 
            this.radiusLabel.AutoSize = true;
            this.radiusLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radiusLabel.Location = new System.Drawing.Point(15, 126);
            this.radiusLabel.Name = "radiusLabel";
            this.radiusLabel.Size = new System.Drawing.Size(301, 48);
            this.radiusLabel.TabIndex = 5;
            this.radiusLabel.Text = "半徑(0-500)：";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.areaLabel.Location = new System.Drawing.Point(15, 405);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(370, 48);
            this.areaLabel.TabIndex = 8;
            this.areaLabel.Text = "面積(0-785398)：";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // areaTextBox
            // 
            this.areaTextBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.areaTextBox.Location = new System.Drawing.Point(397, 394);
            this.areaTextBox.MaxLength = 7;
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(862, 65);
            this.areaTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1081, 48);
            this.label1.TabIndex = 9;
            this.label1.Text = "請輸入圓的半徑或直徑或圓周長或面積(最多7位數)";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(23, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3000, 1465);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2604, 1780);
            this.Controls.Add(this.clearCircleButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.radiusTextBox);
            this.Controls.Add(this.radiusLabel);
            this.Controls.Add(this.diameterTextBox);
            this.Controls.Add(this.diameterLabel);
            this.Controls.Add(this.circumferenceTextBox);
            this.Controls.Add(this.circumferenceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "計算圓及畫圓";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radiusLabel;
        private System.Windows.Forms.TextBox radiusTextBox;
        private System.Windows.Forms.Label diameterLabel;
        private System.Windows.Forms.TextBox diameterTextBox;
        private System.Windows.Forms.Label circumferenceLabel;
        private System.Windows.Forms.TextBox circumferenceTextBox;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Button clearCircleButton;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

