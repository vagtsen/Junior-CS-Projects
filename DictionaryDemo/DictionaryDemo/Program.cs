using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Key value pairs 
namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> capitals = new Dictionary<string, string>();
            capitals.Add("Attica", "Athens");
            capitals.Add("Pieria", "Katerini");
            capitals.Add("Magnisia", "Volos");
            capitals.Add("Imathias", "Veroia");

            string capitalofAttica = capitals["Attica"];
            Console.WriteLine("The capital of Attica is {0} ", capitalofAttica);
            //string capitalofPieria = capitals["Katerini"];
            //Console.WriteLine("The capital of Attica is {0} ", capitalofPieria);
            //string capitalofMagnisia = capitals["Volos"];
            //Console.WriteLine("The capital of Attica is {0} ", capitalofMagnisia);
            //string capitalofImathias = capitals["Veroia"];
            //Console.WriteLine("The capital of Attica is {0} ", capitalofImathias);

            var nomoi = Nomos.GetNomoi();
            var attiki = nomoi["Attica"];
            Console.WriteLine("The Capital of Attica is {0}, population is {1}", attiki.Capital, attiki.Population);

        }
    }
}
