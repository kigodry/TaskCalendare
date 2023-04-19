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

    public partial class Page1 : Page
    {
        public DateTime DateTimeNow { get; set; } = DateTime.Now;
        public Page1()
        {
            InitializeComponent();
            DataContext = this;

            DataX invar = new DataX();
            DataBut();
        }

        private void Button_Click_Left(object sender, RoutedEventArgs e)
        {

            MyWrapPanel.Children.Clear();
            DateTimeNow = DateTimeNow.AddMonths(-1);
            TbDate.Text = DateTimeNow.ToString("dd MMMM yyyy");
            DataBut();
        }

        private void Button_Click_Right(object sender, RoutedEventArgs e)
        {

            MyWrapPanel.Children.Clear();
            DateTimeNow = DateTimeNow.AddMonths(1);
            TbDate.Text = DateTimeNow.ToString("dd MMMM yyyy");
            DataBut();
        }

        private void DataBut()
        {
            for (int i = 1; i <= DateTime.DaysInMonth(DateTimeNow.Year, DateTimeNow.Month); i++)
            {
                DataX date = new DataX();
                date.DataName.Content = i.ToString();

                DateTime datehere = new DateTime(DateTimeNow.Year, DateTimeNow.Month, i);
                Class2 item = Class.ClassList.FirstOrDefault(iteminlist => iteminlist.time == datehere);
                if (item != null)
                {
                    if (item.ChoseButton == 1)
                    {
                        date.DataName.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\\Users\\ivano\\Desktop\\Fotos\\heart.png")));
                    }
                    else if (item.ChoseButton == 2)
                    {
                        date.DataName.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\ivano\Desktop\Fotos\airplane.png")));

                    }
                    else if (item.ChoseButton == 3)
                    {
                        date.DataName.Background = new ImageBrush(new BitmapImage(new Uri(@"C:\Users\ivano\Desktop\Fotos\clock.png")));
                    }
                }

                date.DataName.Click += DataName_Click;
                MyWrapPanel.Children.Add(date);
            }
        }

        private void DataName_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            int day = Convert.ToInt32(btn.Content);
            DateTime datehere = new DateTime(DateTimeNow.Year, DateTimeNow.Month, day);
            
            Page2 page2 = new Page2(datehere);
            NavigationService.Navigate(page2);
        }

    }
}
