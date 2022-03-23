using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace primerio_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double altura = double.Parse(txt_altura.Text);
            double peso = double.Parse(txt_peso.Text);
            string nome = txt_nome.Text;
            double imc = peso / (altura * altura);
            imc = Math.Round(imc, 2);


            if (imc < 18.5)
            {
                DisplayAlert("Seu IMC", $"Você está abaixo do peso. Seu índice de massa corporal é de: {imc}", "Ok");
            }
            else if (imc > 18.5 && imc < 24.9)
            {
                DisplayAlert("Seu IMC", $"Sua classificação é Peso Normal, seu índice de massa corporal é de: {imc}", "Ok");
            }
            else if (imc > 25 && imc < 29.9)
            {
                DisplayAlert("Seu IMC", $"Sua classificação é Sobrepeso. Seu índice de massa corporal é de: {imc}", "Ok");
            }
            else if (imc > 30 && imc < 34.9)
            {
                DisplayAlert("Seu IMC", $"Sua classificação é de Obesidade Grau I. Seu índice d emassa corporal é de {imc}", "Ok");
            }
            else if (imc > 35 && imc < 39.9)
            {
                DisplayAlert("Seu IMC", $"Sua classificação é de Obesidade Grau II. Seu índice de massa corporal é de {imc}", "Ok");
            }
            else
            {
                DisplayAlert("Seu IMC", $"Sua classificação é de Obesidade Grau III. Seu índice de massa corporal é de {imc}", "Ok");
            }
    
        }

    }
}
