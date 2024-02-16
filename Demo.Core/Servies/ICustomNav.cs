using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Core.Servies
{
    public interface ICustomNav
    {
        Task Regresar();
        Task Inicio();
        Task NavegarA(string Pagina);
        Task NavegarA(string Pagina, object[] parameters);
    }
}
