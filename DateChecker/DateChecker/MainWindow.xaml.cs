using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DateChecker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, RoutedEventArgs e)
        {
            dayTxt.Text = "";
            monthTxt.Text = "";
            yearTxt.Text = "";
        }

        private void check(string[] messages, params Func<bool>[] tests)
        {
            foreach (var test in tests.Select((value, index) => new { index, value }))
            {
                if (!test.value())
                {
                    MessageBox.Show(messages[test.index]);
                    return;
                }
            }
            MessageBox.Show(messages[messages.Length - 1]);
        }

        private void checkBtn_Click(object sender, RoutedEventArgs e)
        {
            int day = 0, month = 0, year = 0;
            string[] messages = {
                "Input data for day is incorrect format!",
                "Input data for day is out of range!",
                "Input data for month is incorrect format!",
                "Input data for month is out of range!",
                "Input data for year is incorrect format!",
                "Input data for year is out of range!",
                "dd/MM/yyyy is NOT correct data time!",
                "dd/MM/yyyy is correct data time!"
            };
            check(messages, () => {
                return int.TryParse(dayTxt.Text, out day);
            }, () => {
                return day >= 1 && day <= 31;
            }, () => {
                return int.TryParse(monthTxt.Text, out month);
            }, () => {
                return month >= 1 && month <= 12;
            }, () => {
                return int.TryParse(yearTxt.Text, out year);
            }, () => {
                return year >= 1000 && year <= 3000;
            }, () => {
                try
                {
                    DateTime datetime = DateTime.ParseExact($"{day}-{month}-{year}", "d-M-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    return true;
                }
                catch (System.FormatException)
                {
                    return false;
                }
            });
        }

        private void checkOnEnter(KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                checkBtn_Click(null, null);
            }
        }

        private void dayTxt_KeyDown(object sender, KeyEventArgs e)
        {
            checkOnEnter(e);
        }

        private void monthTxt_KeyDown(object sender, KeyEventArgs e)
        {
            checkOnEnter(e);
        }

        private void yearTxt_KeyDown(object sender, KeyEventArgs e)
        {
            checkOnEnter(e);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to quit?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
