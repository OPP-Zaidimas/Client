
namespace Game.Views.User_Controls
{
    partial class ArenaSide
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
            this.MainLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DeckLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.CardsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectButton1 = new System.Windows.Forms.Button();
            this.SelectButton2 = new System.Windows.Forms.Button();
            this.SelectButton3 = new System.Windows.Forms.Button();
            this.SelectButton4 = new System.Windows.Forms.Button();
            this.SelectButton5 = new System.Windows.Forms.Button();
            this.CardView1 = new Game.Views.User_Controls.CardView();
            this.CardView2 = new Game.Views.User_Controls.CardView();
            this.CardView3 = new Game.Views.User_Controls.CardView();
            this.CardView4 = new Game.Views.User_Controls.CardView();
            this.CardView5 = new Game.Views.User_Controls.CardView();
            this.HeroLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.HeroSelectButton = new System.Windows.Forms.Button();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.HeroHpLabel = new System.Windows.Forms.Label();
            this.MainLayoutPanel.SuspendLayout();
            this.DeckLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.CardsLayoutPanel.SuspendLayout();
            this.HeroLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLayoutPanel
            // 
            this.MainLayoutPanel.ColumnCount = 3;
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.MainLayoutPanel.Controls.Add(this.DeckLayoutPanel, 2, 0);
            this.MainLayoutPanel.Controls.Add(this.CardsLayoutPanel, 1, 0);
            this.MainLayoutPanel.Controls.Add(this.HeroLayoutPanel, 0, 0);
            this.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainLayoutPanel.Name = "MainLayoutPanel";
            this.MainLayoutPanel.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MainLayoutPanel.RowCount = 1;
            this.MainLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayoutPanel.Size = new System.Drawing.Size(893, 176);
            this.MainLayoutPanel.TabIndex = 0;
            // 
            // DeckLayoutPanel
            // 
            this.DeckLayoutPanel.ColumnCount = 1;
            this.DeckLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.DeckLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.DeckLayoutPanel.Controls.Add(this.pictureBox1, 0, 0);
            this.DeckLayoutPanel.Controls.Add(this.pictureBox2, 0, 1);
            this.DeckLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeckLayoutPanel.Location = new System.Drawing.Point(805, 6);
            this.DeckLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DeckLayoutPanel.Name = "DeckLayoutPanel";
            this.DeckLayoutPanel.RowCount = 2;
            this.DeckLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DeckLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DeckLayoutPanel.Size = new System.Drawing.Size(80, 164);
            this.DeckLayoutPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(4, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(4, 85);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // CardsLayoutPanel
            // 
            this.CardsLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.CardsLayoutPanel.ColumnCount = 5;
            this.CardsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CardsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CardsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CardsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CardsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CardsLayoutPanel.Controls.Add(this.SelectButton1, 0, 1);
            this.CardsLayoutPanel.Controls.Add(this.SelectButton2, 1, 1);
            this.CardsLayoutPanel.Controls.Add(this.SelectButton3, 2, 1);
            this.CardsLayoutPanel.Controls.Add(this.SelectButton4, 3, 1);
            this.CardsLayoutPanel.Controls.Add(this.SelectButton5, 4, 1);
            this.CardsLayoutPanel.Controls.Add(this.CardView1, 0, 0);
            this.CardsLayoutPanel.Controls.Add(this.CardView2, 1, 0);
            this.CardsLayoutPanel.Controls.Add(this.CardView3, 2, 0);
            this.CardsLayoutPanel.Controls.Add(this.CardView4, 3, 0);
            this.CardsLayoutPanel.Controls.Add(this.CardView5, 4, 0);
            this.CardsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardsLayoutPanel.Location = new System.Drawing.Point(104, 6);
            this.CardsLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CardsLayoutPanel.Name = "CardsLayoutPanel";
            this.CardsLayoutPanel.Padding = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.CardsLayoutPanel.RowCount = 2;
            this.CardsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CardsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.CardsLayoutPanel.Size = new System.Drawing.Size(693, 164);
            this.CardsLayoutPanel.TabIndex = 2;
            // 
            // SelectButton1
            // 
            this.SelectButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectButton1.Enabled = false;
            this.SelectButton1.Location = new System.Drawing.Point(7, 139);
            this.SelectButton1.Margin = new System.Windows.Forms.Padding(2);
            this.SelectButton1.Name = "SelectButton1";
            this.SelectButton1.Size = new System.Drawing.Size(131, 20);
            this.SelectButton1.TabIndex = 5;
            this.SelectButton1.Text = "Select";
            this.SelectButton1.UseVisualStyleBackColor = true;
            this.SelectButton1.Click += new System.EventHandler(this.SelectButton1_Click);
            // 
            // SelectButton2
            // 
            this.SelectButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectButton2.Enabled = false;
            this.SelectButton2.Location = new System.Drawing.Point(143, 139);
            this.SelectButton2.Margin = new System.Windows.Forms.Padding(2);
            this.SelectButton2.Name = "SelectButton2";
            this.SelectButton2.Size = new System.Drawing.Size(131, 20);
            this.SelectButton2.TabIndex = 6;
            this.SelectButton2.Text = "Select";
            this.SelectButton2.UseVisualStyleBackColor = true;
            this.SelectButton2.Click += new System.EventHandler(this.SelectButton2_Click);
            // 
            // SelectButton3
            // 
            this.SelectButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectButton3.Enabled = false;
            this.SelectButton3.Location = new System.Drawing.Point(279, 139);
            this.SelectButton3.Margin = new System.Windows.Forms.Padding(2);
            this.SelectButton3.Name = "SelectButton3";
            this.SelectButton3.Size = new System.Drawing.Size(131, 20);
            this.SelectButton3.TabIndex = 7;
            this.SelectButton3.Text = "Select";
            this.SelectButton3.UseVisualStyleBackColor = true;
            this.SelectButton3.Click += new System.EventHandler(this.SelectButton3_Click);
            // 
            // SelectButton4
            // 
            this.SelectButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectButton4.Enabled = false;
            this.SelectButton4.Location = new System.Drawing.Point(415, 139);
            this.SelectButton4.Margin = new System.Windows.Forms.Padding(2);
            this.SelectButton4.Name = "SelectButton4";
            this.SelectButton4.Size = new System.Drawing.Size(131, 20);
            this.SelectButton4.TabIndex = 8;
            this.SelectButton4.Text = "Select";
            this.SelectButton4.UseVisualStyleBackColor = true;
            this.SelectButton4.Click += new System.EventHandler(this.SelectButton4_Click);
            // 
            // SelectButton5
            // 
            this.SelectButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectButton5.Enabled = false;
            this.SelectButton5.Location = new System.Drawing.Point(551, 139);
            this.SelectButton5.Margin = new System.Windows.Forms.Padding(2);
            this.SelectButton5.Name = "SelectButton5";
            this.SelectButton5.Size = new System.Drawing.Size(135, 20);
            this.SelectButton5.TabIndex = 9;
            this.SelectButton5.Text = "Select";
            this.SelectButton5.UseVisualStyleBackColor = true;
            this.SelectButton5.Click += new System.EventHandler(this.SelectButton5_Click);
            // 
            // CardView1
            // 
            this.CardView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardView1.Location = new System.Drawing.Point(5, 4);
            this.CardView1.Margin = new System.Windows.Forms.Padding(0);
            this.CardView1.Name = "CardView1";
            this.CardView1.Size = new System.Drawing.Size(134, 131);
            this.CardView1.TabIndex = 10;
            this.CardView1.ViewModel = null;
            // 
            // CardView2
            // 
            this.CardView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardView2.Location = new System.Drawing.Point(140, 4);
            this.CardView2.Margin = new System.Windows.Forms.Padding(0);
            this.CardView2.Name = "CardView2";
            this.CardView2.Size = new System.Drawing.Size(134, 131);
            this.CardView2.TabIndex = 11;
            this.CardView2.ViewModel = null;
            // 
            // CardView3
            // 
            this.CardView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardView3.Location = new System.Drawing.Point(275, 4);
            this.CardView3.Margin = new System.Windows.Forms.Padding(0);
            this.CardView3.Name = "CardView3";
            this.CardView3.Size = new System.Drawing.Size(134, 131);
            this.CardView3.TabIndex = 12;
            this.CardView3.ViewModel = null;
            // 
            // CardView4
            // 
            this.CardView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardView4.Location = new System.Drawing.Point(410, 4);
            this.CardView4.Margin = new System.Windows.Forms.Padding(0);
            this.CardView4.Name = "CardView4";
            this.CardView4.Size = new System.Drawing.Size(134, 131);
            this.CardView4.TabIndex = 13;
            this.CardView4.ViewModel = null;
            // 
            // CardView5
            // 
            this.CardView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CardView5.Location = new System.Drawing.Point(545, 4);
            this.CardView5.Margin = new System.Windows.Forms.Padding(0);
            this.CardView5.Name = "CardView5";
            this.CardView5.Size = new System.Drawing.Size(134, 131);
            this.CardView5.TabIndex = 14;
            this.CardView5.ViewModel = null;
            // 
            // HeroLayoutPanel
            // 
            this.HeroLayoutPanel.AutoSize = true;
            this.HeroLayoutPanel.ColumnCount = 1;
            this.HeroLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeroLayoutPanel.Controls.Add(this.HeroSelectButton, 0, 2);
            this.HeroLayoutPanel.Controls.Add(this.UsernameLabel, 0, 0);
            this.HeroLayoutPanel.Controls.Add(this.HeroHpLabel, 0, 1);
            this.HeroLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeroLayoutPanel.Location = new System.Drawing.Point(6, 5);
            this.HeroLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.HeroLayoutPanel.Name = "HeroLayoutPanel";
            this.HeroLayoutPanel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.HeroLayoutPanel.RowCount = 3;
            this.HeroLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.HeroLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.HeroLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.HeroLayoutPanel.Size = new System.Drawing.Size(92, 166);
            this.HeroLayoutPanel.TabIndex = 3;
            // 
            // HeroSelectButton
            // 
            this.HeroSelectButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeroSelectButton.Location = new System.Drawing.Point(0, 140);
            this.HeroSelectButton.Margin = new System.Windows.Forms.Padding(0);
            this.HeroSelectButton.Name = "HeroSelectButton";
            this.HeroSelectButton.Size = new System.Drawing.Size(92, 24);
            this.HeroSelectButton.TabIndex = 0;
            this.HeroSelectButton.Text = "Select";
            this.HeroSelectButton.UseVisualStyleBackColor = true;
            this.HeroSelectButton.Click += new System.EventHandler(this.HeroSelectButton_Click);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoEllipsis = true;
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsernameLabel.Location = new System.Drawing.Point(3, 2);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Padding = new System.Windows.Forms.Padding(2);
            this.UsernameLabel.Size = new System.Drawing.Size(86, 119);
            this.UsernameLabel.TabIndex = 1;
            this.UsernameLabel.Text = "username";
            this.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HeroHpLabel
            // 
            this.HeroHpLabel.AutoSize = true;
            this.HeroHpLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeroHpLabel.Location = new System.Drawing.Point(2, 123);
            this.HeroHpLabel.Margin = new System.Windows.Forms.Padding(2);
            this.HeroHpLabel.Name = "HeroHpLabel";
            this.HeroHpLabel.Size = new System.Drawing.Size(88, 15);
            this.HeroHpLabel.TabIndex = 2;
            this.HeroHpLabel.Text = "HP: 0/0";
            this.HeroHpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ArenaSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.MainLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ArenaSide";
            this.Size = new System.Drawing.Size(893, 176);
            this.MainLayoutPanel.ResumeLayout(false);
            this.MainLayoutPanel.PerformLayout();
            this.DeckLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.CardsLayoutPanel.ResumeLayout(false);
            this.HeroLayoutPanel.ResumeLayout(false);
            this.HeroLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel DeckLayoutPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel CardsLayoutPanel;
        private CardView CardView1;
        private CardView CardView2;
        private CardView CardView3;
        private CardView CardView4;
        private CardView CardView5;
        private System.Windows.Forms.Button SelectButton1;
        private System.Windows.Forms.Button SelectButton2;
        private System.Windows.Forms.Button SelectButton3;
        private System.Windows.Forms.Button SelectButton4;
        private System.Windows.Forms.Button SelectButton5;
        private CardView cardView6;
        private CardView cardView7;
        private CardView cardView8;
        private CardView cardView9;
        private CardView cardView10;
        private System.Windows.Forms.TableLayoutPanel HeroLayoutPanel;
        private System.Windows.Forms.Button HeroSelectButton;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label HeroHpLabel;
    }
}
