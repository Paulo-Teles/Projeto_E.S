using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationAndLogin
{
    public partial class Registration : Form
    {


        public Registration()
        {
            InitializeComponent();
        }

        public void ClearTable(DataTable table)
        {
            try
            {
                table.Clear();
            }
            catch (DataException e)
            {
                // Process exception and return.
                Console.WriteLine("Exception of type {0} occurred.",
                    e.GetType());
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (txtconfirmpassword.Text != string.Empty && txtpassword.Text != string.Empty && txtusername.Text != string.Empty && txtaddress.Text != string.Empty && txtfirstname.Text != string.Empty && txtlastname.Text != string.Empty && txtphonenumber.Text != string.Empty && BornDate.Text != string.Empty && txtcc.Text != string.Empty)
            {
                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    if (Utente.Checked)
                        try
                        {
                            using (var ctx = new EFContext())
                            {
                                UserFactory factory = null;
                                factory = new Utente(txtusername.Text, txtpassword.Text, txtaddress.Text, txtfirstname.Text, txtlastname.Text, txtphonenumber.Text, BornDate.Value, txtcc.Text);
                                Utente utente = new Utente(txtusername.Text, txtpassword.Text, txtaddress.Text, txtfirstname.Text, txtlastname.Text, txtphonenumber.Text, BornDate.Value, txtcc.Text);
                                ctx.Utentes.Add(utente);
                                ctx.SaveChanges();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Erro ao criar utente");
                            Console.WriteLine(ex.Message);
                        }
                    else
                    {
                        try
                        {
                            using (var ctx = new EFContext())
                            {
                                Terapeuta terapeuta = new Terapeuta() { FirstName = txtfirstname.Text, Lastname = txtlastname.Text, Address = txtaddress.Text, Borndate = BornDate.Value, CC = txtcc.Text, Password = txtpassword.Text, Phonenumber = txtphonenumber.Text, Username = txtusername.Text };
                                ctx.Terapeutas.Add(terapeuta);
                                ctx.SaveChanges();
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Erro ao criar terapeuta");
                            Console.WriteLine(ex.Message);
                        }
                    }
                    MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            BornDate.Format = DateTimePickerFormat.Custom;
            BornDate.CustomFormat = "dd/MM/yyyy";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
