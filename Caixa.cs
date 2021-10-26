using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria
{
    class Caixa
    {
        public void AnaliseCaixa(Dictionary  <string, int> cardapio, Dictionary  <int, string> cliente, Dictionary  <string, int> carrinho, double saldo, bool cadastrofeito){
            Menu menu = new Menu();
            double e = 0;
            if(carrinho.Count == 0){
                Console.WriteLine("Carrinho vazio!");
                menu.MenuLoja(cardapio, cliente, carrinho, saldo, cadastrofeito);
            }
            foreach(KeyValuePair <string, int> v in carrinho){
                e += v.Value;
                saldo-=v.Value;
                if(saldo < 0){
                        Console.WriteLine("Saldo negativado ou zerado, compra cancelada!");
                        Environment.Exit(0);

                    }
            }
            Console.WriteLine($"Valor da compra: {e}");
            PagarCaixa(cardapio, cliente,carrinho, e, saldo, cadastrofeito);
        }

        public void PagarCaixa(Dictionary  <string, int> cardapio, Dictionary  <int, string> cliente, Dictionary  <string, int> carrinho, double e, double saldo, bool cadastrofeito){
            Menu menu = new Menu();
            Console.WriteLine($"Saldo final: R${saldo}");
            carrinho.Clear();
            menu.MenuLoja(cardapio, cliente, carrinho, saldo, cadastrofeito);

            
        }
    }
}