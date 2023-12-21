using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
    public class ConsultaVet
    {
        //Classe de Consultas
        private int Animal, Veterinario, codigo;
        private string Data, Motivo, Status;

        //Gets e sets
        public string status { get { return Status; } set { Status = value; } }
        public string motivo { get { return Motivo; } set { Motivo = value; } }
        public string data { get { return Data; } set { Data = value; } }
        public int animal { get { return Animal; } set { Animal = value; } }
        public int Codigo { get { return codigo; } set { codigo = value; } }
        public int veterinario { get { return Veterinario; } set { Veterinario = value; } }



        public ConsultaVet(int Animal, int Veterinario, string Data, String Motivo, string Status, int codigo)
        {
            this.Animal = Animal;
            this.Veterinario = Veterinario;
            this.Data = Data;
            this.Motivo = Motivo;
            this.Status = Status;
            this.codigo = codigo;
        }

    }
}
