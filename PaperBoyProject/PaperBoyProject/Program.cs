using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperBoyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //Wallet wallet = new Wallet(65f);
       
            Customer customer = new Customer();
            PaperBoy ppBoy = new PaperBoy();

            //Customer customer2 = new Customer("Vaggelis", "Tsenes", new Wallet(65f));

            //Or 
            //Wallet paymentNew = new Wallet(52f);
            //Customer customer = new Customer("Vaggelis", "Tsenes", paymentNew);
            //customer.FirstName

            float walletValue = customer.PayAmount(12);
            PaperBoy ppBoy = new PaperBoy();
            Customer customer2 = new Customer("Vaggelis", "Tsenes", new Wallet(65f));
            ppBoy.SellPaper(customer);
            Console.WriteLine(customer);
        }
    }
}
