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
        int cur_Step = 1;

        Counter[] counters = new Counter[4];
        Rectangle[] counterPanels = new Rectangle[4];
        TextBlock[] counterTexts = new TextBlock[4];
        Step1 Step1 = new Step1();
        int cur_Counter = 0;

        public MainWindow()
        {
            InitializeComponent();

            // Load Data
            // Make Counter instance by data

            // Make Counter instance Load data

            // Set data of counters[0] (initial Counter) to TextBox
            // Update_Step1_Textboxes(cur_Counter);

            counters[0] = new Counter();
            // FOR TEST
            counters[1] = new Counter();
            counters[2] = new Counter();
            counters[3] = new Counter();
            //
            counterPanels[0] = counter1_panel1;
            counterPanels[1] = counter2_panel1;
            counterPanels[2] = counter3_panel1;
            counterPanels[3] = counter4_panel1;
            counterTexts[0] = counter1_text;
            counterTexts[1] = counter2_text;
            counterTexts[2] = counter3_text;
            counterTexts[3] = counter4_text;

        }

        private void AmountBox_10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = amountBox_10.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                amountBox_10.Text = amount;

                // Move Cursor behind of text
                amountBox_10.Select(amountBox_10.Text.Length, 0);

                // Get and Set calculated price
                price = counters[cur_Counter].GetPriceFromAmount(10, int.Parse(amount)).ToString();
                priceBox_10.Text = price;

                // Update data (save together)
                counters[cur_Counter].UpdateData(10, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void AmountBox_50_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = amountBox_50.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                amountBox_50.Text = amount;

                // Move Cursor behind of text
                amountBox_50.Select(amountBox_50.Text.Length, 0);

                // Get and Set calculated price
                price = counters[cur_Counter].GetPriceFromAmount(50, int.Parse(amount)).ToString();
                priceBox_50.Text = price;

                // Update data (save together)
                counters[cur_Counter].UpdateData(50, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void AmountBox_100_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = amountBox_100.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                amountBox_100.Text = amount;

                // Move Cursor behind of text
                amountBox_100.Select(amountBox_100.Text.Length, 0);

                // Get and Set calculated price
                price = counters[cur_Counter].GetPriceFromAmount(100, int.Parse(amount)).ToString();
                priceBox_100.Text = price;

                // Update data (save together)
                counters[cur_Counter].UpdateData(100, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void AmountBox_500_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = amountBox_500.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                amountBox_500.Text = amount;

                // Move Cursor behind of text
                amountBox_500.Select(amountBox_500.Text.Length, 0);

                // Get and Set calculated price
                price = counters[cur_Counter].GetPriceFromAmount(500, int.Parse(amount)).ToString();
                priceBox_500.Text = price;

                // Update data (save together)
                counters[cur_Counter].UpdateData(500, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void AmountBox_1000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = amountBox_1000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                amountBox_1000.Text = amount;

                // Move Cursor behind of text
                amountBox_1000.Select(amountBox_1000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[cur_Counter].GetPriceFromAmount(1000, int.Parse(amount)).ToString();
                priceBox_1000.Text = price;

                // Update data (save together)
                counters[cur_Counter].UpdateData(1000, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void AmountBox_5000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = amountBox_5000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                amountBox_5000.Text = amount;

                // Move Cursor behind of text
                amountBox_5000.Select(amountBox_5000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[cur_Counter].GetPriceFromAmount(5000, int.Parse(amount)).ToString();
                priceBox_5000.Text = price;

                // Update data (save together)
                counters[cur_Counter].UpdateData(5000, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void AmountBox_10000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = amountBox_10000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                amountBox_10000.Text = amount;

                // Move Cursor behind of text
                amountBox_10000.Select(amountBox_10000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[cur_Counter].GetPriceFromAmount(10000, int.Parse(amount)).ToString();
                priceBox_10000.Text = price;

                // Update data (save together)
                counters[cur_Counter].UpdateData(10000, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void AmountBox_50000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = amountBox_50000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                amountBox_50000.Text = amount;

                // Move Cursor behind of text
                amountBox_50000.Select(amountBox_50000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[cur_Counter].GetPriceFromAmount(50000, int.Parse(amount)).ToString();
                priceBox_50000.Text = price;

                // Update data (save together)
                counters[cur_Counter].UpdateData(50000, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void AmountBox_100000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount = amountBox_100000.Text;
                string price;
                if (string.IsNullOrWhiteSpace(amount)) amount = "0";

                // Check if calculation should be done
                amount = Step1.CheckCalculation(amount);
                amountBox_100000.Text = amount;

                // Move Cursor behind of text
                amountBox_100000.Select(amountBox_100000.Text.Length, 0);

                // Get and Set calculated price
                price = counters[cur_Counter].GetPriceFromAmount(100000, int.Parse(amount)).ToString();
                priceBox_100000.Text = price;

                // Update data (save together)
                counters[cur_Counter].UpdateData(100000, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void PriceBox_10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = priceBox_10.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                priceBox_10.Text = price;

                // Move Cursor behind of text
                priceBox_10.Select(priceBox_10.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[cur_Counter].GetAmountFromPrice(10, int.Parse(price)).ToString();
                amountBox_10.Text = amount;

                // Update data (save together)
                counters[cur_Counter].UpdateData(10, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void PriceBox_50_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = priceBox_50.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                priceBox_50.Text = price;

                // Move Cursor behind of text
                priceBox_50.Select(priceBox_50.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[cur_Counter].GetAmountFromPrice(50, int.Parse(price)).ToString();
                amountBox_50.Text = amount;

                // Update data (save together)
                counters[cur_Counter].UpdateData(50, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void PriceBox_100_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = priceBox_100.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                priceBox_100.Text = price;

                // Move Cursor behind of text
                priceBox_100.Select(priceBox_100.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[cur_Counter].GetAmountFromPrice(100, int.Parse(price)).ToString();
                amountBox_100.Text = amount;

                // Update data (save together)
                counters[cur_Counter].UpdateData(100, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void PriceBox_500_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = priceBox_500.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                priceBox_500.Text = price;

                // Move Cursor behind of text
                priceBox_500.Select(priceBox_500.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[cur_Counter].GetAmountFromPrice(500, int.Parse(price)).ToString();
                amountBox_500.Text = amount;

                // Update data (save together)
                counters[cur_Counter].UpdateData(500, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void PriceBox_1000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = priceBox_1000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                priceBox_1000.Text = price;

                // Move Cursor behind of text
                priceBox_1000.Select(priceBox_1000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[cur_Counter].GetAmountFromPrice(1000, int.Parse(price)).ToString();
                amountBox_1000.Text = amount;

                // Update data (save together)
                counters[cur_Counter].UpdateData(1000, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void PriceBox_5000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = priceBox_5000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                priceBox_5000.Text = price;

                // Move Cursor behind of text
                priceBox_5000.Select(priceBox_5000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[cur_Counter].GetAmountFromPrice(5000, int.Parse(price)).ToString();
                amountBox_5000.Text = amount;

                // Update data (save together)
                counters[cur_Counter].UpdateData(5000, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void PriceBox_10000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = priceBox_10000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                priceBox_10000.Text = price;

                // Move Cursor behind of text
                priceBox_10000.Select(priceBox_10000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[cur_Counter].GetAmountFromPrice(10000, int.Parse(price)).ToString();
                amountBox_10000.Text = amount;

                // Update data (save together)
                counters[cur_Counter].UpdateData(10000, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void PriceBox_50000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = priceBox_50000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                priceBox_50000.Text = price;

                // Move Cursor behind of text
                priceBox_50000.Select(priceBox_50000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[cur_Counter].GetAmountFromPrice(50000, int.Parse(price)).ToString();
                amountBox_50000.Text = amount;

                // Update data (save together)
                counters[cur_Counter].UpdateData(50000, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void PriceBox_100000_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                string amount;
                string price = priceBox_100000.Text;
                if (string.IsNullOrWhiteSpace(price)) price = "0";

                // Check if calculation should be done
                price = Step1.CheckCalculation(price);
                priceBox_100000.Text = price;

                // Move Cursor behind of text
                priceBox_100000.Select(priceBox_100000.Text.Length, 0);

                // Get and Set calculated price
                amount = counters[cur_Counter].GetAmountFromPrice(100000, int.Parse(price)).ToString();
                amountBox_100000.Text = amount;

                // Update data (save together)
                counters[cur_Counter].UpdateData(100000, int.Parse(amount), int.Parse(price));

                // Get and Set total price
                total_text.Text = counters[cur_Counter].GetTotalPrice().ToString();
            }
        }

        private void Counter1_panel1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int prev_Counter = cur_Counter;
            cur_Counter = 0;
            // Animation
            animate_Step1_Indexer(prev_Counter, cur_Counter);

            // Load data to textBox
            Update_Step1_Textboxes(cur_Counter);
        }

        private void Counter2_panel1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int prev_Counter = cur_Counter;
            cur_Counter = 1;
            // Animation
            animate_Step1_Indexer(prev_Counter, cur_Counter);

            // Load data to textBox
            Update_Step1_Textboxes(cur_Counter);
        }

        private void Counter3_panel1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int prev_Counter = cur_Counter;
            cur_Counter = 2;
            // Animation
            animate_Step1_Indexer(prev_Counter, cur_Counter);

            // Load data to textBox
            Update_Step1_Textboxes(cur_Counter);
        }

        private void Counter4_panel1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            int prev_Counter = cur_Counter;
            cur_Counter = 3;
            // Animation
            animate_Step1_Indexer(prev_Counter, cur_Counter);

            // Load data to textBox
            Update_Step1_Textboxes(cur_Counter);
        }

        private void animate_Step1_Indexer(int _prev, int _cur)
        {
            counterPanels[_prev].Fill = new SolidColorBrush(Color.FromRgb(1, 58, 64));
            counterTexts[_prev].Foreground = new SolidColorBrush(Color.FromRgb(255, 255, 255));

            counterPanels[_cur].Fill = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            counterTexts[_cur].Foreground = new SolidColorBrush(Color.FromRgb(0, 0, 0));
        }

        private void Update_Step1_Textboxes(int _cur)
        {
            amountBox_10.Text = counters[_cur].amount_10.ToString();
            amountBox_50.Text = counters[_cur].amount_50.ToString();
            amountBox_100.Text = counters[_cur].amount_100.ToString();
            amountBox_500.Text = counters[_cur].amount_500.ToString();
            amountBox_1000.Text = counters[_cur].amount_1000.ToString();
            amountBox_5000.Text = counters[_cur].amount_5000.ToString();
            amountBox_10000.Text = counters[_cur].amount_10000.ToString();
            amountBox_50000.Text = counters[_cur].amount_50000.ToString();
            amountBox_100000.Text = counters[_cur].amount_100000.ToString();

            priceBox_10.Text = counters[_cur].price_10.ToString();
            priceBox_50.Text = counters[_cur].price_50.ToString();
            priceBox_100.Text = counters[_cur].price_100.ToString();
            priceBox_500.Text = counters[_cur].price_500.ToString();
            priceBox_1000.Text = counters[_cur].price_1000.ToString();
            priceBox_5000.Text = counters[_cur].price_5000.ToString();
            priceBox_10000.Text = counters[_cur].price_10000.ToString();
            priceBox_50000.Text = counters[_cur].price_50000.ToString();
            priceBox_100000.Text = counters[_cur].price_100000.ToString();

            total_text.Text = counters[_cur].GetTotalPrice().ToString();
        }
    }
}
