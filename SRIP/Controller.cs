namespace SRIP_EventosDelegados {
    class Controller {

        Model model;
        View view;

        public Controller() {
            model = new Model();
            view = new View();
        }
        public void IniciarPrograma() {
            Vista vista = new Vista();
            vista.Iniciar();
        }
    }
}