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

// 1 step
// ALWAYS -> counter1_panel1 / CONDITIONAL -> counter2_text, counter3_text, counter4_text, counter2_plusBtn, counter3_plusBtn, counter4_plusBtn
// 2 step
//
// 3 step
//

namespace Total
{
    public partial class MainWindow : Window
    {
        Counter counter1 = new Counter();
        Counter counter2 = new Counter();
        Counter counter3 = new Counter();
        Counter counter4 = new Counter();
        Counter[] counters = new Counter[4];
        Step1 Step1 = new Step1();

        public MainWindow()
        {
            InitializeComponent();

            // Load Data
            // Make Counter instance by data

            // Make Counter instance Load data

            // Set data of counters[0] (initial Counter) to TextBox
            // Update_Step1_Textboxes(0);

            counters[0] = new Counter();
            // FOR TEST
            counters[1] = new Counter();
            counters[2] = new Counter();
            counters[3] = new Counter();
            //

        }

        private void counter1_amountBox_10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter1_amountBox_10.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter1_amountBox_10.Text = amount;

                // Move Cursor behind of text
                counter1_amountBox_10.Select(counter1_amountBox_10.Text.Length, 0);

                // Get and Set calculated price
                price = counters[0].GetPriceFromAmount(10, int.Parse(amount)).ToString();
                counter1_priceBox_10.Text = price;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_amountBox_50_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter1_amountBox_50.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter1_amountBox_50.Text = amount;

                // Move Cursor behind of text
                counter1_amountBox_50.Select(counter1_amountBox_50.Text.Length, 0);

                // Get and Set calculated price
                price = counters[0].GetPriceFromAmount(50, int.Parse(amount)).ToString();
                counter1_priceBox_50.Text = price;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_amountBox_100_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter1_amountBox_100.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter1_amountBox_100.Text = amount;

                // Move Cursor behind of text
                counter1_amountBox_100.Select(counter1_amountBox_100.Text.Length, 0);

                // Get and Set calculated price
                price = counters[0].GetPriceFromAmount(100, int.Parse(amount)).ToString();
                counter1_amountBox_100.Text = price;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_counter1_amountBox_500_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter1_amountBox_500.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter1_amountBox_500.Text = amount;

                // Move Cursor behind of text
                counter1_amountBox_500.Select(counter1_amountBox_500.Text.Length, 0);

                // Get and Set calculated price
                price = counters[0].GetPriceFromAmount(500, int.Parse(amount)).ToString();
                counter1_priceBox_500.Text = price;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_amountBox_1000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter1_amountBox_1000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter1_amountBox_1000.Text = amount;

                // Move Cursor behind of text
                counter1_amountBox_1000.Select(counter1_amountBox_1000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[0].GetPriceFromAmount(1000, int.Parse(amount)).ToString();
                counter1_priceBox_1000.Text = price;

                // Update data (save together)
                counters[0].UpdateData(1000, int.Parse(amount), int.Parse(price));

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_amountBox_5000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter1_amountBox_5000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter1_amountBox_5000.Text = amount;

                // Move Cursor behind of text
                counter1_amountBox_5000.Select(counter1_amountBox_5000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[0].GetPriceFromAmount(5000, int.Parse(amount)).ToString();
                counter1_priceBox_5000.Text = price;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_amountBox_10000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter1_amountBox_10000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter1_amountBox_10000.Text = amount;

                // Move Cursor behind of text
                counter1_amountBox_10000.Select(counter1_amountBox_10000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[0].GetPriceFromAmount(10000, int.Parse(amount)).ToString();
                counter1_priceBox_10000.Text = price;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_amountBox_50000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter1_amountBox_50000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter1_amountBox_50000.Text = amount;

                // Move Cursor behind of text
                counter1_amountBox_50000.Select(counter1_amountBox_50000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[0].GetPriceFromAmount(50000, int.Parse(amount)).ToString();
                counter1_priceBox_50000.Text = price;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_amountBox_100000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter1_amountBox_100000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter1_amountBox_100000.Text = amount;

                // Move Cursor behind of text
                counter1_amountBox_100000.Select(counter1_amountBox_100000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[0].GetPriceFromAmount(100000, int.Parse(amount)).ToString();
                counter1_priceBox_100000.Text = price;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_priceBox_10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter1_priceBox_10.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter1_priceBox_10.Text = price;

                // Move Cursor behind of text
                counter1_priceBox_10.Select(counter1_priceBox_10.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[0].GetAmountFromPrice(10, int.Parse(price)).ToString();
                counter1_amountBox_10.Text = amount;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_priceBox_50_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter1_priceBox_50.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter1_priceBox_50.Text = price;

                // Move Cursor behind of text
                counter1_priceBox_50.Select(counter1_priceBox_50.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[0].GetAmountFromPrice(50, int.Parse(price)).ToString();
                counter1_amountBox_50.Text = amount;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_priceBox_100_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter1_priceBox_100.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter1_priceBox_100.Text = price;

                // Move Cursor behind of text
                counter1_priceBox_100.Select(counter1_priceBox_100.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[0].GetAmountFromPrice(100, int.Parse(price)).ToString();
                counter1_amountBox_100.Text = amount;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_priceBox_500_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter1_priceBox_500.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter1_priceBox_500.Text = price;

                // Move Cursor behind of text
                counter1_priceBox_500.Select(counter1_priceBox_500.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[0].GetAmountFromPrice(500, int.Parse(price)).ToString();
                counter1_amountBox_500.Text = amount;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_priceBox_1000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter1_priceBox_1000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter1_priceBox_1000.Text = price;

                // Move Cursor behind of text
                counter1_priceBox_1000.Select(counter1_priceBox_1000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[0].GetAmountFromPrice(1000, int.Parse(price)).ToString();
                counter1_amountBox_1000.Text = amount;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_priceBox_5000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter1_priceBox_5000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter1_priceBox_5000.Text = price;

                // Move Cursor behind of text
                counter1_priceBox_5000.Select(counter1_priceBox_5000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[0].GetAmountFromPrice(5000, int.Parse(price)).ToString();
                counter1_amountBox_5000.Text = amount;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_priceBox_10000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter1_priceBox_10000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter1_priceBox_10000.Text = price;

                // Move Cursor behind of text
                counter1_priceBox_10000.Select(counter1_priceBox_10000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[0].GetAmountFromPrice(10000, int.Parse(price)).ToString();
                counter1_amountBox_10000.Text = amount;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_priceBox_50000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter1_priceBox_50000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter1_priceBox_50000.Text = price;

                // Move Cursor behind of text
                counter1_priceBox_50000.Select(counter1_priceBox_50000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[0].GetAmountFromPrice(50000, int.Parse(price)).ToString();
                counter1_amountBox_50000.Text = amount;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_priceBox_100000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter1_priceBox_100000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter1_priceBox_100000.Text = price;

                // Move Cursor behind of text
                counter1_priceBox_100000.Select(counter1_priceBox_100000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[0].GetAmountFromPrice(100000, int.Parse(price)).ToString();
                counter1_amountBox_100000.Text = amount;

                // Update data (save together)
                Update_Save_data(0, amount, price);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void Update_counter1_textBlocks(int _counter)
        {
            counter1_amountBox_10.Text = counters[_counter].amount_10.ToString();
            counter1_amountBox_50.Text = counters[_counter].amount_50.ToString();
            counter1_amountBox_100.Text = counters[_counter].amount_100.ToString();
            counter1_amountBox_500.Text = counters[_counter].amount_500.ToString();
            counter1_amountBox_1000.Text = counters[_counter].amount_1000.ToString();
            counter1_amountBox_5000.Text = counters[_counter].amount_5000.ToString();
            counter1_amountBox_10000.Text = counters[_counter].amount_10000.ToString();
            counter1_amountBox_50000.Text = counters[_counter].amount_50000.ToString();
            counter1_amountBox_100000.Text = counters[_counter].amount_100000.ToString();

            counter1_priceBox_10.Text = counters[_counter].price_10.ToString();
            counter1_priceBox_50.Text = counters[_counter].price_50.ToString();
            counter1_priceBox_100.Text = counters[_counter].price_100.ToString();
            counter1_priceBox_500.Text = counters[_counter].price_500.ToString();
            counter1_priceBox_1000.Text = counters[_counter].price_1000.ToString();
            counter1_priceBox_5000.Text = counters[_counter].price_5000.ToString();
            counter1_priceBox_10000.Text = counters[_counter].price_10000.ToString();
            counter1_priceBox_50000.Text = counters[_counter].price_50000.ToString();
            counter1_priceBox_100000.Text = counters[_counter].price_100000.ToString();
        }

        private void Update_Save_data(int _counter, string _amount, string _price)
        {
            counters[_counter].UpdateData(10, int.Parse(_amount), int.Parse(_price));
        }

        private void Update_total_textBoxes(int _counter)
        {
            string total = counters[_counter].GetTotalPrice().ToString();

            switch (_counter)
            {
                case 0:
                    counter1_total_text1.Text = total;
                    counter1_total_text2.Text = total;
                    break;
                case 1:
                    counter2_total_text1.Text = total;
                    counter2_total_text2.Text = total;
                    break;
                case 2:
                    counter3_total_text1.Text = total;
                    counter3_total_text2.Text = total;
                    break;
                case 3:
                    counter4_total_text1.Text = total;
                    counter4_total_text2.Text = total;
                    break;
            }
        }
    }
}
