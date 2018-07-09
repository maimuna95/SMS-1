namespace IntroductionWindowsApp
{
    partial class MuhitUi
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
            this.label1 = new System.Windows.Forms.Label();
            this.studentTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student";
            // 
            // studentTextBox
            // 
            this.studentTextBox.Location = new System.Drawing.Point(224, 34);
            this.studentTextBox.Name = "studentTextBox";
            this.studentTextBox.Size = new System.Drawing.Size(146, 20);
            this.studentTextBox.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(224, 85);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(146, 20);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(233, 145);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(136, 20);
            this.resultTextBox.TabIndex = 3;
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(233, 186);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(130, 19);
            this.ShowButton.TabIndex = 4;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            // 
            // MuhitUi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 261);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.studentTextBox);
            this.Controls.Add(this.label1);
            this.Name = "MuhitUi";
            this.Text = "MuhitUi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox studentTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button ShowButton;
    }
}