using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UserForms
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> PhoneNumbers = new List<String>();
        System.Windows.Forms.SaveFileDialog aDialog;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MaskedTextBox aBox;
            aBox = (System.Windows.Forms.MaskedTextBox)windowsFormsHost1.Child;
            PhoneNumbers.Add(aBox.Text);
            aBox.Clear();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            aDialog = new System.Windows.Forms.SaveFileDialog();
            aDialog.Filter = "Text Files | *.txt";
            aDialog.ShowDialog();
            System.IO.StreamWriter myWriter = new System.IO.StreamWriter(aDialog.FileName, true);
            foreach (string s in PhoneNumbers)
                myWriter.WriteLine(s);
            myWriter.Close();

        }
    }
}
