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
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();
        }

        private void btnPet_Click(object sender, EventArgs e)
        {
            this.Close();
           Pet_Form back = new Pet_Form();
            back.Show();

        }

        private void btnInjected_Click(object sender, EventArgs e)
        {
            this.Close();
            Pet_Injected back = new Pet_Injected();
            back.Show();
        }

        private void btnVaccine_Click(object sender, EventArgs e)
        {
             this.Close();
           Pet_Vaccine back = new Pet_Vaccine();
            back.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {

        }
    }
}
