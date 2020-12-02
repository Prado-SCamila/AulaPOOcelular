namespace AulaPOOcelular
{
    public class Celular
    {
        public string cor;
        public string modelo;
        public int tamanhoTela;
        public bool ligado;

        public bool Ligar(){
            return true;
        }
        public bool Desligar(){
            return false;
        }
        public string EnviarMensagem(){
            return "Enviando mensagem...";
        }
        public string Chamar(){
            return "Chamando...";
        }
    }
}