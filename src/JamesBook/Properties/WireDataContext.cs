using JamesBook.Forms.Local.ViewModels;
using JamesBook.Forms.UI.Views;
using JamesBook.Main.Local.ViewModels;
using JamesBook.Main.UI.Views;
using Jamesnet.Wpf.Global.Location;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesBook.Properties
{
    internal class WireDataContext : ViewModelLocationScenario
    {
        protected override void Match(ViewModelLocatorCollection items)
        {
            items.Register<JamesBookWindow, JamesBookViewModel>();
            items.Register<MainContent, MainContentViewModel>();
        }
    }
}
