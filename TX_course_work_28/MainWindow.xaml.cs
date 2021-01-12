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
using Microsoft.Win32;
using TX_course_work_28.NewFolder1;

namespace TX_course_work_28
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Mode;
        Exhibitions DailyExhibitions;


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
            
           ListOfExhibitions.ItemsSource = DailyExhibitions.exh;
            switch (Mode)
            {
                case 0:
                    {
                       
                        DailyExhibitions = new Exhibitions(Mode);
                        ListwithInformation.ItemsSource = DailyExhibitions.exh;
                        Mode = 1;
                        break;
                    }
                case 1:
                    {
                       
                        DailyExhibitions = new Exhibitions(Mode);
                        ListwithInformation.ItemsSource = DailyExhibitions.exh;
                        Mode = 2;
                        break;
                    }
                case 2:
                    {
                       
                        DailyExhibitions = new Exhibitions(Mode);
                        ListwithInformation.ItemsSource = DailyExhibitions.exh;
                        Mode =3 ;
                        break;
                    }
                case 3:
                    {
                        
                        DailyExhibitions = new Exhibitions(Mode);
                        ListwithInformation.ItemsSource = DailyExhibitions.exh;
                        Mode = 4;
                        break;
                    }
                case 4:
                    {
                        
                        DailyExhibitions = new Exhibitions(Mode);
                        ListwithInformation.ItemsSource = DailyExhibitions.exh;
                        Mode=0;
                        break;
                    }
               

            }
        }
    }
}
