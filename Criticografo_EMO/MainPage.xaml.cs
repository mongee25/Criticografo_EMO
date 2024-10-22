using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Criticografo_EMO
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void CriticarComando()
        {
            string nombre = NombreEntry.Text;
            string genero = ""; 

            
            DisplayAlert("Crítica", "¡Crítica enviada!", "OK");
        }

        private void Criticar(object sender, EventArgs e)
        {
            string nombre = NombreEntry.Text;
            if (string.IsNullOrWhiteSpace(nombre))
            {
                ResultadoLabel.Text = "Por favor ingresa un nombre.";
                return;
            }

            string genero = "";
            if (Hombre.IsChecked)
                genero = "Hombre";
            else if (Mujer.IsChecked)
                genero = "Mujer";
            else
            {
                ResultadoLabel.Text = "Por favor selecciona un género.";
                return;
            }

            List<string> atributos = new List<string>();
            if (AltoCheckBox.IsChecked) atributos.Add(AltoLabel.Text);
            if (FeoCheckBox.IsChecked) atributos.Add(FeoLabel.Text);
            if (ListoCheckBox.IsChecked) atributos.Add(ListoLabel.Text);
            if (GuapoCheckBox.IsChecked) atributos.Add(GuapoLabel.Text);
            if (RaroCheckBox.IsChecked) atributos.Add(RaroLabel.Text);
            if (GrandeCheckBox.IsChecked) atributos.Add(GrandeLabel.Text);

            if (atributos.Count == 0)
            {
                ResultadoLabel.Text = "Por favor selecciona al menos un atributo.";
                return;
            }

          
            string mensaje = $"Nombre: {nombre}\nGénero: {genero}\nAtributos: {string.Join(", ", atributos)}";
            ResultadoLabel.Text = mensaje;
        }

        private void Genero(object sender, CheckedChangedEventArgs e)
        {
            if (Hombre.IsChecked)
            {
                AltoLabel.Text = "Alto";
                FeoLabel.Text = "Feo";
                ListoLabel.Text = "Listo";
                GuapoLabel.Text = "Extravagante";
                RaroLabel.Text = "Raro";
                GrandeLabel.Text = "Grande";
            }
            else if (Mujer.IsChecked)
            {
                AltoLabel.Text = "Alta";
                FeoLabel.Text = "Fea";
                ListoLabel.Text = "Lista";
                GuapoLabel.Text = "Extravagante";
                RaroLabel.Text = "Rara";
                GrandeLabel.Text = "Grande";
            }
        }
    }
}
