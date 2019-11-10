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
        int currentStep = 1;

        Counter[] counters = new Counter[4];
        Step1 Step1 = new Step1();
        int currentCounter = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AmountBox_10_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void AmountBox_50_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void AmountBox_100_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void AmountBox_500_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void AmountBox_1000_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void AmountBox_5000_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void AmountBox_10000_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void AmountBox_50000_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void AmountBox_100000_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
