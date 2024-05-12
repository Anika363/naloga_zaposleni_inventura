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
    public partial class pogled : Form
    {
        public pogled()
        {
            InitializeComponent();
            ReadDB();
        }

        private void ust_pro_btn_Click(object sender, EventArgs e)
        {
            Ustvari_projekt ust = new Ustvari_projekt();
            ust.Show();
            this.Hide();
        }

        private void podaj_vodji_btn_Click(object sender, EventArgs e)
        {
            Postavi_vodjo pos = new Postavi_vodjo();
            pos.Show();
            this.Hide();
        }
        List<string> dataList = new List<string>();
        void ReadDB()
        {

            using (NpgsqlConnection connection = new NpgsqlConnection("Host=ep-cool-hall-a2mhk856-pooler.eu-central-1.aws.neon.tech;Username=evidenca_owner;Password=ERlImXbW0OP2;Database=evindeca;SSL Mode=Require;"))
            {
                connection.Open();

                // da dobis podatke
                string sqlQuery = "SELECT * FROM pogled_zapo";
                using (NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string fullName = $"{reader["ime"]} {reader["priimek"]}";
                                Console.WriteLine(fullName);
                                //dataList.Add(fullName);
                                Console.WriteLine(reader.GetInt32(0));
                                Console.WriteLine(reader.GetString(3)); //gmail
                                Console.WriteLine(reader.GetString(4)); //geslo
                                Console.WriteLine(reader.GetString(5)); //sola
                                                                        //Console.WriteLine(reader.GetString(6)); //kraj is set to null
                                                                        // Console.WriteLine(reader.GetString(7));
                                string vse = reader.GetInt32(0) + "|" + reader.GetString(1) + "|" + reader.GetString(2) + "|" + reader.GetString(3) + "|" + reader.GetString(4) + "|" + reader.GetString(5);
                                Console.WriteLine(vse);
                                dataList.Add(vse);
                            }
                            command.Dispose();
                        }
                        connection.Close();
                        addNamesToListBox();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ReadDB error\n" + ex.Message + "\n" + ex.StackTrace);

                    }
                }

            }
        }
            void addNamesToListBox()
            {
                foreach (string item in dataList)
                {
                    listBox1_zapo.Items.Add(item);
                }
            }

            private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedUser = listBox1_zapo.Items[listBox1_zapo.SelectedIndex].ToString();
            string[] userData = selectedUser.Split('|');
            id_lab.Text = userData[0];
            ime_text.Text = userData[1];
            priimek_text.Text = userData[2];
            email_text.Text = userData[3];
            geslo_text.Text = userData[4];
            sola_text.Text = userData[5];
            //kraj_text.Text = userData[6];
        }

        private void kraj_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void uredi_btn_Click(object sender, EventArgs e)
        {
            string connString = "Host=ep-cool-hall-a2mhk856-pooler.eu-central-1.aws.neon.tech;Username=evidenca_owner;Password=ERlImXbW0OP2;Database=evindeca;SSL Mode=Require;";
            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT update_zapo(@id, @ime, @priimek, @email, @geslo, @sola, @kraj)", connection))
                {
                    cmd.Parameters.AddWithValue("@id", int.Parse(id_lab.Text));
                    Console.WriteLine(int.Parse(id_lab.Text));
                    cmd.Parameters.AddWithValue("@ime", ime_text.Text);
                    cmd.Parameters.AddWithValue("@priimek", priimek_text.Text);
                    cmd.Parameters.AddWithValue("@email", email_text.Text);
                    cmd.Parameters.AddWithValue("@geslo", geslo_text.Text);
                    cmd.Parameters.AddWithValue("@sola", sola_text.Text);
                    cmd.Parameters.AddWithValue("@kraj", kraj_text.Text);

                    try
                    {
                        var result = cmd.ExecuteScalar();
                        Console.WriteLine("result: " + result);
                        if (result != null)
                        {
                            Console.WriteLine("Test");
                            MessageBox.Show("Record updated successfully!");
                            // Refresh the form or update UI as needed
                        }
                    }
                    catch (PostgresException ex)
                    {
                        Console.WriteLine("SQL error: " + ex.Message);
                        Console.WriteLine("Error code: " + ex.SqlState);
                        Console.WriteLine("Error detail: " + ex.Detail);
                        MessageBox.Show("Error updating record: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                connection.Close();
            }
        }

        private void izbr_btn_Click(object sender, EventArgs e)
        {
            string connString = "Host=ep-cool-hall-a2mhk856-pooler.eu-central-1.aws.neon.tech;Username=evidenca_owner;Password=ERlImXbW0OP2;Database=evindeca;SSL Mode=Require;";
            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT izbrisi_zapo_prav(@id_uporabnika)", connection))
                {
                    cmd.Parameters.AddWithValue("@id_uporabnika", int.Parse(id_lab.Text));
                    Console.WriteLine("id" + int.Parse(id_lab.Text));

                    try
                    {
                        var result = cmd.ExecuteScalar();
                        if (result != null)
                        {
                            MessageBox.Show("Record deleted successfully!");
                            // Refresh the form or update UI as needed
                        }
                    }
                    catch (PostgresException ex)
                    {
                        Console.WriteLine("SQL error: " + ex.Message);
                        Console.WriteLine("Error code: " + ex.SqlState);
                        Console.WriteLine("Error detail: " + ex.Detail);
                        MessageBox.Show("Error deleting record: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
                Console.WriteLine("nic ni bilo");
                connection.Close();
            }
        }
    }
}
