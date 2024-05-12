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
    public partial class Postavi_vodjo : Form
    {
        public Postavi_vodjo()
        {
            InitializeComponent();
            ReadDB();
            Db();
        }

        private void Postavi_vodjo_Load(object sender, EventArgs e)
        {

        }
            string projekt ;
            string name;
            string surname;
        int zaposlen;
        int id;
        int pro;
        List<string> list = new List<string>();
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
                                Console.WriteLine(reader.GetString(1));
                                Console.WriteLine(reader.GetString(2)); //sola
                                                                        //Console.WriteLine(reader.GetString(6)); //kraj is set to null
                                                                        // Console.WriteLine(reader.GetString(7));
                                string vse = reader.GetInt32(0) + "|" + reader.GetString(1) + "|" + reader.GetString(2) ;
                                Console.WriteLine(vse);
                                list.Add(vse);
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
            foreach (string item in list)
            {
                listbox_zaposlenih.Items.Add(item);
            }
        }
        List<string> proj = new List<string>();
        void Db()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Host=ep-cool-hall-a2mhk856-pooler.eu-central-1.aws.neon.tech;Username=evidenca_owner;Password=ERlImXbW0OP2;Database=evindeca;SSL Mode=Require;"))
            {
                connection.Open();

                // da dobis podatke
                string sqlQuery = "SELECT * FROM projekti_pogled_vse";

                using (NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection))
                {
                    try
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string fullName = $"{reader["ime"]}" ;
                                Console.WriteLine(fullName);
                                //dataList.Add(fullName);
                                Console.WriteLine(reader.GetInt32(0));
                                Console.WriteLine(reader.GetString(1));
                                string vse = reader.GetInt32(0) + "|" + reader.GetString(1) ;
                                pro = reader.GetInt32(0);
                                Console.WriteLine(vse);
                                proj.Add(vse);
                            }
                            command.Dispose();
                        }
                        connection.Close();
                        addNamesToprojekti();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ReadDB error\n" + ex.Message + "\n" + ex.StackTrace);

                    }
                }

            }
        }
        void addNamesToprojekti()
        {
            foreach (string item in proj)
            {
                listbox_projektov.Items.Add(item);
            }
        }
        private void btn_nastavi_Click(object sender, EventArgs e)
        {


            // Connection string for Npgsql
            string connString = "Host=ep-cool-hall-a2mhk856-pooler.eu-central-1.aws.neon.tech;Username=evidenca_owner;Password=ERlImXbW0OP2;Database=evindeca;SSL Mode=Require;";

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                connection.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand("SELECT dobi_vodjo_pravi(@id_zaposleni, @id_projekta)", connection))
                {
                        string selectedFullName = listbox_zaposlenih.SelectedItem.ToString();
                        string selectedprojekt = listbox_projektov.SelectedItem.ToString();
                        Console.WriteLine(selectedprojekt);
                        Console.WriteLine(selectedFullName);

                        // Split the full name into parts (assuming space separates Name and Surname)
                        string[] parts = selectedFullName.Split('|');
                        Console.WriteLine(parts[0]);
                        string[] deli = selectedprojekt.Split('|');

                        if (parts.Length >= 2)
                        {
                            zaposlen= int.Parse(parts[0]);
                            id =int.Parse(deli[0]);
                            Console.WriteLine("Z: " + zaposlen);
                            Console.WriteLine("P: " + id);
                            cmd.Parameters.AddWithValue("@id_zaposleni", zaposlen);
                            cmd.Parameters.AddWithValue("@id_projekta", id);

                            try
                            {
                                // Execute the command
                                var result = cmd.ExecuteScalar();
                            // Handle the result
                            MessageBox.Show("vstavljeno");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error executing function: " + ex.Message);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid format for full name.");
                        MessageBox.Show("No item selected!");
                        }

                        connection.Close();
                }
            }
        }

        private void listbox_zaposlenih_SelectedIndexChanged(object sender, EventArgs e)
        {


           
            string selectedUser = listbox_zaposlenih.Items[listbox_zaposlenih.SelectedIndex].ToString();
            string[] userData = selectedUser.Split('|');
            zaposlen = int.Parse(userData[0]);
            name = userData[1];
            surname = userData[2];


        }
        /* void addNamesToListBox()
         {
             foreach (string item in dataList)
             {
                 listbox_zaposlenih.Items.Add(item);
             }
         }*/

        private void listbox_projektov_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedUser = listbox_projektov.Items[listbox_projektov.SelectedIndex].ToString();
            string[] userData = selectedUser.Split('|');
            pro = int.Parse(userData[0]);
            projekt = userData[1];


        }
        /*void addProjektToListBox()
        {
            foreach (string item in dataList)
            {
                listbox_projektov.Items.Add(item);
            }
        }*/
    }
}
