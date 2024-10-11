using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentLates
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void DisplayData()
        {
            clsDBConnector dbConnector = new clsDBConnector();
            OleDbDataReader dr;
            string sqlStr;
            dbConnector.Connect();
            sqlStr = "SELECT studentID, firstName, surName, studentDOB FROM tblStudent";
            dr = dbConnector.DoSQL(sqlStr);
            lstVStudents.Items.Clear();
            while (dr.Read())
            {
                lstVStudents.Items.Add(dr[0].ToString());
                lstVStudents.Items[lstVStudents.Items.Count - 1].SubItems.Add(dr[1].ToString());
                lstVStudents.Items[lstVStudents.Items.Count - 1].SubItems.Add(dr[2].ToString());
                lstVStudents.Items[lstVStudents.Items.Count - 1].SubItems.Add(dr[3].ToString());
            }
            dbConnector.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmStudent studentForm = new frmStudent();
            studentForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmStudentLatesV1 lateForm = new frmStudentLatesV1();
            lateForm.Show();
        }
    }
}
