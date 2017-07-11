using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppStylesXF
{
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            //pasando la referencia de los recursos de -HomePage- a -TestPage-
            Resources = new HomePage().Resources;
            InitializeComponent();
        }
    }
}
