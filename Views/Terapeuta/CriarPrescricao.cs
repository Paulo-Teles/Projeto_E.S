using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationAndLogin
{
    public partial class CriarPrescricao : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public CriarPrescricao()
        {
            InitializeComponent();
        }

        private void CriarPrescricao_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\Desktop\Projeto_E.S\Database.mdf;Integrated Security=True");
            cn.Open();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty || textBox3.Text != string.Empty || textBox4.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    cmd.CommandText = "SELECT type FROM LoginTable WHERE username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                    string str = Convert.ToString(cmd.ExecuteScalar());
                    if (str.Equals("Utente"))
                    {
                        dr.Close();
                        Utente_Home home = new Utente_Home();
                        home.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        Terapeuta_Home home = new Terapeuta_Home();
                        home.ShowDialog();
                    }
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account available with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
