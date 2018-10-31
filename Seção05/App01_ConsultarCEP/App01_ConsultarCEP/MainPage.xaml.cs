using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Servico;
using App01_ConsultarCEP.Servico.Modelo;


namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BOTAO.Clicked += BuscarCEP;                        
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            //TODO - Lógica de programação

            //TODO - Validações

            //TODO - Consulta a API
            string cep = CEP.Text.Trim();
            if (isValidCEP(cep))
            {
                Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(CEP.Text);
                RESULTADO.Text = string.Format("{2} - Bairro {3} - {0}/{1}", end.localidade, end.uf, end.logradouro, end.bairro);
            }
        }

        private bool isValidCEP(string CEP)
        {
            bool valido = true;

            //TODO - Validar se tem 8 posições
            if (CEP.Length != 8)
            {
                //TDOD - Tratar erro
                DisplayAlert("ERRO", "CEP Inválido! O CEP Deve conter 8 caracteres.","Ok");
                valido = false;
            }
            //TODO - Validar se é numérico 
            int NovoCEP = 0;
            if (!int.TryParse(CEP, out NovoCEP))
            {
                //TDOD - Tratar erro
                DisplayAlert("ERRO", "CEP Inválido! O CEP Deve deve ser composto apenas por números.", "Ok");
                valido = false;
            }
            return valido;
        }
    }
}
