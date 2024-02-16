using Demo.Core.Modelo;
using Demo.Core.Servies;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Demo.Core.ViewModels
{
    public class Login_ViewModel:ViewModelBase
    {
        public int Myproperty { get; set; }

        private Users user=new Users();
        public Users User { get => user; set => Set(ref user, value); }


        private String mensaje;
        public String Mensaje { get => mensaje; set => Set(ref mensaje, value); }

        RelayCommand loginCommand = null;
        public RelayCommand LoginCommand
        {
            get => loginCommand ?? (loginCommand = new RelayCommand(async() =>
            {   
                
                if (user.Usuario == "julio" && user.Password == "00")
                {
                    this.mensaje = "Correcto";
                    await Xamarin.Forms.DependencyService.Get<ICustomNav>().NavegarA("Principal");
                }
                else {
                    this.mensaje = "Incorrecto";
                    await Xamarin.Forms.DependencyService.Get<ICustomNav>().NavegarA("Login");
                }

            }, () => { return true; }));
        }


        RelayCommand saludarCommand = null;
        public RelayCommand SaludarCommand
        {
            get => saludarCommand ?? (saludarCommand = new RelayCommand(() =>
            {
                Mensaje = Xamarin.Forms.DependencyService.Get<ISaludar>().Saludando();
            }, () => { return true; }));
        }
    }
}
