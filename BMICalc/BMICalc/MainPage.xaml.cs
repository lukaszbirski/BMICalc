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

namespace BMICalc
{
    [DesignTimeVisible(false)]
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void changeUnitsToolbarItem_Clicked(object sender, EventArgs e)
        {
            /*string alert = "Popup menu will appear now";
            CrossToastPopUp.Current.ShowToastError(alert, Plugin.Toast.Abstractions.ToastLength.Short);*/
            PopupNavigation.Instance.PushAsync(new PopupPage());
        }
    }
}
