using System.Windows;

namespace Ink_Pad
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Forms.SaveFileDialog aDialog;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.inkCanvas1.Strokes.Clear();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
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
