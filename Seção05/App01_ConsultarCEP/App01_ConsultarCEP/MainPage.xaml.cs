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
            Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(CEP.Text);
            RESULTADO.Text = string.Format("Endereço : {0}, {1} {2}", end.localidade, end.uf, end.logradouro);
        }
    }
}
