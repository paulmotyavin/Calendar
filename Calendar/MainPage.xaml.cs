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

namespace Calendar
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public int month, year;
        public DateTime date;

        private void PreviousMonth_Click(object sender, RoutedEventArgs e)
        {
            if (month == 1)
            {
                year--;
                month = 12;
                date = new DateTime(year, month, 1);
                string yearMonth = date.ToString("MMMM yyyy");
                MonthYear.Text = yearMonth;
            }
            else
            {
                int days = DateTime.DaysInMonth(year, month);

                /*for (int i = 1; i <= days; i++)
                {
                    CardsDay cards = new CardsDay();
                    cards.days(i);
                    grid.Children.Add(cards);
                }*/
                date = date.AddMonths(-1);
                string yearMonth = date.ToString("MMMM yyyy");
                MonthYear.Text = yearMonth;
                month--;
            }
        }

        private void NextMonth_Click(object sender, RoutedEventArgs e)
        {
            if (month == 12)
            {
                year++;
                month = 1;
                date = new DateTime(year, month, 1);
                string yearMonth = date.ToString("MMMM yyyy");
                MonthYear.Text = yearMonth;
            }
            else
            {
                int days = DateTime.DaysInMonth(year, month);

                /*for (int i = 1; i <= days; i++)
                {
                    CardsDay cards = new CardsDay();
                    cards.days(i);
                    grid.Children.Add(cards);
                }*/
                date = date.AddMonths(1);
                string yearMonth = date.ToString("MMMM yyyy");
                MonthYear.Text = yearMonth;
                month++;
            }
        }

        public MainPage()
        {
            InitializeComponent();
            date = DateTime.Now;
            string yearMonth = date.ToString("MMMM yyyy");
            month = date.Month;
            year = date.Year;
            MonthYear.Text = yearMonth;
            int days = DateTime.DaysInMonth(year, month);

            /*for (int i = 1; i <= days; i++)
            {
                CardsDay cards = new CardsDay();
                cards.days(i);
                grid.Children.Add(cards);
            }*/
        }
    }
}
