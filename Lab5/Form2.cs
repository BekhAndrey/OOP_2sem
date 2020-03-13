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
        public Owner owner { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void CreationDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SaveClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FIOField.Text) || string.IsNullOrEmpty(PassportField.Text))
            {
                MessageBox.Show("Пожалуйста, заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PassportField.Text.Length != 9)
            {
                MessageBox.Show("Номер паспорта должен состоять из 9 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (FIOField.Text.Length != 3)
            {
                MessageBox.Show("ФИО должно состоять из 3 символов", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                owner.FIO = FIOField.Text;
                owner.BirthDate = BirthField.Value;
                owner.PassportNumber = PassportField.Text;
                this.Close();
            }
        }

        private void ShowInfo(object sender, EventArgs e)
        {
            OwnerInfo.Text = $"Информация о владельце: \nФИО: {FIOField.Text} \nДата рождения: {BirthField.Value}\nНомер паспорта: {PassportField.Text}";
        }
    }
}
