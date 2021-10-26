using System;
using System.Collections.Generic;

namespace Pizzaria
{
    class Menu
    {
        public void MenuLoja(Dictionary  <string, int> cardapio, Dictionary  <int, string> cliente, Dictionary  <string, int> carrinho, double saldo,  bool cadastrofeito){
            int opcao;
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("1 - Realizar cadastro");
            Console.WriteLine("2 - Realizar compra");
            Console.WriteLine("3 - Ver carrinho");
            Console.WriteLine("4 - Ir para o caixa");
            Console.WriteLine("5 - Sair do sistema");
            Console.Write("Opcão: ");
            Int32.TryParse(Console.ReadLine(), out opcao);
            OpcaoSelecionada(cardapio, cliente, carrinho, saldo, cadastrofeito, opcao);
        }
        public void OpcaoSelecionada(Dictionary  <string, int> cardapio, Dictionary  <int, string> cliente, Dictionary  <string, int> carrinho, double saldo,  bool cadastrofeito, int opcao){
            Cadastro cadastro = new Cadastro();
            Compra compra = new Compra();
            ExibirCarrinho exibe = new ExibirCarrinho();
            Caixa caixa = new Caixa();
            switch(opcao){
                case 1:
                    cadastro.RealizarCadastro(cardapio, cliente, carrinho, saldo, cadastrofeito);
                    MenuLoja(cardapio, cliente, carrinho, saldo, cadastrofeito);
                    break;
                case 2:
                    compra.RealizarCompra(cardapio, cliente, carrinho, saldo, cadastrofeito);
                    MenuLoja(cardapio, cliente, carrinho, saldo, cadastrofeito);
                    break;
                case 3:
                    exibe.Carrinho(cardapio, cliente, carrinho, saldo, cadastrofeito);
                    MenuLoja(cardapio, cliente, carrinho, saldo, cadastrofeito);
                    break;
                case 4:
                    caixa.AnaliseCaixa(cardapio, cliente, carrinho, saldo, cadastrofeito);
                    MenuLoja(cardapio, cliente, carrinho, saldo, cadastrofeito);
                    break;
                case 5:
                    Console.WriteLine("Muito obrigado por acessar nosso sistema!");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opcao inválida!");
                    MenuLoja(cardapio, cliente, carrinho, saldo, cadastrofeito);
                    break;

            }

        }

    }
}