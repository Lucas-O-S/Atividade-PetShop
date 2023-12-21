using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    class MenuVet
    {


        private ListaVet listavet = new ListaVet();

        //facilita a pergunta de qual codigo será desejado


        //Menu relacionado a veterinarios
        public void Menuvet()
        {
            int PerguntarCRMV()
            {
                Console.Write("Digite o CRMV desejado: ");
                int codigo = int.Parse(Console.ReadLine());
                return codigo;

            }

            Console.WriteLine("\n---Menu de Veterinaios---");
            int opcao;

            while (true)
            {
                //Opções disponiveis
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("\n\n 1- Adicionar veterinario\n 2- Consultar veterinario" +
                    "\n 3- Alterar veterinario \n 4- Excluir veterinario\n 5- Listar veterinairos" +
                    "\n 6- Sair do Menu");
                try
                {
                    opcao = OutrasFuncoes.PerguntarEscolha();

                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro, valor invalido");
                    continue;
                }

                if (opcao == 6)
                {
                    Console.WriteLine("Saindo do menu");
                    break;
                }

                switch (opcao)
                {
                    case 1:
                        listavet.AddVet();
                        break;

                    case 2:
                        listavet.ConsultarVet(PerguntarCRMV());
                        break;

                    case 3:
                        listavet.AlterarVet(PerguntarCRMV());

                        break;

                    case 4:
                        listavet.ExcluirVet(PerguntarCRMV());

                        break;

                    case 5:
                        listavet.ListarVet();
                        break;

                    default:
                        Console.WriteLine("Erro, valor invalido");
                        break;

                }

            }


        }

    }
}
