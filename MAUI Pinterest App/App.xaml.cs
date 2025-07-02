using MAUI_Pinterest_App.Views;

namespace MAUI_Pinterest_App
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

        }

    }
}