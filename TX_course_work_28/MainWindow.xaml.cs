using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using TX_course_work_28.DataGrid;

namespace TX_course_work_28
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int[,] Peaple_sum = new int [5, 6];
        Random ran = new Random();



        private BindingList <DataGrid_time_table> People;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < 5; i++)
                for (int j = 0; j < 6; j++)
                    Peaple_sum[i, j] = ran.Next(0, 9);

            People = new BindingList<DataGrid_time_table>()
            {
                new DataGrid_time_table (){Hall= "Залл 1", Time_1 = Peaple_sum [0,0], Time_2 = Peaple_sum [0,1], Time_3 = Peaple_sum [0,2], Time_4 = Peaple_sum [0,3], Time_5 = Peaple_sum [0,4]},
                new DataGrid_time_table (){Hall= "Залл 2", Time_1 = Peaple_sum [1,0], Time_2 = Peaple_sum [1,1], Time_3 = Peaple_sum [1,2], Time_4 = Peaple_sum [1,3], Time_5 = Peaple_sum [1,4]},
                new DataGrid_time_table (){Hall= "Залл 3", Time_1 = Peaple_sum [2,0], Time_2 = Peaple_sum [2,1], Time_3 = Peaple_sum [2,2], Time_4 = Peaple_sum [2,3], Time_5 = Peaple_sum [2,4]},
                new DataGrid_time_table (){Hall= "Залл 4", Time_1 = Peaple_sum [3,0], Time_2 = Peaple_sum [3,1], Time_3 = Peaple_sum [3,2], Time_4 = Peaple_sum [3,3], Time_5 = Peaple_sum [3,4]},
                new DataGrid_time_table (){Hall= "Залл 5", Time_1 = Peaple_sum [4,0], Time_2 = Peaple_sum [4,1], Time_3 = Peaple_sum [4,2], Time_4 = Peaple_sum [4,3], Time_5 = Peaple_sum [4,4]},
            };
            DataGrid_Time_and_sum.ItemsSource = People;
        }
    }
}
