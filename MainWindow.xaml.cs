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

namespace WPFTestSkill
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            textBox4.IsEnabled = false;
        }

        private void cal(double income,double expense,double itemwant) {

            double keepMoney = (income - expense);
            double alldate = itemwant / keepMoney;
            textBox4.Text = alldate.ToString();


                    

        

        
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double inCome = double.Parse(textBox1.Text);
                double exPense = double.Parse(textBox2.Text);
                double itemWant = double.Parse(textBox3.Text);

                cal(inCome, exPense, itemWant);
            }
            catch (Exception ex) {

                MessageBox.Show("ERROR"+ex.Message);
            }

        }


    }
}
