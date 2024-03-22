using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chainblock
{
    public class Transaction : ITransaction
    {
        private readonly int _id;
        private string _sender;
        private string _receiver;
        private decimal _amount;

        public TransactionStatus Status { get; set; }

        public int Id
        {
            get => _id;
            init
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _id = value;
            }
        }
        public string Sender
        {
            get => _sender;
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException();
                }
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException();
                }
                _sender = value;
            }
        }

        public string Receiver
        {
            get => _receiver;
            set
            {
                if (value is null)
                {
                    throw new ArgumentNullException();
                }
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentException();
                }
                _receiver = value;
            }
        }

        public decimal Amount
        {
            get => _amount;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }
                _amount = value;
            }
        }

        public Transaction(int id, string sender, string receiver, decimal amount)
        {
            Id = id;
            Status = TransactionStatus.New;
            Sender = sender;
            Receiver = receiver;
            Amount = amount;
        }
    }
}
