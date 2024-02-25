namespace BookingWinForm.FormsBooking
{
    partial class HotelsList
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
            dgvHotelsList = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnShowHotel = new Button();
            button1 = new Button();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvHotelsList).BeginInit();
            SuspendLayout();
            // 
            // dgvHotelsList
            // 
            dgvHotelsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHotelsList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvHotelsList.Location = new Point(52, 255);
            dgvHotelsList.Margin = new Padding(4);
            dgvHotelsList.Name = "dgvHotelsList";
            dgvHotelsList.RowHeadersWidth = 102;
            dgvHotelsList.Size = new Size(2284, 824);
            dgvHotelsList.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Місто";
            Column1.MinimumWidth = 12;
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // Column2
            // 
            Column2.HeaderText = "Адреса";
            Column2.MinimumWidth = 12;
            Column2.Name = "Column2";
            Column2.Width = 800;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Площа";
            Column3.MinimumWidth = 12;
            Column3.Name = "Column3";
            Column3.Width = 181;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Кімнат";
            Column4.MinimumWidth = 12;
            Column4.Name = "Column4";
            Column4.Width = 177;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Людей";
            Column5.MinimumWidth = 12;
            Column5.Name = "Column5";
            Column5.Width = 182;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(622, 25);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(716, 54);
            label1.TabIndex = 1;
            label1.Text = "Список місць проживання (готелів)";
            // 
            // btnShowHotel
            // 
            btnShowHotel.BackColor = Color.PapayaWhip;
            btnShowHotel.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnShowHotel.Location = new Point(425, 137);
            btnShowHotel.Name = "btnShowHotel";
            btnShowHotel.Size = new Size(526, 92);
            btnShowHotel.TabIndex = 2;
            btnShowHotel.Text = "Показати вибране житло";
            btnShowHotel.UseVisualStyleBackColor = false;
            btnShowHotel.Click += btnShowHotel_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.PapayaWhip;
            button1.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(1134, 128);
            button1.Name = "button1";
            button1.Size = new Size(658, 92);
            button1.TabIndex = 2;
            button1.Text = "Редагувати вибране житло";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Column6
            // 
            Column6.HeaderText = "Ціна за добу";
            Column6.MinimumWidth = 12;
            Column6.Name = "Column6";
            Column6.Width = 250;
            // 
            // HotelsList
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2416, 1204);
            Controls.Add(button1);
            Controls.Add(btnShowHotel);
            Controls.Add(label1);
            Controls.Add(dgvHotelsList);
            Font = new Font("Segoe UI", 10F);
            Margin = new Padding(4);
            Name = "HotelsList";
            Text = "Список місць проживання (готелів)";
            Load += HotelsList_Load;
            ((System.ComponentModel.ISupportInitialize)dgvHotelsList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvHotelsList;
        private Label label1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button btnShowHotel;
        private Button button1;
        private DataGridViewTextBoxColumn Column6;
    }
}