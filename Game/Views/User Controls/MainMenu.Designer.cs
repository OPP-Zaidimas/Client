
namespace Game.Views.User_Controls
{
    partial class MainMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NewGameButton = new System.Windows.Forms.Button();
            this.FindGameButton = new System.Windows.Forms.Button();
            this.ExitGameButton = new System.Windows.Forms.Button();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.MainMenuLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SessionIdLabel = new System.Windows.Forms.Label();
            this.SessionIdInput = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.NewGameStatusLabel = new System.Windows.Forms.Label();
            this.PlayLocalButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.FindGameStatusLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MainMenuLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewGameButton
            // 
            this.NewGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(238)))));
            this.NewGameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewGameButton.FlatAppearance.BorderSize = 0;
            this.NewGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(114)))), ((int)(((byte)(170)))));
            this.NewGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(114)))), ((int)(((byte)(170)))));
            this.NewGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewGameButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewGameButton.ForeColor = System.Drawing.Color.White;
            this.NewGameButton.Location = new System.Drawing.Point(7, 19);
            this.NewGameButton.Margin = new System.Windows.Forms.Padding(7, 19, 13, 13);
            this.NewGameButton.Name = "NewGameButton";
            this.NewGameButton.Size = new System.Drawing.Size(183, 64);
            this.NewGameButton.TabIndex = 0;
            this.NewGameButton.Text = "New Game";
            this.NewGameButton.UseVisualStyleBackColor = false;
            this.NewGameButton.Click += new System.EventHandler(this.NewGameButton_Click);
            // 
            // FindGameButton
            // 
            this.FindGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FindGameButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(238)))));
            this.FindGameButton.FlatAppearance.BorderSize = 0;
            this.FindGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(114)))), ((int)(((byte)(170)))));
            this.FindGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(114)))), ((int)(((byte)(170)))));
            this.FindGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindGameButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindGameButton.ForeColor = System.Drawing.Color.White;
            this.FindGameButton.Location = new System.Drawing.Point(35, 11);
            this.FindGameButton.Margin = new System.Windows.Forms.Padding(0, 11, 0, 11);
            this.FindGameButton.Name = "FindGameButton";
            this.FindGameButton.Size = new System.Drawing.Size(183, 64);
            this.FindGameButton.TabIndex = 1;
            this.FindGameButton.Text = "Find Game";
            this.FindGameButton.UseVisualStyleBackColor = false;
            this.FindGameButton.Click += new System.EventHandler(this.FindGameButton_Click);
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitGameButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(15)))), ((int)(((byte)(53)))));
            this.ExitGameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.ExitGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitGameButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitGameButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(71)))), ((int)(((byte)(108)))));
            this.ExitGameButton.Location = new System.Drawing.Point(388, 741);
            this.ExitGameButton.Margin = new System.Windows.Forms.Padding(0, 43, 0, 64);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new System.Drawing.Size(183, 48);
            this.ExitGameButton.TabIndex = 2;
            this.ExitGameButton.Text = "Exit";
            this.ExitGameButton.UseVisualStyleBackColor = true;
            this.ExitGameButton.Click += new System.EventHandler(this.ExitGameButton_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleLabel.Location = new System.Drawing.Point(300, 43);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(0, 43, 0, 11);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(360, 46);
            this.TitleLabel.TabIndex = 3;
            this.TitleLabel.Text = "Monsters, Spells, Items";
            // 
            // MainMenuLayoutPanel
            // 
            this.MainMenuLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(252)))));
            this.MainMenuLayoutPanel.ColumnCount = 1;
            this.MainMenuLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainMenuLayoutPanel.Controls.Add(this.TitleLabel, 0, 0);
            this.MainMenuLayoutPanel.Controls.Add(this.ExitGameButton, 0, 5);
            this.MainMenuLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.MainMenuLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.MainMenuLayoutPanel.Controls.Add(this.tableLayoutPanel3, 0, 4);
            this.MainMenuLayoutPanel.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.MainMenuLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainMenuLayoutPanel.Name = "MainMenuLayoutPanel";
            this.MainMenuLayoutPanel.RowCount = 6;
            this.MainMenuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainMenuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainMenuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainMenuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainMenuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainMenuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.MainMenuLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.MainMenuLayoutPanel.Size = new System.Drawing.Size(960, 853);
            this.MainMenuLayoutPanel.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.SessionIdLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SessionIdInput, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(312, 504);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 43, 0, 11);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(335, 42);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // SessionIdLabel
            // 
            this.SessionIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SessionIdLabel.AutoSize = true;
            this.SessionIdLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SessionIdLabel.Location = new System.Drawing.Point(3, 7);
            this.SessionIdLabel.Margin = new System.Windows.Forms.Padding(3, 0, 5, 0);
            this.SessionIdLabel.Name = "SessionIdLabel";
            this.SessionIdLabel.Size = new System.Drawing.Size(139, 28);
            this.SessionIdLabel.TabIndex = 0;
            this.SessionIdLabel.Text = "Enter Match Id";
            // 
            // SessionIdInput
            // 
            this.SessionIdInput.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SessionIdInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SessionIdInput.Location = new System.Drawing.Point(150, 4);
            this.SessionIdInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SessionIdInput.Name = "SessionIdInput";
            this.SessionIdInput.Size = new System.Drawing.Size(182, 34);
            this.SessionIdInput.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.NewGameButton, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.NewGameStatusLabel, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.PlayLocalButton, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(277, 310);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 21);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(406, 130);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // NewGameStatusLabel
            // 
            this.NewGameStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NewGameStatusLabel.AutoSize = true;
            this.tableLayoutPanel2.SetColumnSpan(this.NewGameStatusLabel, 2);
            this.NewGameStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewGameStatusLabel.Location = new System.Drawing.Point(56, 107);
            this.NewGameStatusLabel.Margin = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.NewGameStatusLabel.Name = "NewGameStatusLabel";
            this.NewGameStatusLabel.Size = new System.Drawing.Size(294, 23);
            this.NewGameStatusLabel.TabIndex = 1;
            this.NewGameStatusLabel.Text = "Press the Button to start a new game";
            // 
            // PlayLocalButton
            // 
            this.PlayLocalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(156)))), ((int)(((byte)(238)))));
            this.PlayLocalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayLocalButton.FlatAppearance.BorderSize = 0;
            this.PlayLocalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayLocalButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlayLocalButton.ForeColor = System.Drawing.Color.White;
            this.PlayLocalButton.Location = new System.Drawing.Point(216, 19);
            this.PlayLocalButton.Margin = new System.Windows.Forms.Padding(13, 19, 7, 13);
            this.PlayLocalButton.Name = "PlayLocalButton";
            this.PlayLocalButton.Size = new System.Drawing.Size(183, 64);
            this.PlayLocalButton.TabIndex = 2;
            this.PlayLocalButton.Text = "Play Local";
            this.PlayLocalButton.UseVisualStyleBackColor = false;
            this.PlayLocalButton.Click += new System.EventHandler(this.PlayLocalButton_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.FindGameButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.FindGameStatusLabel, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(353, 557);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 21);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(253, 120);
            this.tableLayoutPanel3.TabIndex = 6;
            // 
            // FindGameStatusLabel
            // 
            this.FindGameStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FindGameStatusLabel.AutoSize = true;
            this.FindGameStatusLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindGameStatusLabel.Location = new System.Drawing.Point(0, 97);
            this.FindGameStatusLabel.Margin = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.FindGameStatusLabel.Name = "FindGameStatusLabel";
            this.FindGameStatusLabel.Size = new System.Drawing.Size(253, 23);
            this.FindGameStatusLabel.TabIndex = 2;
            this.FindGameStatusLabel.Text = "Press the Button to find a game";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.5F));
            this.tableLayoutPanel4.Controls.Add(this.usernameInput, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(333, 269);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(293, 37);
            this.tableLayoutPanel4.TabIndex = 7;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(150, 4);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(138, 27);
            this.usernameInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(44, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter username:";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.MainMenuLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(960, 853);
            this.MainMenuLayoutPanel.ResumeLayout(false);
            this.MainMenuLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewGameButton;
        private System.Windows.Forms.Button FindGameButton;
        private System.Windows.Forms.Button ExitGameButton;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TableLayoutPanel MainMenuLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label SessionIdLabel;
        private System.Windows.Forms.TextBox SessionIdInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label NewGameStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label FindGameStatusLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PlayLocalButton;
    }
}
