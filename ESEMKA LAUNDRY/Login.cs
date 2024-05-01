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

namespace ESEMKA_LAUNDRY
{
    public partial class Login : Form
    {
        public static string username_text;
        public Login()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=BROTHERZHAFIF\SQLEXPRESS;Initial Catalog=esemka_laundry;Integrated Security=True");

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (cnn != null)
            {

                string query = "SELECT * FROM employee WHERE email_employee='" + user_txt.Text + "' AND password_employee='"+ pass_txt.Text +"'";

                if (!string.IsNullOrEmpty(user_txt.Text) && !string.IsNullOrEmpty(pass_txt.Text))
                {
                    SqlDataAdapter da = new SqlDataAdapter(query, cnn);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        username_text = dt.Rows[0][3].ToString();
                        MessageBox.Show("Login Berhasil");
                        Main main = new Main();
                        main.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username Atau Password Salah");
                    }
                }
                else
                {
                   MessageBox.Show("Tolong Isi Semua Kolom");
                }
            }
            else
            {
                MessageBox.Show("Koneksi Gagal");
            }
        }
    }
}
