using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatarynxPgmTest.ViewModels;
using Xamarin.Forms;

namespace DatarynxPgmTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new TaskDetailsViewModel();


        }

        void lstItems_ItemSelected(System.Object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;
    }
}
