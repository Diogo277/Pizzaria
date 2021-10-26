using System;
using System.Collections.Generic;


namespace Pizzaria
{
    public class Compra: ICompra
    {
        private string pizza;
            public string Pizza{
                get{return pizza;}
                set{pizza = value;}
            } 
            private int quant;
            public int Quant{
                get{return quant;}
                set{quant = value;}
            }

        
        public void RealizarCompra(Dictionary  <string, int> cardapio, Dictionary  <int, string> cliente, Dictionary  <string, int> carrinho, double saldo, bool cadastrofeito){
            Menu menu = new Menu();
            int opcao;
            string pizza;
            
            if(cadastrofeito == false){
                Console.WriteLine("Faça seu cadastro primeiro!");
                menu.MenuLoja(cardapio, cliente, carrinho, saldo, cadastrofeito);

            }
            if(cardapio.Count == 0){
                Console.Write("Cardápio vazio, deseja cadastrar uma pizza? {1}-SIM, {2}-NAO: ");
                Int32.TryParse(Console.ReadLine(), out opcao);
                if(opcao == 1){
                    CadastroPizza(cardapio, cliente, carrinho, saldo);
                }else{
                    Console.WriteLine("Tudo bem, volte para o menu");

                }
                menu.MenuLoja(cardapio, cliente, carrinho, saldo, cadastrofeito);

            }

            
           
            Console.WriteLine("Cardápio da pizzaria");
            foreach(KeyValuePair <string, int> v in cardapio){
                Console.WriteLine($"Sabor: {v.Key}, preço: R${v.Value}");
            }
            Console.Write("Deseja cadastrar uma pizza {1}-SIM, {2}-NAO: ");
            Int32.TryParse(Console.ReadLine(), out opcao);
            if(opcao == 2){
                Console.Write("Digite a pizza que deseja: ");
                pizza = Console.ReadLine();
                bool encontrado = false;

                foreach(KeyValuePair <string, int> v in cardapio){
                    if(pizza == v.Key){
                        Console.WriteLine("Pizza encontradada em nosso cardápio!");
                        encontrado = true;
                        Console.Write("Quantas pizzas vai querer? ");
                        Int32.TryParse(Console.ReadLine(), out quant);
                        carrinho.Add(pizza, quant*v.Value);
                        menu.MenuLoja(cardapio, cliente, carrinho, saldo, cadastrofeito);
                    }

                }
                if(encontrado == false){
                    Console.WriteLine("Pizza não registrada, volte para o Menu");
                    menu.MenuLoja(cardapio, cliente, carrinho, saldo, cadastrofeito);   

                } 
            }else {
                CadastroPizza(cardapio, cliente, carrinho, saldo);
                menu.MenuLoja(cardapio, cliente, carrinho, saldo, cadastrofeito);

            }

        }
        public void CadastroPizza(Dictionary  <string, int> cardapio, Dictionary  <int, string> cliente, Dictionary  <string, int> carrinho, double saldo){
            string pizza;
            int preco;
            Console.Write("Digite a pizza que deseja cadastrar: ");
            pizza = Console.ReadLine();
            Console.Write("Qual será o preço da pizza? ");
            Int32.TryParse(Console.ReadLine(), out preco);
            cardapio.Add(pizza, preco);   
        }
    }
}
