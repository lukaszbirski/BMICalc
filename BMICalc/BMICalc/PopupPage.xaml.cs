using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BMICalc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PopupPage
    {
        public PopupPage()
        {
            InitializeComponent();
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
                string alert = returnCheckedCheckBox();
                CrossToastPopUp.Current.ShowToastError(alert, Plugin.Toast.Abstractions.ToastLength.Short);
            }
        }

        private string returnCheckedCheckBox()
        {
            if (usUnitsCheckbox.IsChecked) return "US_UNITS";
            else return "METRIC_UNITS";
        }
    }
}