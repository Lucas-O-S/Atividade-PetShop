using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    public class Animal
    {
        private string nome;
        private string especie;
        private string dataNasc;
        private string raca;
        private float peso;
        private int codigo;

        //Gets e sets
        public string Nome{get{ return nome; } set { nome = value; } }
        public string Especie { get { return especie; } set { especie = value; } }
        public string DataNasc { get { return dataNasc; } set { dataNasc = value; } }
        public string Raca { get { return raca; } set { raca = value; } }
        public float Peso { get { return peso; } set { peso = value; } }
        public int Codigo { get { return codigo; } set { codigo = value; } }



        //Classe com as informações de um animal
        public Animal(string nome, string especie, string dataNasc,
            string raca, float peso, int codigo)
        {
            this.nome = nome;
            this.especie = especie;
            this.dataNasc = dataNasc;
            this.raca = raca;
            this.peso = peso;
            this.codigo = codigo;


        }

    }
}
