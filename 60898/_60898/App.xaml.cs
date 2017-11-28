using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace _60898
{
    public partial class App : Application
    {
        public static App Instance;

        public App()
        {
            InitializeComponent();
            Instance = this;

            MainPage = new NavigationPage(new FirstMasterDetailPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public void SetMainPage(Page p)
        {
            MainPage = p;
        }
    }
}
