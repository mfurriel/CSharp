using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Este código simples é apenas para aprender conceitos básicos
 * relacionados à estruturas de repetição, condição e outros.
 * 
 * O código não representa a melhor maneira se obter a idade de alguém. 
 * Também não apresenta meios para validar se a entrada do usuário está correta.
 */

namespace CalculaIdadeCMD
{
    class Program
    {
        static void Main(string[] args)
        {
            int diaHoje = DateTime.Now.Day;
            int mesHoje = DateTime.Now.Month;
            int anoHoje = DateTime.Now.Year;

            int diaNasc = 0, mesNasc = 0, anoNasc = 0, idade = 0;

            Console.WriteLine("Informe o dia do seu aniversario (dd/mm/aaaa) : ");
            string dtNascimento = Console.ReadLine();
            string[] dtNasc = dtNascimento.Split('/');

            for (int i = 0; i < dtNasc.Length; i++)
            {
                if(i == 0)
                {
                    diaNasc = Convert.ToInt32(dtNasc[i]);
                }
                else if (i == 1)
                {
                    mesNasc = Convert.ToInt32(dtNasc[i]);
                }
                else if (i == 2)
                {
                    anoNasc = Convert.ToInt32(dtNasc[i]);
                }
            }

            idade = anoHoje - anoNasc;

            if((mesHoje < mesNasc) || ((mesHoje == mesNasc) && (diaHoje >= diaNasc)))
            {
                idade--;
            }

            Console.WriteLine("Sua idade é " + idade + " anos");
            Console.ReadLine();

        }
    }
}
