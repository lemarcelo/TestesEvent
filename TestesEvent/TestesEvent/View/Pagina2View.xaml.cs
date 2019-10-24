using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestesEvent.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina2View : ContentPage
    {
        public event EventHandler<string> PrimeiroEvento;

        public Pagina2View()
        {
            InitializeComponent();
            BindingContext = new ViewModel.Pagina2ViewModel();
        }
    }
}