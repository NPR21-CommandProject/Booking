namespace BookingWinForm.FormsBooking
{
    partial class ProfileForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblName = new Label();
            lblSurname = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(194, 64);
            label1.Name = "label1";
            label1.Size = new Size(55, 30);
            label1.TabIndex = 0;
            label1.Text = "Ім'я:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(139, 114);
            label2.Name = "label2";
            label2.Size = new Size(110, 30);
            label2.TabIndex = 1;
            label2.Text = "Прізвище:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(53, 167);
            label3.Name = "label3";
            label3.Size = new Size(196, 30);
            label3.TabIndex = 2;
            label3.Text = "Електронна пошта:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(149, 221);
            label4.Name = "label4";
            label4.Size = new Size(100, 30);
            label4.TabIndex = 3;
            label4.Text = "Телефон:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblName.Location = new Point(255, 64);
            lblName.Name = "lblName";
            lblName.Size = new Size(18, 30);
            lblName.TabIndex = 4;
            lblName.Text = ".";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblSurname.Location = new Point(255, 114);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(23, 30);
            lblSurname.TabIndex = 5;
            lblSurname.Text = "..";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblEmail.Location = new Point(255, 167);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(28, 30);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "...";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblPhone.Location = new Point(255, 221);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(33, 30);
            lblPhone.TabIndex = 7;
            lblPhone.Text = "....";
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ProfileForm";
            Text = "ProfileForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblName;
        private Label lblSurname;
        private Label lblEmail;
        private Label lblPhone;
    }
}