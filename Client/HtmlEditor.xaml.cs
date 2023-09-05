using DevExpress;
using System.Windows;
using System.Windows.Controls;

namespace XAML4Blazor_DevexHTMLEditorBridge.Client
{
    public partial class HtmlEditor : Page
    {
        //HtmlEdit htmlEdit1;
        public HtmlEditor()
        {
            InitializeComponent();
            Loaded += HtmlEditor_Loaded;
        }

        private async void HtmlEditor_Loaded(object sender, RoutedEventArgs e)
        {
            await DevExpress.HtmlEdit.Initialize();
            var htmlEdit1 = new DevExpress.HtmlEdit(); 
            tb1.Content = htmlEdit1;
        }

        //private void Editor_TabItem_Loaded(object sender, RoutedEventArgs e)
        //{
        //    htmlEdit1.SetHeight(500);
        //    tabControl.SelectionChanged += TabControl_SelectionChanged;
        //}

        //private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    htmlEdit1.SetHeight(500);
        //}

        //private void btnSave_Click(object sender, RoutedEventArgs e)
        //{
        //    htmlPresenter.Html = htmlEdit1.Html;
        //}
    }
}
