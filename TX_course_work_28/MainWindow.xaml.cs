using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using TX_course_work_28.DataGrid;
using Microsoft.Win32;
using TX_course_work_28.NewFolder1;

namespace TX_course_work_28
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a, b, c, Hulman, numer;
        int Mode;
        Exhibitions DailyExhibitions;


        public int[,,] Peaple_sum = new int [5, 7, 8];
        Random ran = new Random();
        int temp; 

        private BindingList <DataGrid_time_table> People;
       

        int Sort_tabl(int Page)
        {
            for (int x = 0; x < 5 - 1; x++)                                                                                  //Сортировка                                         
                for (int y = x + 1; y < 5; y++)
                    if (Peaple_sum[x, 5, Page] < Peaple_sum[y, 5, Page])
                        for (int z = 0; z < 7; z++)
                        {
                            temp = Peaple_sum[x, z, Page];
                            Peaple_sum[x, z, Page] = Peaple_sum[y, z, Page];
                            Peaple_sum[y, z, Page] = temp;
                        }
            People = new BindingList<DataGrid_time_table>()
            {
                new DataGrid_time_table (){Excursion= ("Экскурсия "+Peaple_sum [0,6,Page]), Time_1 = Peaple_sum [0,0,Page], Time_2 = Peaple_sum [0,1,Page], Time_3 = Peaple_sum [0,2,Page], Time_4 = Peaple_sum [0,3,Page], Time_5 = Peaple_sum [0,4,Page], Sum = Peaple_sum [0,5,Page], Profit = (Peaple_sum [0,5,Page]*100)},
                new DataGrid_time_table (){Excursion= ("Экскурсия "+Peaple_sum [1,6,Page]), Time_1 = Peaple_sum [1,0,Page], Time_2 = Peaple_sum [1,1,Page], Time_3 = Peaple_sum [1,2,Page], Time_4 = Peaple_sum [1,3,Page], Time_5 = Peaple_sum [1,4,Page], Sum = Peaple_sum [1,5,Page], Profit = (Peaple_sum [1,5,Page]*90)},
                new DataGrid_time_table (){Excursion= ("Экскурсия "+Peaple_sum [2,6,Page]), Time_1 = Peaple_sum [2,0,Page], Time_2 = Peaple_sum [2,1,Page], Time_3 = Peaple_sum [2,2,Page], Time_4 = Peaple_sum [2,3,Page], Time_5 = Peaple_sum [2,4,Page], Sum = Peaple_sum [2,5,Page], Profit = (Peaple_sum [2,5,Page]*120)},
                new DataGrid_time_table (){Excursion= ("Экскурсия "+Peaple_sum [3,6,Page]), Time_1 = Peaple_sum [3,0,Page], Time_2 = Peaple_sum [3,1,Page], Time_3 = Peaple_sum [3,2,Page], Time_4 = Peaple_sum [3,3,Page], Time_5 = Peaple_sum [3,4,Page], Sum = Peaple_sum [3,5,Page], Profit = (Peaple_sum [3,5,Page]*110)},
                new DataGrid_time_table (){Excursion= ("Экскурсия "+Peaple_sum [4,6,Page]), Time_1 = Peaple_sum [4,0,Page], Time_2 = Peaple_sum [4,1,Page], Time_3 = Peaple_sum [4,2,Page], Time_4 = Peaple_sum [4,3,Page], Time_5 = Peaple_sum [4,4,Page], Sum = Peaple_sum [4,5,Page], Profit = (Peaple_sum [4,5,Page]*125)},
            };                                                          //Вывод в таблицу
            DataGrid_Time_and_sum.ItemsSource = People;

            return Page;
        }



        public MainWindow()
        {
            Mode = 0;
            DailyExhibitions = new Exhibitions(Mode);
            InitializeComponent();
            this.DataContext = DailyExhibitions;
            ListOfExhibitions.ItemsSource = DailyExhibitions.exh;
            ListwithInformation.ItemsSource = DailyExhibitions.exh;
            ListOfExhibitions.Items.Refresh();
            ListwithInformation.Items.Refresh();
        }

        private void ChooseFileClick_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void ChangeTheHall_Click(object sender, RoutedEventArgs e)
        {
            
          
            switch (Mode)
            {
                case 0:
                    {
                       
                        DailyExhibitions = new Exhibitions(Mode);
                        ListOfExhibitions.ItemsSource = DailyExhibitions.exh;
                        ListwithInformation.ItemsSource = DailyExhibitions.exh;
                        Mode = 1;
                        break;
                    }
                case 1:
                    {
                       
                        DailyExhibitions = new Exhibitions(Mode);
                        ListOfExhibitions.ItemsSource = DailyExhibitions.exh;
                        ListwithInformation.ItemsSource = DailyExhibitions.exh;
                        Mode = 2;
                        break;
                    }
                case 2:
                    {
                       
                        DailyExhibitions = new Exhibitions(Mode);
                        ListOfExhibitions.ItemsSource = DailyExhibitions.exh;
                        ListwithInformation.ItemsSource = DailyExhibitions.exh;
                        Mode =3 ;
                        break;
                    }
                case 3:
                    {
                        
                        DailyExhibitions = new Exhibitions(Mode);
                        ListOfExhibitions.ItemsSource = DailyExhibitions.exh;
                        ListwithInformation.ItemsSource = DailyExhibitions.exh;
                        Mode = 4;
                        break;
                    }
                case 4:
                    {
                        
                        DailyExhibitions = new Exhibitions(Mode);
                        ListOfExhibitions.ItemsSource = DailyExhibitions.exh;
                        ListwithInformation.ItemsSource = DailyExhibitions.exh;
                        Mode=0;
                        break;
                    }
               

            }
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



            Sort_tabl(0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Sort_tabl(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Sort_tabl(1);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Sort_tabl(2);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Sort_tabl(3);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Sort_tabl(4);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Sort_tabl(5);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            Sort_tabl(6);
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Excursion_1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Monday")
                a = 0;
            if (Excursion_1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Tuesday")
                a = 1;
            if (Excursion_1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Wednesday")
                a = 2;
            if (Excursion_1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Thursday")
                a = 3;
            if (Excursion_1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Friday")
                a = 4;
            if (Excursion_1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Saturday")
                a = 5;
            if (Excursion_1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Sunday")
                a = 6;
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (Time.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: 11:00")
                b = 0;
            if (Time.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: 12:00")
                b = 1;
            if (Time.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: 13:00")
                b = 2;
            if (Time.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: 14:00")
                b = 3;
            if (Time.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: 15:00")
                b = 4;
        }

        private void Excursion_2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Excursion_2.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Экскурсия 1")
                c = 0;
            if (Excursion_2.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Экскурсия 2")
                c = 1;
            if (Excursion_2.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Экскурсия 3")
                c = 2;
            if (Excursion_2.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Экскурсия 4")
                c = 3;
            if (Excursion_2.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: Экскурсия 5")
                c = 4;
        }

        private void People1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (People1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: 1 человек")
                Hulman = 1;
            if (People1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: 2 человек")
                Hulman = 2;
            if (People1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: 3 человек")
                Hulman = 3;
            if (People1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: 4 человек")
                Hulman = 4;
            if (People1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: 5 человек")
                Hulman = 5;
            if (People1.SelectedItem.ToString() == "System.Windows.Controls.ComboBoxItem: 6 человек")
                Hulman = 6;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {

            for (int x = 0; x < 5; x++)
                if (Peaple_sum[x, 6, a] == (c + 1))
                    numer = x;

          

            Peaple_sum[numer, b, a] = Peaple_sum[numer, b, a]+ Hulman;
            for (int x = 0; x < 5; x++)                                                                                         
                Peaple_sum[x, 5, a] = Peaple_sum[x, 0, a] + Peaple_sum[x, 1, a] + Peaple_sum[x, 2, a] + Peaple_sum[x, 3, a] + Peaple_sum[x, 4, a];


            Sort_tabl(a);

        }


    }
}
