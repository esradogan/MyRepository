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


        private void textLength(int tb1Length, int tb2Length)
        {

            for (int i = 1; i < 50 - tb1Length; i++)
            {
                tb1.Text = tb1.Text + " ";
            }

            for (int i = 0; i < 50 - tb2Length; i++)
            {
                tb2.Text = tb2.Text + " ";
            }          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path1 = @"C:\Users\LENOVO\Desktop\Adsoyad.txt";
            FileStream fs = new FileStream(path1, FileMode.OpenOrCreate, FileAccess.Write);


            //tb1.MaxLength=50;
            //tb2.MaxLength=50;

            //char[] data1 = new char[50];
            //char[] data2 = new char[50];

            int tb1Length = tb1.Text.Length;
            int tb2Length = tb2.Text.Length;

            textLength(tb1Length, tb2Length);


            using (StreamWriter outputFile = new StreamWriter(fs, System.Text.Encoding.UTF8))
            {

                outputFile.Write(tb1.Text + " " + tb2.Text);
                // position = position + tb1.Text.Length + 1 + tb2.Text.Length;

            }

            FileStream fs2 = new FileStream(path1, FileMode.Open, FileAccess.Read);
            StreamReader reading = new StreamReader(fs2, System.Text.Encoding.UTF8);
            char[] data = null;
            data = new char[50];
            data = tb1.Text.ToCharArray();
            string writing = reading.ReadLine();


            while (writing != null)
            {
                list.Items.Add(writing);
                writing = reading.ReadLine();
            }

            reading.Close();
            fs2.Close();


            //  FileStream fStream = new FileStream(@"C:\Users\LENOVO\Desktop\Adsoyad.txt", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            //  FileStream fs = new FileStream(path1, FileMode.OpenOrCreate, FileAccess.Write);
            //  StreamWriter sw = new StreamWriter(fs);

        }


        private void Ad_Soyad_Kaydet_Click(object sender, RoutedEventArgs e)
        {
            //string complement = list.SelectedItem.ToString();
            //char[] bracket = { ' ' };
            //string[] parts = complement.Split(bracket);
            //int number = parts.Length;
            //string surname = parts[number - 1];
            //string name = "";
            //for (int i = 0; i < number - 1; i++)
            //{
            //    name = name + parts[i];
            //}


            char[] complement = list.SelectedItem.ToString().ToCharArray();
            tb1.Text = null;
            tb2.Text = null;
            for (int i = 0; i < 50; i++)
            {
                tb1.Text = tb1.Text + complement[i];

            }

            for (int i = 50; i < 100; i++)
            {
                tb2.Text = tb2.Text + complement[i];

            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {


            list.Items.Remove(list.SelectedItem);
        }




    }
}