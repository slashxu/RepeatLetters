using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepeatLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "";
            Console.Write("Entre com uma mensagem: ");
            msg = Console.ReadLine();

            //Console.WriteLine(msg + "\n\n");

            var result = from a in msg.ToUpper().ToCharArray().Where(Char.IsLetter)
                         group a by a into g
                         select new
                         {
                             Letra = g.Key,
                             Repetidos = g.Count()
                         };

            foreach (var item in result)
            {
                Console.WriteLine(string.Format("Letra {0} aparece {1} vezes", item.Letra, item.Repetidos));
            }

            Console.ReadKey();
        }
    }
}
