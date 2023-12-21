using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petshop
{
     static class OutrasFuncoes
    {

        //pergunta qual opção de menu deseja
        public static int PerguntarEscolha()
        {
            int resp = int.Parse(Console.ReadLine());
            return resp;
        }
        //Pega o ultimo codigo de animais ou consultas para evitar que hajá repetição do codigo delas
        public static int GetQuant(int escolha)
        {
            //1 para animais e 2(qualquer outra coisa) para consultas
            int quant;
            if (escolha == 1)
            {
                try
                {
                    quant = GerenciarDados.GetAnimais()[GerenciarDados.GetAnimais().Count - 1].Codigo + 1;
                    return quant;
                }
                catch (Exception)
                {
                    return 1;
                }

            }
            else
            {
                try
                {
                    quant = GerenciarDados.GetConsul()[GerenciarDados.GetConsul().Count - 1].Codigo + 1;
                    return quant;
                }

                catch (Exception)
                {
                    return 1;
                }

            }

        }
    }
    
}
