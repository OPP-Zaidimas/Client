
namespace Game.Views.User_Controls
{
    partial class ArenaView
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
            this.ArenaLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PlayerArenaSide = new Game.Views.User_Controls.ArenaSide();
            this.EnemyArenaSide = new Game.Views.User_Controls.ArenaSide();
            this.HandView = new Game.Views.User_Controls.HandView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.EndTurnButton = new System.Windows.Forms.Button();
            this.DrawCardButton = new System.Windows.Forms.Button();
            this.ArenaLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArenaLayoutPanel
            // 
            this.ArenaLayoutPanel.ColumnCount = 1;
            this.ArenaLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ArenaLayoutPanel.Controls.Add(this.PlayerArenaSide, 0, 2);
            this.ArenaLayoutPanel.Controls.Add(this.EnemyArenaSide, 0, 0);
            this.ArenaLayoutPanel.Controls.Add(this.HandView, 0, 3);
            this.ArenaLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.ArenaLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArenaLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ArenaLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ArenaLayoutPanel.Name = "ArenaLayoutPanel";
            this.ArenaLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.ArenaLayoutPanel.RowCount = 4;
            this.ArenaLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ArenaLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ArenaLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ArenaLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.ArenaLayoutPanel.Size = new System.Drawing.Size(1125, 873);
            this.ArenaLayoutPanel.TabIndex = 0;
            // 
            // PlayerArenaSide
            // 
            this.PlayerArenaSide.AutoSize = true;
            this.PlayerArenaSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerArenaSide.Location = new System.Drawing.Point(3, 352);
            this.PlayerArenaSide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PlayerArenaSide.Name = "PlayerArenaSide";
            this.PlayerArenaSide.Size = new System.Drawing.Size(1119, 310);
            this.PlayerArenaSide.TabIndex = 0;
            // 
            // EnemyArenaSide
            // 
            this.EnemyArenaSide.AutoSize = true;
            this.EnemyArenaSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnemyArenaSide.Location = new System.Drawing.Point(3, 2);
            this.EnemyArenaSide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnemyArenaSide.Name = "EnemyArenaSide";
            this.EnemyArenaSide.Size = new System.Drawing.Size(1119, 310);
            this.EnemyArenaSide.TabIndex = 1;
            // 
            // HandView
            // 
            this.HandView.AutoSize = true;
            this.HandView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HandView.Location = new System.Drawing.Point(3, 666);
            this.HandView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HandView.Name = "HandView";
            this.HandView.Size = new System.Drawing.Size(1119, 193);
            this.HandView.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.EndTurnButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DrawCardButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 316);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1121, 32);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // EndTurnButton
            // 
            this.EndTurnButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndTurnButton.AutoSize = true;
            this.EndTurnButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EndTurnButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EndTurnButton.Location = new System.Drawing.Point(1029, 3);
            this.EndTurnButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EndTurnButton.Name = "EndTurnButton";
            this.EndTurnButton.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.EndTurnButton.Size = new System.Drawing.Size(88, 26);
            this.EndTurnButton.TabIndex = 4;
            this.EndTurnButton.Text = "End Turn";
            this.EndTurnButton.UseVisualStyleBackColor = true;
            // 
            // DrawCardButton
            // 
            this.DrawCardButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawCardButton.AutoSize = true;
            this.DrawCardButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DrawCardButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DrawCardButton.Location = new System.Drawing.Point(922, 3);
            this.DrawCardButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DrawCardButton.Name = "DrawCardButton";
            this.DrawCardButton.Padding = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.DrawCardButton.Size = new System.Drawing.Size(99, 26);
            this.DrawCardButton.TabIndex = 5;
            this.DrawCardButton.Text = "Draw GameCard";
            this.DrawCardButton.UseVisualStyleBackColor = true;
            this.DrawCardButton.Click += new System.EventHandler(this.DrawCardButton_Click);
            // 
            // ArenaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ArenaLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ArenaView";
            this.Size = new System.Drawing.Size(1125, 873);
            this.ArenaLayoutPanel.ResumeLayout(false);
            this.ArenaLayoutPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ArenaLayoutPanel;
        private ArenaSide PlayerArenaSide;
        private ArenaSide EnemyArenaSide;
        private HandView HandView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button EndTurnButton;
        private System.Windows.Forms.Button DrawCardButton;
    }
}
