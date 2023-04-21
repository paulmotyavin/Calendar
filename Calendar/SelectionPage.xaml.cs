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
    public partial class SelectionPage : Page
    {
        public SelectionPage()
        {
            InitializeComponent();
            Select first = new Select();
            first.NameEmotions.Text = "Радость";
            first.EmotionsImage.Source = new BitmapImage(new Uri("images/joy.png", UriKind.Relative));
            Select second = new Select();
            second.NameEmotions.Text = "Грусть";
            second.EmotionsImage.Source = new BitmapImage(new Uri("images/sadness.png", UriKind.Relative));
            Select third = new Select();
            third.NameEmotions.Text = "Гнев";
            third.EmotionsImage.Source = new BitmapImage(new Uri("images/anger.png", UriKind.Relative));
            Select fourth = new Select();
            fourth.NameEmotions.Text = "Страх";
            fourth.EmotionsImage.Source = new BitmapImage(new Uri("images/afraid.png", UriKind.Relative));
            Select fifth = new Select();
            fifth.NameEmotions.Text = "Отвращение"; 
            fifth.EmotionsImage.Source = new BitmapImage(new Uri("images/otvrashenie.png", UriKind.Relative));
            Select sixth = new Select();
            sixth.NameEmotions.Text = "Удивление";
            sixth.EmotionsImage.Source = new BitmapImage(new Uri("images/shock.png", UriKind.Relative));
            Select seventh = new Select();
            seventh.NameEmotions.Text = "Ненависть";
            seventh.EmotionsImage.Source = new BitmapImage(new Uri("images/hate.png", UriKind.Relative));
            Select eighth = new Select();
            eighth.NameEmotions.Text = "Тревога";
            eighth.EmotionsImage.Source = new BitmapImage(new Uri("images/stress.png", UriKind.Relative));
            Select ninth = new Select();
            ninth.NameEmotions.Text = "Боль";
            ninth.EmotionsImage.Source = new BitmapImage(new Uri("images/pain.png", UriKind.Relative));
            Select tenth = new Select();
            tenth.NameEmotions.Text = "Стеснение";
            tenth.EmotionsImage.Source = new BitmapImage(new Uri("images/shy.png", UriKind.Relative));

            List<Select> emotions = new List<Select>() { first, second, third, fourth, fifth, sixth, seventh, eighth, ninth, tenth };
            Emotions.ItemsSource = emotions;
        }

        private void ToMainPage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = (MainWindow)Window.GetWindow(this);
            MainPage page = new MainPage();
            window.PagesFrame.Content = page;
        }

        private void SaveExit_Click(object sender, RoutedEventArgs e)
        {
            /*Save*/
            MainWindow window = (MainWindow)Window.GetWindow(this);
            MainPage page = new MainPage();
            window.PagesFrame.Content = page;
        }
    }
}
