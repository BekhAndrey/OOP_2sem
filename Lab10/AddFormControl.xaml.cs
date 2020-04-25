using Laba7_8.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Laba7_8
{
    /// <summary>
    /// Логика взаимодействия для AddFormControl.xaml
    /// </summary>
    public partial class AddFormControl : UserControl
    {
        public ObservableCollection<TodoModel> modelList;
        public TodoModel tempModel;
        public AddFormControl()
        {
            InitializeComponent();
        }
        private void NewCommand_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (!Name.Text.Trim().Equals(string.Empty) && !Description.Text.Trim().Equals(string.Empty) && !Status.Text.Trim().Equals(string.Empty) && !Priority.Text.Trim().Equals(string.Empty))
            {
                tempModel = new TodoModel() { Status = Status.Text, Priority = Priority.Text, Name = Name.Text, Description = Description.Text };
                modelList.Add(tempModel);
            }
            Name.Text = "";
            Description.Text = "";
            Status.Text = "";
            Priority.Text = "";
        }
    }
}
