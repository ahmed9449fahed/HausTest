using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuildServerHausTest.UIL;
using BuildServerHausTest.UIL.HIlfeUIL;
using DevExpress.Mvvm;
using DevExpress.Xpf.Editors.Helpers;

namespace BuildServerHausTest
{
    class MainWindowsmodel:ViewModelBase
    {
        public MainWindowsmodel()
        {
            TestView=new DelegateCommand(()=> NavigationService.Navigate(typeof(TestView).FullName,null,this));
            TestView2 = new DelegateCommand(() => NavigationService.Navigate(typeof(TestView2).FullName, null, this));
        }

        public DelegateCommand TestView { get; }
        public DelegateCommand TestView2 { get; }
        private INavigationService NavigationService => GetService<INavigationService>();
    }
}
