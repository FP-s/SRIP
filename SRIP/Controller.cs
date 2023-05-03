using System;

namespace SRIP_EventosDelegados {

    class Controller {

        //iniciar componentes do programa
        View view = new View();
        Model model = new Model();

        //eventos e delegados
        public delegate void ApresentarLogin();
        public event ApresentarLogin Login;

        public delegate void ApresentarInterface();
        public event ApresentarInterface Interface;

        public void IniciarPrograma() {

            //associar controller com a view para apresentar a interface de login
            Login += view.ApresentarLogin;

        }

        public void IntroduzirLogin(string login)
        {

            //associar controller com o model para verificar o login (metodo booleano retorna true se o login for valido)
            login += model.VerificarLogin;

            if (VerificarLogin(login)) {

                //associar controller com a view para apresentar a interface do programa
                Interface += view.ApresentarInterface;
            }
        }
    }    
}