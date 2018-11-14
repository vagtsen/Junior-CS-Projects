using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperBoyProject
{
    class PaperBoy
    {
        public void SellPaper(Customer customer)
        {
            //Wallet wallet = new Wallet(65f);
            //wallet.Value = 65f; // δεν μπορώ να πειράξω το property γιατί το set το έχω θέσει private 

            var payment = 2.0f;
            //var amountPay = 
            //customer.PayAmount(65f);
            var customerWalletValue = customer.PayAmount(payment);// έτσι δεν έχει σχεση το paperboy με το wallet 
                                                                  // δεν ασχολούμαι γενικά με το wallet

        }
    }
}
