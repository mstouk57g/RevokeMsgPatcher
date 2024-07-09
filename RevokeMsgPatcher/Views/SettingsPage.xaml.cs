using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace RevokeMsgPatcher.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page
    {
        public SettingsPage()
        {
            this.InitializeComponent();
        }

        public void OpenBtn(object sender, RoutedEventArgs e)
        {
            switch ((sender as Button).Name)
            {
                case "WeChatMoreOpenBtn":
                    break;
                case "SupportVersions":
                    System.Diagnostics.Process.Start("explorer.exe", "https://github.com/huiyadanli/RevokeMsgPatcher/wiki/%E7%89%88%E6%9C%AC%E6%94%AF%E6%8C%81");
                    break;
                case "Questions":
                    System.Diagnostics.Process.Start("explorer.exe", "https://github.com/huiyadanli/RevokeMsgPatcher/wiki#%E5%B8%B8%E8%A7%81%E9%97%AE%E9%A2%98");
                    break;
                case "HowToPatch":
                    System.Diagnostics.Process.Start("explorer.exe", "https://github.com/huiyadanli/RevokeMsgPatcher/wiki#%E5%8E%9F%E7%90%86");
                    break;
                case "Documents":
                    System.Diagnostics.Process.Start("explorer.exe", "https://github.com/huiyadanli/RevokeMsgPatcher/wiki");
                    break;
                case "AboutMeBtn":
                    System.Diagnostics.Process.Start("explorer.exe", "https://github.com/huiyadanli/RevokeMsgPatcher");
                    break;
            }
        }
    }
}
