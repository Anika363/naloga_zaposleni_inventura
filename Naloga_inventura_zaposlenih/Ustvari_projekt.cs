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
    public partial class Ustvari_projekt : Form
    {
        public Ustvari_projekt()
        {
            InitializeComponent();
        }

        private void Ustvari_projekt_Load(object sender, EventArgs e)
        {

        }

        private void btn_ustvari_Click(object sender, EventArgs e)
        {
            string ime = ime_projekta.Text;
            string opis = opis_projekta.Text;
            string connString = "Host=ep-cool-hall-a2mhk856-pooler.eu-central-1.aws.neon.tech;Port=5432;Username=evidenca_owner;Password=ERlImXbW0OP2;Database=evindeca;SSL Mode=Require;Trust Server Certificate=true;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT dodaj_projekt(@ime, @opis)", connection))
                {
                    cmd.Parameters.AddWithValue("@ime", ime);
                    cmd.Parameters.AddWithValue("@opis", opis);

                    try
                    {
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            pogled pog = new pogled();
                            pog.Show();
                            this.Hide();
                            MessageBox.Show("dodano med projekte");
                        }
                    }
                    catch (Exception ex)
                    {
                        //Console.WriteLine("Error executing function: " + ex.Message);
                        MessageBox.Show("Error executing function: " + ex.Message);
                    }
                }

                connection.Close();
                //ce ne dela je to tezava
                pogled novo = new pogled();
                novo.Show();
                this.Hide();
            }
        }

        private void btn_nazaj_Click(object sender, EventArgs e)
        {
            pogled pog = new pogled();
            pog.Show();
            this.Hide();
        }

        private void ime_projekta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
