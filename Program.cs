using System;

namespace AulaPOOcelular
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------CELULAR----------");

            Celular xyz = new Celular();
            xyz.cor = "dourado";
            xyz.modelo = "Motorola G5";
            xyz.tamanhoTela = 8;
            xyz.ligado = false;

            Console.WriteLine("Celular Desligado. Deseja ligar?");
            string resposta = Console.ReadLine();

            if(resposta =="sim"){
                xyz.ligado = true;
                Console.WriteLine("LIGADO");
                  Console.WriteLine("[1]- Enviar Mensagem");
                    Console.WriteLine("[2]- Chamar");
                      Console.WriteLine("[0]- Desligar");
                      int choice = int.Parse(Console.ReadLine());

                      switch(choice){
                          case 1: Console.WriteLine($"{xyz.EnviarMensagem()}");
                            break;

                          case 2:Console.WriteLine($"{xyz.Chamar()}");
                            break;

                          case 0:Console.WriteLine($"{xyz.Desligar()}");
                            break;

                      }
            }else{
                Console.Clear();
            }
        }
    }
}
