using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BMICalc.models;

namespace BMICalc
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ObliczButton_Clicked(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(kgEntry.Text) || string.IsNullOrEmpty(cmEntry.Text))
            {

            }
            else
            {
                double kg = double.Parse(kgEntry.Text);
                double cm = double.Parse(cmEntry.Text);
                Navigation.PushAsync(new ResultPage(kg, cm));
            }

        }
    }
}
