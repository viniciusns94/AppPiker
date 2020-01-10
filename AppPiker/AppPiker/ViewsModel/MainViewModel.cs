using AppPiker.Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppPiker.ViewsModel
{
    public class MainViewModel
    {
        CalculosMatematicos calcular = new CalculosMatematicos();

        public MainViewModel() { }

        public string OpcaoSelecionada(int valor, int opcao)
        {
            var resposta = "Erro valor inválido";
            if (valor > 0)
            {
                switch (opcao)
                {
                    //case "Número Primo":
                    case 0:
                        resposta = "Não é um n° primo";
                        if (calcular.NumeroPrimo(valor))
                        {
                            resposta = "É n° primo";
                        }
                        break;
                    //case "Número Par":
                    case 1:
                        resposta = "Não é um n° par";
                        if (calcular.NumeroPar(valor))
                        {
                            resposta = "É n° par";
                        }
                        break;
                    //case "Fatorial":
                    case 2:
                        resposta = calcular.CalcularFatorial(valor).ToString();
                        break;
                }
            }
            return resposta;
        }
    }
}