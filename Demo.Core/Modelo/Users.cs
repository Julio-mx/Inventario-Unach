using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Core.Modelo
{
    public class Users:ViewModelBase
    {
        //public String UserName { get; set; }
        //public String Password { get; set; }

        private string usuario;
        public string Usuario { get => usuario; set => Set(ref usuario, value); }

        private string password;
        public string Password { get => password; set => Set(ref password, value); }
    }
}
