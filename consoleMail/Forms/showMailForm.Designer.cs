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
            messege_label = new Label();
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
            // messege_label
            // 
            messege_label.AutoSize = true;
            messege_label.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            messege_label.Location = new Point(12, 81);
            messege_label.Name = "messege_label";
            messege_label.Size = new Size(128, 25);
            messege_label.TabIndex = 2;
            messege_label.Text = "Сообщение -";
            // 
            // showMailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(messege_label);
            Controls.Add(sender_label);
            Controls.Add(theme_label);
            Name = "showMailForm";
            Text = "showMailForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label theme_label;
        private Label sender_label;
        private Label messege_label;
    }
}