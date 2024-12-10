using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Practichesk5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); pair1 = new Pair(); pair2 = new Pair(); pair3 = new Pair();
        }
        Pair pair1;
        Pair pair2;
        Pair pair3;

        private void Pair1_Increment_Click(object sender, RoutedEventArgs e)//4545345234524234234234242343
        {
            int.TryParse(Pair1_1.Text, out int a);
            int.TryParse(Pair1_2.Text, out int b);
            pair1.SetParams(a,b);
            pair1.SetParams();
            Pair1_1.Text = pair1.first.ToString();
            Pair1_2.Text = pair1.second.ToString();
        }

        private void Pair2_Increment_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(Pair2_1.Text, out int a);
            int.TryParse(Pair2_2.Text, out int b);
            pair2.SetParams(a, b);
            pair2.SetParams();
            Pair2_1.Text = pair2.first.ToString();
            Pair2_2.Text = pair2.second.ToString();
        }

        private void Pair1_SumRes_Click(object sender, RoutedEventArgs e)
        {   
            int.TryParse(Pair1_1.Text,out int a);
            int.TryParse(Pair1_2.Text,out int b);
            pair1.SetParams(a,b);
            Pair1_Sum.Text = (pair1.first + pair1.second).ToString();


        }

        private void Pair2_SumRes_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(Pair2_1.Text, out int a);
            int.TryParse(Pair2_2.Text, out int b);
            pair2.SetParams(a, b);
            Pair2_Sum.Text = (pair2.first + pair2.second).ToString();
        }

        private void Sum_Click(object sender, RoutedEventArgs e)
        {   
            int.TryParse(Pair1_1.Text, out int a);
            int.TryParse(Pair1_2.Text, out int b);
            pair1.SetParams(a, b);
            int.TryParse(Pair2_1.Text, out int c);
            int.TryParse(Pair2_2.Text, out int d);
            pair2.SetParams(c,d);
            pair1.plus(pair2,out int res_part1, out int res_part2);
            Sum_pairs.Text = ( res_part1, res_part2).ToString();
        }

        private void sum3Pairs_res_Click(object sender, RoutedEventArgs e)
        {
            int.TryParse(Pair1_1.Text, out int a);
            int.TryParse(Pair1_2.Text, out int b);
            pair1.SetParams(a, b);
            int.TryParse(Pair2_1.Text, out int c);
            int.TryParse(Pair2_2.Text, out int d);
            pair2.SetParams(c, d);
            int.TryParse(Pair3_1.Text, out int x);
            int.TryParse(Pair3_2.Text, out int z);
            pair3.SetParams(x, z);
            pair1.plus(pair2, pair3, out int res_part1, out int res_part2);
            Sum3_pairs.Text = (res_part1, res_part2).ToString();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void about_programm_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Баукин Алексей Алексеевич , в 1:02 , \n Задание: Создать класс Pair (пара чисел). Создать необходимые методы и свойства.\r\nОпределить методы метод сложения полей и операцию сложения пар (а, b) + (с, d)\r\n= (а + c, b + d). Создать перегруженные методы для увеличения полей на 1,\r\nсложения трех пар чисел.");
        }
    }
 }
