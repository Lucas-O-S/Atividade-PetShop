using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    internal class Program
    {
        //Classe principal
        static void Main(string[] args)
        {
            GerenciarDados.CriarVerificar();
            int opcao;
            Console.WriteLine("---Bem Vindo, escolha qual menu deseja acessar---");

            while (true)
            {
                //Menus disponiveis
                Console.WriteLine("\n 1- Menu de Consultas" +
    "\n 2- Menu de Veterinario\n 3- Menu de Pets\n 4- Sair do sistema");
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (FormatException )
                {
                    Console.WriteLine("Erro, valor invalido");
                    continue;
                }

                switch(opcao){
                    case 1:
                        //Chama menu de consultas
                        MenuConsulta MC = new MenuConsulta();
                        MC.MenuConsul();

                        break;

                    case 2:
                        //Chama menu de veterinarios
                        MenuVet mv = new MenuVet();
                        mv.Menuvet();
                        break;

                    case 3:
                        //chama menu de pets
                        MenuAnimais ma = new MenuAnimais();
                        ma.MenuPets();
                        break;

                    case 4:
                        //fecha programa
                        Console.WriteLine("Fechando o sistema...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    default:
                        //Caso escreva valor de opcao invalido com a swicth
                        Console.WriteLine("Erro, valor invalido");
                        break;
                }

            }


        }
    }
}
