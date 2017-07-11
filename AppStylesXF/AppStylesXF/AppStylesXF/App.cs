using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppStylesXF.Resources;
using Xamarin.Forms;

namespace AppStylesXF
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application
            MainPage = new TestPage();
        }


        //public App()
        //{
        //    // The root page of your application
        //     var sty=new AppStylesXF.Resources.Styles2();
        //    MainPage = new ContentPage
        //    {
               
        //        Content = new StackLayout
        //        {
        //            VerticalOptions = LayoutOptions.Center,
        //            Children =
        //            {
        //                new Label
        //                {
        //                    XAlign = TextAlignment.Center,
        //                    Text = "Label sin estilo!",
        //                    Style = (Style) sty.Resources["LabelStyle"]

        //                },
        //                  new Label
        //                {
        //                    XAlign = TextAlignment.Center,
        //                    Text = "Label Con estilo!",
        //                    Style = AppStyles.LabelStyle

        //                }
        //            }
        //        }
        //    };
        //}





 

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
