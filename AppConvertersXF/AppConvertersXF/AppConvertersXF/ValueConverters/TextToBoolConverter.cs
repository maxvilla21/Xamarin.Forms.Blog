using System;
using System.Globalization;
using Xamarin.Forms;

namespace AppConvertersXF.ValueConverters
{
    class TextToBoolConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool result = false;
            //verificar el valor de "EntStatus" en "Text" contenga algun valor.
            //cuando se le paso como parametro.
            if (value != null)
            {
                //pasando a minusculas el texto 
                //y enseguida verificar si coincide con los casos
                switch (value.ToString().ToLower())
                {
                    case "activo":
                        result = true;
                        break;
                    case "inactivo":
                        result = false;
                        break;
                }
            }
            return result;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string result = "";
            //vericar que el objeto valor sea boleano
            if (value is bool)
            {
                //verificando que sea verdero o falso
                //esto es para poner el texto en "EntStatus"
                if ((bool) value == true)
                {
                    result = "activo";
                }
                else
                {
                    result = "inactivo";
                }
            }
            return result;
        }
    }
}
