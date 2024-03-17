namespace consoleMail.Forms
{
    partial class regForm
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
            tryReg_button = new Button();
            firstName_textBox = new TextBox();
            firstName_label = new Label();
            secondName_label = new Label();
            secondName_textBox = new TextBox();
            login_label = new Label();
            login_textBox = new TextBox();
            postion_label = new Label();
            postion_textBox = new TextBox();
            password_label = new Label();
            password_textBox = new TextBox();
            department_label = new Label();
            department_textBox = new TextBox();
            back_button = new Button();
            SuspendLayout();
            // 
            // tryReg_button
            // 
            tryReg_button.Location = new Point(176, 403);
            tryReg_button.Name = "tryReg_button";
            tryReg_button.Size = new Size(131, 35);
            tryReg_button.TabIndex = 0;
            tryReg_button.Text = "Зарегистрироваться";
            tryReg_button.UseVisualStyleBackColor = true;
            tryReg_button.Click += tryReg_button_Click;
            // 
            // firstName_textBox
            // 
            firstName_textBox.Font = new Font("Segoe UI", 15.75F);
            firstName_textBox.Location = new Point(12, 147);
            firstName_textBox.Multiline = true;
            firstName_textBox.Name = "firstName_textBox";
            firstName_textBox.Size = new Size(131, 34);
            firstName_textBox.TabIndex = 1;
            firstName_textBox.TextAlign = HorizontalAlignment.Center;
            firstName_textBox.KeyDown += textBox_KeyDown;
            // 
            // firstName_label
            // 
            firstName_label.AutoSize = true;
            firstName_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            firstName_label.Location = new Point(12, 112);
            firstName_label.Name = "firstName_label";
            firstName_label.Size = new Size(61, 32);
            firstName_label.TabIndex = 2;
            firstName_label.Text = "Имя";
            // 
            // secondName_label
            // 
            secondName_label.AutoSize = true;
            secondName_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            secondName_label.Location = new Point(176, 112);
            secondName_label.Name = "secondName_label";
            secondName_label.Size = new Size(113, 32);
            secondName_label.TabIndex = 4;
            secondName_label.Text = "Фамилия";
            // 
            // secondName_textBox
            // 
            secondName_textBox.Font = new Font("Segoe UI", 15.75F);
            secondName_textBox.Location = new Point(176, 147);
            secondName_textBox.Multiline = true;
            secondName_textBox.Name = "secondName_textBox";
            secondName_textBox.Size = new Size(131, 34);
            secondName_textBox.TabIndex = 3;
            secondName_textBox.TextAlign = HorizontalAlignment.Center;
            secondName_textBox.KeyDown += textBox_KeyDown;
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_label.Location = new Point(12, 25);
            login_label.Name = "login_label";
            login_label.Size = new Size(81, 32);
            login_label.TabIndex = 6;
            login_label.Text = "Логин";
            // 
            // login_textBox
            // 
            login_textBox.Font = new Font("Segoe UI", 15.75F);
            login_textBox.Location = new Point(12, 60);
            login_textBox.Multiline = true;
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(131, 34);
            login_textBox.TabIndex = 5;
            login_textBox.TextAlign = HorizontalAlignment.Center;
            login_textBox.KeyDown += textBox_KeyDown;
            // 
            // postion_label
            // 
            postion_label.AutoSize = true;
            postion_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            postion_label.Location = new Point(12, 208);
            postion_label.Name = "postion_label";
            postion_label.Size = new Size(124, 32);
            postion_label.TabIndex = 10;
            postion_label.Text = "Дожность";
            // 
            // postion_textBox
            // 
            postion_textBox.Font = new Font("Segoe UI", 15.75F);
            postion_textBox.Location = new Point(176, 243);
            postion_textBox.Multiline = true;
            postion_textBox.Name = "postion_textBox";
            postion_textBox.Size = new Size(131, 34);
            postion_textBox.TabIndex = 9;
            postion_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_label.Location = new Point(176, 25);
            password_label.Name = "password_label";
            password_label.Size = new Size(96, 32);
            password_label.TabIndex = 8;
            password_label.Text = "Пароль";
            // 
            // password_textBox
            // 
            password_textBox.Font = new Font("Segoe UI", 15.75F);
            password_textBox.Location = new Point(176, 60);
            password_textBox.Multiline = true;
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(131, 34);
            password_textBox.TabIndex = 7;
            password_textBox.TextAlign = HorizontalAlignment.Center;
            password_textBox.KeyDown += textBox_KeyDown;
            // 
            // department_label
            // 
            department_label.AutoSize = true;
            department_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            department_label.Location = new Point(176, 208);
            department_label.Name = "department_label";
            department_label.Size = new Size(81, 32);
            department_label.TabIndex = 12;
            department_label.Text = "Отдел";
            // 
            // department_textBox
            // 
            department_textBox.Font = new Font("Segoe UI", 15.75F);
            department_textBox.Location = new Point(12, 243);
            department_textBox.Multiline = true;
            department_textBox.Name = "department_textBox";
            department_textBox.Size = new Size(131, 34);
            department_textBox.TabIndex = 11;
            department_textBox.TextAlign = HorizontalAlignment.Center;
            // 
            // back_button
            // 
            back_button.Location = new Point(10, 403);
            back_button.Name = "back_button";
            back_button.Size = new Size(133, 35);
            back_button.TabIndex = 14;
            back_button.Text = "Назад";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // regForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 454);
            Controls.Add(back_button);
            Controls.Add(department_label);
            Controls.Add(department_textBox);
            Controls.Add(postion_label);
            Controls.Add(postion_textBox);
            Controls.Add(password_label);
            Controls.Add(password_textBox);
            Controls.Add(login_label);
            Controls.Add(login_textBox);
            Controls.Add(secondName_label);
            Controls.Add(secondName_textBox);
            Controls.Add(firstName_label);
            Controls.Add(firstName_textBox);
            Controls.Add(tryReg_button);
            Name = "regForm";
            Text = "Форма регистрации";
            KeyDown += textBox_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tryReg_button;
        private TextBox firstName_textBox;
        private Label firstName_label;
        private Label secondName_label;
        private TextBox secondName_textBox;
        private Label login_label;
        private TextBox login_textBox;
        private Label postion_label;
        private TextBox postion_textBox;
        private Label password_label;
        private TextBox password_textBox;
        private Label department_label;
        private TextBox department_textBox;
        private Button back_button;
    }
}