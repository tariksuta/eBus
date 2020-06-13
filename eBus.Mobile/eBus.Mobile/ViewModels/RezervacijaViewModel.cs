using eBus.Mobile.Services;
using eBus.Model;
using eBus.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace eBus.Mobile.ViewModels
{
    public class RezervacijaViewModel : BaseViewModel
    {
        private readonly APIService _rezervacijeService = new APIService("Rezervacija");
        private readonly APIService _putnikService = new APIService("Putnik");

        public RezervacijaViewModel()
        {
            Title = "Rezervacije";
        }
        public ObservableCollection<Rezervacija> RezervacijeList { get; set; } = new ObservableCollection<Rezervacija>();

        private Rezervacija _selectedRezervacija = null;

        public Rezervacija SelectedRezervacija
        {
            get { return _selectedRezervacija; }
            set { SetProperty(ref _selectedRezervacija, value); }
        }

        public async Task Init()
        {
            var search = new PutnikSearchRequest()
            {
                KorisnickoIme = APIService.KorisnickoIme
            };

            var listaPutnika = await _putnikService.Get<List<Putnik>>(search);

            Putnik putnik = null;

            foreach (var item in listaPutnika)
            {
                if(item.KorisnickoIme == APIService.KorisnickoIme)
                {
                    putnik = item;
                    break;
                }
            }

            var searchRez = new RezervacijaSearchRequest()
            {
                PoAngazmanu = false,
                PutnikId = putnik.Id
            };

            var lista = await _rezervacijeService.Get<List<Rezervacija>>(searchRez);

            RezervacijeList.Clear();
            foreach (var item in lista)
            {
                if (!item.Otkazana.Value && item.DatumIsteka > DateTime.Now) // dodao da prikazuje samo gdje je DatumIsteka veci od trenutnog datuma
                {
                    RezervacijeList.Add(item);
                }
               
            }
        }

      
    }
}
