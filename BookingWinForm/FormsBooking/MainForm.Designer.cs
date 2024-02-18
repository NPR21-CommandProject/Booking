namespace BookingWinForm.FormsBooking
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            профільToolStripMenuItem = new ToolStripMenuItem();
            ViewProfileStrip = new ToolStripMenuItem();
            RedactProfileStrip = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { профільToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(700, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // профільToolStripMenuItem
            // 
            профільToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ViewProfileStrip, RedactProfileStrip });
            профільToolStripMenuItem.Name = "профільToolStripMenuItem";
            профільToolStripMenuItem.Size = new Size(67, 20);
            профільToolStripMenuItem.Text = "Профіль";
            // 
            // ViewProfileStrip
            // 
            ViewProfileStrip.Name = "ViewProfileStrip";
            ViewProfileStrip.Size = new Size(194, 22);
            ViewProfileStrip.Text = "Переглянути профіль";
            ViewProfileStrip.Click += ViewProfileStrip_Click;
            // 
            // RedactProfileStrip
            // 
            RedactProfileStrip.Name = "RedactProfileStrip";
            RedactProfileStrip.Size = new Size(194, 22);
            RedactProfileStrip.Text = "Редагувати профіль";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            Text = "MainForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem профільToolStripMenuItem;
        private ToolStripMenuItem ViewProfileStrip;
        private ToolStripMenuItem RedactProfileStrip;
    }
}