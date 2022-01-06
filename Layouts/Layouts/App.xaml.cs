using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Layouts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new StackLayoutDemo();
            //MainPage = new GridDemo();
            MainPage = new NavigationPage(new Page1());
            //MainPage = new TabbedPage1();
            //MainPage = new CarouselPage1xaml();

        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
