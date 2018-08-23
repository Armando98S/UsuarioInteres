using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsuarioInteres
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PrimerEjercicio : ContentPage
	{
		public PrimerEjercicio ()
        {
            InitializeComponent();
            btnCalcular.Clicked += BtnCalcular_Clicked;

        }

        private void BtnCalcular_Clicked(object sender, EventArgs e)
        {
            double Total = double.Parse(entTotal.Text);
            double Propina = double.Parse(entPropina.Text);
            double NumPersonas = double.Parse(entNumPersonas.Text);

            double Propinas = (Total * Propina) / 100;
            double Totales = Propinas + Total;
            double PropinaPersonas = Propinas / NumPersonas;
            double Totale = Totales / NumPersonas;

            txtPropina.Detail = Propinas.ToString("C");
            txtTotal.Detail = Totales.ToString("C");
            txtProPersonas.Detail = PropinaPersonas.ToString("C");
            txtTotalesPers.Detail = Totale.ToString("C");
        }
    }
}