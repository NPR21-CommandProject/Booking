namespace BookingWinForm.FormsBooking
{
    partial class RegistrationForm
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
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            txtLastN = new TextBox();
            label5 = new Label();
            txtFirstN = new TextBox();
            label6 = new Label();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(105, 25);
            label1.Name = "label1";
            label1.Size = new Size(168, 25);
            label1.TabIndex = 0;
            label1.Text = "Створити акаунт";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 73);
            label2.Name = "label2";
            label2.Size = new Size(141, 20);
            label2.TabIndex = 1;
            label2.Text = "Електронна пошта:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 96);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 162);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(261, 23);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.Location = new Point(12, 139);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "Пароль:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 239);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(261, 23);
            txtPhone.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(12, 216);
            label4.Name = "label4";
            label4.Size = new Size(129, 20);
            label4.TabIndex = 5;
            label4.Text = "Номер телефону:";
            // 
            // txtLastN
            // 
            txtLastN.Location = new Point(12, 314);
            txtLastN.Name = "txtLastN";
            txtLastN.Size = new Size(141, 23);
            txtLastN.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(12, 291);
            label5.Name = "label5";
            label5.Size = new Size(80, 20);
            label5.TabIndex = 7;
            label5.Text = "Прізвище:";
            // 
            // txtFirstN
            // 
            txtFirstN.Location = new Point(193, 314);
            txtFirstN.Name = "txtFirstN";
            txtFirstN.Size = new Size(145, 23);
            txtFirstN.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.Location = new Point(193, 291);
            label6.Name = "label6";
            label6.Size = new Size(38, 20);
            label6.TabIndex = 9;
            label6.Text = "Ім'я:";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(94, 359);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(179, 36);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Зареєструватися";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 417);
            Controls.Add(btnRegister);
            Controls.Add(txtFirstN);
            Controls.Add(label6);
            Controls.Add(txtLastN);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtLastN;
        private Label label5;
        private TextBox txtFirstN;
        private Label label6;
        private Button btnRegister;
    }
}