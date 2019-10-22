using System;
using System.Collections.Generic;
using System.Text;
using TestesEvent.Events;

namespace TestesEvent.ViewModel
{
    public class Pagina2ViewModel
    {
        public delegate void CustomDelegate(object sender, CustomEvents e);
        public event CustomDelegate CustomEvent;
        public Pagina2ViewModel()
        {
            CustomEvent(this, new CustomEvents("Mensagem da Pagina2"));
        }


            //App.Current.MainPage.DisplayAlert("","EventoAcionado","Ok");
        
    }
}
