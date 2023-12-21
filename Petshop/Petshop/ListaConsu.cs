using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    class ListaConsu
    {
        private int CodAnimal, CodVeterinario;
        private string Data, Motivo;

         List<ConsultaVet> listaConsul = GerenciarDados.GetConsul();
         List<Veterinaio> veterinaios = GerenciarDados.GetVet();
        List<Animal> animais = GerenciarDados.GetAnimais();
        private int codigo, res;

        //Adiciona Consultas
        public void AddConsul()
        {

            Console.WriteLine("Criação de Consulta");
            codigo = OutrasFuncoes.GetQuant(2);
            try
            {
                codigo = OutrasFuncoes.GetQuant(2);
                Console.Write("Digite o Codigo do animal: ");
                CodAnimal = int.Parse(Console.ReadLine());
                Console.Write("Digite o CRMV do Veterinario: ");
                CodVeterinario = int.Parse(Console.ReadLine());
                Console.Write("Digite a data marcada: ");
                Data = Console.ReadLine();
                Console.Write("Digite o Motivo: ");
                Motivo = Console.ReadLine();

                //Verifica se animal ou veterinario existe
                if (buscarAnimal(CodAnimal) < 0 || buscarVet(CodVeterinario) < 0)
                {
                    Console.WriteLine("Erro, Pet ou veterinario não existem");

                }
                else
                {
                    listaConsul.Add(new ConsultaVet(CodAnimal, CodVeterinario, Data, Motivo, "Incompleta", codigo));
                    GerenciarDados.SetConsu(listaConsul);
                    res = VerificarConsulta(codigo);
                    Console.WriteLine($"Consulta de Codigo {codigo} foi marcada");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Erro, Valor invalido");
            }


        }

        //Busca consultas atravez do codigo
        public void BuscarConsulta(int numConsulta)
        {
            res = VerificarConsulta(numConsulta);
            if(res < 0)
            {
                Console.WriteLine("Erro, Valor invalido");

            }
            else{
                Console.WriteLine($"Codigo: {numConsulta}");
                Console.WriteLine($"Animal: {listaConsul[res].animal}");
                Console.WriteLine($"Veterinario: {listaConsul[res].veterinario} ");
                Console.WriteLine($"Data: {listaConsul[res].data}");
                Console.WriteLine($"Motivo: {listaConsul[res].motivo}");
                Console.WriteLine($"Status: {listaConsul[res].status}");


            }

        }

        //Muda status para cancelado
        public void CancelarConsulta(int numConsulta)
        {
            if (VerificarConsulta(numConsulta) < 0)
            {
                Console.WriteLine("Erro, Valor invalido");

            }
            else
            {
                listaConsul[res].status = "Cancelada";
                GerenciarDados.SetConsu(listaConsul);
                Console.WriteLine("Consulta cancelada");

            }


        }

        //deixa estatus como finalizado
        public void FinalizarConsulta(int numConsulta)
        {
            if (VerificarConsulta(numConsulta) < 0)
            {
                Console.WriteLine("Erro, Valor invalido");

            }
            else
            {
                listaConsul[res].status = "Finalizada";
                GerenciarDados.SetConsu(listaConsul);
                Console.WriteLine("Consulta Finalizada");
            }

        }

        //Muda data da consulta
        public void RemarcarConsulta(int numConsulta)
        {
            res = VerificarConsulta(numConsulta);
            if(res < 0)
            {
                Console.WriteLine("Erro, Valor invalido");

            }
            else{
                Console.Write("Digite nova data");
                listaConsul[res].data = Console.ReadLine();
                GerenciarDados.SetConsu(listaConsul);
                Console.WriteLine("Data da Consulta alterada");
            }

        }

        //Lista todos os codigos e status das consultas
        public void ListarConsultas()
        {
            for(int i =0; i<listaConsul.Count(); i++)
            {
                Console.WriteLine($"Codigo: {listaConsul[i].Codigo}      Status: {listaConsul[i].status}");
            }
        }





        //vê se existe o animal chamado
        private int buscarAnimal(int CodigoAnimal)
        {
            int temp = -1;
            for (int i = 0; i < animais.Count; i++)
            {
                if (animais[i].Codigo == CodigoAnimal)
                {
                    temp = i;

                    break;

                }


            }
            return temp;
        }

        //Vê se existe a consulta
        private int VerificarConsulta(int CodigoConsulta)
        {
            int temp = -1;
            for (int i = 0; i < listaConsul.Count; i++)
            {
                if (listaConsul[i].Codigo == CodigoConsulta)
                {
                    temp = i;

                    break;

                }


            }
            return temp;
        }

        //Vê se existe o veterinario
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
