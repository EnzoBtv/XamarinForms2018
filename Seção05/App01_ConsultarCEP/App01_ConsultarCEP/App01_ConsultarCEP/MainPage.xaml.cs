﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App01_ConsultarCEP.Serviço.Modelo;
using App01_ConsultarCEP.Serviço;

namespace App01_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Botao.Clicked += BuscarCEP;
        }
        void BuscarCEP(object sender, EventArgs args)
        {
            //TODO - Validações
            string cep = CEP.Text.Trim();
            if (isValidCEP(cep))
            {
                try {
                    Endereco end = ViaCEPServico.BuscarEnderecoViaCEP(cep);
                    if (end != null)
                    {
                        Resultado.Text = string.Format("Endereço: {3} {0},{1} {2}", end.localidade, end.uf, end.logradouro, end.bairro);
                    }
                    else
                    {
                        DisplayAlert("ERRO!", "CEP não encontrado", "OK");
                    }
                }catch(Exception e)
                {
                    DisplayAlert("ERRO CRÍTICO!", e.Message, "OK");
                }
            }
        }
        private bool isValidCEP(string cep)
        {
            bool valid = true;
            if(cep.Length != 8)
            {
                DisplayAlert("ERRO", "CEP inválido! O CEP deve conter 8 caracteres", "OK");
                valid = false;
            }
            int NovoCEP = 0;
            if(!int.TryParse(cep, out NovoCEP))
            {
                DisplayAlert("ERRO", "CEP inválido! O CEP não deve conter letras ou caracteres especiais", "OK");
                valid = false;
            }
            return valid;
        }
    }
}
