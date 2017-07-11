using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppStylesXF.Resources
{
   public static class AppStyles
   {
       public static Color Fuchsia = Color.Fuchsia;
       public static Color Lime = Color.Lime;

       public static Style LabelStyle
       {
           get
           {
               return new Style(typeof (Label))
               {
                   Setters =
                   {
                       new Setter{Property=Label.FontSizeProperty,Value=20},
                       new Setter{Property = Label.TextColorProperty,Value = Fuchsia},
                       new Setter{Property = Label.FontAttributesProperty,Value = FontAttributes.Bold}
                   }
               };
           }
       }
   }
}
