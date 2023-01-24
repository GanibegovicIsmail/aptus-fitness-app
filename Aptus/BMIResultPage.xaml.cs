using System;

namespace Aptus
{
    public partial class BMIResultPage : ContentPage
    {
        private double _height;
        private double _weight;
        private double _bmi;
        private string _classification;

        public BMIResultPage(double height, double weight)
        {
            InitializeComponent();
            _height = height;
            _weight = weight;
            CalculateBmi();
        }
        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();

        }

        private void OnNextButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GoalsPage());
        }

        // Create a static variable to store the BMI value
        public static double BmiValue { get; set; }

        private void CalculateBmi()
        {
            if (_height > 0 && _weight > 0)
            {
                _bmi = Math.Round(_weight / (_height / 100 * _height / 100), 2);
                BmiValueLabel.Text = _bmi.ToString();
                BmiValue = _bmi; // Store the BMI value in the static variable
                if (_bmi < 18.5)
                {
                    _classification = "Underweight";
                }
                else if (_bmi >= 18.5 && _bmi <= 24.9)
                {
                    _classification = "Normal weight";
                }
                else if (_bmi >= 25 && _bmi <= 29.9)
                {
                    _classification = "Overweight";
                }
                else if (_bmi >= 30)
                {
                    _classification = "Obesity";
                }
                ClassificationLabel.Text = _classification;
            }
        }

    }
}
