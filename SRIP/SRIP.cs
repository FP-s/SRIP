using System;

namespace SRIP_EventosDelegados {
    
    class SRIP {

        //Ponto de entrada principal do programa
        static void Main(string[] args) {

            //iniciar componente controller
            Controller controller = new Controller();
            controller.IniciarPrograma();
        }
    };
}