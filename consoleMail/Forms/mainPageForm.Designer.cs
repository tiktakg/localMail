﻿namespace consoleMail.Forms
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
            allMesseges_listView = new ListView();
            msg_textBox = new TextBox();
            sendMail_button = new Button();
            attachFile_button = new Button();
            nameOfFile_label = new Label();
            theme_textBox = new TextBox();
            theme_label = new Label();
            receiver_textBox = new TextBox();
            receiver_label = new Label();
            sortMsg_textBox = new TextBox();
            priorityOfMsg_comboBox = new ComboBox();
            priorityOfMsg_label = new Label();
            priorityOfMsgToSort_comboBox = new ComboBox();
            SuspendLayout();
            // 
            // allMesseges_listView
            // 
            allMesseges_listView.Location = new Point(12, 39);
            allMesseges_listView.Name = "allMesseges_listView";
            allMesseges_listView.Size = new Size(194, 399);
            allMesseges_listView.TabIndex = 0;
            allMesseges_listView.UseCompatibleStateImageBehavior = false;
            allMesseges_listView.MouseDoubleClick += allMesseges_listView_MouseDoubleClick;
            // 
            // msg_textBox
            // 
            msg_textBox.Location = new Point(212, 97);
            msg_textBox.Multiline = true;
            msg_textBox.Name = "msg_textBox";
            msg_textBox.Size = new Size(580, 305);
            msg_textBox.TabIndex = 1;
            // 
            // sendMail_button
            // 
            sendMail_button.Location = new Point(667, 408);
            sendMail_button.Name = "sendMail_button";
            sendMail_button.Size = new Size(125, 30);
            sendMail_button.TabIndex = 2;
            sendMail_button.Text = "Отправить";
            sendMail_button.UseVisualStyleBackColor = true;
            sendMail_button.Click += sendMail_button_Click;
            // 
            // attachFile_button
            // 
            attachFile_button.Location = new Point(212, 408);
            attachFile_button.Name = "attachFile_button";
            attachFile_button.Size = new Size(125, 30);
            attachFile_button.TabIndex = 3;
            attachFile_button.Text = "Прикрепить файл";
            attachFile_button.UseVisualStyleBackColor = true;
            attachFile_button.Click += attachFile_button_Click;
            // 
            // nameOfFile_label
            // 
            nameOfFile_label.AutoSize = true;
            nameOfFile_label.Font = new Font("Segoe UI Semilight", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameOfFile_label.Location = new Point(343, 408);
            nameOfFile_label.Name = "nameOfFile_label";
            nameOfFile_label.Size = new Size(170, 30);
            nameOfFile_label.TabIndex = 4;
            nameOfFile_label.Text = "Название файла";
            // 
            // theme_textBox
            // 
            theme_textBox.Location = new Point(212, 10);
            theme_textBox.Multiline = true;
            theme_textBox.Name = "theme_textBox";
            theme_textBox.Size = new Size(121, 23);
            theme_textBox.TabIndex = 5;
            // 
            // theme_label
            // 
            theme_label.AutoSize = true;
            theme_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            theme_label.Location = new Point(349, 10);
            theme_label.Name = "theme_label";
            theme_label.Size = new Size(130, 21);
            theme_label.TabIndex = 6;
            theme_label.Text = "Тема сообщения";
            // 
            // receiver_textBox
            // 
            receiver_textBox.Location = new Point(212, 39);
            receiver_textBox.Multiline = true;
            receiver_textBox.Name = "receiver_textBox";
            receiver_textBox.Size = new Size(121, 23);
            receiver_textBox.TabIndex = 7;
            // 
            // receiver_label
            // 
            receiver_label.AutoSize = true;
            receiver_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            receiver_label.Location = new Point(349, 41);
            receiver_label.Name = "receiver_label";
            receiver_label.Size = new Size(54, 21);
            receiver_label.TabIndex = 8;
            receiver_label.Text = "Кому?";
            // 
            // sortMsg_textBox
            // 
            sortMsg_textBox.Location = new Point(112, 10);
            sortMsg_textBox.Multiline = true;
            sortMsg_textBox.Name = "sortMsg_textBox";
            sortMsg_textBox.Size = new Size(94, 23);
            sortMsg_textBox.TabIndex = 9;
            sortMsg_textBox.TextChanged += sortMsg_textBox_TextChanged;
            // 
            // priorityOfMsg_comboBox
            // 
            priorityOfMsg_comboBox.FormattingEnabled = true;
            priorityOfMsg_comboBox.Items.AddRange(new object[] { "Не важно", "Важно!", "Очень важно!" });
            priorityOfMsg_comboBox.Location = new Point(212, 68);
            priorityOfMsg_comboBox.Name = "priorityOfMsg_comboBox";
            priorityOfMsg_comboBox.Size = new Size(121, 23);
            priorityOfMsg_comboBox.TabIndex = 10;
            priorityOfMsg_comboBox.Text = "Не важно";
            // 
            // priorityOfMsg_label
            // 
            priorityOfMsg_label.AutoSize = true;
            priorityOfMsg_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priorityOfMsg_label.Location = new Point(349, 70);
            priorityOfMsg_label.Name = "priorityOfMsg_label";
            priorityOfMsg_label.Size = new Size(164, 21);
            priorityOfMsg_label.TabIndex = 11;
            priorityOfMsg_label.Text = "Важность сообщения";
            // 
            // priorityOfMsgToSort_comboBox
            // 
            priorityOfMsgToSort_comboBox.FormattingEnabled = true;
            priorityOfMsgToSort_comboBox.Items.AddRange(new object[] { "Все", "Не важно", "Важно!", "Очень важно!" });
            priorityOfMsgToSort_comboBox.Location = new Point(12, 10);
            priorityOfMsgToSort_comboBox.Name = "priorityOfMsgToSort_comboBox";
            priorityOfMsgToSort_comboBox.Size = new Size(94, 23);
            priorityOfMsgToSort_comboBox.TabIndex = 12;
            priorityOfMsgToSort_comboBox.Text = "Все";
            priorityOfMsgToSort_comboBox.SelectionChangeCommitted += priorityOfMsgToSort_comboBox_SelectionChangeCommitted;
            // 
            // mainPageForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(priorityOfMsgToSort_comboBox);
            Controls.Add(priorityOfMsg_label);
            Controls.Add(priorityOfMsg_comboBox);
            Controls.Add(sortMsg_textBox);
            Controls.Add(receiver_label);
            Controls.Add(receiver_textBox);
            Controls.Add(theme_label);
            Controls.Add(theme_textBox);
            Controls.Add(nameOfFile_label);
            Controls.Add(attachFile_button);
            Controls.Add(sendMail_button);
            Controls.Add(msg_textBox);
            Controls.Add(allMesseges_listView);
            Name = "mainPageForm";
            Text = "mainPageForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView allMesseges_listView;
        private TextBox msg_textBox;
        private Button sendMail_button;
        private Button attachFile_button;
        private Label nameOfFile_label;
        private TextBox theme_textBox;
        private Label theme_label;
        private TextBox receiver_textBox;
        private Label receiver_label;
        private TextBox sortMsg_textBox;
        private ComboBox priorityOfMsg_comboBox;
        private Label priorityOfMsg_label;
        private ComboBox priorityOfMsgToSort_comboBox;
    }
}