using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comida
{
    class MainWindowVM : INotifyPropertyChanged
    {
        private ObservableCollection<Plato> platos;

        public ObservableCollection<Plato> Platos
        {
            get => platos;
            set
            {
                this.platos = value;
                this.NotifyPropertyChanged("Platos");

            }
        }

        private Plato platoSeleccionada;

        public Plato PlatoSeleccionada
        {
            get { return platoSeleccionada; }
            set
            {
                platoSeleccionada = value;
                NotifyPropertyChanged("PlatoSeleccionada");
            }
        }

        public MainWindowVM(){
            Platos = Plato.GetSamples("C:/Users/alumno/Pictures/ImagenesComida");
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
