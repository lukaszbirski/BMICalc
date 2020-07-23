using Plugin.Toast;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BMICalc.utils;

namespace BMICalc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MetricUnitsPage : ContentPage
    {
        public MetricUnitsPage()
        {
            InitializeComponent();
        }

        private void CalculateButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(kilogramsEntry.Text) && !string.IsNullOrEmpty(centimetersEntry.Text))
            {
                double kg = double.Parse(kilogramsEntry.Text);
                double cm = double.Parse(centimetersEntry.Text);
                Navigation.PushAsync(new ResultPage(kg, cm));
            }
            else 
            {
                string alert = (string)App.Current.Resources["toastAlertString"];
                CrossToastPopUp.Current.ShowToastError(alert, Plugin.Toast.Abstractions.ToastLength.Short);
            }
            
        }
    }
}