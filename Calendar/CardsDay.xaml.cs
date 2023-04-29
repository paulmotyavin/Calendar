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
        DateTime date;
        public CardsDay()
        {
            InitializeComponent();
        }
        public void days(int day, int month, int year)
        {
            number.Text = day + "";
            GetMonth = month;
            GetYear = year;
            date = new DateTime(GetYear, GetMonth, Convert.ToInt32(number.Text));
            Deserialize_Image();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Window.GetWindow(this);
            SelectionPage page = new SelectionPage();
            page.DateDes(date);
            page.TakeText.Text = date.ToString("dd MMMM yyyy");
            window.PagesFrame.Content = page;
        }
        private void Deserialize_Image()
        {
            List<ChooseUser> deserializeUsers = Deserialize.DeserializeObj<List<ChooseUser>>();
            if (deserializeUsers != null )
            {
                foreach (ChooseUser user in deserializeUsers)
                {
                    if (date == user.date)
                    {
                        foreach (Par par in user.pars)
                        {
                            if (par.Selected == true)
                            {
                                Image.Source = new BitmapImage(new Uri(par.Path, UriKind.RelativeOrAbsolute));
                                break;
                            }
                        }
                    }

                }
            }
        }
    }
}
