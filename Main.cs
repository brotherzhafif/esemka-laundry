using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESEMKA_LAUNDRY
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Username_lbl.Text = Login.username_text;
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            Manage_Employee manage_Employee = new Manage_Employee();
            manage_Employee.Show();
            this.Close();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();      
            login.Show();
            this.Close();
        }
    }
}
