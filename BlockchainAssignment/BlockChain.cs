using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class BlockChain
    {
        public List<Block> Blocks = new List<Block>();
        public List<Transactions> transactionpool = new List<Transactions>();
        int transactionsPerBlock = 5;
        public int miningmethod = 0;
        public bool useminignmethod = false;

        public BlockChain()
        {
            Blocks.Add(new Block());
        }

        public String getBlockasString(int index)
        {
            return Blocks[index].ToString();
        }

        public Block getLastBlock()
        {
            return Blocks[Blocks.Count - 1];
        }

        public List<Transactions> getPendingTransactions()
        {
            int n = Math.Min(transactionsPerBlock, transactionpool.Count);
            List<Transactions> transactions = transactionpool.GetRange(0, n);
            transactionpool.RemoveRange(0, n);
            return transactions;
        }
        public override string ToString()
        {
            String output = String.Empty;
            Blocks.ForEach(b => output += (b.ToString() + "\n"));
            return output;
        }
        public double GetBalance(String address)
        {
            double balance = 0.0;
            foreach (Block b in Blocks)
            {
                foreach (Transactions t in b.transactionList)
                {
                    if (t.recipientAddress.Equals(address))
                    {
                        balance += t.amount;
                    }
                    if (t.senderAddress.Equals(address))
                    {
                        balance -= (t.amount + t.fee);
                    }
                }
            }
            return balance;
        }

        public bool validateMerkleRoot(Block b)
        {
            String remerkle = Block.MerkleRoot(b.transactionList);
            return remerkle.Equals(b.merkleroot);
        }
    }
}
