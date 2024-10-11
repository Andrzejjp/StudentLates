using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StudentLates
{
    public partial class frmStudentLatesV1 : Form
    {
        public frmStudentLatesV1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewLate_Click(object sender, EventArgs e)
        {
            clsDBConnector dbConnector = new clsDBConnector();
            string cmdStr = $"INSERT INTO tblLate  (studentID,period, dateOfLate,minsLate) " +
                $"VALUES ('{txtStudentID}' , '{txtPeriod}', '{dtpDayOfLate}','{txtMinLate}')";
            dbConnector.Connect();
            dbConnector.DoDML(cmdStr);
            dbConnector.Close();
            (Application.OpenForms["Form1"] as Form1).DisplayData();
        }
    }
}
