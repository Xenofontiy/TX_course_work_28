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
        public int[,,] Peaple_sum = new int [5, 7, 8];
        Random ran = new Random();
        int temp;



        private BindingList <DataGrid_time_table> People;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            for (int x = 0; x < 5; x++)                                                                                         //генератор рандомных чисел
                for (int y = 0; y < 6; y++)
                    for (int z = 0; z < 8; z++)
                        Peaple_sum[x, y, z] = ran.Next(0, 9);

            for (int x = 0; x < 5; x++)                                                                                        //сумма людей пришедших
                for (int z = 0; z < 8; z++)
                    Peaple_sum[x, 5, z] = Peaple_sum[x, 0, z] + Peaple_sum[x, 1, z] + Peaple_sum[x, 2, z] + Peaple_sum[x, 3, z] + Peaple_sum[x, 4, z];


            for (int x = 0; x < 5; x++)                                                                                         //номера экскурсий x,6,y, шесть это номер, не трогать
                for (int z = 0; z < 8; z++)
                    Peaple_sum[x, 6, z] = x+1;



            for (int x = 0; x < 5 - 1; x++)                                                                                     // первичная сортировка (доделать сортировку во всех остальных столбцах!)
                for (int y = x + 1; y < 5; y++)
                    if (Peaple_sum[x,5,0] < Peaple_sum[y,5,0])
                        for (int z = 0; z < 7; z++)
                        {
                            temp = Peaple_sum[x, z, 0];
                            Peaple_sum[x, z, 0] = Peaple_sum[y, z, 0];
                            Peaple_sum[y, z, 0] = temp;
                        }



            People = new BindingList<DataGrid_time_table>()
            {
                new DataGrid_time_table (){Excursion= ("Экскурсия "+Peaple_sum [0,6,0]), Time_1 = Peaple_sum [0,0,0], Time_2 = Peaple_sum [0,1,0], Time_3 = Peaple_sum [0,2,0], Time_4 = Peaple_sum [0,3,0], Time_5 = Peaple_sum [0,4,0], Sum = Peaple_sum [0,5,0], Profit = (Peaple_sum [0,5,0]*100)},
                new DataGrid_time_table (){Excursion= ("Экскурсия "+Peaple_sum [1,6,0]), Time_1 = Peaple_sum [1,0,0], Time_2 = Peaple_sum [1,1,0], Time_3 = Peaple_sum [1,2,0], Time_4 = Peaple_sum [1,3,0], Time_5 = Peaple_sum [1,4,0], Sum = Peaple_sum [1,5,0], Profit = (Peaple_sum [1,5,0]*90)},
                new DataGrid_time_table (){Excursion= ("Экскурсия "+Peaple_sum [2,6,0]), Time_1 = Peaple_sum [2,0,0], Time_2 = Peaple_sum [2,1,0], Time_3 = Peaple_sum [2,2,0], Time_4 = Peaple_sum [2,3,0], Time_5 = Peaple_sum [2,4,0], Sum = Peaple_sum [2,5,0], Profit = (Peaple_sum [2,5,0]*120)},
                new DataGrid_time_table (){Excursion= ("Экскурсия "+Peaple_sum [3,6,0]), Time_1 = Peaple_sum [3,0,0], Time_2 = Peaple_sum [3,1,0], Time_3 = Peaple_sum [3,2,0], Time_4 = Peaple_sum [3,3,0], Time_5 = Peaple_sum [3,4,0], Sum = Peaple_sum [3,5,0], Profit = (Peaple_sum [3,5,0]*110)},
                new DataGrid_time_table (){Excursion= ("Экскурсия "+Peaple_sum [4,6,0]), Time_1 = Peaple_sum [4,0,0], Time_2 = Peaple_sum [4,1,0], Time_3 = Peaple_sum [4,2,0], Time_4 = Peaple_sum [4,3,0], Time_5 = Peaple_sum [4,4,0], Sum = Peaple_sum [4,5,0], Profit = (Peaple_sum [4,5,0]*125)},
            };
            DataGrid_Time_and_sum.ItemsSource = People;
        }
    }
}
