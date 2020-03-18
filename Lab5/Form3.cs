using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DataTable accountdata = new DataTable();
            accountdata.Columns.Add("Number");
            accountdata.Columns.Add("Type");
            accountdata.Columns.Add("Balance");
            accountdata.Columns.Add("Creation Date");
            accountdata.Columns.Add("Sms");
            accountdata.Columns.Add("Banking");
            accountdata.Columns.Add("Owner");

            Form1 form1 = (Form1)ActiveForm;
            foreach (Account acc in form1.accountslist)
            {
                accountdata.Rows.Add(acc.Number, acc.Type, acc.Balance, acc.CreationDate, acc.Sms, acc.Banking, acc.Owner);
            }
            dataGridView1.DataSource = accountdata;

            DataTable ownerdata = new DataTable();
            ownerdata.Columns.Add("ID");
            ownerdata.Columns.Add("FIO");
            ownerdata.Columns.Add("Birth date");
            ownerdata.Columns.Add("Passport number");
            ;
            foreach (Form2.Owner p in form1.ownerslist)
            {
                ownerdata.Rows.Add(p.ID, p.FIO, p.BirthDate, p.PassportNumber);
            }

            dataGridView2.DataSource = ownerdata;


        }
    }
}
