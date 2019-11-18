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
using System.Windows.Shapes;

namespace Total
{
    /// <summary>
    /// ExportSettingWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ExportSettingWindow : Window
    {
        public MainWindow mainWindow;

        public ExportSettingWindow()
        {
            InitializeComponent();
        }

        private void Close_btn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Export_btn_Click(object sender, RoutedEventArgs e)
        {
            string date = calendar.SelectedDate.Value.Year.ToString() + "." + calendar.SelectedDate.Value.Month.ToString() + "." + calendar.SelectedDate.Value.Day.ToString();
            mainWindow.Export_result(date);
            Close();
        }

        private void Rectangle_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }
    }
}
