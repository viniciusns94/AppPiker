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

        public string OpcaoSelecionada(int valor, String opcao)
        {
            var resposta = "Erro valor inválido";
            if (valor > 0)
            {
                switch (opcao)
                {
                    case "Número Primo":
                        resposta = "Não é um n° primo";
                        if (calcular.NumeroPrimo(valor))
                        {
                            resposta = "É n° primo";
                        }
                        break;
                    case "Número Par":
                        resposta = "Não é um n° par";
                        if (calcular.NumeroPar(valor))
                        {
                            resposta = "É n° par";
                        }
                        break;
                    case "Fatorial":
                        resposta = calcular.CalcularFatorial(valor).ToString();
                        break;
                }
            }
            return resposta;
        }
    }
}