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
            reg_button.Location = new Point(523, 338);
            reg_button.Name = "reg_button";
            reg_button.Size = new Size(265, 100);
            reg_button.TabIndex = 1;
            reg_button.Text = "Зарегистрироватья";
            reg_button.UseVisualStyleBackColor = true;
            reg_button.Click += reg_button_Click;
            // 
            // auth_button
            // 
            auth_button.Location = new Point(12, 338);
            auth_button.Name = "auth_button";
            auth_button.Size = new Size(265, 100);
            auth_button.TabIndex = 2;
            auth_button.Text = "Авторизоваться";
            auth_button.UseVisualStyleBackColor = true;
            auth_button.Click += auth_button_Click;
            // 
            // ipOfHost_textBox
            // 
            ipOfHost_textBox.Location = new Point(232, 71);
            ipOfHost_textBox.Multiline = true;
            ipOfHost_textBox.Name = "ipOfHost_textBox";
            ipOfHost_textBox.Size = new Size(173, 51);
            ipOfHost_textBox.TabIndex = 12;
            // 
            // startForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ipOfHost_textBox);
            Controls.Add(auth_button);
            Controls.Add(reg_button);
            Name = "startForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button reg_button;
        private Button auth_button;
        private TextBox ipOfHost_textBox;
    }
}
