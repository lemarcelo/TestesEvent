using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using TestesEvent.Events;

namespace TestesEvent.ViewModel
{
    public class Pagina1ViewModel
    {
        Pagina2ViewModel page = new Pagina2ViewModel();

        public Pagina1ViewModel()
        {
            EventosControles();
        }
        private void EventosControles()
        {
            page.PrimeiroEvento += OnClick;
        }
    }
}
