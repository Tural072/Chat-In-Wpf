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

namespace Chat_In_Wpf
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

        

        private void sendBtn_Click(object sender, RoutedEventArgs e)
        {
            string space = "\n";

            user.HorizontalAlignment = HorizontalAlignment.Left;
            user.Items.Add(msgTxtb.Text);
            user.Items.Add(space);

            msgTxtb.Text = msgTxtb.Text.ToLower();
            if (msgTxtb.Text == "salam")
            {
                ai.HorizontalAlignment = HorizontalAlignment.Right;
                ai.Items.Add(space);
                ai.Items.Add(AIService.GetResponseSalam());
            }
            else if (msgTxtb.Text == "necesen?")
            {
                ai.HorizontalAlignment = HorizontalAlignment.Right;
                ai.Items.Add(space);
                ai.Items.Add(AIService.GetResponseNecesen());
            }
            else if (msgTxtb.Text == "neyneyirsen?")
            {
                ai.HorizontalAlignment = HorizontalAlignment.Right;
                ai.Items.Add(space);
                ai.Items.Add(AIService.GetResponseNeVarNeYox());
            }
            else if (msgTxtb.Text == "hardasan?")
            {
                ai.HorizontalAlignment = HorizontalAlignment.Right;
                ai.Items.Add(space);
                ai.Items.Add(AIService.GetResponseHardasan());
            }
            else
            {
                ai.HorizontalAlignment = HorizontalAlignment.Right;
                ai.Items.Add(space);
                ai.Items.Add(AIService.GetResponse());
            }
        }

        private void minimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void x_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
