namespace Tessa_Biava_Exercise4
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
            this.secondsEntryLabel = new System.Windows.Forms.Label();
            this.secondsTextBox = new System.Windows.Forms.TextBox();
            this.convertedLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // secondsEntryLabel
            // 
            this.secondsEntryLabel.AutoSize = true;
            this.secondsEntryLabel.Location = new System.Drawing.Point(12, 52);
            this.secondsEntryLabel.Name = "secondsEntryLabel";
            this.secondsEntryLabel.Size = new System.Drawing.Size(146, 13);
            this.secondsEntryLabel.TabIndex = 0;
            this.secondsEntryLabel.Text = "Enter the number of seconds:";
            // 
            // secondsTextBox
            // 
            this.secondsTextBox.Location = new System.Drawing.Point(164, 49);
            this.secondsTextBox.Name = "secondsTextBox";
            this.secondsTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondsTextBox.TabIndex = 1;
            // 
            // convertedLabel
            // 
            this.convertedLabel.AutoSize = true;
            this.convertedLabel.Location = new System.Drawing.Point(64, 77);
            this.convertedLabel.Name = "convertedLabel";
            this.convertedLabel.Size = new System.Drawing.Size(0, 13);
            this.convertedLabel.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.calculateButton.Location = new System.Drawing.Point(106, 95);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 147);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.convertedLabel);
            this.Controls.Add(this.secondsTextBox);
            this.Controls.Add(this.secondsEntryLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label secondsEntryLabel;
        private System.Windows.Forms.TextBox secondsTextBox;
        private System.Windows.Forms.Label convertedLabel;
        private System.Windows.Forms.Button calculateButton;
    }
}

