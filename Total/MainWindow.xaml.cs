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

namespace Total
{

    public partial class MainWindow : Window
    {
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
            counters[1] = new Counter();
            counters[2] = new Counter();
            counters[3] = new Counter();
        }


        /// 
        /// COUNTER 1
        /// 


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

                // Update and Save data
                Update_Save_data(0, 10, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

                // Get and Set saved total price to textBoxes
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

                // Update and Save data
                Update_Save_data(0, 50, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

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

                // Update and Save data
                Update_Save_data(0, 100, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        private void counter1_amountBox_500_KeyDown(object sender, KeyEventArgs e)
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

                // Update and Save data
                Update_Save_data(0, 500, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

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

                // Update and Save data
                Update_Save_data(0, 1000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

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

                // Update and Save data
                Update_Save_data(0, 5000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

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

                // Update and Save data
                Update_Save_data(0, 10000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

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

                // Update and Save data
                Update_Save_data(0, 50000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

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

                // Update and Save data
                Update_Save_data(0, 100000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

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

                // Update and Save data
                Update_Save_data(0, 10, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

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

                // Update and Save data
                Update_Save_data(0, 50, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

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

                // Update and Save data
                Update_Save_data(0, 100, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

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

                // Update and Save data
                Update_Save_data(0, 500, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

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

                // Update and Save data
                Update_Save_data(0, 1000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

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

                // Update and Save data
                Update_Save_data(0, 5000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

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

                // Update and Save data
                Update_Save_data(0, 10000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

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

                // Update and Save data
                Update_Save_data(0, 50000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

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

                // Update and Save data
                Update_Save_data(0, 100000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(0);

                // Get and Set total price
                Update_total_textBoxes(0);
            }
        }

        
        /// 
        /// COUNTER 2
        /// 
        

        private void counter2_amountBox_10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter2_amountBox_10.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter2_amountBox_10.Text = amount;

                // Move Cursor behind of text
                counter2_amountBox_10.Select(counter2_amountBox_10.Text.Length, 0);

                // Get and Set calculated price
                price = counters[1].GetPriceFromAmount(10, int.Parse(amount)).ToString();
                counter2_priceBox_10.Text = price;

                // Update and Save data
                Update_Save_data(1, 10, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_amountBox_50_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter2_amountBox_50.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter2_amountBox_50.Text = amount;

                // Move Cursor behind of text
                counter2_amountBox_50.Select(counter2_amountBox_50.Text.Length, 0);

                // Get and Set calculated price
                price = counters[1].GetPriceFromAmount(50, int.Parse(amount)).ToString();
                counter2_priceBox_50.Text = price;

                // Update and Save data
                Update_Save_data(1, 50, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_amountBox_100_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter2_amountBox_100.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter2_amountBox_100.Text = amount;

                // Move Cursor behind of text
                counter2_amountBox_100.Select(counter2_amountBox_100.Text.Length, 0);

                // Get and Set calculated price
                price = counters[1].GetPriceFromAmount(100, int.Parse(amount)).ToString();
                counter2_amountBox_100.Text = price;

                // Update and Save data
                Update_Save_data(1, 100, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_amountBox_500_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter2_amountBox_500.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter2_amountBox_500.Text = amount;

                // Move Cursor behind of text
                counter2_amountBox_500.Select(counter2_amountBox_500.Text.Length, 0);

                // Get and Set calculated price
                price = counters[1].GetPriceFromAmount(500, int.Parse(amount)).ToString();
                counter2_priceBox_500.Text = price;

                // Update and Save data
                Update_Save_data(1, 500, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_amountBox_1000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter2_amountBox_1000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter2_amountBox_1000.Text = amount;

                // Move Cursor behind of text
                counter2_amountBox_1000.Select(counter2_amountBox_1000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[1].GetPriceFromAmount(1000, int.Parse(amount)).ToString();
                counter2_priceBox_1000.Text = price;

                // Update and Save data
                Update_Save_data(1, 1000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_amountBox_5000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter2_amountBox_5000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter2_amountBox_5000.Text = amount;

                // Move Cursor behind of text
                counter2_amountBox_5000.Select(counter2_amountBox_5000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[1].GetPriceFromAmount(5000, int.Parse(amount)).ToString();
                counter2_priceBox_5000.Text = price;

                // Update and Save data
                Update_Save_data(1, 5000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_amountBox_10000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter2_amountBox_10000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter2_amountBox_10000.Text = amount;

                // Move Cursor behind of text
                counter2_amountBox_10000.Select(counter2_amountBox_10000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[1].GetPriceFromAmount(10000, int.Parse(amount)).ToString();
                counter2_priceBox_10000.Text = price;

                // Update and Save data
                Update_Save_data(1, 10000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_amountBox_50000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter2_amountBox_50000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter2_amountBox_50000.Text = amount;

                // Move Cursor behind of text
                counter2_amountBox_50000.Select(counter2_amountBox_50000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[1].GetPriceFromAmount(50000, int.Parse(amount)).ToString();
                counter2_priceBox_50000.Text = price;

                // Update and Save data
                Update_Save_data(1, 50000, amount, price);
                // Set saved price to textBlocks
                Update_textBlocks(1);


                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_amountBox_100000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter2_amountBox_100000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter2_amountBox_100000.Text = amount;

                // Move Cursor behind of text
                counter2_amountBox_100000.Select(counter2_amountBox_100000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[1].GetPriceFromAmount(100000, int.Parse(amount)).ToString();
                counter2_priceBox_100000.Text = price;

                // Update and Save data
                Update_Save_data(1, 100000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_priceBox_10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter2_priceBox_10.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter2_priceBox_10.Text = price;

                // Move Cursor behind of text
                counter2_priceBox_10.Select(counter2_priceBox_10.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[1].GetAmountFromPrice(10, int.Parse(price)).ToString();
                counter2_amountBox_10.Text = amount;

                // Update and Save data
                Update_Save_data(1, 10, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_priceBox_50_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter2_priceBox_50.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter2_priceBox_50.Text = price;

                // Move Cursor behind of text
                counter2_priceBox_50.Select(counter2_priceBox_50.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[1].GetAmountFromPrice(50, int.Parse(price)).ToString();
                counter2_amountBox_50.Text = amount;

                // Update and Save data
                Update_Save_data(1, 50, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_priceBox_100_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter2_priceBox_100.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter2_priceBox_100.Text = price;

                // Move Cursor behind of text
                counter2_priceBox_100.Select(counter2_priceBox_100.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[1].GetAmountFromPrice(100, int.Parse(price)).ToString();
                counter2_amountBox_100.Text = amount;

                // Update and Save data
                Update_Save_data(1, 100, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_priceBox_500_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter2_priceBox_500.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter2_priceBox_500.Text = price;

                // Move Cursor behind of text
                counter2_priceBox_500.Select(counter2_priceBox_500.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[1].GetAmountFromPrice(500, int.Parse(price)).ToString();
                counter2_amountBox_500.Text = amount;

                // Update and Save data
                Update_Save_data(1, 500, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_priceBox_1000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter2_priceBox_1000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter2_priceBox_1000.Text = price;

                // Move Cursor behind of text
                counter2_priceBox_1000.Select(counter2_priceBox_1000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[1].GetAmountFromPrice(1000, int.Parse(price)).ToString();
                counter2_amountBox_1000.Text = amount;

                // Update and Save data
                Update_Save_data(1, 1000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_priceBox_5000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter2_priceBox_5000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter2_priceBox_5000.Text = price;

                // Move Cursor behind of text
                counter2_priceBox_5000.Select(counter2_priceBox_5000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[1].GetAmountFromPrice(5000, int.Parse(price)).ToString();
                counter2_amountBox_5000.Text = amount;

                // Update and Save data
                Update_Save_data(1, 5000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_priceBox_10000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter2_priceBox_10000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter2_priceBox_10000.Text = price;

                // Move Cursor behind of text
                counter2_priceBox_10000.Select(counter2_priceBox_10000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[1].GetAmountFromPrice(10000, int.Parse(price)).ToString();
                counter2_amountBox_10000.Text = amount;

                // Update and Save data
                Update_Save_data(1, 10000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_priceBox_50000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter2_priceBox_50000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter2_priceBox_50000.Text = price;

                // Move Cursor behind of text
                counter2_priceBox_50000.Select(counter2_priceBox_50000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[1].GetAmountFromPrice(50000, int.Parse(price)).ToString();
                counter2_amountBox_50000.Text = amount;

                // Update and Save data
                Update_Save_data(1, 50000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }

        private void counter2_priceBox_100000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter2_priceBox_100000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter2_priceBox_100000.Text = price;

                // Move Cursor behind of text
                counter2_priceBox_100000.Select(counter2_priceBox_100000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[1].GetAmountFromPrice(100000, int.Parse(price)).ToString();
                counter2_amountBox_100000.Text = amount;

                // Update and Save data
                Update_Save_data(1, 100000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(1);

                // Get and Set total price
                Update_total_textBoxes(1);
            }
        }


        /// 
        /// COUNTER 3
        /// 


        private void counter3_amountBox_10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter3_amountBox_10.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter3_amountBox_10.Text = amount;

                // Move Cursor behind of text
                counter3_amountBox_10.Select(counter3_amountBox_10.Text.Length, 0);

                // Get and Set calculated price
                price = counters[2].GetPriceFromAmount(10, int.Parse(amount)).ToString();
                counter3_priceBox_10.Text = price;

                // Update and Save data
                Update_Save_data(2, 10, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_amountBox_50_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter3_amountBox_50.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter3_amountBox_50.Text = amount;

                // Move Cursor behind of text
                counter3_amountBox_50.Select(counter3_amountBox_50.Text.Length, 0);

                // Get and Set calculated price
                price = counters[2].GetPriceFromAmount(50, int.Parse(amount)).ToString();
                counter3_priceBox_50.Text = price;

                // Update and Save data
                Update_Save_data(2, 50, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_amountBox_100_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter3_amountBox_100.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter3_amountBox_100.Text = amount;

                // Move Cursor behind of text
                counter3_amountBox_100.Select(counter3_amountBox_100.Text.Length, 0);

                // Get and Set calculated price
                price = counters[2].GetPriceFromAmount(100, int.Parse(amount)).ToString();
                counter3_amountBox_100.Text = price;

                // Update and Save data
                Update_Save_data(2, 100, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_amountBox_500_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter3_amountBox_500.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter3_amountBox_500.Text = amount;

                // Move Cursor behind of text
                counter3_amountBox_500.Select(counter3_amountBox_500.Text.Length, 0);

                // Get and Set calculated price
                price = counters[2].GetPriceFromAmount(500, int.Parse(amount)).ToString();
                counter3_priceBox_500.Text = price;

                // Update and Save data
                Update_Save_data(2, 500, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_amountBox_1000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter3_amountBox_1000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter3_amountBox_1000.Text = amount;

                // Move Cursor behind of text
                counter3_amountBox_1000.Select(counter3_amountBox_1000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[2].GetPriceFromAmount(1000, int.Parse(amount)).ToString();
                counter3_priceBox_1000.Text = price;

                // Update and Save data
                Update_Save_data(2, 1000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_amountBox_5000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter3_amountBox_5000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter3_amountBox_5000.Text = amount;

                // Move Cursor behind of text
                counter3_amountBox_5000.Select(counter3_amountBox_5000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[2].GetPriceFromAmount(5000, int.Parse(amount)).ToString();
                counter3_priceBox_5000.Text = price;

                // Update and Save data
                Update_Save_data(2, 5000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_amountBox_10000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter3_amountBox_10000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter3_amountBox_10000.Text = amount;

                // Move Cursor behind of text
                counter3_amountBox_10000.Select(counter3_amountBox_10000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[2].GetPriceFromAmount(10000, int.Parse(amount)).ToString();
                counter3_priceBox_10000.Text = price;

                // Update and Save data
                Update_Save_data(2, 10000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_amountBox_50000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter3_amountBox_50000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter3_amountBox_50000.Text = amount;

                // Move Cursor behind of text
                counter3_amountBox_50000.Select(counter3_amountBox_50000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[2].GetPriceFromAmount(50000, int.Parse(amount)).ToString();
                counter3_priceBox_50000.Text = price;

                // Update and Save data
                Update_Save_data(2, 50000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_amountBox_100000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter3_amountBox_100000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter3_amountBox_100000.Text = amount;

                // Move Cursor behind of text
                counter3_amountBox_100000.Select(counter3_amountBox_100000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[2].GetPriceFromAmount(100000, int.Parse(amount)).ToString();
                counter3_priceBox_100000.Text = price;

                // Update and Save data
                Update_Save_data(2, 100000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_priceBox_10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter3_priceBox_10.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter3_priceBox_10.Text = price;

                // Move Cursor behind of text
                counter3_priceBox_10.Select(counter3_priceBox_10.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[2].GetAmountFromPrice(10, int.Parse(price)).ToString();
                counter3_amountBox_10.Text = amount;

                // Update and Save data
                Update_Save_data(2, 10, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_priceBox_50_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter3_priceBox_50.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter3_priceBox_50.Text = price;

                // Move Cursor behind of text
                counter3_priceBox_50.Select(counter3_priceBox_50.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[2].GetAmountFromPrice(50, int.Parse(price)).ToString();
                counter3_amountBox_50.Text = amount;

                // Update and Save data
                Update_Save_data(2, 50, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_priceBox_100_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter3_priceBox_100.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter3_priceBox_100.Text = price;

                // Move Cursor behind of text
                counter3_priceBox_100.Select(counter3_priceBox_100.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[2].GetAmountFromPrice(100, int.Parse(price)).ToString();
                counter3_amountBox_100.Text = amount;

                // Update and Save data
                Update_Save_data(2, 100, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_priceBox_500_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter3_priceBox_500.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter3_priceBox_500.Text = price;

                // Move Cursor behind of text
                counter3_priceBox_500.Select(counter3_priceBox_500.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[2].GetAmountFromPrice(500, int.Parse(price)).ToString();
                counter3_amountBox_500.Text = amount;

                // Update and Save data
                Update_Save_data(2, 500, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_priceBox_1000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter3_priceBox_1000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter3_priceBox_1000.Text = price;

                // Move Cursor behind of text
                counter3_priceBox_1000.Select(counter3_priceBox_1000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[2].GetAmountFromPrice(1000, int.Parse(price)).ToString();
                counter3_amountBox_1000.Text = amount;

                // Update and Save data
                Update_Save_data(2, 1000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_priceBox_5000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter3_priceBox_5000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter3_priceBox_5000.Text = price;

                // Move Cursor behind of text
                counter3_priceBox_5000.Select(counter3_priceBox_5000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[2].GetAmountFromPrice(5000, int.Parse(price)).ToString();
                counter3_amountBox_5000.Text = amount;

                // Update and Save data
                Update_Save_data(2, 5000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_priceBox_10000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter3_priceBox_10000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter3_priceBox_10000.Text = price;

                // Move Cursor behind of text
                counter3_priceBox_10000.Select(counter3_priceBox_10000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[2].GetAmountFromPrice(10000, int.Parse(price)).ToString();
                counter3_amountBox_10000.Text = amount;

                // Update and Save data
                Update_Save_data(2, 10000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_priceBox_50000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter3_priceBox_50000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter3_priceBox_50000.Text = price;

                // Move Cursor behind of text
                counter3_priceBox_50000.Select(counter3_priceBox_50000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[2].GetAmountFromPrice(50000, int.Parse(price)).ToString();
                counter3_amountBox_50000.Text = amount;

                // Update and Save data
                Update_Save_data(2, 50000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }

        private void counter3_priceBox_100000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter3_priceBox_100000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter3_priceBox_100000.Text = price;

                // Move Cursor behind of text
                counter3_priceBox_100000.Select(counter3_priceBox_100000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[2].GetAmountFromPrice(100000, int.Parse(price)).ToString();
                counter3_amountBox_100000.Text = amount;

                // Update and Save data
                Update_Save_data(2, 100000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(2);

                // Get and Set total price
                Update_total_textBoxes(2);
            }
        }


        /// 
        /// COUNTER 4
        /// 


        private void counter4_amountBox_10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter4_amountBox_10.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter4_amountBox_10.Text = amount;

                // Move Cursor behind of text
                counter4_amountBox_10.Select(counter4_amountBox_10.Text.Length, 0);

                // Get and Set calculated price
                price = counters[3].GetPriceFromAmount(10, int.Parse(amount)).ToString();
                counter4_priceBox_10.Text = price;

                // Update and Save data
                Update_Save_data(3, 10, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_amountBox_50_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter4_amountBox_50.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter4_amountBox_50.Text = amount;

                // Move Cursor behind of text
                counter4_amountBox_50.Select(counter4_amountBox_50.Text.Length, 0);

                // Get and Set calculated price
                price = counters[3].GetPriceFromAmount(50, int.Parse(amount)).ToString();
                counter4_priceBox_50.Text = price;

                // Update and Save data
                Update_Save_data(3, 50, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_amountBox_100_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter4_amountBox_100.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter4_amountBox_100.Text = amount;

                // Move Cursor behind of text
                counter4_amountBox_100.Select(counter4_amountBox_100.Text.Length, 0);

                // Get and Set calculated price
                price = counters[3].GetPriceFromAmount(100, int.Parse(amount)).ToString();
                counter4_amountBox_100.Text = price;

                // Update and Save data
                Update_Save_data(3, 100, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_amountBox_500_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter4_amountBox_500.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter4_amountBox_500.Text = amount;

                // Move Cursor behind of text
                counter4_amountBox_500.Select(counter4_amountBox_500.Text.Length, 0);

                // Get and Set calculated price
                price = counters[3].GetPriceFromAmount(500, int.Parse(amount)).ToString();
                counter4_priceBox_500.Text = price;

                // Update and Save data
                Update_Save_data(3, 500, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_amountBox_1000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter4_amountBox_1000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter4_amountBox_1000.Text = amount;

                // Move Cursor behind of text
                counter4_amountBox_1000.Select(counter4_amountBox_1000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[3].GetPriceFromAmount(1000, int.Parse(amount)).ToString();
                counter4_priceBox_1000.Text = price;

                // Update and Save data
                Update_Save_data(3, 1000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_amountBox_5000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter4_amountBox_5000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter4_amountBox_5000.Text = amount;

                // Move Cursor behind of text
                counter4_amountBox_5000.Select(counter4_amountBox_5000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[3].GetPriceFromAmount(5000, int.Parse(amount)).ToString();
                counter4_priceBox_5000.Text = price;

                // Update and Save data
                Update_Save_data(3, 5000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_amountBox_10000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter4_amountBox_10000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter4_amountBox_10000.Text = amount;

                // Move Cursor behind of text
                counter4_amountBox_10000.Select(counter4_amountBox_10000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[3].GetPriceFromAmount(10000, int.Parse(amount)).ToString();
                counter4_priceBox_10000.Text = price;

                // Update and Save data
                Update_Save_data(3, 10000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_amountBox_50000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter4_amountBox_50000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter4_amountBox_50000.Text = amount;

                // Move Cursor behind of text
                counter4_amountBox_50000.Select(counter4_amountBox_50000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[3].GetPriceFromAmount(50000, int.Parse(amount)).ToString();
                counter4_priceBox_50000.Text = price;

                // Update and Save data
                Update_Save_data(3, 50000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_amountBox_100000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = counter4_amountBox_100000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                counter4_amountBox_100000.Text = amount;

                // Move Cursor behind of text
                counter4_amountBox_100000.Select(counter4_amountBox_100000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[3].GetPriceFromAmount(100000, int.Parse(amount)).ToString();
                counter4_priceBox_100000.Text = price;

                // Update and Save data
                Update_Save_data(3, 100000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_priceBox_10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter4_priceBox_10.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter4_priceBox_10.Text = price;

                // Move Cursor behind of text
                counter4_priceBox_10.Select(counter4_priceBox_10.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[3].GetAmountFromPrice(10, int.Parse(price)).ToString();
                counter4_amountBox_10.Text = amount;

                // Update and Save data
                Update_Save_data(3, 10, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_priceBox_50_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter4_priceBox_50.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter4_priceBox_50.Text = price;

                // Move Cursor behind of text
                counter4_priceBox_50.Select(counter4_priceBox_50.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[3].GetAmountFromPrice(50, int.Parse(price)).ToString();
                counter4_amountBox_50.Text = amount;

                // Update and Save data
                Update_Save_data(3, 50, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_priceBox_100_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter4_priceBox_100.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter4_priceBox_100.Text = price;

                // Move Cursor behind of text
                counter4_priceBox_100.Select(counter4_priceBox_100.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[3].GetAmountFromPrice(100, int.Parse(price)).ToString();
                counter4_amountBox_100.Text = amount;

                // Update and Save data
                Update_Save_data(3, 100, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_priceBox_500_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter4_priceBox_500.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter4_priceBox_500.Text = price;

                // Move Cursor behind of text
                counter4_priceBox_500.Select(counter4_priceBox_500.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[3].GetAmountFromPrice(500, int.Parse(price)).ToString();
                counter4_amountBox_500.Text = amount;

                // Update and Save data
                Update_Save_data(3, 500, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_priceBox_1000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter4_priceBox_1000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter4_priceBox_1000.Text = price;

                // Move Cursor behind of text
                counter4_priceBox_1000.Select(counter4_priceBox_1000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[3].GetAmountFromPrice(1000, int.Parse(price)).ToString();
                counter4_amountBox_1000.Text = amount;

                // Update and Save data
                Update_Save_data(3, 1000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_priceBox_5000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter4_priceBox_5000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter4_priceBox_5000.Text = price;

                // Move Cursor behind of text
                counter4_priceBox_5000.Select(counter4_priceBox_5000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[3].GetAmountFromPrice(5000, int.Parse(price)).ToString();
                counter4_amountBox_5000.Text = amount;

                // Update and Save data
                Update_Save_data(3, 5000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_priceBox_10000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter4_priceBox_10000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter4_priceBox_10000.Text = price;

                // Move Cursor behind of text
                counter4_priceBox_10000.Select(counter4_priceBox_10000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[3].GetAmountFromPrice(10000, int.Parse(price)).ToString();
                counter4_amountBox_10000.Text = amount;

                // Update and Save data
                Update_Save_data(3, 10000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_priceBox_50000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter4_priceBox_50000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter4_priceBox_50000.Text = price;

                // Move Cursor behind of text
                counter4_priceBox_50000.Select(counter4_priceBox_50000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[3].GetAmountFromPrice(50000, int.Parse(price)).ToString();
                counter4_amountBox_50000.Text = amount;

                // Update and Save data
                Update_Save_data(3, 50000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void counter4_priceBox_100000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = counter4_priceBox_100000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                counter4_priceBox_100000.Text = price;

                // Move Cursor behind of text
                counter4_priceBox_100000.Select(counter4_priceBox_100000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[3].GetAmountFromPrice(100000, int.Parse(price)).ToString();
                counter4_amountBox_100000.Text = amount;

                // Update and Save data
                Update_Save_data(3, 100000, amount, price);

                // Set saved price to textBlocks
                Update_textBlocks(3);

                // Get and Set total price
                Update_total_textBoxes(3);
            }
        }

        private void originalPriceBox_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void Update_textBlocks(int _counter)
        {
            switch (_counter)
            {
                case 0:
                    counter1_amountBox_10.Text = counters[0].amount["10"];
                    counter1_amountBox_50.Text = counters[0].amount["50"];
                    counter1_amountBox_100.Text = counters[0].amount["100"];
                    counter1_amountBox_500.Text = counters[0].amount["500"];
                    counter1_amountBox_1000.Text = counters[0].amount["1000"];
                    counter1_amountBox_5000.Text = counters[0].amount["5000"];
                    counter1_amountBox_10000.Text = counters[0].amount["10000"];
                    counter1_amountBox_50000.Text = counters[0].amount["50000"];
                    counter1_amountBox_100000.Text = counters[0].amount["100000"];

                    counter1_priceBox_10.Text = counters[0].price["10"];
                    counter1_priceBox_50.Text = counters[0].price["50"];
                    counter1_priceBox_100.Text = counters[0].price["100"];
                    counter1_priceBox_500.Text = counters[0].price["500"];
                    counter1_priceBox_1000.Text = counters[0].price["1000"];
                    counter1_priceBox_5000.Text = counters[0].price["5000"];
                    counter1_priceBox_10000.Text = counters[0].price["10000"];
                    counter1_priceBox_50000.Text = counters[0].price["50000"];
                    counter1_priceBox_100000.Text = counters[0].price["100000"];
                    break;
                case 1:
                    counter2_amountBox_10.Text = counters[1].amount["10"];
                    counter2_amountBox_50.Text = counters[1].amount["50"];
                    counter2_amountBox_100.Text = counters[1].amount["100"];
                    counter2_amountBox_500.Text = counters[1].amount["500"];
                    counter2_amountBox_1000.Text = counters[1].amount["1000"];
                    counter2_amountBox_5000.Text = counters[1].amount["5000"];
                    counter2_amountBox_10000.Text = counters[1].amount["10000"];
                    counter2_amountBox_50000.Text = counters[1].amount["50000"];
                    counter2_amountBox_100000.Text = counters[1].amount["100000"];

                    counter2_priceBox_10.Text = counters[1].price["10"];
                    counter2_priceBox_50.Text = counters[1].price["50"];
                    counter2_priceBox_100.Text = counters[1].price["100"];
                    counter2_priceBox_500.Text = counters[1].price["500"];
                    counter2_priceBox_1000.Text = counters[1].price["1000"];
                    counter2_priceBox_5000.Text = counters[1].price["5000"];
                    counter2_priceBox_10000.Text = counters[1].price["10000"];
                    counter2_priceBox_50000.Text = counters[1].price["50000"];
                    counter2_priceBox_100000.Text = counters[1].price["100000"];
                    break;
                case 2:
                    counter3_amountBox_10.Text = counters[2].amount["10"];
                    counter3_amountBox_50.Text = counters[2].amount["50"];
                    counter3_amountBox_100.Text = counters[2].amount["100"];
                    counter3_amountBox_500.Text = counters[2].amount["500"];
                    counter3_amountBox_1000.Text = counters[2].amount["1000"];
                    counter3_amountBox_5000.Text = counters[2].amount["5000"];
                    counter3_amountBox_10000.Text = counters[2].amount["10000"];
                    counter3_amountBox_50000.Text = counters[2].amount["50000"];
                    counter3_amountBox_100000.Text = counters[2].amount["100000"];

                    counter3_priceBox_10.Text = counters[2].price["10"];
                    counter3_priceBox_50.Text = counters[2].price["50"];
                    counter3_priceBox_100.Text = counters[2].price["100"];
                    counter3_priceBox_500.Text = counters[2].price["500"];
                    counter3_priceBox_1000.Text = counters[2].price["1000"];
                    counter3_priceBox_5000.Text = counters[2].price["5000"];
                    counter3_priceBox_10000.Text = counters[2].price["10000"];
                    counter3_priceBox_50000.Text = counters[2].price["50000"];
                    counter3_priceBox_100000.Text = counters[2].price["100000"];
                    break;
                case 3:
                    counter4_amountBox_10.Text = counters[3].amount["10"];
                    counter4_amountBox_50.Text = counters[3].amount["50"];
                    counter4_amountBox_100.Text = counters[3].amount["100"];
                    counter4_amountBox_500.Text = counters[3].amount["500"];
                    counter4_amountBox_1000.Text = counters[3].amount["1000"];
                    counter4_amountBox_5000.Text = counters[3].amount["5000"];
                    counter4_amountBox_10000.Text = counters[3].amount["10000"];
                    counter4_amountBox_50000.Text = counters[3].amount["50000"];
                    counter4_amountBox_100000.Text = counters[3].amount["100000"];

                    counter4_priceBox_10.Text = counters[3].price["10"];
                    counter4_priceBox_50.Text = counters[3].price["50"];
                    counter4_priceBox_100.Text = counters[3].price["100"];
                    counter4_priceBox_500.Text = counters[3].price["500"];
                    counter4_priceBox_1000.Text = counters[3].price["1000"];
                    counter4_priceBox_5000.Text = counters[3].price["5000"];
                    counter4_priceBox_10000.Text = counters[3].price["10000"];
                    counter4_priceBox_50000.Text = counters[3].price["50000"];
                    counter4_priceBox_100000.Text = counters[3].price["100000"];
                    break;
            }
        }

        private void Update_Save_data(int _counter, int _currency, string _amount, string _price)
        {
            counters[_counter].UpdateData(_currency, int.Parse(_amount), int.Parse(_price));
            counters[_counter].SaveData();
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
            }
        }
    }
}
