using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SampleUITest.Business;
using Xamarin.Forms;

namespace SampleUITest
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

	    private void Add_Clicked(object sender, EventArgs e)
	    {
	        double.TryParse(ValueAEntry.Text, out var valueA);
	        double.TryParse(ValueBEntry.Text, out var valueB);
	        ResultLabel.Text = Calculator.Sum(valueA, valueB).ToString(CultureInfo.InvariantCulture);
	    }

	    private void Multiply_Clicked(object sender, EventArgs e)
	    {
	        double.TryParse(ValueAEntry.Text, out var valueA);
	        double.TryParse(ValueBEntry.Text, out var valueB);
	        ResultLabel.Text = Calculator.Multiply(valueA, valueB).ToString(CultureInfo.InvariantCulture);
        }
    }
}
