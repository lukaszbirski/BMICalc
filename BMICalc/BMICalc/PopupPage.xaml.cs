using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace BMICalc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupPage
    {
        public PopupPage()
        {
            InitializeComponent();
            setCheckBoxsFromPreferences();
        }

        private void metricUnitsCheckbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            usUnitsCheckbox.IsChecked = !metricUnitsCheckbox.IsChecked;
        }

        private void usUnitsCheckbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            metricUnitsCheckbox.IsChecked = !usUnitsCheckbox.IsChecked;
        }

        private void saveButton_Clicked(object sender, EventArgs e)
        {
            if(metricUnitsCheckbox.IsChecked || usUnitsCheckbox.IsChecked)
            {
                string choosenSystem = returnCheckedCheckBox();
                Preferences.Set((string)App.Current.Resources["systemKeyString"], choosenSystem);
                Navigation.PushAsync(new MainPage());
            }
        }

        private string returnCheckedCheckBox()
        {
            if (usUnitsCheckbox.IsChecked) return (string)App.Current.Resources["usUnitsString"];
            else return (string)App.Current.Resources["metricUnitsString"];
        }

        private void setCheckBoxsFromPreferences()
        {
            if (Preferences.ContainsKey((string)App.Current.Resources["systemKeyString"]))
            {
                var systemFromPreferences = Preferences.Get((string)App.Current.Resources["systemKeyString"], (string)App.Current.Resources["errorString"]);
                if (systemFromPreferences.Equals((string)App.Current.Resources["metricUnitsString"]))
                {
                    metricUnitsCheckbox.IsChecked = true;
                    usUnitsCheckbox.IsChecked = false;
                }
                else if (systemFromPreferences.Equals((string)App.Current.Resources["usUnitsString"]))
                {
                    metricUnitsCheckbox.IsChecked = false;
                    usUnitsCheckbox.IsChecked = true;
                }
            }
        }
    }
}