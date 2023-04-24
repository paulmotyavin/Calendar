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
    public partial class CardsDay : UserControl
    {
        public int GetMonth, GetYear;
        public CardsDay()
        {
            InitializeComponent();
        }
        public void days(int day, int month, int year)
        {
            number.Text = day + "";
            GetMonth = month;
            GetYear = year;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Window.GetWindow(this);
            SelectionPage page = new SelectionPage();
            DateTime date = new DateTime(GetYear, GetMonth, Convert.ToInt32(number.Text));
            page.TakeText.Text = date.ToString("dd MMMM yyyy");
            window.PagesFrame.Content = page;
        }
    }
}
