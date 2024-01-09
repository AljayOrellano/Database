using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Vaccination
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            bool checker = InfoDB.GetAdminPassword(tbxUsername, tbxPassword);

            if (checker)
            {
                Mainform login = new Mainform();
                login.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("LOG IN FAILED");
            }
        }

       
        }
    }

