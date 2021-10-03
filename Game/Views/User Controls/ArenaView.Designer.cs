
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
            this.arenaSide1 = new Game.Views.User_Controls.ArenaSide();
            this.arenaSide2 = new Game.Views.User_Controls.ArenaSide();
            this.HandView = new Game.Views.User_Controls.HandView();
            this.EndTurnButton = new System.Windows.Forms.Button();
            this.ArenaLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ArenaLayoutPanel
            // 
            this.ArenaLayoutPanel.ColumnCount = 1;
            this.ArenaLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ArenaLayoutPanel.Controls.Add(this.arenaSide1, 0, 2);
            this.ArenaLayoutPanel.Controls.Add(this.arenaSide2, 0, 0);
            this.ArenaLayoutPanel.Controls.Add(this.HandView, 0, 3);
            this.ArenaLayoutPanel.Controls.Add(this.EndTurnButton, 0, 1);
            this.ArenaLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ArenaLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ArenaLayoutPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ArenaLayoutPanel.Name = "ArenaLayoutPanel";
            this.ArenaLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 16);
            this.ArenaLayoutPanel.RowCount = 4;
            this.ArenaLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ArenaLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.ArenaLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ArenaLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.ArenaLayoutPanel.Size = new System.Drawing.Size(1286, 617);
            this.ArenaLayoutPanel.TabIndex = 0;
            // 
            // arenaSide1
            // 
            this.arenaSide1.AutoSize = true;
            this.arenaSide1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arenaSide1.Location = new System.Drawing.Point(3, 231);
            this.arenaSide1.Name = "arenaSide1";
            this.arenaSide1.Size = new System.Drawing.Size(1280, 174);
            this.arenaSide1.TabIndex = 0;
            // 
            // arenaSide2
            // 
            this.arenaSide2.AutoSize = true;
            this.arenaSide2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.arenaSide2.Location = new System.Drawing.Point(3, 3);
            this.arenaSide2.Name = "arenaSide2";
            this.arenaSide2.Size = new System.Drawing.Size(1280, 174);
            this.arenaSide2.TabIndex = 1;
            // 
            // HandView
            // 
            this.HandView.AutoSize = true;
            this.HandView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HandView.Location = new System.Drawing.Point(3, 411);
            this.HandView.Name = "HandView";
            this.HandView.Size = new System.Drawing.Size(1280, 187);
            this.HandView.TabIndex = 2;
            // 
            // EndTurnButton
            // 
            this.EndTurnButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndTurnButton.AutoSize = true;
            this.EndTurnButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EndTurnButton.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EndTurnButton.Location = new System.Drawing.Point(1178, 184);
            this.EndTurnButton.Margin = new System.Windows.Forms.Padding(4);
            this.EndTurnButton.Name = "EndTurnButton";
            this.EndTurnButton.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.EndTurnButton.Size = new System.Drawing.Size(104, 40);
            this.EndTurnButton.TabIndex = 3;
            this.EndTurnButton.Text = "End Turn";
            this.EndTurnButton.UseVisualStyleBackColor = true;
            // 
            // ArenaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ArenaLayoutPanel);
            this.Name = "ArenaView";
            this.Size = new System.Drawing.Size(1286, 617);
            this.ArenaLayoutPanel.ResumeLayout(false);
            this.ArenaLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ArenaLayoutPanel;
        private ArenaSide arenaSide1;
        private ArenaSide arenaSide2;
        private HandView HandView;
        private System.Windows.Forms.Button EndTurnButton;
    }
}
