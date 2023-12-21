using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{

        public class ListaAnimais
        {
            //Atributos da classe Animais
            //Declaração de variáveis -> atributos

            private string nome;
            private string especie;
            private string dataNasc;
            private string raca;
            private float peso;

            //Numero unico de cada animal que incrementa automaticamente

            //Variavel responsavel por devolver o codigo do animal que está sendo buscado
            private int res;
            
            //Lista de animais da classe animal
            List<Animal> animais = GerenciarDados.GetAnimais();
        private int codigo = OutrasFuncoes.GetQuant(1);


        //métodos
        public void cadastrar()
            {

            try
            {
                codigo = OutrasFuncoes.GetQuant(1);
                Console.WriteLine("---> Cadastro de Animais <---");

                //Este método permite cadastrar o animal de acordo com os dados
                Console.Write("Digite o nome do animal: ");
                nome = Console.ReadLine();

                Console.Write("Digite a espécie: ");
                especie = Console.ReadLine();

                Console.Write("Digite a raça: ");
                raca = Console.ReadLine();

                Console.Write("Digite a data de nascimento do animal. \n Formato: dd/mm/aaaa ");
                dataNasc = Console.ReadLine();

                Console.Write("Digite o peso: ");
                peso = float.Parse(Console.ReadLine());

                //Adiciona um animal a lista
                animais.Add(new Animal(nome, especie, dataNasc, raca, peso, codigo));
                GerenciarDados.SetAnimais(animais);

                res = buscarAnimal(codigo);

                //prepara o proximo codigo do animal que pode ser cadastrado

                Console.WriteLine($"O animal {animais[res].Nome} de codigo {animais[res].Codigo} foi adicionado ");

            }
            catch (FormatException)
            {
                Console.WriteLine("Valor Invalido");
            }

            }

            //Exclui um animal na lista
            public void excluir(int CodigoAnimal)
            {
            res = buscarAnimal(CodigoAnimal);

            if (res < 0)
            {
                Console.WriteLine("Erro, animal não encontrado ou não existe" );
                    
            }
            else
            {
                animais.RemoveAt(res);
                Console.WriteLine("Animal Deletado");
                GerenciarDados.SetAnimais(animais);

            }

            }

            //Reseta informações do animal, mas mantendo o seu codigo
            public void limparDados(int CodigoAnimal)
            {
            res = buscarAnimal(CodigoAnimal);

            if (res < 0)
            {
                Console.WriteLine("Erro, animal não encontrado ou não existe");

            }
            else
            {
                animais[res].Nome = null;
                animais[res].Especie = null;
                animais[res].Raca = null;
                animais[res].DataNasc = null;
                animais[res].Peso = 0;
                Console.WriteLine($"OS dados do animal, de codigo {animais[res].Codigo}," +
                    $" foram limpos");
                GerenciarDados.SetAnimais(animais);

            }

            }
            
            //Altera as informações do animal selecionado
            public void alterar(int CodigoAnimal)
            {

            res = buscarAnimal(CodigoAnimal);

            if (res < 0)
            {
                Console.WriteLine("Erro, animal não encontrado ou não existe");

            }
            else
            {
                try{
                    Console.WriteLine("---> Alteração de Cadastro do Animais <---");
                    Console.Write("Digite o nome: ");
                    animais[res].Nome = Console.ReadLine();

                    Console.Write("Digite a espécie: ");
                    animais[res].Especie = Console.ReadLine();

                    Console.Write("Digite a raça: ");
                    animais[res].Raca = Console.ReadLine();

                    Console.Write("Digite a data de nascimento. \n Formato: dd/mm/aaaa ");
                    animais[res].DataNasc = Console.ReadLine();

                    Console.Write("Digite o peso: ");
                    animais[res].Peso = float.Parse(Console.ReadLine());
                    Console.WriteLine($"O animal {animais[res].Nome} de codigo {animais[res].Codigo} teve seus dados alterados ");
                    GerenciarDados.SetAnimais(animais);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erro, Valor Invalido");
                }

            }

            }

            //Devolve todas as informações do animal
            public void consultar(int CodigoAnimal)
            {

            res = buscarAnimal(CodigoAnimal);

            if (res < 0)
            {
                Console.WriteLine("Erro, animal não encontrado ou não existe");

            }
            else
            {
                Console.WriteLine($"Nome: {animais[res].Nome}");
                Console.WriteLine($"Data de nascimento: {animais[res].DataNasc}");
                Console.WriteLine($"Especie: {animais[res].Especie}");
                Console.WriteLine($"Raça: {animais[res].Raca}");
                Console.WriteLine($"Peso: {animais[res].Peso}KG");

            }
            }

            //Lista todos os animais com seu nome e codigo
            public void ListarAnimais()
            {

                GerenciarDados.GetAnimais();
                if ( animais.Count == 0)
                {
                Console.WriteLine("Nenhum animal cadastrado");
                }
                else
                {
                    Console.WriteLine("---Lista de Animais Cadastrados---");
                    for (int i = 0; i < animais.Count; i++)
                    {
                        Console.WriteLine($"Codigo: {animais[i].Codigo} - Nome: {animais[i].Nome}");
                    }
                }


            }

            //Busca dentro da lista um animal com o codigo desejado e devolve se foi encontrato
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
    }


    }

