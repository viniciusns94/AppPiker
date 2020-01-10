using AppPiker.ViewsModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppPiker
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        MainViewModel mainViewModel;

        public MainPage()
        {
            InitializeComponent();
            mainViewModel = new MainViewModel();
        }

        private void ButtonMainpageVerificar_Clicked(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(entry_mainpage_valor.Text);
            //String opcao = (String)piker_maintpage_operacao.SelectedItem;
            int opcao = piker_maintpage_operacao.SelectedIndex;
            label_mainpage_resposta.Text = mainViewModel.OpcaoSelecionada(valor, opcao);
        }
    }
}
