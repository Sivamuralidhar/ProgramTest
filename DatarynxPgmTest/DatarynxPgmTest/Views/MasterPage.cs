using System;
using Xamarin.Forms;

namespace DatarynxPgmTest.Views
{
    public class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {

            this.IconImageSource = null;
            this.Title = "";

            NavigationPage.SetHasNavigationBar(this, true);

            Application.Current.Properties["ParentPage"] = this;

            Master = new HomeMenupage();

            Detail = new NavigationPage(new MainPage())
            {
                BarBackgroundColor = Color.AliceBlue,
                BarTextColor = Color.Black,

            };
        }

    }
}
