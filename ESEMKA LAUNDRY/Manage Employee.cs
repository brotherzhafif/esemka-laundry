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
    public partial class Manage_Employee : Form
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=BROTHERZHAFIF\SQLEXPRESS;Initial Catalog=esemka_laundry;Integrated Security=True");

        public Manage_Employee()
        {
            InitializeComponent();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }

        private void Manage_Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'esemka_laundryDataSet1.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.esemka_laundryDataSet1.employee);
            this.employeeTableAdapter.Fill(this.esemka_laundryDataSet.employee);
        }

        private void DGV_employee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DGV_employee.CurrentCell.Selected = true;
            name_txt.Text = DGV_employee.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            email_txt.Text = DGV_employee.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            phone_txt.Text = DGV_employee.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            address_txt.Text = DGV_employee.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            job_txt.Text = DGV_employee.Rows[e.RowIndex].Cells["Job"].Value.ToString();
            DOB_txt.Text = DGV_employee.Rows[e.RowIndex].Cells["DOB"].Value.ToString();
            Salary_txt.Text = DGV_employee.Rows[e.RowIndex].Cells["Salary"].Value.ToString();
        }

        string method;

        private void insert_btn_Click(object sender, EventArgs e)
        {
            name_txt.Visible = true;
            email_txt.Visible = true;
            phone_txt.Visible = true;
            address_txt.Visible = true;
            job_txt.Visible = true;
            DOB_txt.Visible = true;
            Salary_txt.Visible = true;
            pass_txt.Visible = true;
            passcon_txt.Visible = true;
            Save_btn.Visible = true;
            Cancel_btn.Visible = true;
            name_lbl.Visible = true;
            email_lbl.Visible = true;
            phone_lbl.Visible = true;
            address_lbl.Visible = true;
            job_lbl.Visible = true;
            DOB_lbl.Visible = true;
            Salary_lbl.Visible = true;
            pass_lbl.Visible = true;
            passcon_lbl.Visible = true;

            method = "Insert";
            return;

        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            method = "Update";

            name_txt.Visible = true;
            email_txt.Visible = true;
            phone_txt.Visible = true;
            address_txt.Visible = true;
            job_txt.Visible = true;
            DOB_txt.Visible = true;
            Salary_txt.Visible = true;
            pass_txt.Visible = true;
            passcon_txt.Visible = true;
            Save_btn.Visible = true;
            Cancel_btn.Visible = true;
            name_lbl.Visible = true;
            email_lbl.Visible = true;
            phone_lbl.Visible = true;
            address_lbl.Visible = true;
            job_lbl.Visible = true;
            DOB_lbl.Visible = true;
            Salary_lbl.Visible = true;
            pass_lbl.Visible = true;
            passcon_lbl.Visible = true;


        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            method = "Delete";

            name_txt.Visible = true;
            email_txt.Visible = true;
            phone_txt.Visible = true;
            address_txt.Visible = true;
            job_txt.Visible = true;
            DOB_txt.Visible = true;
            Salary_txt.Visible = true;
            pass_txt.Visible = true;
            passcon_txt.Visible = true;
            Save_btn.Visible = true;
            Cancel_btn.Visible = true;
            name_lbl.Visible = true;
            email_lbl.Visible = true;
            phone_lbl.Visible = true;
            address_lbl.Visible = true;
            job_lbl.Visible = true;
            DOB_lbl.Visible = true;
            Salary_lbl.Visible = true;
            pass_lbl.Visible = true;
            passcon_lbl.Visible = true;

        }

        private void Save_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(name_txt.Text)
                && !string.IsNullOrEmpty(email_txt.Text)
                && !string.IsNullOrEmpty(phone_txt.Text)
                && !string.IsNullOrEmpty(address_txt.Text)
                && !string.IsNullOrEmpty(job_txt.Text)
                && !string.IsNullOrEmpty(DOB_txt.Text)
                && !string.IsNullOrEmpty(Salary_txt.Text)
                && !string.IsNullOrEmpty(pass_txt.Text)
                && !string.IsNullOrEmpty(passcon_txt.Text)
                )
            {
                if (method == "Insert")
                {
                    MessageBox.Show("Insert");
                    if (pass_txt.Text == passcon_txt.Text)
                    {
                       
                        string sql_insert = "INSERT INTO employee " +
                        "(id_job, name_employee, email_employee, address_employee, phone_number_employee,salary_employee, password_employee, date_of_birth_employee)" +
                        "VALUES ('" + job_txt.Text + "','" + name_txt.Text + "','" + email_txt.Text + "','" + address_txt.Text + "','" + phone_txt.Text + "','" + Salary_txt.Text + "', '" + pass_txt.Text + "', 2008-05-15 12:30:20.000)";

                            SqlCommand cmd = new SqlCommand(sql_insert, cnn);

                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            cnn.Close();

                            MessageBox.Show("INSERT DATA BERHASIL");
                    }
                    else
                    {
                        MessageBox.Show("Password Tidak Sama");
                    }
                }

                else if (method == "Update")
                {
                    MessageBox.Show("Update");
                }
            }
            else if (method == "Delete")
            {
                
            }
            else
            {
                MessageBox.Show("Tolong Isi Semua Kolom");
            }

            
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            name_txt.Visible = false;
            email_txt.Visible = false;
            phone_txt.Visible = false;
            address_txt.Visible = false;
            job_txt.Visible = false;
            DOB_txt.Visible = false;
            Salary_txt.Visible = false;
            pass_txt.Visible = false;
            passcon_txt.Visible = false;
            Save_btn.Visible = false;
            Cancel_btn.Visible = false;
            name_lbl.Visible = false;
            email_lbl.Visible = false;
            phone_lbl.Visible = false;
            address_lbl.Visible = false;
            job_lbl.Visible = false;
            DOB_lbl.Visible = false;
            Salary_lbl.Visible = false;
            pass_lbl.Visible = false;
            passcon_lbl.Visible = false;
        }
    }
}
