namespace Telefon_Rehberi
{
    partial class rehber
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
            btn_add = new Button();
            menu = new ComboBox();
            srcBox = new TextBox();
            btn_del = new Button();
            btn_edit = new Button();
            contactList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)contactList).BeginInit();
            SuspendLayout();
            // 
            // btn_add
            // 
            btn_add.Font = new Font("Segoe UI", 20F);
            btn_add.Location = new Point(12, 513);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(257, 61);
            btn_add.TabIndex = 1;
            btn_add.Text = "+";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // menu
            // 
            menu.FormattingEnabled = true;
            menu.Items.AddRange(new object[] { "Tüm Kişiler", "Favoriler" });
            menu.Location = new Point(12, 18);
            menu.Name = "menu";
            menu.Size = new Size(257, 23);
            menu.TabIndex = 2;
            menu.Text = "Tüm Kişiler";
            menu.SelectedIndexChanged += menu_SelectedIndexChanged;
            // 
            // srcBox
            // 
            srcBox.Location = new Point(12, 60);
            srcBox.Name = "srcBox";
            srcBox.Size = new Size(257, 23);
            srcBox.TabIndex = 3;
            srcBox.TextChanged += srcBox_TextChanged;
            // 
            // btn_del
            // 
            btn_del.Font = new Font("Segoe UI", 15F);
            btn_del.Location = new Point(12, 215);
            btn_del.Name = "btn_del";
            btn_del.Size = new Size(257, 55);
            btn_del.TabIndex = 4;
            btn_del.Text = "Sil";
            btn_del.UseVisualStyleBackColor = true;
            btn_del.Click += btn_del_Click;
            // 
            // btn_edit
            // 
            btn_edit.Font = new Font("Segoe UI", 15F);
            btn_edit.Location = new Point(12, 154);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(257, 55);
            btn_edit.TabIndex = 5;
            btn_edit.Text = "Düzenle";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // contactList
            // 
            contactList.AllowUserToAddRows = false;
            contactList.AllowUserToDeleteRows = false;
            contactList.AllowUserToResizeColumns = false;
            contactList.AllowUserToResizeRows = false;
            contactList.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            contactList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            contactList.EditMode = DataGridViewEditMode.EditProgrammatically;
            contactList.Location = new Point(275, 20);
            contactList.Name = "contactList";
            contactList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            contactList.Size = new Size(602, 554);
            contactList.TabIndex = 6;
            contactList.CellClick += contactList_CellClick;
            // 
            // rehber
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 594);
            Controls.Add(contactList);
            Controls.Add(btn_edit);
            Controls.Add(btn_del);
            Controls.Add(srcBox);
            Controls.Add(menu);
            Controls.Add(btn_add);
            Name = "rehber";
            Text = "Rehber";
            Load += rehber_Load;
            ((System.ComponentModel.ISupportInitialize)contactList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_add;
        private ComboBox menu;
        private TextBox srcBox;
        private Button btn_del;
        private Button btn_edit;
        private DataGridView contactList;
    }
}
