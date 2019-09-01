using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
	public partial class MainPage : ContentPage
	{
        SimpleInterestCalculatorModel Model = new SimpleInterestCalculatorModel();
        public MainPage()
		{
            BindingContext = this.Model;
            InitializeComponent();
            
		}

        private void Calculate_Clicked(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(this.Model.Prinipal_Amount) || string.IsNullOrEmpty(this.Model.Rate) || string.IsNullOrEmpty(this.Model.Time))
                {
                    DisplayAlert("Alert!", "Please Enter Mandatory Items", "OK");
                    return;
                }
                else
                    this.Model.CalculatedValue = (Convert.ToDouble(this.Model.Prinipal_Amount) * Convert.ToDouble(this.Model.Rate) * Convert.ToDouble(this.Model.Time) / 100).ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void refresh_Clicked(object sender, EventArgs e)
        {
            this.Model.Prinipal_Amount = null;
            this.Model.Time = null;
            this.Model.CalculatedValue = null;
            this.Model.Rate = null;
        }
    }
}
