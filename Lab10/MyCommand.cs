using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Laba7_8
{
    public static class MyCommand
    {

        static RoutedUICommand blue = new RoutedUICommand("Set Blue", "SetBlue", typeof(MyCommand));

        public static RoutedUICommand SetBlue { get { return blue; } }

        static RoutedUICommand purple = new RoutedUICommand("Set Purple", "SetPurple", typeof(MyCommand));

        public static RoutedUICommand SetPurple { get { return purple; } }
    }
}
