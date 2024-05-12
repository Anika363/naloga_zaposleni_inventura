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
using Npgsql;

namespace Naloga_inventura_zaposlenih
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Vpis_btn_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Host=ep-cool-hall-a2mhk856-pooler.eu-central-1.aws.neon.tech;Port=5432;Username=evidenca_owner;Password=ERlImXbW0OP2;Database=evindeca;SSL Mode=Require;Trust Server Certificate=true;"))
            {
                Console.WriteLine("here " + connection.Database);
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT check_user_exists_exsist (@username, @geslo_uporabnik)", connection))
                {
                    Console.WriteLine("here2 " + connection.UserName);
                    cmd.Parameters.AddWithValue("@username", textBox1.Text);
                    cmd.Parameters.AddWithValue("@geslo_uporabnik", textBox2.Text);

                    try
                    {
                        var result = cmd.ExecuteScalar();
                        Console.WriteLine("result " + result);
                        if (result != null)
                        {

                            pogled pog = new pogled();
                            pog.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("loggin error\n" + ex.Message + "\n" + ex.StackTrace);

                    }
                }
                connection.Close();
            }
        }

        private void ustvari_upr_Click(object sender, EventArgs e)
        {
            Ustavi_uporabnika ust = new Ustavi_uporabnika();
            ust.Show();
            this.Hide();
        }
    }
}
