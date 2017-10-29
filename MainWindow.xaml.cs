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

        private void MyWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
            getData();
            
        }

        private void getData() {

            string path1 = @"C:\Users\LENOVO\Desktop\Adsoyad.txt";
            FileStream fs2 = new FileStream(path1, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reading = new StreamReader(fs2, System.Text.Encoding.UTF8);
            //string satir = "";

            //string[] x;
            //do
            //{
            //    satir = reading.ReadLine();
            //    x = satir.Split(' ');
            //    list.Items.Add(x[0] + " " + x[1] + "\n");
            //} while (!reading.EndOfStream);
            //reading.Close();
            //fs2.Close();



            //string[] writing = new string[1000]; // veritabanına bin tane mi eleman girilmeli?
            //string line;
            ////string writing = reading.ReadLine(); 
            //line = reading.ReadLine();
            //int elementNumber = line.Length / 100;
            //for (int i = 0; i < elementNumber; i++)
            //{
            //    writing[i] = ((i + 1) * (line.Length / elementNumber)).ToString();
            //    list.Items.Add(writing[i]);
            //}

            //fs2.Close();

            string writing = reading.ReadLine();
            do
            {

                list.Items.Add(writing);

            } while (!reading.EndOfStream);
            fs2.Close();



            //while (writing != null)
            //{
            //    list.Items.Add(writing);
            //    writing = reading.ReadLine();
            //}

            //reading.Close();
            //fs2.Close();
        
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

            for (int i = 1; i < 50 - tb2Length; i++)
            {
                tb2.Text = tb2.Text + " ";
            }          
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string path1 = @"C:\Users\LENOVO\Desktop\Adsoyad.txt";
            FileStream fs = new FileStream(path1, FileMode.Append, FileAccess.Write);

            int tb1Length = tb1.Text.Length;
            int tb2Length = tb2.Text.Length;

            textLength(tb1Length, tb2Length);


            using (StreamWriter outputFile = new StreamWriter(fs, System.Text.Encoding.UTF8)) 

            {
                
               outputFile.Write(tb1.Text + tb2.Text, fs.Position + 1);
             
             //  outputFile.BaseStream.Seek(0, SeekOrigin.End);
               
            }

                getData();
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
            for (int i = 0; i < 50- tb1.Text.Length; i++)
            {
                tb1.Text = tb1.Text + complement[i];

            }

            for (int i = 50; i < 100 - tb2.Text.Length; i++)
            {
                tb2.Text = tb2.Text + complement[i];

            }
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {

            list.Items.Remove(list.SelectedItem);
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            string selected = list.SelectedItem.ToString();

        }

    }
}