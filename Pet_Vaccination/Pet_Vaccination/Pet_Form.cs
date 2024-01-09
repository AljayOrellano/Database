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
    public partial class Pet_Form : Form
    {
        public Pet_Form()
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
            InfoDB.saveUpdateDeleteData("INSERT INTO `pet_info`(`Pet_Id`, `Pet_Name`, `Pet_Owner`, `Gender`) VALUES ('" + InfoStorage.infoSet.maxId + "','" + tbxName.Text + "','" + tbxOwner.Text + "','" + cbxGender.Text + "')", "Saved");
            this.Close();
            Mainform back = new Mainform();
            back.Show();
        }

        private void Pet_Form_Load(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("SELECT * FROM `pet_info`", dgvView);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("UPDATE `pet_info` SET `Pet_Id`='tbxId.Text',`Pet_Name`='tbxName.Text',`Pet_Owner`='tbxOwner.Text',`Gender`='cbxGender' WHERE 1", dgvView);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            InfoDB.saveUpdateDeleteData("DELETE FROM `pet_info` WHERE `pet_info` =" + tbxId.Text, "Delete");

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InfoDB.dgvViewing("SELECT * FROM `pet_info` where Name like '%" + tbxSearch.Text + "%'", dgvView);

        }

        private void dgvView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            InfoStorage.infoSet.furnitureId = int.Parse(dgvView.Rows[e.RowIndex].Cells[0].Value.ToString());
            tbxSearch.Text = (dgvView.Rows[e.RowIndex].Cells[2].Value.ToString());

        }
    }
}