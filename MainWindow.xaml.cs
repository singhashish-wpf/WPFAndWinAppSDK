using ABI.Windows.UI.ViewManagement;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Windows.UI.ViewManagement;
using UISettings = Windows.UI.ViewManagement.UISettings;

namespace WPFAndWinAppSDK
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UISettings _uiSettings;
        private Color accent;
        private Color ConvertToMediaColor(Windows.UI.Color winUIColor)
        {
            return Color.FromArgb(winUIColor.A, winUIColor.R, winUIColor.G, winUIColor.B);
        }

        public MainWindow()
        {
            InitializeComponent();
            _uiSettings = new UISettings();
            accent =  ConvertToMediaColor(_uiSettings.GetColorValue(UIColorType.Accent));
        }
    }
}