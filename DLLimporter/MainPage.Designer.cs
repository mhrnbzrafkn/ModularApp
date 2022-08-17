
namespace DLLimporter
{
    partial class MainPage
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
            this.SelectFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectButton = new System.Windows.Forms.Button();
            this.SelectsTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // SelectFileDialog
            // 
            this.SelectFileDialog.FileName = "File";
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(497, 12);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 25);
            this.SelectButton.TabIndex = 0;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // SelectsTextBox
            // 
            this.SelectsTextBox.Location = new System.Drawing.Point(12, 12);
            this.SelectsTextBox.Name = "SelectsTextBox";
            this.SelectsTextBox.Size = new System.Drawing.Size(479, 337);
            this.SelectsTextBox.TabIndex = 1;
            this.SelectsTextBox.Text = "";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.SelectsTextBox);
            this.Controls.Add(this.SelectButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog SelectFileDialog;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.RichTextBox SelectsTextBox;
    }
}

