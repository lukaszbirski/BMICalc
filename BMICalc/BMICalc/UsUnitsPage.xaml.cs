using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BMICalc.logic;
using Plugin.Toast;
using BMICalc.utils;

namespace BMICalc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsUnitsPage : ContentPage
    {
        public UsUnitsPage()
        {
            InitializeComponent();
        }

        private void CalculateButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(poundsEntry.Text) && !string.IsNullOrEmpty(feetsEntry.Text) && !string.IsNullOrEmpty(inchesEntry.Text))
            {
                double kg = Converters.poundsToKilogramsConverter(double.Parse(poundsEntry.Text));
                double cm = Converters.feetsAndInchesToCentimitersConverte(double.Parse(feetsEntry.Text), double.Parse(inchesEntry.Text)) ;
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