using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Laba9_WPF
{
    class MyCommands
    {
        public static RoutedCommand Exit { get; set; }
        public static RoutedCommand Tolshina { get; set; }
        public static RoutedCommand Kursiv { get; set; }
        public static RoutedCommand Podcherknut { get; set; }
        public static RoutedCommand Red { get; set; }
        static MyCommands()
        {
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.T, ModifierKeys.Control, "Ctrl+T"));
            Exit = new RoutedUICommand("Выход", "Exit", typeof(MyCommands), inputs);
            Tolshina = new RoutedCommand();
            Kursiv = new RoutedCommand();
            Podcherknut = new RoutedCommand();
            Red = new RoutedCommand();
        }
    }
}
