namespace laba36
{
    partial class GameForm
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
            components = new System.ComponentModel.Container();
            GameCycleTimer = new System.Windows.Forms.Timer(components);
            GameMenuStrip = new MenuStrip();
            InformationToolStripMenuItem = new ToolStripMenuItem();
            playerball = new Ball();
            playerracket = new Racket();
            GamePanel = new Panel();
            StopLabel = new Label();
            GameMenuStrip.SuspendLayout();
            GamePanel.SuspendLayout();
            SuspendLayout();
            // 
            // GameCycleTimer
            // 
            GameCycleTimer.Tick += GameCycleTimer_Tick;
            // 
            // GameMenuStrip
            // 
            GameMenuStrip.Items.AddRange(new ToolStripItem[] { InformationToolStripMenuItem });
            GameMenuStrip.Location = new Point(0, 0);
            GameMenuStrip.Name = "GameMenuStrip";
            GameMenuStrip.Size = new Size(884, 24);
            GameMenuStrip.TabIndex = 3;
            GameMenuStrip.Text = "menuStrip1";
            // 
            // InformationToolStripMenuItem
            // 
            InformationToolStripMenuItem.Name = "InformationToolStripMenuItem";
            InformationToolStripMenuItem.Size = new Size(12, 20);
            // 
            // playerball
            // 
            playerball.BackColor = Color.Black;
            playerball.Location = new Point(430, 500);
            playerball.Name = "playerball";
            playerball.Size = new Size(16, 16);
            playerball.TabIndex = 1;
            // 
            // playerracket
            // 
            playerracket.BackColor = Color.Blue;
            playerracket.Location = new Point(373, 561);
            playerracket.Name = "playerracket";
            playerracket.Size = new Size(130, 20);
            playerracket.TabIndex = 0;
            // 
            // GamePanel
            // 
            GamePanel.BackColor = Color.FromArgb(0, 0, 64);
            GamePanel.Controls.Add(StopLabel);
            GamePanel.Controls.Add(playerracket);
            GamePanel.Controls.Add(playerball);
            GamePanel.Dock = DockStyle.Fill;
            GamePanel.Location = new Point(0, 24);
            GamePanel.Name = "GamePanel";
            GamePanel.Size = new Size(884, 637);
            GamePanel.TabIndex = 2;
            // 
            // StopLabel
            // 
            StopLabel.AutoSize = true;
            StopLabel.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 204);
            StopLabel.ForeColor = Color.White;
            StopLabel.Location = new Point(300, 250);
            StopLabel.Name = "StopLabel";
            StopLabel.Size = new Size(0, 128);
            StopLabel.TabIndex = 2;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(884, 661);
            Controls.Add(GamePanel);
            Controls.Add(GameMenuStrip);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Арканоид";
            Load += GameForm_Load;
            KeyDown += GameForm_KeyDown;
            GameMenuStrip.ResumeLayout(false);
            GameMenuStrip.PerformLayout();
            GamePanel.ResumeLayout(false);
            GamePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer GameCycleTimer;
        private MenuStrip GameMenuStrip;
        private Ball playerball;
        private Racket playerracket;
        private Panel GamePanel;
        private ToolStripMenuItem InformationToolStrip;
        private ToolStripMenuItem InformationToolStripMenuItem;
        private Label StopLabel;
    }
}
