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

namespace TaskCalendar
{

    public partial class Page2 : Page
    {
        private DateTime _day;
        private Class2 model = new Class2();
        public Page2(DateTime day)
        {
            InitializeComponent();
            _day = day;
            model.time = day;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Class.ClassList.Add(model);
            MessageBox.Show($"Данные для дня {_day} успешно сохранены!");
            NavigationService.Refresh();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            model.Delete();
            MessageBox.Show($"Данные для дня {_day} успешно удалены!");
            NavigationService.Refresh();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            model.ChoseButton = 1;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            model.ChoseButton = 2;

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            model.ChoseButton = 3;

        }
    }
}
