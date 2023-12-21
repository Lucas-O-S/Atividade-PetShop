using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    public class ListaVet
    {
        private List<Veterinaio> veterinaios = GerenciarDados.GetVet();
        private string NomeVet, Especialidade;
        private int DiasTrabalho, CRMV, res;

        //Adiciona veterinario
        public void AddVet()
        {
            try{

                Console.WriteLine("---Cadastro de Veterinario---");

                Console.Write("Digite Nome:");
                NomeVet = Console.ReadLine();
                Console.Write("Digite CRMV:");
                CRMV = int.Parse(Console.ReadLine());
                Console.Write("Digite Especialidade:");
                Especialidade = Console.ReadLine();
                Console.Write("Digite Dias de Trabalho:");
                DiasTrabalho = int.Parse(Console.ReadLine());
                res = buscarVet(CRMV);
                if (res ==-1)
                {
                    veterinaios.Add(new Veterinaio(NomeVet, CRMV, Especialidade, DiasTrabalho));
                    GerenciarDados.SetVet(veterinaios);
                    res = buscarVet(CRMV);
                    Console.WriteLine($"O Medico {veterinaios[res].nomeVet} com CRMV {veterinaios[res].crmv} foi adicionado");

                }
                else {
                    Console.Write("CRMV já existe");

                }




            }
            catch (FormatException)
            {
                Console.Write("Erro, valor invalido");
            }
        }

        //mostra os dados de um veterinario
        public void ConsultarVet(int CRMV)
        {
            res = buscarVet(CRMV);
            if (res < 0)
            {
                Console.WriteLine("Veterinario Não encontrado");
            }
            else{
                Console.WriteLine($"Nome: {veterinaios[res].nomeVet}");
                Console.WriteLine($"CRMV: {veterinaios[res].crmv}");
                Console.WriteLine($"Especialidade: {veterinaios[res].especialidade}");
                Console.WriteLine($"Dias de Trabalho: {veterinaios[res].diasTrabalho}");

            }


        }

        //Altera os dados de um veterinario
        public void AlterarVet(int CRMV)
        {

            res = buscarVet(CRMV);

            if (res < -1)
            {
                Console.WriteLine("Veterinario Não encontrado");

            }
            else
            {
                try
                {

                    Console.WriteLine("---Alterar Cadastro de Veterinario---");

                    Console.Write("Digite Nome:");
                    veterinaios[res].nomeVet = Console.ReadLine();
                    Console.Write("Digite Especialidade:");
                    veterinaios[res].especialidade = Console.ReadLine();
                    Console.Write("Digite Dias de Trabalho:");
                    veterinaios[res].diasTrabalho = int.Parse(Console.ReadLine());

                    res = buscarVet(CRMV);
                    Console.WriteLine($"O Medico {veterinaios[res].nomeVet} com CRMV {veterinaios[res].crmv} foi alterado");
                    GerenciarDados.SetVet(veterinaios);

                }
                catch (FormatException)
                {
                    Console.Write("Erro, valor invalido");
                }
            }

        }

        //Exclui os dados de um veterinario
        public void ExcluirVet(int CRMV)
        {
            res = buscarVet(CRMV);

            if (res < -1)
            {
                Console.WriteLine("Veterinario Não encontrado");

            }
            else
            {
                veterinaios.RemoveAt(res);
                GerenciarDados.SetVet(veterinaios);
                Console.WriteLine("Veterinairo Deletado");

            }
        }

        //Lista nome e crmv de todos os veterinarios
        public void ListarVet()
        {
            for (int i = 0; i < veterinaios.Count; i++)
            {
                Console.WriteLine($"Nome: {veterinaios[i].nomeVet} CRMV: {veterinaios[i].crmv}");
            }
        }


        //Verifica se existe o veterinario
        private int buscarVet(int CRMV)
        {

            int temp = -1;
            for (int i = 0; i < veterinaios.Count; i++)
            {
                if (veterinaios[i].crmv == CRMV)
                {
                    temp = i;

                    break;

                }


            }
            return temp;
        }
    }

}


