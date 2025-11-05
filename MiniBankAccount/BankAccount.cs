using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankAccount
{
    public class BankAccount
    {
        public string Owner { get; set; }

        public Guid AccountNumber { get; set; }

        public decimal balance { get; set; }

        public BankAccount(string Muzammil)
        {
            Owner = Muzammil;
            AccountNumber = Guid.NewGuid();
            balance = 0;
        }
    }
}
