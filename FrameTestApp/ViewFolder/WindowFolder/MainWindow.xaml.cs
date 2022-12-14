using FrameTestApp.ClassFolder;
using FrameTestApp.ViewFolder.PageFolder;
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

namespace FrameTestApp.ViewFolder.WindowFolder
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetConnectFrame();
            GetFrame();
        }
        public void GetConnectFrame()
        {
            FrameClass.FrameMenu = FrameMenuMain;
            FrameClass.FrameBody = FrameBodyMain;
            FrameClass.FrameTitle = FrameTitleMain;
            FrameClass.FrameLogo = FrameLogoMain;  
        }
        public void GetFrame()
        {
            FrameMenuMain.Navigate(new MenuPage());
            FrameBodyMain.Navigate(new BodyPage());
            FrameTitleMain.Navigate(new TitlePage());
            FrameLogoMain.Navigate(new LogoPage());
        }
    }
}
