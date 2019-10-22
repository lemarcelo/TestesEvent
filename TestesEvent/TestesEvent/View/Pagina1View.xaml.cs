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
    public partial class Pagina1View : ContentPage
    {
        public Pagina1View()
        {
            InitializeComponent();
            BindingContext = new ViewModel.Pagina1ViewModel();
        }
    }
}