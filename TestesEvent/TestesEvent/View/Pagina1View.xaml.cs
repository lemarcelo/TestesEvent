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
        Pagina2View page = new Pagina2View();
        public Pagina1View()
        {
            InitializeComponent();
            BindingContext = new ViewModel.Pagina1ViewModel();
            EventosControles();
        }
        private void EventosControles()
        {
            page.PrimeiroEvento += OnClick;

        }

        private void OnClick(object sender, string e)
        {
            App.Current.MainPage.DisplayAlert("","Botão Clicado com meu Evento","Ok");
        }


        private void btnPagina2_Clicked(object sender, EventArgs e)
        {

            App.Current.MainPage.Navigation.PushAsync(page);
        }

        //private void btnPagina2_Click(object sender, EventArgs e)
        //{
        //    App.Current.MainPage.DisplayAlert("", "Botão clicado", "Ok");
        //}
    }
}