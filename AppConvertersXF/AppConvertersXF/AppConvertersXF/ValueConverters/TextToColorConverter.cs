using System;
using System.Globalization;
using Xamarin.Forms;

namespace AppConvertersXF.ValueConverters
{
    class TextToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            Color clr = Color.Teal;
            if (value != null)
            {
                switch (value.ToString().ToLower())
                {
                    case "rojo":
                        clr = Color.Red;
                        break;
                    case "azul":
                        clr = Color.Blue;
                        break;
                    case "verde":
                        clr = Color.Green;
                        break;
                }
            }

            return clr;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
