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
        private BindingList <DataGrid_time_table> People;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            People = new BindingList<DataGrid_time_table>()
            {
                new DataGrid_time_table (){Hall= "Залл 1"},
                new DataGrid_time_table (){Hall ="Залл 2"}
            };
            DataGrid_Time_and_sum.ItemsSource = People;
        }
    }
}
