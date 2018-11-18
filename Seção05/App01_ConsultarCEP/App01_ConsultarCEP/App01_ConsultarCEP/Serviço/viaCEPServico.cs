using System;
using System.Collections.Generic;
using System.Text;
using System.Net; //WebClient
using App01_ConsultarCEP.Serviço.Modelo;
using Newtonsoft.Json; //Json convert

namespace App01_ConsultarCEP.Serviço
{
    public class ViaCEPServico
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/"; //Link que vai procurar o JSON e armazena em uma var
        public static Endereco BuscarEnderecoViaCEP(string cep) //metodo de procura
        {
            string NovoEnderecoURL = string.Format(EnderecoURL, cep); //Joga o cep que o usuario digitar no {0} do link
            WebClient wc = new WebClient(); //Instancia um novo webClient 
            string Conteudo = wc.DownloadString(NovoEnderecoURL); //Faz o download do Json gerado e joga na variavel Conteudo
            Endereco end = JsonConvert.DeserializeObject<Endereco>(Conteudo); //Converte o Json em um objeto de tipo Endereco
            if (end.cep == null) return null;
            return end;           
        }
    }
}