using Jamesnet.Wpf.Controls;
using Jamesnet.Wpf.Mvvm;
using Prism.Ioc;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamesBook.Forms.Local.ViewModels
{
    public partial class JamesBookViewModel : ObservableBase, IViewLoadable
    {
        private readonly IContainerProvider _containerProvider;
        private readonly IRegionManager _regionManager;

        public JamesBookViewModel(IContainerProvider containerProvider, IRegionManager regionManager)
        {
            _containerProvider = containerProvider;
            _regionManager = regionManager;
        }

        public void OnLoaded(IViewable view)
        {
            IViewable mainContent = _containerProvider.Resolve<IViewable>("MainContent");
            IRegion mainRegion = _regionManager.Regions["MainRegion"];

            if (!mainRegion.Views.Contains(mainContent))
            {
                mainRegion.Add(mainContent);
            }
            mainRegion.Activate(mainContent);
        }
    }
}
