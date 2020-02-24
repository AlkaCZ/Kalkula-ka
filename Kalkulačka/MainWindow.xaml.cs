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
using System.Data;

namespace Kalkulačka
{


    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
        }
        List<string> Z = new List<string>();
        char[] separators = { '*', '/', '+', '-' };

        private void Zero_Click(object sender, RoutedEventArgs e)
        {
            //Zadani.Text += "0";
            Z.Add("0");
            Button dunno = (Button)sender;
            Zadani.Content += dunno.Content.ToString();

        }

        private void One_Click(object sender, RoutedEventArgs e)
        {
            //Zadani.Text += "1";
            Z.Add("1");
            Button dunno = (Button)sender;
            Zadani.Content += dunno.Content.ToString();
        }

        private void Two_Click(object sender, RoutedEventArgs e)
        {
            //Zadani.Text += "2";
            Z.Add("2");
            Button dunno = (Button)sender;
            Zadani.Content += dunno.Content.ToString();
        }

        private void Three_Click(object sender, RoutedEventArgs e)
        {
            //Zadani.Text += "3";
            Z.Add("3");
            Button dunno = (Button)sender;
            Zadani.Content += dunno.Content.ToString();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            //Zadani.Text += " + ";
            Z.Add("+");
            Button dunno = (Button)sender;
            Zadani.Content += dunno.Content.ToString();
        }

        private void Four_Click(object sender, RoutedEventArgs e)
        {
            //Zadani.Text += "4";
            Z.Add("4");
            Button dunno = (Button)sender;
            Zadani.Content += dunno.Content.ToString();
        }

        private void Five_Click(object sender, RoutedEventArgs e)
        {
            //Zadani.Text += "5";
            Z.Add("5");
            Button dunno = (Button)sender;
            Zadani.Content += dunno.Content.ToString();
        }

        private void Six_Click(object sender, RoutedEventArgs e)
        {
            //Zadani.Text += "6";
            Z.Add("6");
            Button dunno = (Button)sender;
            Zadani.Content += dunno.Content.ToString();
        }

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            //Zadani.Text += " - ";
            Z.Add("-");
            Button dunno = (Button)sender;
            Zadani.Content += dunno.Content.ToString();
        }

        private void Seven_Click(object sender, RoutedEventArgs e)
        {
            //Zadani.Text += "7";
            Z.Add("7");
            Button dunno = (Button)sender;
            Zadani.Content += dunno.Content.ToString();
        }

        private void Eight_Click(object sender, RoutedEventArgs e)
        {
            //Zadani.Text += "8";
            Z.Add("8");
            Button dunno = (Button)sender;
            Zadani.Content += dunno.Content.ToString();
        }

        private void Nine_Click(object sender, RoutedEventArgs e)
        {
            //Zadani.Text += "9";
            Z.Add("9");
            Button dunno = (Button)sender;
            Zadani.Content += dunno.Content.ToString();
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            //Zadani.Text += " / ";
            Z.Add("/");
            Button dunno = (Button)sender;
            Zadani.Content += dunno.Content.ToString();
        }

        private void Del_Click(object sender, RoutedEventArgs e)
        {
            if (Z.Count >= 1)
            {
                Z.RemoveAt(Z.Count - 1);
                Zadani.Content = "";
                foreach (string item in Z)
                {
                    Zadani.Content += item.ToString();
                }
            }
            else
            {
                Zadani.Content = "Error";
            }

        }

        public static double Evaluate(string s)
        {
            DataTable table = new DataTable();
            table.Columns.Add("s", string.Empty.GetType(), s);
            DataRow row = table.NewRow();
            table.Rows.Add(row);
            return double.Parse((string)row["s"]);
        }
        private void Enter_Click(object sender, RoutedEventArgs e)
        {

            string test = Zadani.Content.ToString();
            Vysledek.Content = Evaluate(test).ToString();



        }


        private void Multipy_Click(object sender, RoutedEventArgs e)
        {
            Z.Add("*");
            Button dunno = (Button)sender;
            Zadani.Content += dunno.Content.ToString();
        }
    }
}

