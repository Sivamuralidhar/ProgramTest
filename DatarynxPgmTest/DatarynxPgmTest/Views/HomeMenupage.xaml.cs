using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace DatarynxPgmTest.Views
{
    public partial class HomeMenupage : ContentPage
    {

        public ObservableCollection<Options> options = new ObservableCollection<Options>
        {
            new Options{Title="About"},
            new Options{Title="Logout"},
        };

        public HomeMenupage()
        {
            InitializeComponent();
            lstItemsView.ItemsSource = options;

        }

        void lstItemsView_ItemSelected(System.Object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;
    }


    public class Options
    {
        public string Title { get; set; }
    }
}
