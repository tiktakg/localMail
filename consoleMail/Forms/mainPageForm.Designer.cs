namespace consoleMail.Forms
{
    partial class mainPageForm
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
            allUMesseges_listView = new ListView();
            msg_textBox = new TextBox();
            sendMail_button = new Button();
            attachFile_button = new Button();
            nameOfFile_label = new Label();
            theme_textBox = new TextBox();
            theme_label = new Label();
            receiver_textBox = new TextBox();
            receiver_label = new Label();
            SuspendLayout();
            // 
            // allUMesseges_listView
            // 
            allUMesseges_listView.Location = new Point(12, 12);
            allUMesseges_listView.Name = "allUMesseges_listView";
            allUMesseges_listView.Size = new Size(121, 426);
            allUMesseges_listView.TabIndex = 0;
            allUMesseges_listView.UseCompatibleStateImageBehavior = false;
            allUMesseges_listView.ItemSelectionChanged += allUMesseges_listView_ItemSelectionChanged;
            // 
            // msg_textBox
            // 
            msg_textBox.Location = new Point(149, 117);
            msg_textBox.Multiline = true;
            msg_textBox.Name = "msg_textBox";
            msg_textBox.Size = new Size(639, 262);
            msg_textBox.TabIndex = 1;
            // 
            // sendMail_button
            // 
            sendMail_button.Location = new Point(663, 399);
            sendMail_button.Name = "sendMail_button";
            sendMail_button.Size = new Size(125, 39);
            sendMail_button.TabIndex = 2;
            sendMail_button.Text = "Отправить";
            sendMail_button.UseVisualStyleBackColor = true;
            sendMail_button.Click += sendMail_button_Click;
            // 
            // attachFile_button
            // 
            attachFile_button.Location = new Point(149, 399);
            attachFile_button.Name = "attachFile_button";
            attachFile_button.Size = new Size(125, 39);
            attachFile_button.TabIndex = 3;
            attachFile_button.Text = "Прикрепить файл";
            attachFile_button.UseVisualStyleBackColor = true;
            attachFile_button.Click += attachFile_button_Click;
            // 
            // nameOfFile_label
            // 
            nameOfFile_label.AutoSize = true;
            nameOfFile_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameOfFile_label.Location = new Point(296, 411);
            nameOfFile_label.Name = "nameOfFile_label";
            nameOfFile_label.Size = new Size(126, 21);
            nameOfFile_label.TabIndex = 4;
            nameOfFile_label.Text = "Название файла";
            // 
            // theme_textBox
            // 
            theme_textBox.Location = new Point(149, 12);
            theme_textBox.Multiline = true;
            theme_textBox.Name = "theme_textBox";
            theme_textBox.Size = new Size(100, 37);
            theme_textBox.TabIndex = 5;
            // 
            // theme_label
            // 
            theme_label.AutoSize = true;
            theme_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            theme_label.Location = new Point(255, 12);
            theme_label.Name = "theme_label";
            theme_label.Size = new Size(130, 21);
            theme_label.TabIndex = 6;
            theme_label.Text = "Тема сообщения";
            // 
            // receiver_textBox
            // 
            receiver_textBox.Location = new Point(149, 61);
            receiver_textBox.Multiline = true;
            receiver_textBox.Name = "receiver_textBox";
            receiver_textBox.Size = new Size(100, 37);
            receiver_textBox.TabIndex = 7;
            // 
            // receiver_label
            // 
            receiver_label.AutoSize = true;
            receiver_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            receiver_label.Location = new Point(255, 61);
            receiver_label.Name = "receiver_label";
            receiver_label.Size = new Size(54, 21);
            receiver_label.TabIndex = 8;
            receiver_label.Text = "Кому?";
            // 
            // mainPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(receiver_label);
            Controls.Add(receiver_textBox);
            Controls.Add(theme_label);
            Controls.Add(theme_textBox);
            Controls.Add(nameOfFile_label);
            Controls.Add(attachFile_button);
            Controls.Add(sendMail_button);
            Controls.Add(msg_textBox);
            Controls.Add(allUMesseges_listView);
            Name = "mainPageForm";
            Text = "mainPageForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView allUMesseges_listView;
        private TextBox msg_textBox;
        private Button sendMail_button;
        private Button attachFile_button;
        private Label nameOfFile_label;
        private TextBox theme_textBox;
        private Label theme_label;
        private TextBox receiver_textBox;
        private Label receiver_label;
    }
}