using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperBoyProject
{
    class Wallet
    { 
        public float Value {get; private set; }

        public Wallet (float initialAmount)
        {
            Value = initialAmount;
        }

        public void AddMoney (float amount)
        {
            Value += amount;
        }

        public void SubMoney(float amount)
        {
            Value -= amount;
        }
    }
}
