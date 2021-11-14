using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class Mortgage_Calculator_Page : Page
	{
		public Mortgage_Calculator_Page()
		{
			this.InitializeComponent();
		}

		private void calcuateButton_Click(object sender, RoutedEventArgs e)
		{
			double principalBorrow, yearlyInterestRate, monthlyInterestRate, monthlyRepayment, noOfMonths, power, years, months;


			principalBorrow = double.Parse(principalBorrowTextBox.Text);
			years = double.Parse(yearsTextBox.Text);
			months = double.Parse(monthsTextBox.Text);
			yearlyInterestRate = double.Parse(yearlyInterestRateTextBox.Text) /100.0;
			noOfMonths = years * 12 + months;
			monthlyInterestRate = yearlyInterestRate / 12.0;


			monthlyRepayment = principalBorrow * monthlyInterestRate * (Math.Pow((1.0 + monthlyInterestRate), noOfMonths)) / ((Math.Pow((1.0 + monthlyInterestRate), noOfMonths)) - 1);


			monthlyInterestRateTextBox.Text = (yearlyInterestRate / 12.0).ToString("N4") + "%";

			monthlyRepaymentTextBox.Text = monthlyRepayment.ToString("N");

		}
    }
}
