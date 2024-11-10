using Microsoft.Maui.Controls;

namespace ecityloginpage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new SplashPage());
        }
    }
}
