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
using System.IO;

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }


        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //list.Items.Add(tb1.Text);
            //list.Items.Add(tb2.Text);
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path1 = @"C:\Users\LENOVO\Desktop\Adsoyad.txt";
            FileStream fs = new FileStream(path1, FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter outputFile = new StreamWriter(fs, System.Text.Encoding.UTF8))
            {
                outputFile.Write(tb1.Text + " " + tb2.Text);
                //  outputFile.WriteLine(tb2.Text);

            }

            FileStream fs2 = new FileStream(path1, FileMode.Open, FileAccess.Read);
            StreamReader reading = new StreamReader(fs2, System.Text.Encoding.UTF8);

            string writing = reading.ReadLine();
            while (writing != null)
            {
                list.Items.Add(writing);
                writing = reading.ReadLine();
            }

            reading.Close();
            fs2.Close();


            //  FileStream fStream = new FileStream(@"C:\Users\LENOVO\Desktop\Adsoyad.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            // FileStream fs = new FileStream(path1, FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(fs);

        }

        private void Ad_Soyad_Kaydet_Click(object sender, RoutedEventArgs e)
        {
           string complement=list.SelectedItem.ToString();
           char[] bracket = {' '};
            string[] parts = complement.Split(bracket);
            int number=parts.Length;
            string surname = parts[number];
            string name="";
            for (int i = 0; i < number-1; i++)
            {
                name = name + parts[i];
            }
            tb1.Text = name;
            tb2.Text = surname;

        }




    }
}



