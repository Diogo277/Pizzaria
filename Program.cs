using System;
using System.Collections.Generic;

namespace Pizzaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo a pizzaria Jeronimos!");
            Dictionary  <string, int> carrinho = new Dictionary <string, int> ();
            Dictionary  <int, string>  cliente = new Dictionary <int, string> ();
            Dictionary  <string, int> cardapio = new Dictionary <string, int> ();
            double saldo;
            Console.Write("Seu saldo: ");
            Double.TryParse(Console.ReadLine(), out saldo);
            if(saldo<=0){
                Console.WriteLine("Volte quandon ter dinheiro!");
                Environment.Exit(0);
            }
            bool cadastrofeito = false;
            Menu menu = new Menu();
            menu.MenuLoja(cardapio,cliente, carrinho, saldo, cadastrofeito);
                      
        }
    }
}
