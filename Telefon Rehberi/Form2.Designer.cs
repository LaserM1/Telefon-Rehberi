namespace Telefon_Rehberi
{
    partial class ContactAddForm
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            favBox = new CheckBox();
            nameBox = new TextBox();
            lastnameBox = new TextBox();
            telnoBox = new TextBox();
            dateTime = new DateTimePicker();
            button1 = new Button();
            errMsg = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(96, 42);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(69, 87);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 1;
            label2.Text = "Soyad:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(13, 137);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 2;
            label3.Text = "Doğum Tarihi:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(56, 192);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 3;
            label4.Text = "Numara:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(76, 260);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 4;
            label5.Text = "Favori";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // favBox
            // 
            favBox.AutoSize = true;
            favBox.Location = new Point(156, 268);
            favBox.Name = "favBox";
            favBox.Size = new Size(15, 14);
            favBox.TabIndex = 5;
            favBox.TextAlign = ContentAlignment.MiddleCenter;
            favBox.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(138, 44);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(187, 23);
            nameBox.TabIndex = 6;
            // 
            // lastnameBox
            // 
            lastnameBox.Location = new Point(138, 89);
            lastnameBox.Name = "lastnameBox";
            lastnameBox.Size = new Size(187, 23);
            lastnameBox.TabIndex = 7;
            // 
            // telnoBox
            // 
            telnoBox.Location = new Point(138, 194);
            telnoBox.Name = "telnoBox";
            telnoBox.Size = new Size(187, 23);
            telnoBox.TabIndex = 9;
            // 
            // dateTime
            // 
            dateTime.Location = new Point(138, 137);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(187, 23);
            dateTime.TabIndex = 10;
            dateTime.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // button1
            // 
            button1.Location = new Point(195, 369);
            button1.Name = "button1";
            button1.Size = new Size(173, 57);
            button1.TabIndex = 11;
            button1.Text = "Kaydet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // errMsg
            // 
            errMsg.AutoSize = true;
            errMsg.ForeColor = Color.Red;
            errMsg.Location = new Point(56, 333);
            errMsg.Name = "errMsg";
            errMsg.Size = new Size(241, 15);
            errMsg.TabIndex = 12;
            errMsg.Text = "Ad,Soyad,Numara alanları boş bırakılmamalı";
            errMsg.Visible = false;
            // 
            // ContactAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 450);
            Controls.Add(errMsg);
            Controls.Add(button1);
            Controls.Add(dateTime);
            Controls.Add(telnoBox);
            Controls.Add(lastnameBox);
            Controls.Add(nameBox);
            Controls.Add(favBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ContactAddForm";
            Text = "Kişi Ekle";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox favBox;
        private TextBox nameBox;
        private TextBox lastnameBox;
        private TextBox telnoBox;
        private DateTimePicker dateTime;
        private Button button1;
        private Label errMsg;
    }
}