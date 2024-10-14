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

    // Método para el botón CRITICAR
    private void CriticarCommand()
    {
        string nombre = eNombre.Text;
        string genero = ""; // Lógica para obtener el género seleccionado
                            // Aquí puedes manejar la lógica de las casillas de verificación

        // Ejemplo de mostrar un mensaje
        DisplayAlert("Crítica", "¡Crítica enviada!", "OK");
    }

        private void OnCritiqueButtonClicked(object sender, EventArgs e)
        {

        }

        private void OnGenderSelectionChanged(object sender, CheckedChangedEventArgs e)
        {
            if (HombreRadio.IsChecked)
            {
                AltoLabel.Text = "Alto";
                FeoLabel.Text = "Feo";
                ListoLabel.Text = "Listo";
                ExtravaganteLabel.Text = "Extravagante";
                RaroLabel.Text = "Raro";
                GrandeLabel.Text = "Grande";
            }
            else if (MujerRadio.IsChecked)
            {
                AltoLabel.Text = "Alta";
                FeoLabel.Text = "Fea";
                ListoLabel.Text = "Lista";
                ExtravaganteLabel.Text = "Extravagante";
                RaroLabel.Text = "Rara";
                GrandeLabel.Text = "Grande";
            }
        }
    }
}
