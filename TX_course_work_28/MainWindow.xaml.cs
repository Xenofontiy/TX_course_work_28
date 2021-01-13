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

namespace TX_course_work_28
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window

    {
        int a, b, c;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Excursion_1.Name == "Monday")
                a = 0;
            if (Excursion_1.Name == "Tuesday")
                a = 1;
            if (Excursion_1.Name == "Wednesday")
                a = 2;
            if (Excursion_1.Name == "Thursday")
                a = 3;
            if (Excursion_1.Name == "Friday")
                a = 4;
            if (Excursion_1.Name == "Saturday")
                a = 5;
            if (Excursion_1.Name == "Sunday")
                a = 6;
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (Time.Name == "11:00")
                b = 0;
            if (Time.Name == "12:00")
                b = 1;
            if (Time.Name == "13:00")
                b = 2;
            if (Time.Name == "14:00")
                b = 3;
            if (Time.Name == "15:00")
                b = 4;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (People.Name == "1_person")
                 c = 1;
            if (People.Name == "2_person")
                c = 2;
            if (People.Name == "3_person")
                c = 3;
            if (People.Name == "4_person")
                c = 4;
            if (People.Name == "5_person")
                c = 5;
            if (People.Name == "6_person")
                c = 6;
        }
    }
}
