using eBus.Mobile.Models;
using eBus.Model;
using eBus.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBus.Mobile.ViewModels
{
    public class Preporuka2ViewModel
    {
        private readonly APIService _putniciService = new APIService("Putnik");
        private readonly APIService _preporukaService = new APIService("Preporuka");

        public ObservableCollection<LinijaPodaci> ListaLinija { get; set; } = new ObservableCollection<LinijaPodaci>();


        public async Task Init()
        {

            var putnik = await _putniciService.Get<List<Putnik>>(new PutnikSearchRequest() { KorisnickoIme = APIService.KorisnickoIme });


            var lista = await _preporukaService.GetById<List<LinijaPodaci>>(putnik[0].Id);

            ListaLinija.Clear();

            foreach (var item in lista.OrderBy(l => l.DatumPretrage))
            {
                ListaLinija.Add(item);
            }


           
          
        }
    }
}
