
namespace Game.Views
{
    partial class ConsoleWindow
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
            this.ConsoleLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.EnterButton = new System.Windows.Forms.Button();
            this.CommandTextBox = new System.Windows.Forms.TextBox();
            this.ConsoleHistoryLabel = new System.Windows.Forms.Label();
            this.ConsoleLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConsoleLayoutPanel
            // 
            this.ConsoleLayoutPanel.ColumnCount = 2;
            this.ConsoleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsoleLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.ConsoleLayoutPanel.Controls.Add(this.EnterButton, 1, 1);
            this.ConsoleLayoutPanel.Controls.Add(this.CommandTextBox, 0, 1);
            this.ConsoleLayoutPanel.Controls.Add(this.ConsoleHistoryLabel, 0, 0);
            this.ConsoleLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ConsoleLayoutPanel.Margin = new System.Windows.Forms.Padding(8);
            this.ConsoleLayoutPanel.Name = "ConsoleLayoutPanel";
            this.ConsoleLayoutPanel.Padding = new System.Windows.Forms.Padding(8);
            this.ConsoleLayoutPanel.RowCount = 2;
            this.ConsoleLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ConsoleLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ConsoleLayoutPanel.Size = new System.Drawing.Size(622, 433);
            this.ConsoleLayoutPanel.TabIndex = 0;
            // 
            // EnterButton
            // 
            this.EnterButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnterButton.Location = new System.Drawing.Point(516, 393);
            this.EnterButton.Margin = new System.Windows.Forms.Padding(4);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(94, 28);
            this.EnterButton.TabIndex = 0;
            this.EnterButton.Text = "Enter";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // CommandTextBox
            // 
            this.CommandTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommandTextBox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CommandTextBox.Location = new System.Drawing.Point(12, 393);
            this.CommandTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CommandTextBox.Name = "CommandTextBox";
            this.CommandTextBox.Size = new System.Drawing.Size(496, 25);
            this.CommandTextBox.TabIndex = 1;
            this.CommandTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CommandTextBox_KeyDown);
            // 
            // ConsoleHistoryLabel
            // 
            this.ConsoleHistoryLabel.AutoSize = true;
            this.ConsoleLayoutPanel.SetColumnSpan(this.ConsoleHistoryLabel, 2);
            this.ConsoleHistoryLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConsoleHistoryLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConsoleHistoryLabel.Location = new System.Drawing.Point(11, 8);
            this.ConsoleHistoryLabel.Name = "ConsoleHistoryLabel";
            this.ConsoleHistoryLabel.Size = new System.Drawing.Size(600, 381);
            this.ConsoleHistoryLabel.TabIndex = 2;
            this.ConsoleHistoryLabel.Text = "...";
            // 
            // ConsoleWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.ConsoleLayoutPanel);
            this.Name = "ConsoleWindow";
            this.Text = "Console";
            this.ConsoleLayoutPanel.ResumeLayout(false);
            this.ConsoleLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ConsoleLayoutPanel;
        private System.Windows.Forms.Button EnterButton;
        private System.Windows.Forms.TextBox CommandTextBox;
        private System.Windows.Forms.Label ConsoleHistoryLabel;
    }
}