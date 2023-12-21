using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    public class Veterinaio
    {

        private string NomeVet,Especialidade;
        private int DiasTrabalho,CRMV;

        //Gets e sets
        public string nomeVet { get { return NomeVet; } set { NomeVet = value; } }
        public string especialidade { get { return Especialidade; } set { Especialidade = value; } }
        public int diasTrabalho { get { return DiasTrabalho; } set { DiasTrabalho = value; } }
        public int crmv { get { return CRMV; } set { CRMV = value; } }



        public Veterinaio(string nomeVet, int CRMV,string Especialidade, int DiasTrabalho)
        {
            this.NomeVet = nomeVet;
            this.CRMV = CRMV;
            this.Especialidade = Especialidade;
            this.DiasTrabalho = DiasTrabalho;
        }


    }
}
