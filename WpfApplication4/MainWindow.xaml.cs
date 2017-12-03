using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApplication4
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

      
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {
            getData();
        }

        private void getData()
        {
                     string path= @"C:\Users\LENOVO\Desktop\Adsoyad.txt";
                     FileStream fs2 = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read); 
                     StreamReader reading = new StreamReader(fs2, System.Text.Encoding.UTF8);

                    fs2.Position = 2 ;
                    char character = ' ';
                    string word = "";
                    int count1 ;
                    int count2 = 1;
            
                   
                    for (int i = count2 ; i < reading.Read(); i++)
                    {
                        for ( count1 = count2  ; count1 <= fs2.Length - 3 ; count1++)
                        {
               
                            character = (char)reading.Read();

                            if (count1 % 100 == 0)
                            {
                                word = (word + character + "\n");
                            }

                            else word = word + character;
                           }
                        
                      list.Items.Add(word);
                      count2 = count2 + 100;

                    }
                    count2 = count2 + 100;
            reading.Close();
            fs2.Close();

        }

        private void textLength(int tb1Length, int tb2Length)
                {
                    for (int i = 1; i <= 50 - tb1Length; i++)
                    {
                        tb1.Text = tb1.Text + " ";
                    }
                    
                    for (int i = 1; i <= 50 - tb2Length; i++)
                    {
                        tb2.Text = tb2.Text + " ";
                    }  
                }


        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\LENOVO\Desktop\Adsoyad.txt";
            FileStream fs = new FileStream(path, FileMode.Append , FileAccess.Write);

           
                        int tb1Length = tb1.Text.Length;
                        int tb2Length = tb2.Text.Length;
                        textLength(tb1Length, tb2Length);

            using (StreamWriter outputFile = new StreamWriter(fs, System.Text.Encoding.UTF8))
            {
                outputFile.Write(tb1.Text + tb2.Text , fs.Position + 1);
                tb1.Text = null;
                tb2.Text = null;
            }

            getData();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            char[] complement = list.SelectedItem.ToString().ToCharArray();
            tb1.Text = null;
            tb2.Text = null;
            for (int i = 0; i < 50 - tb1.Text.Length; i++)
            {
                tb1.Text = tb1.Text + complement[i];

            }

            for (int i = 50; i < 100 - tb2.Text.Length; i++)
            {
                tb2.Text = tb2.Text + complement[i];

            }
        }
          
    }
}
