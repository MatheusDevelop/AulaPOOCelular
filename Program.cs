﻿using System;

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
            
            return true;
        }
        public string Mensagem(string msg){
            if(state){
                Console.WriteLine(msg);
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
           inicio:
           
           Console.WriteLine("Qual açao voce quer fazer?");
           Console.WriteLine("Digite MENSAGEM para enviar uma mensagem");
           Console.WriteLine("Digite LIGAR para uma ligaçao");
           Console.WriteLine("Digite DESLIGAR para desligar o celular");
           switch (Console.ReadLine())
           {
               case "MENSAGEM":
                    Console.WriteLine("Digite uma mensagem");
                    Cell.Mensagem(Console.ReadLine());
                    
                    break;
                case "LIGAR":
                    Console.WriteLine("Digite o numero para ligaçao");
                    Cell.Ligar(Console.ReadLine());
                    break;
                case "DESLIGAR":
                    Cell.Desligar();
                    break;
               default:
                    Console.WriteLine("Comando invalido");
                    goto inicio;    
           }
           
           



        }
    }



}