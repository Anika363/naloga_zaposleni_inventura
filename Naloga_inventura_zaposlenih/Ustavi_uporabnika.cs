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
    public partial class Ustavi_uporabnika : Form
    {
        public Ustavi_uporabnika()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Ustavi_uporabnika_Load(object sender, EventArgs e)
        {

        }

        private void Ustvali_Click(object sender, EventArgs e)
        {
            string ime = ime_uporabnika.Text;
            string priimek = priimek_uporabnika.Text;
            string mail = email_uporabnika.Text;
            string geslo = geslo_uporabnika.Text;
            string sola = sola_uporabnika.Text;
            string kraj = kraj_uporabnika.Text;
            string connString = "Host=ep-cool-hall-a2mhk856-pooler.eu-central-1.aws.neon.tech;Port=5432;Username=evidenca_owner;Password=ERlImXbW0OP2;Database=evindeca;SSL Mode=Require;Trust Server Certificate=true;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT ustvari_uporabnika(@ime, @priimek, @mail, @geslo, @sola, @kraj)", connection))
                {
                    cmd.Parameters.AddWithValue("@ime", ime);
                    cmd.Parameters.AddWithValue("@priimek", priimek);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@geslo", geslo);
                    cmd.Parameters.AddWithValue("@sola", sola);
                    cmd.Parameters.AddWithValue("@kraj", kraj);

                    try
                    {
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            pogled pog = new pogled();
                            pog.Show();
                            this.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine("Error executing function: " + ex.Message);
                        MessageBox.Show("Error executing function: " + ex.Message);
                    }
                }
            
            connection.Close();
            }

        }

        private void nazaj_btn_Click(object sender, EventArgs e)
        {
           Form  fr = new Form ();
            fr.Show();
            this.Hide();
        }
    }
}
