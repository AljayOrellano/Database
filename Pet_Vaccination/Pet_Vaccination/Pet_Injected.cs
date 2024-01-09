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
    public partial class Pet_Injected : Form
    {
        public Pet_Injected()
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
            InfoDB.saveUpdateDeleteData("INSERT INTO `pet_injected`(`Pet_id`, `Pet_name`, `Vaccine_name`, `Dose`, `Date_injected`) VALUES ('" + InfoStorage.infoSet.maxId + "','" + tbxName.Text + "','" + cbxVaccine.Text+ "','" + cbxDose.Text + "','" + dtpDate.Value.ToString() + "')", "Saved");
            this.Close();
            Mainform back = new Mainform();
            back.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            InfoDB.saveUpdateDeleteData("DELETE FROM `pet_injected` WHERE `pet_injected` =" + tbxId.Text, "Delete");

        }

        private void Pet_Injected_Load(object sender, EventArgs e)
        {

            InfoDB.dgvViewing("SELECT * FROM `pet_injected`", dgvView);

        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            InfoStorage.infoSet.furnitureId = int.Parse(dgvView.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbxSearch.Text = (dgvView.Rows[e.RowIndex].Cells[2].Value.ToString());

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("SELECT * FROM `pet_injected` where Name like '%" + tbxSearch.Text + "%'", dgvView);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("UPDATE `pet_injected` SET `Pet_id`='tbxId.Text',`Pet_name`='tbxName.Text',`Vaccine_name`='cbxVaccine.Text',`Dose`='cbxDose.Text',`Date_injected`='dtpDate.Text' WHERE 1", dgvView);
        }
    }
}
