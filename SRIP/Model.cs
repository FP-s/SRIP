using System;

namespace SRIP_EventosDelegados {

    public class Model {

        View view = new View();
        public void VerificarLogin() {

            //Apresenta uma janela para o agente introduzir o seu login e passar ao metodo de verificação
            //Verificar o login
            //se for valido, chamar o metodo ApresentarInterface()
            //se não for valido, chamar o metodo ApresentarLogin()
            

            if (LoginValido()) {
                view.ApresentarInterface();
            }

            view.ApresentarLogin();            
        }

        public void ValidarDados() {

            //Apresentar a interface do programa para o agente introduzir os dados
            //Validar os dados
            if(DadosValidos()) {

            }
        }

        //função para verificar se o login é valido ou não
        public bool LoginValido() {

            //verificar se o login e password são validos atraves de uma interface apresentada
            //se forem validos, retornar true
            //se não forem validos, retornar false
            return true;

        }

        //função para verificar se os dados são validos ou não
        public bool DadosValidos() {

            //verificar todos os campos inseridos
            //se todos os campos forem validos, retornar true
            //se algum campo não for valido, retornar false
            return true;
        }


    }
}