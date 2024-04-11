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

namespace WpfUserControl
{
    /// <summary>
    /// Логика взаимодействия для ShowNumberControl.xaml
    /// </summary>
    public partial class ShowNumberControl : UserControl
    {
        //private int currNumber = 0;
        //public int CurrentNumber
        //{
        //    get { return currNumber; }
        //    set
        //    {
        //        currNumber = value;
        //        // Передаем в метку текущее значение
        //        numberDisplay.Content = CurrentNumber.ToString();
        //    }
        //}


        public int CurrentNumber
        {
            get { return (int)GetValue(CurrentNumberProperty); }
            set { SetValue(CurrentNumberProperty, value); }
        }

        // Using a DependencyProperty as the backing store for CurrentNumber.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentNumberProperty =
            DependencyProperty.Register("CurrentNumber", typeof(int), typeof(ShowNumberControl), new PropertyMetadata(100, new PropertyChangedCallback(CurrentNumberChanged)),
                new ValidateValueCallback(ValidateCurrentNumber));

        private static void CurrentNumberChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs args)
        {
            ShowNumberControl s = (ShowNumberControl)depObj;
            Label theLabel = s.numberDisplay;
            theLabel.Content = args.NewValue.ToString();
        }

        public static bool ValidateCurrentNumber(object value)
        {
            if (Convert.ToInt32(value) >= 0 && Convert.ToInt32(value) <= 500)
                return true;
            else
                return false;
        }

        public ShowNumberControl()
        {
            InitializeComponent();
        }
    }
}
