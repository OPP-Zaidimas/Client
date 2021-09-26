
namespace Game
{
    partial class MatchIdForm
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
            this.CopyButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MatchIdTextField = new System.Windows.Forms.TextBox();
            this.MatchIdLable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(527, 137);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(102, 34);
            this.CopyButton.TabIndex = 8;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(326, 285);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(79, 30);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // MatchIdTextField
            // 
            this.MatchIdTextField.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MatchIdTextField.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MatchIdTextField.Location = new System.Drawing.Point(287, 137);
            this.MatchIdTextField.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MatchIdTextField.Name = "MatchIdTextField";
            this.MatchIdTextField.Size = new System.Drawing.Size(182, 34);
            this.MatchIdTextField.TabIndex = 6;
            // 
            // MatchIdLable
            // 
            this.MatchIdLable.AutoSize = true;
            this.MatchIdLable.Location = new System.Drawing.Point(172, 144);
            this.MatchIdLable.Name = "MatchIdLable";
            this.MatchIdLable.Size = new System.Drawing.Size(69, 20);
            this.MatchIdLable.TabIndex = 5;
            this.MatchIdLable.Text = "Match ID";
            // 
            // MatchId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MatchIdTextField);
            this.Controls.Add(this.MatchIdLable);
            this.Name = "MatchId";
            this.Text = "MatchId";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TextBox MatchIdTextField;
        private System.Windows.Forms.Label MatchIdLable;
    }
}