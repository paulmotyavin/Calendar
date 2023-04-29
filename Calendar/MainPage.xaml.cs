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
                WorkWithDate();
            }
            else
            {
                date = date.AddMonths(-1);
                month--;
                WorkWithDate();
            }
        }

        private void NextMonth_Click(object sender, RoutedEventArgs e)
        {
            if (month == 12)
            {
                year++;
                month = 1;
                date = new DateTime(year, month, 1);
                WorkWithDate();
            }
            else
            {        
                date = date.AddMonths(1);
                month++;
                WorkWithDate();
            }
        }

        public MainPage()
        {
            InitializeComponent();
            Date();
        }
        private void Date()
        {
            date = DateTime.Now;
            month = date.Month;
            year = date.Year;
            WorkWithDate();
        }
        private void WorkWithDate()
        {
            string yearMonth = date.ToString("MMMM yyyy");
            MonthYear.Text = yearMonth;
            int days = DateTime.DaysInMonth(year, month);
            panel.Children.Clear();
            for (int i = 1; i <= days; i++)
            {
                CardsDay cards = new CardsDay();
                cards.days(i, month, year);
                panel.Children.Add(cards);
            }
        }
    }
}
