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

        private ObservableCollection<String> tipos;

        public ObservableCollection<String> Tipos
        {
            get => tipos;
            set
            {
                this.tipos = value;
                this.NotifyPropertyChanged("Tipos");

            }
        }

        private Plato platoSeleccionado;

        public Plato PlatoSeleccionado
        {
            get { return platoSeleccionado; }
            set
            {
                platoSeleccionado = value;
                NotifyPropertyChanged("PlatoSeleccionado");
            }
        }

        public MainWindowVM(){
            Platos = Plato.GetSamples("C:/Users/alumno/Pictures/ImagenesComida");
            Tipos = new ObservableCollection<string> { "Americana", "China", "Mexicana" };
        }

        public void LimpiaSeleccion() {
            PlatoSeleccionado = null;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
