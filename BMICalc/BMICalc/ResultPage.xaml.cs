using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BMICalc.models;

namespace BMICalc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage : ContentPage
    {
        public ResultPage(double kg, double cm)
        {
            InitializeComponent();
            Bmi bmi = new Bmi(kg, cm);
            string calcResult = bmi.Result.ToString();
            resultLabel.Text = $"Wskaźnik BMI wynosi: {calcResult}";
            descriptionLabel.Text = $"i oznacza {bmi.getDescription()}.";
        }
    }
}