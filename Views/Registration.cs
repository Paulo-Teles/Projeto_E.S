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

        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

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
           // cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\pedro\Downloads\RegistrationAndLogin\Projeto_E.S\Database.mdf;Integrated Security=True");
            //cn.Open();
        }

        private static void addUser()
        {
            Console.WriteLine("adding user ");
            User usr = new User() { Name = "Sachin", Email = "sachin@gmail.com" };
            try
            {
                using (var ctx = new EFContext())
                {
                    ctx.Users.Add(usr);
                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            if (txtconfirmpassword.Text != string.Empty && txtpassword.Text != string.Empty && txtusername.Text != string.Empty && txtaddress.Text != string.Empty && txtfirstname.Text != string.Empty && txtlastname.Text != string.Empty && txtphonenumber.Text != string.Empty && BornDate.Text != string.Empty && txtcc.Text != string.Empty)
            {

                if (txtpassword.Text == txtconfirmpassword.Text)
                {
                    Utente utente  = new Utente() { FirstName = "alalal", Lastname = "ahahaha", Address = "add", Borndate = DateTime.Now, CC = "ccc", Password = "pass", Phonenumber = "99933", Username = "eyyy" };
                    Terapeuta terapeuta = new Terapeuta() { FirstName = txtfirstname.Text, Lastname = txtlastname.Text, Address=txtaddress.Text, Borndate= BornDate.Value, CC=txtcc.Text, Password=txtpassword.Text, Phonenumber=txtphonenumber.Text, Username= txtusername.Text};
                    try
                    {
                        using (var ctx = new EFContext())
                        {
                            ctx.Utentes.Add(utente);
                            ctx.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("n deu");
                        Console.WriteLine(ex.Message);
                    }
                    try
                    {
                        using (var ctx2 = new EFContext())
                        {
                            ctx2.Terapeutas.Add(terapeuta);
                            ctx2.SaveChanges();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("n deu2");
                        Console.WriteLine(ex.Message);
                    }

                    /*
                    terapeuta.username = txtusername.Text.Trim();
                    terapeuta.password = txtpassword.Text.Trim();
                    terapeuta.address = txtaddress.Text.Trim();
                    terapeuta.firstname = txtfirstname.Text.Trim();
                    terapeuta.lastname = txtlastname.Text.Trim();
                    terapeuta.phonenumber = txtphonenumber.Text.Trim();
                    terapeuta.borndate = BornDate.Value;
                    terapeuta.cc = txtcc.Text.Trim();
                    using ( DatabaseEntities db = new DatabaseEntities())
                    {
                        db.TerapeutaTable.Add(terapeuta);
                        db.SaveChanges();
                    }
                    Console.WriteLine("done");
                    Application.Exit();
                    */
                    /*
                    cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        
                        cmd = new SqlCommand("insert into LoginTable values(@username,@password,@address,@firstname,@lastname,@phonenumber,@borndate,@type,@cc)", cn);
                        cmd.Parameters.AddWithValue("username", txtusername.Text);
                        cmd.Parameters.AddWithValue("password", txtpassword.Text);
                        cmd.Parameters.AddWithValue("address", txtaddress.Text);
                        cmd.Parameters.AddWithValue("firstname", txtfirstname.Text);
                        cmd.Parameters.AddWithValue("lastname", txtlastname.Text);
                        cmd.Parameters.AddWithValue("phonenumber", txtphonenumber.Text);
                        cmd.Parameters.AddWithValue("borndate", BornDate.Value);
                        cmd.Parameters.AddWithValue("cc", txtcc.Text);
                        */
                    /*
                        var context = new DatabaseEntities();
                        UtenteTable utente = new UtenteTable()
                        {
                            username = txtusername.Text,
                            password = txtpassword.Text,
                            address = txtaddress.Text,
                            firstname = txtfirstname.Text,
                            lastname = txtlastname.Text,
                            phonenumber = txtphonenumber.Text,
                            borndate = BornDate.Value,
                            cc = txtcc.Text
                        };
                        Console.WriteLine(utente.address);
                        Console.WriteLine("firstname " + utente.firstname.ToString());
                        context.UtenteTable.Add(utente);
                        context.SaveChanges();
                    */
                    /*
                        if (Utente.Checked)
                        {
                            cmd.Parameters.AddWithValue("type", "Utente");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("type", "Terapeuta");
                        }
                    */
                    //cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //}
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
    }
}
