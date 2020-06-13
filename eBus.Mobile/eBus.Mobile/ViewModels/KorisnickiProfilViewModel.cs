using eBus.Model.Requests;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace eBus.Mobile.ViewModels
{
    class KorisnickiProfilViewModel
    {
        private readonly APIService _putniciService = new APIService("Putnik");

        
        public Model.Putnik Putnik { get; set; }

       


    }
}
