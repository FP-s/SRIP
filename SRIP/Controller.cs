namespace SRIP_EventosDelegados {
    class Controller {

        Model model;
        View view;

        public Controller() {
            model = new Model();
            view = new View();
        }
        public void IniciarPrograma() {
           View view = new View();
           view.ApresentarLogin();
        }
    }
}