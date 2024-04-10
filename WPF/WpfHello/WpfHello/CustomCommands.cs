using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;

namespace WpfHello
{
    class CustomCommands
    {
        public static RoutedUICommand Launch { get; }
        static CustomCommands()
        {
            var myInputGestures = new InputGestureCollection
            {
                new KeyGesture(Key.L, ModifierKeys.Control)
            };
            Launch = new RoutedUICommand("Запуск", "Launch", typeof(CustomCommands), myInputGestures);
        }
    }
}
