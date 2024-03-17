namespace consoleMail.Forms
{
    partial class showMailForm
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
            theme_label = new Label();
            sender_label = new Label();
            openFile_button = new Button();
            priorityOfMsg_label = new Label();
            pathOfFile_lable = new Label();
            messege_textBox = new TextBox();
            SuspendLayout();
            // 
            // theme_label
            // 
            theme_label.AutoSize = true;
            theme_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            theme_label.Location = new Point(12, 9);
            theme_label.Name = "theme_label";
            theme_label.Size = new Size(73, 25);
            theme_label.TabIndex = 0;
            theme_label.Text = "Тема - ";
            // 
            // sender_label
            // 
            sender_label.AutoSize = true;
            sender_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sender_label.Location = new Point(12, 45);
            sender_label.Name = "sender_label";
            sender_label.Size = new Size(143, 25);
            sender_label.TabIndex = 1;
            sender_label.Text = "Отправитель - ";
            // 
            // openFile_button
            // 
            openFile_button.Location = new Point(12, 406);
            openFile_button.Name = "openFile_button";
            openFile_button.Size = new Size(184, 32);
            openFile_button.TabIndex = 3;
            openFile_button.Text = "Открыть файл";
            openFile_button.UseVisualStyleBackColor = true;
            openFile_button.Click += openFile_button_Click;
            // 
            // priorityOfMsg_label
            // 
            priorityOfMsg_label.AutoSize = true;
            priorityOfMsg_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priorityOfMsg_label.Location = new Point(12, 85);
            priorityOfMsg_label.Name = "priorityOfMsg_label";
            priorityOfMsg_label.Size = new Size(109, 25);
            priorityOfMsg_label.TabIndex = 4;
            priorityOfMsg_label.Text = "Важность -";
            // 
            // pathOfFile_lable
            // 
            pathOfFile_lable.AutoSize = true;
            pathOfFile_lable.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pathOfFile_lable.Location = new Point(202, 417);
            pathOfFile_lable.Name = "pathOfFile_lable";
            pathOfFile_lable.Size = new Size(106, 21);
            pathOfFile_lable.TabIndex = 5;
            pathOfFile_lable.Text = "Путь файла - ";
            // 
            // messege_textBox
            // 
            messege_textBox.Enabled = false;
            messege_textBox.Location = new Point(12, 113);
            messege_textBox.Multiline = true;
            messege_textBox.Name = "messege_textBox";
            messege_textBox.Size = new Size(776, 287);
            messege_textBox.TabIndex = 6;
            // 
            // showMailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(messege_textBox);
            Controls.Add(pathOfFile_lable);
            Controls.Add(priorityOfMsg_label);
            Controls.Add(openFile_button);
            Controls.Add(sender_label);
            Controls.Add(theme_label);
            Name = "showMailForm";
            Text = "Сообщение";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label theme_label;
        private Label sender_label;
        private Button openFile_button;
        private Label priorityOfMsg_label;
        private Label pathOfFile_lable;
        private TextBox messege_textBox;
    }
}