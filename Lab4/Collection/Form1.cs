using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OOP_Lab01_2
{
    public partial class Form1 : Form
    {
        private static List<Person> collection;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputField_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenerateClick(object sender, EventArgs e)
        {
            try
            {
                collection = new List<Person>();
                int size = int.Parse(inputField.Text);

                Random rnd = new Random();
                if (listBox.Items.Count != 0)
                    listBox.Items.Clear();

                for (int i = 0; i < size; i++)
                    collection.Add(new Person(rnd.Next(10,30 )));

                foreach (Person item in collection)
                    listBox.Items.Add("Возраст: " + item.Age);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SortAscClick(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            collection.Sort();
            foreach (Person item in collection)
                listBox.Items.Add("Возраст: " + item.Age);
        }

        private void SortDescClick(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            collection.Sort();
            collection.Reverse();
            foreach (Person item in collection)
                listBox.Items.Add("Возраст: " + item.Age);
        }

        private void MaxClick(object sender, EventArgs e)
        {
            LinqBox.Items.Clear();
            LinqBox.Items.Add("Максимальный возраст: " + collection.Max().Age.ToString());
        }

        private void MinClick(object sender, EventArgs e)
        {
            LinqBox.Items.Clear();
            LinqBox.Items.Add("Максимальный возраст: " + collection.Min().Age.ToString());
        }

        private void RangeClick(object sender, EventArgs e)
        {
            LinqBox.Items.Clear();
            foreach (Person person in collection)
                if (person.Age > 20 && person.Age < 30)
                    LinqBox.Items.Add("Возраст: "+ person.Age.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
