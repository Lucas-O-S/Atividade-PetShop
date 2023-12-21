using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    class MenuAnimais
    {
        public void MenuPets()
        {


            //Variavel de seleção
            int opcao;

            //Chama da lista de animais
            ListaAnimais animal = new ListaAnimais();

            //metodo para digitar o codigo do animal
            int PerguntarCodigo()
            {
                Console.Write("Qual o Codigo do animal: ");
                int codigo = int.Parse(Console.ReadLine());
                return codigo;

            }

            //Começo do main
            Console.WriteLine("Menu de Pets");

            //Loop infinito do sistema até que seja quebrado
            while (true)
            {
                //Lista de opções
                Console.WriteLine("\n\nEscolha uma opção");
                Console.WriteLine("\n 1- Cadastrar\n 2- Excluir\n 3- Limpar Dados\n 4- Alterar\n 5- Consultar\n" +
                    " 6- Listar todos os animais cadastrados\n 7- Sair do Menu");

                //Verificação de escolha valida
                //Caso a escolha esteja certa e não saia do sistema o usuarios sera levado a esta parte do codigo
                try
                {
                   //Escolha de opção
                    opcao = OutrasFuncoes.PerguntarEscolha();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro, valor invalido");
                    continue;
                }

                if (opcao == 7)
                {
                    Console.WriteLine("Saindo do menu");
                    Console.ReadKey();
                    break;
                }

                else
                {
                    //Puxa o codigo correspondente com a escolha da pessoa
                    switch (opcao)
                    {
                        case 1:
                            animal.cadastrar(); ;


                            break;
                        case 2:

                            animal.excluir(PerguntarCodigo());

                            break;

                        case 3:
                            animal.limparDados(PerguntarCodigo());


                            break;

                        case 4:
                            animal.alterar(PerguntarCodigo());


                            break;

                        case 5:
                            animal.consultar(PerguntarCodigo());

                            break;

                        case 6:
                            animal.ListarAnimais();

                            break;


                    }
                }


            }


        }

    }
    
}
