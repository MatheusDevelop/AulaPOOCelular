using System;

namespace _01
{
    public class Celular
    {
        // public string Color(string cor){
        //     return cor;
        // };
        public bool state=false;
        public bool Ligar(){
            
            Console.WriteLine("O celular ligou");
            state =true;
            Console.WriteLine("Digite uma marca de celular");
            string marca= Console.ReadLine();
            Console.WriteLine("Digite a cor do celular");
            string cor= Console.ReadLine();
                 
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Marca {0} , Cor : {1}",marca,cor);
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("_____________________");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|Hello world.       |");            
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|                   |");
            Console.WriteLine("|___________________|");
            Console.WriteLine("|                   |");
            Console.WriteLine("|___________________|");
            Console.ResetColor();
            inicio:
            Console.ForegroundColor = ConsoleColor.Magenta;
            
            Console.WriteLine("_________________________________________");
            Console.WriteLine("Digite MENSAGEM para enviar uma mensagem");
            Console.WriteLine("Digite LIGAR para uma ligaçao");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Digite DESLIGAR para desligar o celular");
            Console.ResetColor();
            switch (Console.ReadLine())
            {
                case "MENSAGEM":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Digite uma mensagem");
                        Mensagem(Console.ReadLine());
                        Console.ResetColor();
                        goto inicio;
                        
                        
                        break;
                    case "LIGAR":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Digite o numero para ligaçao");
                        Ligar(Console.ReadLine());
                        Console.ResetColor();
                       goto inicio;
                        
                        
                        break;
                    case "DESLIGAR":
                        Desligar();
                        
                        break;
                default:
                        Console.WriteLine("Comando invalido");
                        Console.Clear();
                        goto inicio;
                        
                       
                        break;    
            }
            return true;
        }
        public string Mensagem(string msg){
            if(state){
                Console.WriteLine("Sua mensagem : {0}",msg);
                return "";
            }else{
                Console.WriteLine("O celular esta desligado");
                return "";
            }
        }
        public string Ligar(string number){
            if(state){
                Console.WriteLine("Ligando para {0}",number);
                return "";
            }else{
                Console.WriteLine("O celular esta desligado");
                return "";
            }
        }
        public bool Desligar(){
            Console.WriteLine("Desligando");
            state=false;
            return false;
        }
        

        




    };

    class Program
    {
        static void Main(string[] args){
           Celular Cell = new Celular();
           Console.WriteLine("Digite ON para ligar");
           switch(Console.ReadLine()){
                case "ON":
                    Cell.Ligar();
                    break;
                default:
                    Console.WriteLine("Comando invalido");
                    break;
           };
           
           
          
           
           
           
           
           



        }
    }



}
