﻿namespace consoleMail.Forms
{
    partial class authForm
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
            login_label = new Label();
            login_textBox = new TextBox();
            password_label = new Label();
            password_textBox = new TextBox();
            tryAuth_button = new Button();
            back_button = new Button();
            SuspendLayout();
            // 
            // login_label
            // 
            login_label.AutoSize = true;
            login_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_label.Location = new Point(12, 18);
            login_label.Name = "login_label";
            login_label.Size = new Size(81, 32);
            login_label.TabIndex = 8;
            login_label.Text = "Логин";
            // 
            // login_textBox
            // 
            login_textBox.Font = new Font("Segoe UI", 14.25F);
            login_textBox.Location = new Point(12, 53);
            login_textBox.Multiline = true;
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(131, 34);
            login_textBox.TabIndex = 7;
            login_textBox.TextAlign = HorizontalAlignment.Center;
            login_textBox.KeyDown += textBox_KeyDown;
            // 
            // password_label
            // 
            password_label.AutoSize = true;
            password_label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password_label.Location = new Point(155, 18);
            password_label.Name = "password_label";
            password_label.Size = new Size(96, 32);
            password_label.TabIndex = 10;
            password_label.Text = "Пароль";
            // 
            // password_textBox
            // 
            password_textBox.Font = new Font("Segoe UI", 14.25F);
            password_textBox.Location = new Point(155, 53);
            password_textBox.Multiline = true;
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(131, 34);
            password_textBox.TabIndex = 9;
            password_textBox.TextAlign = HorizontalAlignment.Center;
            password_textBox.KeyDown += textBox_KeyDown;
            // 
            // tryAuth_button
            // 
            tryAuth_button.Font = new Font("Segoe UI", 11.25F);
            tryAuth_button.Location = new Point(155, 107);
            tryAuth_button.Name = "tryAuth_button";
            tryAuth_button.Size = new Size(131, 50);
            tryAuth_button.TabIndex = 11;
            tryAuth_button.Text = "Авторизоваться";
            tryAuth_button.UseVisualStyleBackColor = true;
            tryAuth_button.Click += tryAuth_button_Click;
            // 
            // back_button
            // 
            back_button.Font = new Font("Segoe UI", 11.25F);
            back_button.Location = new Point(12, 107);
            back_button.Name = "back_button";
            back_button.Size = new Size(131, 50);
            back_button.TabIndex = 12;
            back_button.Text = "Назад";
            back_button.UseVisualStyleBackColor = true;
            back_button.Click += back_button_Click;
            // 
            // authForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 171);
            Controls.Add(back_button);
            Controls.Add(tryAuth_button);
            Controls.Add(password_label);
            Controls.Add(password_textBox);
            Controls.Add(login_label);
            Controls.Add(login_textBox);
            Name = "authForm";
            Text = "Форма авторизации";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label login_label;
        private TextBox login_textBox;
        private Label password_label;
        private TextBox password_textBox;
        private Button tryAuth_button;
        private Button back_button;
    }
}