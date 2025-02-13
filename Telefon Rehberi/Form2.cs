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
    public partial class ContactAddForm : Form
    {
        public string name;
        public string lastname;
        public DateTime bday;
        public string number;
        public string fav;
        public ContactAddForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkAllBox() == false)
            {
                errMsg.Visible = true;
            }
            else
            {
                errMsg.Visible = false;
                name = nameBox.Text;
                lastname = lastnameBox.Text;
                bday = dateTime.Value;
                number = telnoBox.Text;
                if (favBox.Checked == true)
                {
                    fav = "true";
                }
                else
                {
                    fav = "false";
                }
                this.Close();
            }
        }


    }
}
