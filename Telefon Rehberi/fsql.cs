using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Telefon_Rehberi
{
    class fsql
    {
        private SqlConnection _con = new SqlConnection("Data Source = KAAN-HUMA; Initial Catalog = rehber; Integrated Security = True; Trust Server Certificate=True");
        public DataTable getContacts()
        {
            
            
            _con.Open();
            SqlDataAdapter _da = new SqlDataAdapter("SELECT * FROM rehber", _con);
            DataTable tablo = new DataTable();
            _da.Fill(tablo);
            _con.Close();

            return tablo;
        }
        public void addContact(string name, string lastname, DateTime bday, string number, string fav)
        {
            string text = "INSERT INTO rehber(isim,soyisim,dogum_gunu,tel,favori) VALUES (@isim,@soyisim,@bday,@tel,@favori)";
            SqlCommand _command = new SqlCommand(text, _con);
            _command.Parameters.AddWithValue("@isim", name);
            _command.Parameters.AddWithValue("@soyisim", lastname);
            _command.Parameters.AddWithValue("@bday", bday);
            _command.Parameters.AddWithValue("@tel", number);
            _command.Parameters.AddWithValue("@favori", fav);
            _con.Open();
            _command.ExecuteNonQuery();
            _con.Close();
        }
        public void updateContact(int no, string name, string lastname, DateTime bday, string number, string fav)
        {
            string text = "UPDATE rehber SET isim=@isim,soyisim=@soyisim,dogum_gunu=@bday,tel=@tel,favori=@favori WHERE no=@no";
            SqlCommand _command = new SqlCommand(text, _con);
            _command.Parameters.AddWithValue("@no", no);
            _command.Parameters.AddWithValue("@isim", name);
            _command.Parameters.AddWithValue("@soyisim", lastname);
            _command.Parameters.AddWithValue("@bday", bday);
            _command.Parameters.AddWithValue("@tel", number);
            _command.Parameters.AddWithValue("@favori", fav);
            _con.Open();
            _command.ExecuteNonQuery();
            _con.Close();
        }

        public void removeContact(int no)
        {
            string text = "DELETE FROM rehber WHERE no = @no";
            SqlCommand _command = new SqlCommand(text, _con);
            _command.Parameters.AddWithValue("@no", no);
            _con.Open();
            _command.ExecuteNonQuery();
            _con.Close();
        }
    }
}
