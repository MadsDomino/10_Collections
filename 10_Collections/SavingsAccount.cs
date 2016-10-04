using System;

namespace _10_Collections
{
    internal class SavingsAccount : IAsset
    {
        private string symbol;
        public string Symbol
        {
            set
            {
                symbol = value;
            }
            get
            {
                return symbol;
            }
        }

        double value;
        public double Value
        {
            set
            {
                this.value = value;
            }
            get
            {
                return value;
            }
        }

        double interestrate;
        public double InterestRate
        {
            set
            {
                interestrate = value;
            }
            get
            {
                return interestrate;
            }
        }

        public double GetValue()
        {
            return Value;
        }

        public override string ToString()
        {
            return "SavingsAccount[value="+Value.ToString("#.0")+",interestRate="+InterestRate+"]";
        }

        public void ApplyInterest()
        {
            Value = Value * (1 + (InterestRate/100));
        }

        public string GetSymbol()
        {
            return Symbol;
        }

        public SavingsAccount () { }

        public SavingsAccount (string nid, double nvalue, double nirate)
        {
            Symbol = nid;
            Value = nvalue;
            InterestRate = nirate;
        }
    }
}