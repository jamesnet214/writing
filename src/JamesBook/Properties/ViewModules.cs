using JamesBook.Forms.Local.ViewModels;
using JamesBook.Forms.UI.Views;
using JamesBook.Main.Local.ViewModels;
using JamesBook.Main.UI.Views;
using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Global.Location;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesBook.Properties
{
    internal class ViewModules : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IViewable, MainContent>("MainContent");
        }
    }
}
