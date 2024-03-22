using Chainblock.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chainblock
{
    public interface IChainblock
    {
        int Count { get; }

        void Add(ITransaction tx);

        bool Contains(int id);

        void ChangeTransactionStatus(int id, TransactionStatus newStatus);

        void RemoveTransactionById(int id);

        ITransaction GetById(int id);
    }
}
