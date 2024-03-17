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

namespace Naloga_inventura_zaposlenih
{
    public partial class Login : Form
    {
        SqlConnection conn;
        public Login()
        {
            InitializeComponent();
            conn = new SqlConnection( "inventura.cvc0og42isdz.eu-north-1.rds.amazonaws.com");

        }



private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
