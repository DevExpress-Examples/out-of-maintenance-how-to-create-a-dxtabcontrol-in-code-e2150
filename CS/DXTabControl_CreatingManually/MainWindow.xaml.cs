using System.Windows;
using System.Windows.Controls;
using DevExpress.Xpf.Core;

namespace DXTabControl_CreatingManually {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e) {
            DXTabControl tabControl = new DXTabControl();
            tabControl.Height = 75;
            tabControl.Width = 200;

            DXTabItem tabItem1 = new DXTabItem();
            tabItem1.Header = "Button";
            tabItem1.Content = new Button() { Content = "Button" };
            tabControl.Items.Add(tabItem1);

            DXTabItem tabItem2 = new DXTabItem();
            tabItem2.Header = "Check box";
            tabItem2.Content = new CheckBox() { Content = "Check box" };
            tabControl.Items.Add(tabItem2);

            LayoutRoot.Children.Add(tabControl);
        }
    }
}
