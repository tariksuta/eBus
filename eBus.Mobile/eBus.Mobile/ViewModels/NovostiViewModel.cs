using eBus.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eBus.Mobile.ViewModels
{
    public class NovostiViewModel : BaseViewModel
    {
        private readonly APIService _novostiService = new APIService("Novosti");
        private readonly APIService _putnikNotifikacijeService = new APIService("PutnikNotifikacije");

        public NovostiViewModel() {
            Title = "Novosti";
        }
        public ObservableCollection<Model.Novosti> NovostiList { get; set; } = new ObservableCollection<Model.Novosti>();

        public ICommand InitCommand { get; set; }


        Dictionary<int, int> BrojPregleda = new Dictionary<int, int>();

        public async Task Init()
        {
            try
            {
                var lista = await _novostiService.Get<List<Model.Novosti>>(null);

                var listaNotif = await _putnikNotifikacijeService.Get<List<PutnikNotifikacije>>(null);
                NovostiList.Clear();

               

                foreach (var item in lista)
                {
                    item.BrojPregleda = 0;
                    foreach (var item2 in listaNotif)
                    {
                        if(item.Id == item2.Notifikacija.NovostId && item2.Pregledana)
                        {
                            item.BrojPregleda += 1;
                        }
                    }
                }
                foreach (var item in lista)
                {
                    
                    NovostiList.Add(item);
                  
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
