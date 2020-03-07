using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form, ICalculator
    {
        Double result = 0;
        Double memoryValue = 0;
        String operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void ClickNumber(object sender, EventArgs e)
        {
            if (ResultBox.Text == "0")
                ResultBox.Clear();
            Button button = (Button)sender;
            ResultBox.Text += button.Text;
        }

        public void TrigonometryOperation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(ResultBox.Text);
            ResultBox.Clear();
            ResultBox.Text += button.Text + result;

        }
        public void SqrtOperation(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(ResultBox.Text);
            ResultBox.Clear();
            ResultBox.Text += button.Text + result;
        }
        public void Exponentiating(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(ResultBox.Text);
            ResultBox.Text += button.Text;
        }
        public void CleanBox(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
            memoryValue = 0;
            result = 0;
        }
        public void CleanEntryBox(object sender, EventArgs e)
        {
            ResultBox.Text = "0";
        }
        public void MemorySaveClick(object sender, EventArgs e)
        {
            memoryValue= Double.Parse(ResultBox.Text);
        }
        public void MemoryReadClick(object sender, EventArgs e)
        {
            result = memoryValue;
            ResultBox.Text = result.ToString();
        }

        public void GetResult(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "sin":
                    ResultBox.Clear();
                    ResultBox.Text = (Math.Sin((result * 3.14) / 180)).ToString();
                    break;
                case "cos":
                    ResultBox.Clear();
                    ResultBox.Text = (Math.Cos((result * 3.14) / 180)).ToString();
                    break;
                case "tg":
                    ResultBox.Clear();
                    ResultBox.Text = (Math.Tan((result * 3.14) / 180)).ToString();
                    break;
                case "ctg":
                    ResultBox.Clear();
                    ResultBox.Text = (1 / Math.Tan((result * 3.14) / 180)).ToString();
                    break;
                case "√":
                    ResultBox.Clear();
                    ResultBox.Text = (Math.Sqrt(result)).ToString();
                    break;
                case "∛":
                    ResultBox.Clear();
                    ResultBox.Text = (Math.Pow(result, 1 / 3.0)).ToString();
                    break;
                case "∜":
                    ResultBox.Clear();
                    ResultBox.Text = (Math.Pow(result, 1 / 4.0)).ToString();
                    break;
                case "²":
                    ResultBox.Clear();
                    ResultBox.Text = (Math.Pow(result, 2.0)).ToString();
                    break;
                case "³":
                    ResultBox.Clear();
                    ResultBox.Text = (Math.Pow(result, 3.0)).ToString();
                    break;
                case "⁴":
                    ResultBox.Clear();
                    ResultBox.Text = (Math.Pow(result,4.0)).ToString();
                    break;
            }
        }
    }
}
