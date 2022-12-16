Imports System.Windows
Imports System.Windows.Controls
Imports DevExpress.Xpf.Core

Namespace DXTabControl_CreatingManually

    Public Partial Class MainWindow
        Inherits Window

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub LayoutRoot_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            Dim tabControl As DXTabControl = New DXTabControl()
            tabControl.Height = 75
            tabControl.Width = 200
            Dim tabItem1 As DXTabItem = New DXTabItem()
            tabItem1.Header = "Button"
            tabItem1.Content = New Button() With {.Content = "Button"}
            tabControl.Items.Add(tabItem1)
            Dim tabItem2 As DXTabItem = New DXTabItem()
            tabItem2.Header = "Check box"
            tabItem2.Content = New CheckBox() With {.Content = "Check box"}
            tabControl.Items.Add(tabItem2)
            Me.LayoutRoot.Children.Add(tabControl)
        End Sub
    End Class
End Namespace
