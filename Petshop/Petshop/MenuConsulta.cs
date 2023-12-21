using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    class MenuConsulta
    {

        int PerguntarCodigo()
        {
            Console.Write("Digite o codigo da consulta desejada: ");
            int codigo = int.Parse(Console.ReadLine());
            return codigo;

        }

        //Menu de consultas
        public void MenuConsul()
        {
            int opcao;

            Console.WriteLine("\n---Menu de Consultas---");
            ListaConsu chamarfunc = new ListaConsu();


            while (true)
            {
                //opções de consultas
                Console.WriteLine("\n\nEscolha uma opção");
                Console.WriteLine("\n 1- Criar Consulta\n 2- Verificar Consulta\n 3- Cancelar Consulta" +
                    "\n 4- Finalizar Consulta\n 5- Remarcar Consulta\n 6- Listar Consultas\n 7- Sair do Menu");

                try
                {
                    opcao = OutrasFuncoes.PerguntarEscolha();

                    //Sao do menu
                    if (opcao==7)
                    {
                        Console.WriteLine("Saindo do Menu");
                        break;
                    }
                    else
                    {
                        //Busca o codigo correspondente a escolha
                        switch(opcao){
                            case 1:
                                chamarfunc.AddConsul();

                                break;

                            case 2:
                                chamarfunc.BuscarConsulta(PerguntarCodigo());
                                break;

                            case 3:
                                chamarfunc.CancelarConsulta(PerguntarCodigo());
                                break;

                            case 4:
                                chamarfunc.FinalizarConsulta(PerguntarCodigo());
                                break;

                            case 5:
                                chamarfunc.RemarcarConsulta(PerguntarCodigo());
                                break;

                            case 6:
                                chamarfunc.ListarConsultas();
                                break;

                            default:
                                Console.WriteLine("Erro, valor invalido");
                                break;

                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro, valor invalido");
                }
            }
        }
    }
}
