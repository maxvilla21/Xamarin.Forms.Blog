using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;
using AppExportRenderXF;
using AppExportRenderXF.WinPhone;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinRT;

[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRender))]
namespace AppExportRenderXF.WinPhone
{
    public class CustomEntryRender : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.Background = new SolidColorBrush(Colors.Cyan);
            }
        }
    }
}
