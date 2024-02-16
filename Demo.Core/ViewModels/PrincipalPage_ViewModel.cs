using Demo.Core.Servies;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.ViewModels
{
    public class PrincipalPage_ViewModel: ViewModelBase
    {

        RelayCommand regresarCommand = null;
        public RelayCommand RegresarCommand
        {
            get => regresarCommand ?? (regresarCommand = new RelayCommand(async () =>
            {
                await Xamarin.Forms.DependencyService.Get<ICustomNav>().NavegarA("Login");
            }, () => { return true; }));
        }
    }
}
