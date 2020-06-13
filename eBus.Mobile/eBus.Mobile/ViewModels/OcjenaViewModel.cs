using eBus.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace eBus.Mobile.ViewModels
{
    public class OcjenaViewModel : BaseViewModel
    {
        private readonly APIService _kompanijeService = new APIService("Kompanija");

        public OcjenaViewModel()
        {
            Title = "Ocjena";
        }

        private string _komentar = string.Empty;

        public string Komentar 
        {
            get { return _komentar; }
            set { SetProperty(ref _komentar, value); }
        }

        private int _ocjena = 1;

        public int Ocjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }
        }

        private Kompanija _kompanije = null;
        public Kompanija Kompanija
        {
            get { return _kompanije; }
            set { SetProperty(ref _kompanije, value); }
        }

        public ICommand KompanijaCommand { get; set; }
        

        public ObservableCollection<Kompanija> ListaKompanija { get; set; } = new ObservableCollection<Kompanija>();

       

        public async Task Init()
        {
            var lista = await _kompanijeService.Get<List<Kompanija>>(null);

            ListaKompanija.Clear();

            foreach (var item in lista)
            {
                ListaKompanija.Add(item);
            }
        }
    }
}
