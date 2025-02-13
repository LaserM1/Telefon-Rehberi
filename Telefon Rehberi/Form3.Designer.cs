namespace Telefon_Rehberi
{
    partial class EditForm
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
            errMsg = new Label();
            savebtn = new Button();
            dateTime = new DateTimePicker();
            telnoBox = new TextBox();
            lastnameBox = new TextBox();
            nameBox = new TextBox();
            favBox = new CheckBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // errMsg
            // 
            errMsg.AutoSize = true;
            errMsg.ForeColor = Color.Red;
            errMsg.Location = new Point(71, 317);
            errMsg.Name = "errMsg";
            errMsg.Size = new Size(241, 15);
            errMsg.TabIndex = 24;
            errMsg.Text = "Ad,Soyad,Numara alanları boş bırakılmamalı";
            errMsg.Visible = false;
            // 
            // savebtn
            // 
            savebtn.Location = new Point(205, 369);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(173, 57);
            savebtn.TabIndex = 23;
            savebtn.Text = "Kaydet";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // dateTime
            // 
            dateTime.Location = new Point(153, 128);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(187, 23);
            dateTime.TabIndex = 22;
            dateTime.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // telnoBox
            // 
            telnoBox.Location = new Point(153, 185);
            telnoBox.Name = "telnoBox";
            telnoBox.Size = new Size(187, 23);
            telnoBox.TabIndex = 21;
            // 
            // lastnameBox
            // 
            lastnameBox.Location = new Point(153, 80);
            lastnameBox.Name = "lastnameBox";
            lastnameBox.Size = new Size(187, 23);
            lastnameBox.TabIndex = 20;
            // 
            // nameBox
            // 
            nameBox.Location = new Point(153, 35);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(187, 23);
            nameBox.TabIndex = 19;
            // 
            // favBox
            // 
            favBox.AutoSize = true;
            favBox.Location = new Point(171, 259);
            favBox.Name = "favBox";
            favBox.Size = new Size(15, 14);
            favBox.TabIndex = 18;
            favBox.TextAlign = ContentAlignment.MiddleCenter;
            favBox.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(91, 251);
            label5.Name = "label5";
            label5.Size = new Size(59, 25);
            label5.TabIndex = 17;
            label5.Text = "Favori";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.Location = new Point(71, 183);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 16;
            label4.Text = "Numara:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(28, 128);
            label3.Name = "label3";
            label3.Size = new Size(122, 25);
            label3.TabIndex = 15;
            label3.Text = "Doğum Tarihi:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(84, 78);
            label2.Name = "label2";
            label2.Size = new Size(66, 25);
            label2.TabIndex = 14;
            label2.Text = "Soyad:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(111, 33);
            label1.Name = "label1";
            label1.Size = new Size(39, 25);
            label1.TabIndex = 13;
            label1.Text = "Ad:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 450);
            Controls.Add(errMsg);
            Controls.Add(savebtn);
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
            Name = "EditForm";
            Text = "Kişiyi Düzenle";
            Load += EditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label errMsg;
        private Button savebtn;
        private DateTimePicker dateTime;
        private TextBox telnoBox;
        private TextBox lastnameBox;
        private TextBox nameBox;
        private CheckBox favBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}