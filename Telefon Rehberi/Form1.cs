using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Telefon_Rehberi
{
    public partial class rehber : Form
    {

        public rehber()
        {
            InitializeComponent();
        }
        private fsql fsql1 = new fsql();

        private void refreshList()
        {
            DataTable contacts = new DataTable();
            contacts = fsql1.getContacts();
            contactList.DataSource = contacts;
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
           
            DialogResult dialogResult;
            if (contactList.SelectedRows.Count > 1)
            {
                dialogResult = MessageBox.Show("Seçilen "+contactList.SelectedRows.Count+" Kiþiyi Silmek istediðine eminmisin ?", "Siliniyor...", MessageBoxButtons.YesNo);
            }
            else
            {
                dialogResult = MessageBox.Show("Kiþiyi Silmek istediðine eminmisin ?", "Siliniyor...", MessageBoxButtons.YesNo);
            }
            if (dialogResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow cl in contactList.SelectedRows)
                {
                    fsql1.removeContact(Convert.ToInt32(cl.Cells[0].Value));
                    
                }
                refreshList();
            }
            else if (dialogResult == DialogResult.No)
            {
            }

            
        }
        

        private void btn_add_Click(object sender, EventArgs e)
        {

            ContactAddForm frm = new ContactAddForm();
            frm.ShowDialog();


            fsql1.addContact(frm.name, frm.lastname, frm.bday, frm.number, frm.fav);
            refreshList();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string newfav;
            EditForm efrm = new EditForm(Convert.ToInt32(contactList.CurrentRow.Cells[0].Value), contactList.CurrentRow.Cells[1].Value.ToString(), contactList.CurrentRow.Cells[2].Value.ToString(), Convert.ToDateTime(contactList.CurrentRow.Cells[3].Value), contactList.CurrentRow.Cells[4].Value.ToString(), contactList.CurrentRow.Cells[5].Value.ToString());
            efrm.ShowDialog();

            if (efrm.fav == true)
            {
                newfav = "true";
            }
            else
            {
                newfav = "false";
            }

            fsql1.updateContact(efrm.no, efrm.name, efrm.lastname, efrm.bday, efrm.number, newfav);
            refreshList();
        }

        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = contactList.DataSource;
            if ( menu.SelectedIndex == 0 ){
                bs.Filter = "favori like '%" + "" + "%'";
                contactList.DataSource = bs.DataSource;
            }
            else
            {
                bs.Filter = "favori like '%" + "true" + "%'";
                contactList.DataSource = bs.DataSource;
            }
        }

        private void srcBox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = contactList.DataSource;
            bs.Filter = "isim like '%" + srcBox.Text + "%' OR soyisim like '%" + srcBox.Text + "%' OR tel like '%" + srcBox.Text + "%'";
            contactList.DataSource = bs.DataSource;
        }

        private void rehber_Load(object sender, EventArgs e)
        {

            refreshList();

        }
        private void contactList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contactList.SelectedRows.Count == 0)
            {
                btn_del.Enabled = false;
            }
            else
            {
                btn_del.Enabled = true;
            }

            if (contactList.SelectedRows.Count > 1 || contactList.SelectedRows.Count == 0)
            {
                btn_edit.Enabled = false;
            }
            else
            {
                btn_edit.Enabled = true;

            }
        }
    }
}
