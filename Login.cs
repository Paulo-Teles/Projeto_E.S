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
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pedro\Downloads\RegistrationAndLogin\Projeto_E.S\Database.mdf;Integrated Security=True");
            cn.Open();
        }

        private void Btnregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "' and password='"+txtpassword.Text+"'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    cmd.CommandText = "SELECT type FROM LoginTable WHERE username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                    string str = Convert.ToString(cmd.ExecuteScalar());
                    if (str.Equals("Utente"))
                    {
                        cmd.CommandText = "SELECT firstname FROM LoginTable WHERE username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                        string firstname = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = "SELECT lastname FROM LoginTable WHERE username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                        string lastname = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = "SELECT cc FROM LoginTable WHERE username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                        string cc = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = "SELECT address FROM LoginTable WHERE username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                        string address = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = "SELECT borndate FROM LoginTable WHERE username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                        string borndate = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = "SELECT phonenumber FROM LoginTable WHERE username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                        string phonenumber = Convert.ToString(cmd.ExecuteScalar());

                        Utente_Home home = new Utente_Home();
                        Utente utente = new Utente(firstname,lastname,cc, borndate, address, phonenumber);
                        dr.Close();
                        home.ShowDialog();
                    }
                    else
                    {
                        cmd.CommandText = "SELECT firstname FROM LoginTable WHERE username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                        string firstname = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = "SELECT lastname FROM LoginTable WHERE username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                        string lastname = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = "SELECT cc FROM LoginTable WHERE username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                        string cc = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = "SELECT address FROM LoginTable WHERE username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                        string address = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = "SELECT borndate FROM LoginTable WHERE username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                        string borndate = Convert.ToString(cmd.ExecuteScalar());
                        cmd.CommandText = "SELECT phonenumber FROM LoginTable WHERE username='" + txtusername.Text + "' and password='" + txtpassword.Text + "'";
                        string phonenumber = Convert.ToString(cmd.ExecuteScalar());

                        Terapeuta_Home home = new Terapeuta_Home();
                        Terapeuta terapeuta = new Terapeuta(firstname, lastname, cc, borndate, address, phonenumber);
                        dr.Close();
                        home.ShowDialog();
                    }
                }
                else
                {
                    //dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
        }

    }
}
