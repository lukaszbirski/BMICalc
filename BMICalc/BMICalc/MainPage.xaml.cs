using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BMICalc.models;
using Plugin.Toast;
using Rg.Plugins.Popup.Services;
using Xamarin.Essentials;

namespace BMICalc
{
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
            getMainPageFromPreferences();
        }

        private void changeUnitsToolbarItem_Clicked(object sender, EventArgs e)
        {
            /*string alert = "Popup menu will appear now";
            CrossToastPopUp.Current.ShowToastError(alert, Plugin.Toast.Abstractions.ToastLength.Short);*/
            PopupNavigation.Instance.PushAsync(new PopupPage());
        }

        private void getMainPageFromPreferences()
        {
            if (Preferences.ContainsKey((string)App.Current.Resources["systemKeyString"]))
            {
                var systemFromPreferences = Preferences.Get((string)App.Current.Resources["systemKeyString"], (string)App.Current.Resources["errorString"]);
                if (systemFromPreferences.Equals((string)App.Current.Resources["metricUnitsString"]))
                {
                    MetricUnitsPage metricUnitsPage = new MetricUnitsPage();
                    metricUnitsPage.Title = (string)App.Current.Resources["metricUnitsString"];
                    Children.Add(metricUnitsPage);
                }
                else if (systemFromPreferences.Equals((string)App.Current.Resources["usUnitsString"]))
                {
                    UsUnitsPage usUnitsPage = new UsUnitsPage();
                    usUnitsPage.Title = (string)App.Current.Resources["usUnitsString"];
                    Children.Add(usUnitsPage);
                }
            }
            else PopupNavigation.Instance.PushAsync(new PopupPage());
        }
    }
}
