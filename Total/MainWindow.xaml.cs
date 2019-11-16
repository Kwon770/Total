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
        Expenditure expenditure = new Expenditure();

        Step1 Step1 = new Step1();
        Step2 Step2 = new Step2();

        int originalPrice = 0;

        public MainWindow()
        {
            for (int i = 0; i < 4; i++) counters[i] = new Counter();
            InitializeComponent();



            // Load Data
            // Make Counter instance by data

            // Make Counter instance Load data

            // Set data of counters[0] (initial Counter) to TextBox
            // Update_Step1_Textboxes(0);
        }


        /// COUNTER 1


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
                Update_Save_counter_data(0, 10, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set saved total price to textBoxes
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 50, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 100, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 500, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 1000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 5000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 10000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 50000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 100000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 10, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 50, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 100, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 500, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 1000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 5000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 10000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 50000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
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
                Update_Save_counter_data(0, 100000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(0);

                // Get and Set total price
                Update_counter_total_textBoxes(0);
            }
        }

        
        /// COUNTER 2
        

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
                Update_Save_counter_data(1, 10, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 50, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 100, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 500, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 1000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 5000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 10000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 50000, amount, price);
                // Set saved price to textBlocks
                Update_counter_textBlocks(1);


                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 100000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 10, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 50, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 100, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 500, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 1000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 5000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 10000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 50000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
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
                Update_Save_counter_data(1, 100000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(1);

                // Get and Set total price
                Update_counter_total_textBoxes(1);
            }
        }


        /// COUNTER 3


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
                Update_Save_counter_data(2, 10, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 50, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 100, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 500, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 1000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 5000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 10000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 50000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 100000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 10, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 50, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 100, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 500, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 1000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 5000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 10000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 50000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
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
                Update_Save_counter_data(2, 100000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(2);

                // Get and Set total price
                Update_counter_total_textBoxes(2);
            }
        }


        /// COUNTER 4


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
                Update_Save_counter_data(3, 10, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 50, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 100, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 500, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 1000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 5000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 10000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 50000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 100000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 10, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 50, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 100, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 500, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 1000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 5000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 10000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 50000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
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
                Update_Save_counter_data(3, 100000, amount, price);

                // Set saved price to textBlocks
                Update_counter_textBlocks(3);

                // Get and Set total price
                Update_counter_total_textBoxes(3);
            }
        }


        /// 


        private void Update_counter_textBlocks(int _counter)
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

        private void Update_Save_counter_data(int _counter, int _currency, string _amount, string _price)
        {
            counters[_counter].UpdateData(_currency, int.Parse(_amount), int.Parse(_price));
            counters[_counter].SaveData();
        }

        private void Update_counter_total_textBoxes(int _counter)
        {
            string total = counters[_counter].Get_totalPrice().ToString();

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

            Update_result();
        }


        /// 


        private void CashNameBox_0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                expenditure.Save_name(0, cashNameBox_0.Text);
            }
        }

        private void CashNameBox_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                expenditure.Save_name(1, cashNameBox_1.Text);
            }
        }

        private void CashNameBox_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                expenditure.Save_name(2, cashNameBox_2.Text);
            }
        }

        private void CashNameBox_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                expenditure.Save_name(3, cashNameBox_3.Text);
            }
        }

        private void CashNameBox_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                expenditure.Save_name(4, cashNameBox_4.Text);
            }
        }

        private void CashNameBox_5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                expenditure.Save_name(5, cashNameBox_5.Text);
            }
        }

        private void CashNameBox_6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                expenditure.Save_name(6, cashNameBox_6.Text);
            }
        }

        private void CashNameBox_7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                expenditure.Save_name(7, cashNameBox_7.Text);
            }
        }

        private void CashNameBox_8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                expenditure.Save_name(8, cashNameBox_8.Text);
            }
        }

        private void CashNameBox_9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                expenditure.Save_name(9, cashNameBox_9.Text);
            }
        }

        private void CashPriceBox_0_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string price = cashPriceBox_0.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                cashPriceBox_0.Text = price;

                // Move Cursor behind of text
                cashPriceBox_0.Select(cashPriceBox_0.Text.Length, 0);

                // Save data
                expenditure.Save_price(0, price);

                // Get and Set total price
                Update_cash_total_textBoxes();
                Update_result();
            }
        }

        private void CashPriceBox_1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string price = cashPriceBox_1.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                cashPriceBox_1.Text = price;

                // Move Cursor behind of text
                cashPriceBox_1.Select(cashPriceBox_1.Text.Length, 0);

                // Save data
                expenditure.Save_price(1, price);

                // Get and Set total price
                Update_cash_total_textBoxes();
                Update_result();
            }
        }

        private void CashPriceBox_2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string price = cashPriceBox_2.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                cashPriceBox_2.Text = price;

                // Move Cursor behind of text
                cashPriceBox_2.Select(cashPriceBox_2.Text.Length, 0);

                // Save data
                expenditure.Save_price(2, price);

                // Get and Set total price
                Update_cash_total_textBoxes();
                Update_result();
            }
        }

        private void CashPriceBox_3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string price = cashPriceBox_3.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                cashPriceBox_3.Text = price;

                // Move Cursor behind of text
                cashPriceBox_3.Select(cashPriceBox_3.Text.Length, 0);

                // Save data
                expenditure.Save_price(3, price);

                // Get and Set total price
                Update_cash_total_textBoxes();
                Update_result();
            }
        }

        private void CashPriceBox_4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string price = cashPriceBox_4.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                cashPriceBox_4.Text = price;

                // Move Cursor behind of text
                cashPriceBox_4.Select(cashPriceBox_4.Text.Length, 0);

                // Save data
                expenditure.Save_price(4, price);

                // Get and Set total price
                Update_cash_total_textBoxes();
                Update_result();
            }
        }

        private void CashPriceBox_5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string price = cashPriceBox_5.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                cashPriceBox_5.Text = price;

                // Move Cursor behind of text
                cashPriceBox_5.Select(cashPriceBox_5.Text.Length, 0);

                // Save data
                expenditure.Save_price(5, price);

                // Get and Set total price
                Update_cash_total_textBoxes();
                Update_result();
            }
        }

        private void CashPriceBox_6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string price = cashPriceBox_6.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                cashPriceBox_6.Text = price;

                // Move Cursor behind of text
                cashPriceBox_6.Select(cashPriceBox_6.Text.Length, 0);

                // Save data
                expenditure.Save_price(6, price);

                // Get and Set total price
                Update_cash_total_textBoxes();
                Update_result();
            }
        }

        private void CashPriceBox_7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string price = cashPriceBox_7.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                cashPriceBox_7.Text = price;

                // Move Cursor behind of text
                cashPriceBox_7.Select(cashPriceBox_7.Text.Length, 0);

                // Save data
                expenditure.Save_price(7, price);

                // Get and Set total price
                Update_cash_total_textBoxes();
                Update_result();
            }
        }

        private void CashPriceBox_8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string price = cashPriceBox_8.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                cashPriceBox_8.Text = price;

                // Move Cursor behind of text
                cashPriceBox_8.Select(cashPriceBox_8.Text.Length, 0);

                // Save data
                expenditure.Save_price(8, price);

                // Get and Set total price
                Update_cash_total_textBoxes();
                Update_result();
            }
        }

        private void CashPriceBox_9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string price = cashPriceBox_9.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                cashPriceBox_9.Text = price;

                // Move Cursor behind of text
                cashPriceBox_9.Select(cashPriceBox_9.Text.Length, 0);

                // Save data
                expenditure.Save_price(9, price);

                // Get and Set total price
                Update_cash_total_textBoxes();
                Update_result();
            }
        }

        private void CashTypeBox_0_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            expenditure.Save_Type(0, cashTypeBox_0.SelectedIndex);

            expenditure.Update_price();

            // Get and Set total price
            Update_cash_total_textBoxes();
            Update_result();
        }

        private void CashTypeBox_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            expenditure.Save_Type(1, cashTypeBox_1.SelectedIndex);

            expenditure.Update_price();

            // Get and Set total price
            Update_cash_total_textBoxes();
            Update_result();
        }

        private void CashTypeBox_2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            expenditure.Save_Type(2, cashTypeBox_2.SelectedIndex);

            expenditure.Update_price();

            // Get and Set total price
            Update_cash_total_textBoxes();
            Update_result();
        }

        private void CashTypeBox_3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            expenditure.Save_Type(3, cashTypeBox_3.SelectedIndex);

            expenditure.Update_price();

            // Get and Set total price
            Update_cash_total_textBoxes();
            Update_result();
        }

        private void CashTypeBox_4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            expenditure.Save_Type(4, cashTypeBox_4.SelectedIndex);

            expenditure.Update_price();

            // Get and Set total price
            Update_cash_total_textBoxes();
            Update_result();
        }

        private void CashTypeBox_5_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            expenditure.Save_Type(5, cashTypeBox_5.SelectedIndex);

            expenditure.Update_price();

            // Get and Set total price
            Update_cash_total_textBoxes();
            Update_result();
        }

        private void CashTypeBox_6_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            expenditure.Save_Type(6, cashTypeBox_6.SelectedIndex);

            expenditure.Update_price();

            // Get and Set total price
            Update_cash_total_textBoxes();
            Update_result();
        }

        private void CashTypeBox_7_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            expenditure.Save_Type(7, cashTypeBox_7.SelectedIndex);

            expenditure.Update_price();

            // Get and Set total price
            Update_cash_total_textBoxes();
            Update_result();
        }

        private void CashTypeBox_8_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            expenditure.Save_Type(8, cashTypeBox_8.SelectedIndex);

            expenditure.Update_price();

            // Get and Set total price
            Update_cash_total_textBoxes();
            Update_result();
        }

        private void CashTypeBox_9_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            expenditure.Save_Type(9, cashTypeBox_9.SelectedIndex);

            expenditure.Update_price();

            // Get and Set total price
            Update_cash_total_textBoxes();
            Update_result();
        }


        ///


        private void Update_cash_total_textBoxes()
        {
            cashExpenditure_total_text1.Text = expenditure.Get_totalPrice().ToString();
            cashExpenditure_total_text2.Text = expenditure.Get_totalPrice().ToString();
        }


        ///


        private void originalPriceBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string price = originalPriceBox.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                originalPriceBox.Text = price;

                // Move Cursor behind of text
                originalPriceBox.Select(counter4_priceBox_100000.Text.Length, 0);

                // Set calculated price
                originalPrice = int.Parse(price);

                // Update result
                Update_result();
            }
        }

        private void Update_result()
        {
            int result = originalPrice - counters[0].Get_totalPrice() - counters[1].Get_totalPrice() - counters[2].Get_totalPrice()
                - counters[3].Get_totalPrice() - expenditure.Get_totalPrice();

            if (result < 0)
            {
                result *= -1;
                judge_text.Text = "남습니다";
            }
            else if (judge_text != null)
            {
                judge_text.Text = "모자랍니다";
            }
            if (resultPrice_text != null) resultPrice_text.Text = result.ToString();
        }


        ///


        private void TopBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }
    }
}
