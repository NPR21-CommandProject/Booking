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
            menuExit = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            txtUserLoginSearch = new TextBox();
            btnUserSearch_main = new Button();
            label3 = new Label();
            btnShowAllHotels_main = new Button();
            label4 = new Label();
            btnAddNewHotel_main = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label12 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            btnSearchHotels_main = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(40, 40);
            menuStrip1.Items.AddRange(new ToolStripItem[] { профільToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(15, 5, 0, 5);
            menuStrip1.Size = new Size(1700, 55);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // профільToolStripMenuItem
            // 
            профільToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { menuExit });
            профільToolStripMenuItem.Name = "профільToolStripMenuItem";
            профільToolStripMenuItem.Size = new Size(126, 45);
            профільToolStripMenuItem.Text = "Меню";
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.ShortcutKeys = Keys.Control | Keys.X;
            menuExit.Size = new Size(358, 54);
            menuExit.Text = "Вихід";
            menuExit.Click += menuExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(51, 96);
            label1.Name = "label1";
            label1.Size = new Size(725, 50);
            label1.TabIndex = 1;
            label1.Text = " Заповнити/Редагувати дані користувача:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(74, 171);
            label2.Name = "label2";
            label2.Size = new Size(227, 50);
            label2.TabIndex = 2;
            label2.Text = "Користувач:";
            // 
            // txtUserLoginSearch
            // 
            txtUserLoginSearch.Font = new Font("Segoe UI", 11F);
            txtUserLoginSearch.Location = new Point(489, 171);
            txtUserLoginSearch.Name = "txtUserLoginSearch";
            txtUserLoginSearch.Size = new Size(651, 56);
            txtUserLoginSearch.TabIndex = 3;
            // 
            // btnUserSearch_main
            // 
            btnUserSearch_main.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnUserSearch_main.Location = new Point(1171, 154);
            btnUserSearch_main.Name = "btnUserSearch_main";
            btnUserSearch_main.Size = new Size(401, 84);
            btnUserSearch_main.TabIndex = 4;
            btnUserSearch_main.Text = "Знайти користувача";
            btnUserSearch_main.UseVisualStyleBackColor = true;
            btnUserSearch_main.Click += btnUserSearch_main_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(51, 280);
            label3.Name = "label3";
            label3.Size = new Size(816, 50);
            label3.TabIndex = 1;
            label3.Text = " Відображення списку всіх місць проживання: ";
            // 
            // btnShowAllHotels_main
            // 
            btnShowAllHotels_main.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnShowAllHotels_main.Location = new Point(1160, 263);
            btnShowAllHotels_main.Name = "btnShowAllHotels_main";
            btnShowAllHotels_main.Size = new Size(401, 84);
            btnShowAllHotels_main.TabIndex = 4;
            btnShowAllHotels_main.Text = "Показати";
            btnShowAllHotels_main.UseVisualStyleBackColor = true;
            btnShowAllHotels_main.Click += btnShowAllHotels_main_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.Location = new Point(74, 406);
            label4.Name = "label4";
            label4.Size = new Size(584, 50);
            label4.TabIndex = 1;
            label4.Text = " Додати нове місце проживання:";
            // 
            // btnAddNewHotel_main
            // 
            btnAddNewHotel_main.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnAddNewHotel_main.Location = new Point(1171, 389);
            btnAddNewHotel_main.Name = "btnAddNewHotel_main";
            btnAddNewHotel_main.Size = new Size(401, 84);
            btnAddNewHotel_main.TabIndex = 4;
            btnAddNewHotel_main.Text = "Показати";
            btnAddNewHotel_main.UseVisualStyleBackColor = true;
            btnAddNewHotel_main.Click += btnAddNewHotel_main_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(51, 171);
            label6.Name = "label6";
            label6.Size = new Size(227, 50);
            label6.TabIndex = 2;
            label6.Text = "Користувач:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.Location = new Point(60, 171);
            label7.Name = "label7";
            label7.Size = new Size(346, 50);
            label7.TabIndex = 2;
            label7.Text = "Користувач (мейл):";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F);
            label8.Location = new Point(60, 280);
            label8.Name = "label8";
            label8.Size = new Size(816, 50);
            label8.TabIndex = 1;
            label8.Text = " Відображення списку всіх місць проживання: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F);
            label9.Location = new Point(74, 406);
            label9.Name = "label9";
            label9.Size = new Size(584, 50);
            label9.TabIndex = 1;
            label9.Text = " Додати нове місце проживання:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F);
            label10.Location = new Point(74, 406);
            label10.Name = "label10";
            label10.Size = new Size(584, 50);
            label10.TabIndex = 1;
            label10.Text = " Додати нове місце проживання:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F);
            label12.Location = new Point(74, 406);
            label12.Name = "label12";
            label12.Size = new Size(584, 50);
            label12.TabIndex = 1;
            label12.Text = " Додати нове місце проживання:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 11F);
            label14.Location = new Point(60, 280);
            label14.Name = "label14";
            label14.Size = new Size(816, 50);
            label14.TabIndex = 1;
            label14.Text = " Відображення списку всіх місць проживання: ";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F);
            label15.Location = new Point(74, 406);
            label15.Name = "label15";
            label15.Size = new Size(584, 50);
            label15.TabIndex = 1;
            label15.Text = " Додати нове місце проживання:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 11F);
            label16.Location = new Point(74, 534);
            label16.Name = "label16";
            label16.Size = new Size(472, 50);
            label16.TabIndex = 1;
            label16.Text = "Пошук місця проживання:";
            // 
            // btnSearchHotels_main
            // 
            btnSearchHotels_main.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSearchHotels_main.Location = new Point(1171, 517);
            btnSearchHotels_main.Name = "btnSearchHotels_main";
            btnSearchHotels_main.Size = new Size(401, 84);
            btnSearchHotels_main.TabIndex = 4;
            btnSearchHotels_main.Text = "Запуск пошуку";
            btnSearchHotels_main.UseVisualStyleBackColor = true;
            btnSearchHotels_main.Click += btnSearchHotels_main_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1700, 924);
            Controls.Add(btnSearchHotels_main);
            Controls.Add(btnAddNewHotel_main);
            Controls.Add(btnShowAllHotels_main);
            Controls.Add(btnUserSearch_main);
            Controls.Add(txtUserLoginSearch);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label14);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(7, 5, 7, 5);
            Name = "MainForm";
            Text = "ГОЛОВНА ФОРМА";
            Load += MainForm_load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem профільToolStripMenuItem;
        private Label label1;
        private Label label2;
        private TextBox txtUserLoginSearch;
        private Button btnUserSearch_main;
        private Label label3;
        private Button btnShowAllHotels_main;
        private Label label4;
        private Button btnAddNewHotel_main;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label12;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button btnSearchHotels_main;
        private ToolStripMenuItem menuExit;
    }
}