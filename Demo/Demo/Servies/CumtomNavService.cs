using Demo.Core.Servies;
using Demo.Servies;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.macOSSpecific;


[assembly: Xamarin.Forms.Dependency(typeof(CumtomNavService))]
namespace Demo.Servies
{
    public class CumtomNavService : Core.Servies.ICustomNav
    {
        public async Task Inicio()
        {
            await App.Current.MainPage.Navigation.PopToRootAsync();
        }

        public Task NavegarA(string Pagina)
        {
            switch (Pagina) 
            {
                case "Login":
                    App.Current.MainPage = new Xamarin.Forms.NavigationPage(new Vistas.LoginPage());
                    break;
                case "Principal":
                    App.Current.MainPage = new Xamarin.Forms.NavigationPage(new Vistas.PrincipalPage());
                    break;
                default: 
                    break;
            }
            return new Task(() => { });
        }

        public Task NavegarA(string Pagina, object[] parameters)
        {
            throw new NotImplementedException();
        }

        public async Task Regresar()
        {
            await App.Current.MainPage.Navigation.PopAsync(true);
        }
    }
}
