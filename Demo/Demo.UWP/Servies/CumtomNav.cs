using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.UWP.Servies
{
    public interface CumtomNav
    {
        Task Regresar();
        Task Inicio();
        Task NavA(string Pagina);
        Task NavB(string Pagina, object[] parameters);
    }
}
