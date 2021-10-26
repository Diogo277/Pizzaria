using System;
using System.Collections.Generic;

namespace Pizzaria
{
    class Cadastro: ICadastro{
        protected string nome;
        public string Nome{
            get{return nome;}
            set{nome = value;}
        } 

        protected string endereco;
        public string Endereco{
            get{return endereco;}
            set{endereco = value;}
        } 

        protected int cpf;
        public int CPF{
            get{return cpf;}
            set{cpf = value;}
        } 
        
        public void RealizarCadastro(Dictionary  <string, int> cardapio, Dictionary  <int, string> cliente, Dictionary  <string, int> carrinho,double saldo, bool cadastrofeito){
            Menu menu = new Menu();
            if(cadastrofeito == false){
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();
                Console.Write("Digite seu CPF para encerrar o cadastro: ");
                Int32.TryParse(Console.ReadLine(), out cpf);
                cadastrofeito = true;
                cliente.Add(cpf, nome);
                menu.MenuLoja(cardapio, cliente, carrinho, saldo, cadastrofeito);
            } else{
                Console.WriteLine("Cadastro já feito!");
                foreach(KeyValuePair <int, string> v in cliente){
                    Console.WriteLine($"Nome dos cliente cadastrado: {v.Value}, CPF: {v.Key}");          
            } menu.MenuLoja(cardapio, cliente, carrinho, saldo, cadastrofeito);
            }
        }

    }
}
