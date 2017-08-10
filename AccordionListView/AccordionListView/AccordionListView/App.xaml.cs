using AccordionListView.DynamicStyle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AccordionListView
{
    public partial class App : Application
    {
        public static MasterDetailPage MasterDetailPage;
        public App()
        {
            InitializeComponent();

            SetMainPage();
        }
        public static void SetMainPage()
        {
             MasterDetailPage = new MasterDetailPage
            {
              
                Detail = new NavigationPage(new AccordionViewPage())
            };
            NavigationPage.SetHasNavigationBar(MasterDetailPage, false);
            NavigationPage.SetHasBackButton(MasterDetailPage, false);
            NavigationPage.SetBackButtonTitle(MasterDetailPage, "");
            Current.MainPage = MasterDetailPage;
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
    }
}
