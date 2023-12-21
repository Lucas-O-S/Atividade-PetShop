using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Petshop
{
    //Classe para gerenciar dados em arquivos txt

    public static class GerenciarDados
    {
        //Local da pasta de save
        private static string LocalDeSave = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\DadosPetshop";
        private static string nomePasta = "DadosPetshop";
        
        //Arquivos para cada classe
        private static string DadosAnimais = $"{Path.Combine(LocalDeSave, "DadosAnimais.txt")}";
        private static string DadosConsulta = $"{LocalDeSave}//DadosConsulta.txt";
        private static string DadosVeterinairos = $"{LocalDeSave}//DadosVeterinarios.txt";

        //Verificar se há as pastas e arquivos no computado
        public static void CriarVerificar()
        {
            if (!Directory.Exists(Path.Combine(LocalDeSave, nomePasta)))
            {
                Directory.CreateDirectory(Path.Combine(LocalDeSave, nomePasta));
            }
            if (!File.Exists(DadosAnimais)) {
                using (FileStream fw = new FileStream(DadosAnimais, FileMode.Create, FileAccess.ReadWrite)) ;
            }
            if (!File.Exists(DadosConsulta))
            {
                using (FileStream fw = new FileStream(DadosConsulta, FileMode.Create, FileAccess.ReadWrite)) ;
            }
            if (!File.Exists(DadosVeterinairos))
            {
                using (FileStream fw = new FileStream(DadosVeterinairos, FileMode.Create, FileAccess.ReadWrite)) ;
            }


        }

        //Salvar Lista Animais
        public static void SetAnimais(List<Animal> animais) {

            File.WriteAllText(DadosAnimais, String.Empty);
            for (int i = 0; i < animais.Count; i++)
            {



                File.AppendAllText(DadosAnimais, $"{animais[i].Nome}-{animais[i].Especie}-{animais[i].DataNasc}-{animais[i].Raca}-{animais[i].Peso}-{animais[i].Codigo};");


            }


        }

        //Pegar Lista Animais
        public static List<Animal> GetAnimais()
        {
            string dados = File.ReadAllText(DadosAnimais);

            List<Animal> animais = new List<Animal>();
            String[] linhas = dados.Split(';');
            String[] colunas;



            for (int i = 0; i < linhas.Length - 1; i++)
            {
                colunas = linhas[i].Split('-');


                animais.Add(new Animal(colunas[0], colunas[1], colunas[2], colunas[3], float.Parse(colunas[4]), int.Parse(colunas[5])));


            }



            return animais;


        }

        //Salvar lista veterinarios
        public static void SetVet(List<Veterinaio> ListaVet) {

            File.WriteAllText(DadosVeterinairos, String.Empty);

            for (int i = 0; i < ListaVet.Count; i++)
            {
                File.AppendAllText(DadosVeterinairos, $"{ListaVet[i].nomeVet}-{ListaVet[i].crmv}-{ListaVet[i].especialidade}-{ListaVet[i].diasTrabalho};");
            }

        }


        //Pegar arquivo e trasformar numa lista de veterinarios
        public static List<Veterinaio> GetVet(){
            string dados = File.ReadAllText(DadosVeterinairos);

            List<Veterinaio> Vet = new List<Veterinaio>();
            String[] linhas = dados.Split(';');
            String[] colunas;


            for (int i = 0; i < linhas.Length - 1; i++)
            {
                colunas = linhas[i].Split('-');


                Vet.Add(new Veterinaio(colunas[0], int.Parse(colunas[1]), colunas[2], int.Parse(colunas[3])));


            }



            return Vet;



        }

        //Salvar lista de consultas em um arquivo txt
        public static void SetConsu(List<ConsultaVet> ListaConsul)
        {

            File.WriteAllText(DadosConsulta, String.Empty);

            for (int i = 0; i < ListaConsul.Count; i++)
            {
                File.AppendAllText(DadosConsulta, $"{ListaConsul[i].animal}-{ListaConsul[i].veterinario}-{ListaConsul[i].data}-{ListaConsul[i].motivo}-{ListaConsul[i].status}-{ListaConsul[i].Codigo};");
            }

        }

        //Trasnformar arquivo em lista de consultas
        public static List<ConsultaVet> GetConsul()
        {
            string dados = File.ReadAllText(DadosConsulta);

            List<ConsultaVet> consultaVet = new List<ConsultaVet>();
            String[] linhas = dados.Split(';');
            String[] colunas;


            for (int i = 0; i < linhas.Length - 1; i++)
            {
                colunas = linhas[i].Split('-');


                consultaVet.Add(new ConsultaVet(int.Parse(colunas[0]), int.Parse(colunas[1]), colunas[2], colunas[3], colunas[4], int.Parse(colunas[5])));
            }

            return consultaVet;



        }




    }
}
