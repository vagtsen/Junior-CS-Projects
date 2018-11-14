using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperBoyProject
{
    class Customer
    {
        public string FirstName { get; private set; } // κλειδώνω τη set 
        public string LastName { get; private set; }
        private Wallet _wallet; // Κλειδώνω το wallet 
        private float paymentNew;

        public Customer(string firstName, string lastName, Wallet wallet)
        {
            FirstName = firstName;
            LastName = lastName;
            _wallet = wallet;
        }

        public Customer()
        {
            LastName = "Tsenes";
            FirstName = "Vaggelis";
            _wallet = new Wallet(35f);
        }

        public float PayAmount(float amountToPay)
        {
            if (_wallet == null)
                throw new ArgumentException("_Wallet", "Wallet should not be null");
            if (_wallet.Value >= amountToPay)
            {
                _wallet.SubMoney(amountToPay);
                // return _wallet.Value
            }
            return _wallet.Value;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + ": " + _wallet.Value;
            //return base.ToString();
        }
    }
}
