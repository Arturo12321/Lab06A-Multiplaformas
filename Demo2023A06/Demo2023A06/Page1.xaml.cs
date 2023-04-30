using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo2023A06
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona { Nombres = "Arturo", Apellidos = "Manrique", Edad = 21 });
            personas.Add(new Persona { Nombres = "Aracely", Apellidos = "Manrique", Edad = 20 });
            personas.Add(new Persona { Nombres = "Doris", Apellidos = "Pérez", Edad = 18 });
            personas.Add(new Persona { Nombres = "Luna", Apellidos = "Pérez", Edad = 19 });

            lvDemo.ItemsSource = personas;

        }
    }
}