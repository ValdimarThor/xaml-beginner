namespace RestaurantManager.UniversalWindows
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Windows.UI.Xaml;
    using Windows.UI.Xaml.Controls;

    public sealed partial class ExpeditePage : Page
    {
        public ExpeditePage()
        {
            this.InitializeComponent();
        }

        public void OnHomeButtonClicked(object sender, RoutedEventArgs args)
        {
            Frame.Navigate(typeof(MainPage));
        }
    }
}