using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace Comida.Convertidores
{
    class ConverterFuente : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string fuente = "";
            switch (value.ToString())
            {
                case "Americana":
                    fuente = "Slim Summer";
                    break;

                case "China":
                    fuente = "Chinese Wok Food St";
                    break;

                case "Mexicana":
                    fuente = "Taco Salad";
                    break;
            }
            return new FontFamily(fuente);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
