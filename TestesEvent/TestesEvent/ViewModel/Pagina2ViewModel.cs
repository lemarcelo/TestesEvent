using System;
using System.Collections.Generic;
using System.Text;
using TestesEvent.Events;
using Xamarin.Forms;

namespace TestesEvent.ViewModel
{
    public class Pagina2ViewModel
    {
        public event EventHandler<string> PrimeiroEvento;
        Command BotaoClicado;
        public Pagina2ViewModel()
        {
            BotaoClicado = new Command(BotaoClicadoAction)
        }

        private void BotaoClicadoAction(object obj)
        {
            PrimeiroEvento?.Invoke(this, "testando");
        }
    }

}
