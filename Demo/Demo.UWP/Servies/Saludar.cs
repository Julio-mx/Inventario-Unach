using Demo.Core.Servies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.UWP.Servies;

[assembly:Xamarin.Forms.Dependency(typeof(Saludar))]
namespace Demo.UWP.Servies
{
    public class Saludar:ISaludar
    {
        public string Saludando()
        {
            return "Hola desde la PC";
        }
    }
}
