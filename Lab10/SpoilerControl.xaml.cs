using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для SpoilerControl.xaml
    /// </summary>
    public partial class SpoilerControl : UserControl
    {


        public string Secret
        {
            get { return (string)GetValue(SecretProperty); }
            set { SetValue(SecretProperty, value); }
        }

        FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();

        public static readonly DependencyProperty SecretProperty = 
            DependencyProperty.Register("Secret", typeof(string), typeof(SpoilerControl), new PropertyMetadata("Message"), new ValidateValueCallback(ValidateValue));

        private static bool ValidateValue(object value)
        {

            string currentValue = (string)value;
            if (!currentValue.Contains("$") || currentValue == null)
                return true;
            return false;
        }
        //private static object CorrectValue(DependencyObject d, object baseValue)
        //{
        //    string currentValue = (string)baseValue;
        //    if (currentValue == "Sercet word")
        //        return "***********";
        //    return currentValue;
        //}



        // Provide CLR accessors for the event
        public event RoutedEventHandler Clicked
        {
            add { AddHandler(ClickedEvent, value); }
            remove { RemoveHandler(ClickedEvent, value); }
        }

        // Using a RoutedEvent
        public static readonly RoutedEvent ClickedEvent = EventManager.RegisterRoutedEvent(
            "Clicked", RoutingStrategy.Bubble, typeof(RoutedEventHandler), typeof(SpoilerControl));



        public event RoutedEventHandler Click
        {
            add
            {
                AddHandler(ClickedEvent, value);
            }
            remove
            {
                RemoveHandler(ClickedEvent, value);
            }
        }


        // Provide CLR accessors for the event
        public event RoutedEventHandler Downed
        {
            add { AddHandler(DownedEvent, value); }
            remove { RemoveHandler(DownedEvent, value); }
        }

        // Using a RoutedEvent
        public static readonly RoutedEvent DownedEvent = EventManager.RegisterRoutedEvent(
            "MyEvent", RoutingStrategy.Tunnel, typeof(RoutedEventHandler), typeof(SpoilerControl));

        public event RoutedEventHandler MouseDown
        {
            add
            {
                AddHandler(DownedEvent, value);
            }
            remove
            {
                RemoveHandler(DownedEvent, value);
            }
        }


        public SpoilerControl()
        {
            InitializeComponent();
        }
        bool result = true;
        private void Spoiler_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("sender: " + sender.ToString());
            if (result)
            {
                box.Visibility = Visibility.Visible;
            }
            else
            {
                box.Visibility = Visibility.Hidden;
            }
            result = !result;
        }
    }
}
