using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telefon_Rehberi
{
    public partial class EditForm : Form
    {
        public int no;
        public string name;
        public string lastname;
        public DateTime bday;
        public string number;
        public bool fav;
        public EditForm(int tno, string isim, string soyisim, DateTime dtarih, string telno, string favori)
        {
            InitializeComponent();
            no = tno;
            name = isim;
            lastname = soyisim;
            bday = dtarih;
            number = telno;
            if (favori == "true")
            {
                fav = true;
            }
            else
            {
                fav = false;
            }
        }
        bool checkAllBox()
        {
            if (nameBox.Text == "" || lastnameBox.Text == "" || telnoBox.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        bool isChangeBoxs()
        {
            if (nameBox.Text == name && lastnameBox.Text == lastname && dateTime.Value == bday && telnoBox.Text == number && favBox.Checked == fav)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (checkAllBox() == false)
            {
                errMsg.Visible = true;
            }
            else
            {

                errMsg.Visible = false;

                if (isChangeBoxs() == true)
                {
                    name = nameBox.Text;
                    lastname = lastnameBox.Text;
                    bday = dateTime.Value;
                    number = telnoBox.Text;
                    fav = favBox.Checked;
                }

                this.Close();
            }

        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            nameBox.Text = name;
            lastnameBox.Text = lastname;
            dateTime.Value = bday;
            telnoBox.Text = number;
            favBox.Checked = fav;
        }
    }
}
