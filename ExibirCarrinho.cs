using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pizzaria
{

    public class ExibirCarrinho{
        

        public void Carrinho(Dictionary  <string, int> cardapio, Dictionary  <int, string> cliente, Dictionary  <string, int> carrinho, double saldo, bool cadastrofeito){
            Menu menu = new Menu();
            if(carrinho.Count != 0){
                foreach(KeyValuePair <string, int> v in carrinho){
                    Console.WriteLine($"Sabor: {v.Key}, preço: R${v.Value}");
                } 
            }else{
                Console.WriteLine("Carrinho vazio!");    
            }
            menu.MenuLoja(cardapio, cliente, carrinho, saldo, cadastrofeito);
        }
    
        
    }
}