
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
            this.TurnLabel = new System.Windows.Forms.Label();
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
            this.ArenaLayoutPanel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ArenaLayoutPanel.Name = "ArenaLayoutPanel";
            this.ArenaLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.ArenaLayoutPanel.RowCount = 4;
            this.ArenaLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ArenaLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ArenaLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ArenaLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 261F));
            this.ArenaLayoutPanel.Size = new System.Drawing.Size(1286, 1164);
            this.ArenaLayoutPanel.TabIndex = 0;
            // 
            // PlayerArenaSide
            // 
            this.PlayerArenaSide.AutoSize = true;
            this.PlayerArenaSide.Builder = null;
            this.PlayerArenaSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayerArenaSide.Location = new System.Drawing.Point(3, 470);
            this.PlayerArenaSide.Name = "PlayerArenaSide";
            this.PlayerArenaSide.Size = new System.Drawing.Size(1280, 413);
            this.PlayerArenaSide.TabIndex = 0;
            this.PlayerArenaSide.ViewModel = null;
            // 
            // EnemyArenaSide
            // 
            this.EnemyArenaSide.AutoSize = true;
            this.EnemyArenaSide.Builder = null;
            this.EnemyArenaSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnemyArenaSide.Location = new System.Drawing.Point(3, 3);
            this.EnemyArenaSide.Name = "EnemyArenaSide";
            this.EnemyArenaSide.Size = new System.Drawing.Size(1280, 413);
            this.EnemyArenaSide.TabIndex = 1;
            this.EnemyArenaSide.ViewModel = null;
            // 
            // HandView
            // 
            this.HandView.AutoSize = true;
            this.HandView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HandView.Location = new System.Drawing.Point(3, 889);
            this.HandView.Name = "HandView";
            this.HandView.Size = new System.Drawing.Size(1280, 256);
            this.HandView.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.TurnLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DrawCardButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.EndTurnButton, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 422);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1282, 42);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // EndTurnButton
            // 
            this.EndTurnButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndTurnButton.AutoSize = true;
            this.EndTurnButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EndTurnButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EndTurnButton.Location = new System.Drawing.Point(1173, 4);
            this.EndTurnButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.EndTurnButton.Name = "EndTurnButton";
            this.EndTurnButton.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.EndTurnButton.Size = new System.Drawing.Size(104, 34);
            this.EndTurnButton.TabIndex = 4;
            this.EndTurnButton.Text = "End Turn";
            this.EndTurnButton.UseVisualStyleBackColor = true;
            this.EndTurnButton.Click += new System.EventHandler(this.EndTurnButton_Click);
            // 
            // DrawCardButton
            // 
            this.DrawCardButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DrawCardButton.AutoSize = true;
            this.DrawCardButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DrawCardButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DrawCardButton.Location = new System.Drawing.Point(1001, 4);
            this.DrawCardButton.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.DrawCardButton.Name = "DrawCardButton";
            this.DrawCardButton.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.DrawCardButton.Size = new System.Drawing.Size(162, 34);
            this.DrawCardButton.TabIndex = 5;
            this.DrawCardButton.Text = "Draw GameCard";
            this.DrawCardButton.UseVisualStyleBackColor = true;
            this.DrawCardButton.Visible = false;
            this.DrawCardButton.Click += new System.EventHandler(this.DrawCardButton_Click);
            // 
            // TurnLabel
            // 
            this.TurnLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TurnLabel.AutoSize = true;
            this.TurnLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TurnLabel.Location = new System.Drawing.Point(82, 2);
            this.TurnLabel.Margin = new System.Windows.Forms.Padding(2);
            this.TurnLabel.Name = "TurnLabel";
            this.TurnLabel.Size = new System.Drawing.Size(912, 38);
            this.TurnLabel.TabIndex = 6;
            this.TurnLabel.Text = "Turn";
            this.TurnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArenaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ArenaLayoutPanel);
            this.Name = "ArenaView";
            this.Size = new System.Drawing.Size(1286, 1164);
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
        private System.Windows.Forms.Label TurnLabel;
    }
}
