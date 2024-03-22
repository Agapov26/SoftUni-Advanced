using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chainblock
{
    public interface ITransaction
    {
        int Id { get; init; }

        TransactionStatus Status { get; set; }

        string Sender { get; set; }

        string Receiver { get; set; }

        decimal Amount { get; set; }
    }
}
