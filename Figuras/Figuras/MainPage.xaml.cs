using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Figuras
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnTriangulo_Clicked(object sender, EventArgs e)
        {
            start.IsVisible = false;
            triangulo.IsVisible = true;
            cuadrado.IsVisible = false;
            cubo.IsVisible = false;
            circulo.IsVisible = false;
            cilindro.IsVisible = false;
            trapezio.IsVisible = false;
            rombo.IsVisible = false;
            hexagono.IsVisible = false;
            tetraedro.IsVisible = false;
            Result.Text = "";
        }

        private void BtnCuadrado_Clicked(object sender, EventArgs e)
        {
            start.IsVisible = false;
            triangulo.IsVisible = false;
            cuadrado.IsVisible = true;
            cubo.IsVisible = false;
            circulo.IsVisible = false;
            cilindro.IsVisible = false;
            trapezio.IsVisible = false;
            rombo.IsVisible = false;
            hexagono.IsVisible = false;
            tetraedro.IsVisible = false;
            Result.Text = "";
        }

        private void BtnCubo_Clicked(object sender, EventArgs e)
        {
            start.IsVisible = false;
            triangulo.IsVisible = false;
            cuadrado.IsVisible = false;
            cubo.IsVisible = true;
            circulo.IsVisible = false;
            cilindro.IsVisible = false;
            trapezio.IsVisible = false;
            rombo.IsVisible = false;
            hexagono.IsVisible = false;
            tetraedro.IsVisible = false;
            Result.Text = "";
        }

        private void BtnCirculo_Clicked(object sender, EventArgs e)
        {
            start.IsVisible = false;
            triangulo.IsVisible = false;
            cuadrado.IsVisible = false;
            cubo.IsVisible = false;
            circulo.IsVisible = true;
            cilindro.IsVisible = false;
            trapezio.IsVisible = false;
            rombo.IsVisible = false;
            hexagono.IsVisible = false;
            tetraedro.IsVisible = false;
            Result.Text = "";
        }

        private void Btncilindro_Clicked(object sender, EventArgs e)
        {
            start.IsVisible = false;
            triangulo.IsVisible = false;
            cuadrado.IsVisible = false;
            cubo.IsVisible = false;
            circulo.IsVisible = false;
            cilindro.IsVisible = true;
            trapezio.IsVisible = false;
            rombo.IsVisible = false;
            hexagono.IsVisible = false;
            tetraedro.IsVisible = false;
            Result.Text = "";
        }

        private void BtnTrapezio_Clicked(object sender, EventArgs e)
        {
            start.IsVisible = false;
            triangulo.IsVisible = false;
            cuadrado.IsVisible = false;
            cubo.IsVisible = false;
            circulo.IsVisible = false;
            cilindro.IsVisible = false;
            trapezio.IsVisible = true;
            rombo.IsVisible = false;
            hexagono.IsVisible = false;
            tetraedro.IsVisible = false;
            Result.Text = "";
        }

        private void BtnRombo_Clicked(object sender, EventArgs e)
        {
            start.IsVisible = false;
            triangulo.IsVisible = false;
            cuadrado.IsVisible = false;
            cubo.IsVisible = false;
            circulo.IsVisible = false;
            cilindro.IsVisible = false;
            trapezio.IsVisible = false;
            rombo.IsVisible = true;
            hexagono.IsVisible = false;
            tetraedro.IsVisible = false;
            Result.Text = "";
        }

        private void BtnHexagonal_Clicked(object sender, EventArgs e)
        {
            start.IsVisible = false;
            triangulo.IsVisible = false;
            cuadrado.IsVisible = false;
            cubo.IsVisible = false;
            circulo.IsVisible = false;
            cilindro.IsVisible = false;
            trapezio.IsVisible = false;
            rombo.IsVisible = false;
            hexagono.IsVisible = true;
            tetraedro.IsVisible = false;
            Result.Text = "";
        }

        private void BtnTetraedro_Clicked(object sender, EventArgs e)
        {
            start.IsVisible = false;
            triangulo.IsVisible = false;
            cuadrado.IsVisible = false;
            cubo.IsVisible = false;
            circulo.IsVisible = false;
            cilindro.IsVisible = false;
            trapezio.IsVisible = false;
            rombo.IsVisible = false;
            hexagono.IsVisible = false;
            tetraedro.IsVisible = true;
            Result.Text = "";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (triangulo.IsVisible == true)
                {
                    if (string.IsNullOrEmpty(Tbase.Text) || string.IsNullOrEmpty(Taltura.Text))
                    {
                        DisplayAlert("Error", "Complete los campos", "Ok");
                    }
                    else
                    {
                        if (double.Parse(Tbase.Text) <= 0 || double.Parse(Taltura.Text) <= 0)
                        {
                            DisplayAlert("Error", "Ingrese numeros positivos", "Ok");
                        }
                        else
                        {
                            var res = (double.Parse(Tbase.Text) * double.Parse(Taltura.Text)) / 2;
                            Result.Text = "El area del triangulo es: " + res + " cm2";
                        }
                    }
                }

                if (cuadrado.IsVisible == true)
                {
                    if (string.IsNullOrEmpty(Clado.Text))
                    {
                        DisplayAlert("Error", "Complete los campos", "Ok");
                    }
                    else
                    {
                        if (double.Parse(Clado.Text) <= 0)
                        {
                            DisplayAlert("Error", "Ingrese numeros positivos", "Ok");
                        }
                        else
                        {
                            var res = double.Parse(Clado.Text) * double.Parse(Clado.Text);
                            var res2 = double.Parse(Clado.Text) + double.Parse(Clado.Text) + double.Parse(Clado.Text) + double.Parse(Clado.Text);
                            Result.Text = "El area del cuadrado es: " + res + " cm2 \n El perimetro del cuadrado es: " + res2;
                        }
                    }
                }

                if (cubo.IsVisible == true)
                {
                    if (string.IsNullOrEmpty(CuboLado.Text))
                    {
                        DisplayAlert("Error", "Complete los campos", "Ok");
                    }
                    else
                    {
                        if (double.Parse(CuboLado.Text) <= 0)
                        {
                            DisplayAlert("Error", "Ingrese numeros positivos", "Ok");
                        }
                        else
                        {
                            var area2d = double.Parse(CuboLado.Text) * double.Parse(CuboLado.Text);
                            var res = area2d * 6;

                            Result.Text = "El area del cubo es: " + res + " cm2";
                        }
                    }
                }

                if (circulo.IsVisible == true)
                {
                    if (string.IsNullOrEmpty(radio.Text))
                    {
                        DisplayAlert("Error", "Complete los campos", "Ok");
                    }
                    else
                    {
                        if (double.Parse(radio.Text) <= 0)
                        {
                            DisplayAlert("Error", "Ingrese numeros positivos", "Ok");
                        }
                        else
                        {
                            var res = 3.1416 * double.Parse(radio.Text) * double.Parse(radio.Text);

                            Result.Text = "El area del circulo es: " + res + " cm2";
                        }
                    }
                }

                if (cilindro.IsVisible == true)
                {
                    if (string.IsNullOrEmpty(Caltura.Text) || string.IsNullOrEmpty(Cradio.Text))
                    {
                        DisplayAlert("Error", "Complete los campos", "Ok");
                    }
                    else
                    {
                        if (double.Parse(Caltura.Text) <= 0 || double.Parse(Cradio.Text) <= 0)
                        {
                            DisplayAlert("Error", "Ingrese numeros positivos", "Ok");
                        }
                        else
                        {
                            var res = 2 * 3.1416 * double.Parse(Cradio.Text) * (double.Parse(Cradio.Text) + double.Parse(Caltura.Text));

                            Result.Text = "El area del cilindro es: " + res + " cm2";
                        }
                    }
                }

                if (trapezio.IsVisible == true)
                {
                    if (string.IsNullOrEmpty(TraAltura.Text) || string.IsNullOrEmpty(B.Text) || string.IsNullOrEmpty(b.Text))
                    {
                        DisplayAlert("Error", "Complete los campos", "Ok");
                    }
                    else
                    {
                        if (double.Parse(TraAltura.Text) <= 0 || double.Parse(B.Text) <= 0 || double.Parse(b.Text) <= 0)
                        {
                            DisplayAlert("Error", "Ingrese numeros positivos", "Ok");
                        }
                        else
                        {
                            var res = (((double.Parse(b.Text) + double.Parse(B.Text)) / 2) * double.Parse(TraAltura.Text));

                            Result.Text = "El area del trapecio es: " + res + " cm2";
                        }
                    }
                }

                if (rombo.IsVisible == true)
                {
                    if (string.IsNullOrEmpty(dM.Text) || string.IsNullOrEmpty(dm.Text))
                    {
                        DisplayAlert("Error", "Complete los campos", "Ok");
                    }
                    else
                    {
                        if (double.Parse(dM.Text) <= 0 || double.Parse(dm.Text) <= 0)
                        {
                            DisplayAlert("Error", "Ingrese numeros positivos", "Ok");
                        }
                        else
                        {
                            var res = (double.Parse(dM.Text) * double.Parse(dm.Text)) / 2;

                            Result.Text = "El area del rombo es: " + res + " cm2";
                        }
                    }
                }

                if (hexagono.IsVisible == true)
                {
                    if (string.IsNullOrEmpty(Hapotema.Text))
                    {
                        DisplayAlert("Error", "Complete los campos", "Ok");
                    }
                    else
                    {
                        if (double.Parse(Hapotema.Text) <= 0)
                        {
                            DisplayAlert("Error", "Ingrese numeros positivos", "Ok");
                        }
                        else
                        {
                            var res = (double.Parse(dM.Text) * double.Parse(dm.Text)) / 2;

                            Result.Text = "El area del hexagono es: " + res + " cm2";
                        }
                    }
                }

                if (tetraedro.IsVisible == true)
                {
                    if (string.IsNullOrEmpty(Tearista.Text))
                    {
                        DisplayAlert("Error", "Complete los campos", "Ok");
                    }
                    else
                    {
                        if (double.Parse(Tearista.Text) <= 0)
                        {
                            DisplayAlert("Error", "Ingrese numeros positivos", "Ok");
                        }
                        else
                        {
                            var res = (Math.Sqrt(3) * (double.Parse(Tearista.Text)) * double.Parse(Tearista.Text));

                            Result.Text = "El area del tetraedro es: " + res + " cm2";
                        }
                    }
                }
            }
            catch (Exception)
            {

                DisplayAlert("Atencion", "No", "No");
            }
        }
    }
}
