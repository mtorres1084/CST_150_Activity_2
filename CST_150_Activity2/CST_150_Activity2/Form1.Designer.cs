namespace CST_150_Activity2
{
    partial class marsConversionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(marsConversionForm));
            this.earthWeightLabel = new System.Windows.Forms.Label();
            this.marsWeightLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.earthWeightTextBox = new System.Windows.Forms.NumericUpDown();
            this.titleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.earthWeightTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // earthWeightLabel
            // 
            this.earthWeightLabel.AutoSize = true;
            this.earthWeightLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earthWeightLabel.Location = new System.Drawing.Point(12, 80);
            this.earthWeightLabel.Name = "earthWeightLabel";
            this.earthWeightLabel.Size = new System.Drawing.Size(251, 24);
            this.earthWeightLabel.TabIndex = 0;
            this.earthWeightLabel.Text = "Enter your weight on Earth:";
            // 
            // marsWeightLabel
            // 
            this.marsWeightLabel.AutoSize = true;
            this.marsWeightLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marsWeightLabel.Location = new System.Drawing.Point(12, 154);
            this.marsWeightLabel.Name = "marsWeightLabel";
            this.marsWeightLabel.Size = new System.Drawing.Size(173, 24);
            this.marsWeightLabel.TabIndex = 1;
            this.marsWeightLabel.Text = "Your mars weight: ";
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(157, 240);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(118, 51);
            this.convertButton.TabIndex = 4;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // earthWeightTextBox
            // 
            this.earthWeightTextBox.DecimalPlaces = 3;
            this.earthWeightTextBox.Location = new System.Drawing.Point(290, 85);
            this.earthWeightTextBox.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.earthWeightTextBox.Name = "earthWeightTextBox";
            this.earthWeightTextBox.Size = new System.Drawing.Size(120, 20);
            this.earthWeightTextBox.TabIndex = 6;
            this.earthWeightTextBox.ValueChanged += new System.EventHandler(this.earthWeightTextBox_ValueChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 30);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(400, 25);
            this.titleLabel.TabIndex = 7;
            this.titleLabel.Text = "Want to know your weight on mars?";
            // 
            // marsConversionForm
            // 
            this.AcceptButton = this.convertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 311);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.earthWeightTextBox);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.marsWeightLabel);
            this.Controls.Add(this.earthWeightLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(460, 350);
            this.Name = "marsConversionForm";
            this.Text = "Mars Weight Conversion";
            this.Load += new System.EventHandler(this.marsConversionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.earthWeightTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label earthWeightLabel;
        private System.Windows.Forms.Label marsWeightLabel;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.NumericUpDown earthWeightTextBox;
        private System.Windows.Forms.Label titleLabel;
    }
}

