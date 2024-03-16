namespace consoleMail
{
    partial class startForm
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
            reg_button = new Button();
            auth_button = new Button();
            ipOfHost_textBox = new TextBox();
            SuspendLayout();
            // 
            // reg_button
            // 
            reg_button.Location = new Point(190, 57);
            reg_button.Name = "reg_button";
            reg_button.Size = new Size(172, 39);
            reg_button.TabIndex = 1;
            reg_button.Text = "Зарегистрироватья";
            reg_button.UseVisualStyleBackColor = true;
            reg_button.Click += reg_button_Click;
            // 
            // auth_button
            // 
            auth_button.Location = new Point(12, 57);
            auth_button.Name = "auth_button";
            auth_button.Size = new Size(172, 39);
            auth_button.TabIndex = 2;
            auth_button.Text = "Авторизоваться";
            auth_button.UseVisualStyleBackColor = true;
            auth_button.Click += auth_button_Click;
            // 
            // ipOfHost_textBox
            // 
            ipOfHost_textBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ipOfHost_textBox.Location = new Point(12, 12);
            ipOfHost_textBox.Multiline = true;
            ipOfHost_textBox.Name = "ipOfHost_textBox";
            ipOfHost_textBox.Size = new Size(350, 39);
            ipOfHost_textBox.TabIndex = 12;
            ipOfHost_textBox.Text = "Введите ip адрес сервера!";
            ipOfHost_textBox.Leave += ipOfHost_textBox_Leave;
            ipOfHost_textBox.MouseHover += ipOfHost_textBox_MouseHover;
            // 
            // startForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 114);
            Controls.Add(ipOfHost_textBox);
            Controls.Add(auth_button);
            Controls.Add(reg_button);
            Name = "startForm";
            Text = "Начало";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reg_button;
        private Button auth_button;
        private TextBox ipOfHost_textBox;
    }
}
