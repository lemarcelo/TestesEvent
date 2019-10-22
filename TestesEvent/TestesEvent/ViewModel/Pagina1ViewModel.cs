using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using TestesEvent.Events;

namespace TestesEvent.ViewModel
{
    public class Pagina1ViewModel
    {
        Command AcessarPagina2
        {
            get;
            set;
        }


        public Pagina1ViewModel()
        {
            AcessarPagina2 = new Command(NavegarPagina2);

        }

        private void NavegarPagina2(object obj)
        {
            App.Current.MainPage.DisplayAlert("","","");

        }
    }
}
