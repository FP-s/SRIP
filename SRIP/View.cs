using System;

namespace SRIP_EventosDelegados {

    public class View {
        
        Model model = new Model();
        public void ApresentarLogin() {

            //apresentar uma janela para o agente introduzir o seu login e passar ao metodo de verificação
            Console.WriteLine("Apresentar login");
            IntroduzirLogin();

        }

        public void IntroduzirLogin() {

            //passar o login para o model para ser verificado no Model
            model.VerificarLogin();

        }

        public void ApresentarInterface()
        {
            //apresentar a interface do programa para o agente introduzir os dados
            Console.WriteLine("Interface do programa");
            IntroduzirDados();
        }

        public void IntroduzirDados()
        {
            //passar os dados para o model para serem validados no Model
            model.ValidarDados();
        }
    }
}