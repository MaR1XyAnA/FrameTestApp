using FrameTestApp.ClassFolder;
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

namespace FrameTestApp.ViewFolder.PageFolder
{
    public partial class MenuPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void DerektorHyperlink_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.FrameLogo.Navigate(new LogoPage());
            FrameClass.FrameBody.Navigate(new BodyPage());
        }

        private void SysadminHyperlink_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.FrameBody.Navigate(new B1Page());
            FrameClass.FrameLogo.Navigate(new L1Page());
        }

        private void ManagerHyperlink_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.FrameBody.Navigate(new B2Page());
            FrameClass.FrameLogo.Navigate(new L2Page());
        }

        private void EngineeringGroupHyperlink_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.FrameBody.Navigate(new B3Page());
            FrameClass.FrameLogo.Navigate(new L3Page());
        }

        private void AccountantHyperlink_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.FrameBody.Navigate(new B4Page());
            FrameClass.FrameLogo.Navigate(new L4Page());
        }

        private void LawyerHyperlink_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.FrameBody.Navigate(new B5Page());
            FrameClass.FrameLogo.Navigate(new L5Page());
        }
    }
}
