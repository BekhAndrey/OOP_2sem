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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        public List<Owner> Owners = new List<Owner>();
        [Serializable]
        public class Owner
        {
            public int ID;
            public string FIO;
            public DateTime BirthDate;
            public string PassportNumber;
            public Owner(int id,string fio, DateTime birthdate, string passportnumber)
            {
                this.ID = id;
                this.FIO = fio;
                this.BirthDate = birthdate;
                this.PassportNumber = passportnumber;
            }
            public Owner() { }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void CreationDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SaveClick(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(IdField.Text)||String.IsNullOrEmpty(FIOField.Text)||String.IsNullOrEmpty(PassportField.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Owners.Add(new Owner(Int32.Parse(IdField.Text), FIOField.Text, BirthField.Value, PassportField.Text));
                Close();
            }
        }


        private void IdField_Leave(object sender, EventArgs e)
        {
            if ((IdField.Text.Length < 3 && IdField.Text.Length > 0) || IdField.Text.Contains(" "))
            {
                MessageBox.Show("Индентификатор должен состять из 3 цифр", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FIOField_Leave(object sender, EventArgs e)
        {
            if ((FIOField.Text.Length < 3 && FIOField.Text.Length > 0) || FIOField.Text.Contains(" "))
            {
                MessageBox.Show("ФИО должно состоять из 3 букв", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PassportField_Leave(object sender, EventArgs e)
        {
            if ((PassportField.Text.Length < 9 && PassportField.Text.Length > 0) || PassportField.Text.Contains(" "))
            {
                MessageBox.Show("Номер паспорта должен состоять из 9 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
