namespace BookingWinForm.FormsBooking
{
    partial class LoginForm
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
            txtServerHost = new TextBox();
            label2 = new Label();
            txtUserName = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            btnCheckConnection = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(46, 40);
            label1.Name = "label1";
            label1.Size = new Size(147, 50);
            label1.TabIndex = 0;
            label1.Text = "Сервер";
            // 
            // txtServerHost
            // 
            txtServerHost.Font = new Font("Segoe UI", 11F);
            txtServerHost.Location = new Point(46, 106);
            txtServerHost.Name = "txtServerHost";
            txtServerHost.Size = new Size(490, 56);
            txtServerHost.TabIndex = 1;
            txtServerHost.Text = "Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(46, 193);
            label2.Name = "label2";
            label2.Size = new Size(113, 50);
            label2.TabIndex = 0;
            label2.Text = "Логін";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 11F);
            txtUserName.Location = new Point(46, 259);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(490, 56);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(46, 361);
            label3.Name = "label3";
            label3.Size = new Size(150, 50);
            label3.TabIndex = 0;
            label3.Text = "Пароль";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(46, 427);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(490, 56);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "Password";
            // 
            // btnCheckConnection
            // 
            btnCheckConnection.Font = new Font("Segoe UI", 11F);
            btnCheckConnection.Location = new Point(63, 564);
            btnCheckConnection.Name = "btnCheckConnection";
            btnCheckConnection.Size = new Size(495, 81);
            btnCheckConnection.TabIndex = 2;
            btnCheckConnection.Text = "Пееревірити з'єднання";
            btnCheckConnection.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnSave.ForeColor = Color.Blue;
            btnSave.Location = new Point(821, 92);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(366, 58);
            btnSave.TabIndex = 3;
            btnSave.Text = "Зберегти";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Font = new Font("Segoe UI", 11.1F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(821, 224);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(366, 58);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Скаcувати";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1265, 691);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(btnCheckConnection);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUserName);
            Controls.Add(label2);
            Controls.Add(txtServerHost);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Форма підключення";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtServerHost;
        private Label label2;
        private TextBox txtUserName;
        private Label label3;
        private TextBox txtPassword;
        private Button btnCheckConnection;
        private Button btnSave;
        private Button btnCancel;
    }
}