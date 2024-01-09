using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Pet_Vaccination
{
    public partial class Pet_Vaccine : Form
    {
        public Pet_Vaccine()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Mainform back = new Mainform();
            back.Show();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InfoDB.saveUpdateDeleteData("INSERT INTO `vaccine`(`vaccine_number`, `vaccine_name`, `dose`)  VALUES ('" + tbxVaccineno.Text + "','" + cbxVaccine.Text + "','" + cbxDose.Text + "')", "Saved");
            this.Close();
            Mainform back = new Mainform();
            back.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            InfoDB.saveUpdateDeleteData("DELETE FROM `vaccine` WHERE `vaccine` =", "Delete");

        }

        private void Pet_Vaccine_Load(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("SELECT * FROM `vaccine`", dgvView);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("SELECT * FROM `vaccine` where Name like '%" + tbxSearch.Text + "%'", dgvView);

        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            InfoStorage.infoSet.furnitureId = int.Parse(dgvView.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbxSearch.Text = (dgvView.Rows[e.RowIndex].Cells[2].Value.ToString());

        }
    }
}
