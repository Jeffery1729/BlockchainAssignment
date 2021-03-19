using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Block
    {
        public int index;
        DateTime timestamp;
        public String hash;
        public String prevhash;
        public long timetaken = 0;
        public List<Transactions> transactionList = new List<Transactions>();
        public long nonce = 0;
        List<String> Threads = new List<string>();
        public String MiningMethod;

        public int difficulty;
        public double reward = 1.0;
        public double fees = 0.0;
        public String merkleroot;
        public String MinerAddress = String.Empty;

        public Block()
        {
            timestamp = DateTime.Now;
            difficulty = 4;
            index = 0;
            prevhash = String.Empty;
            reward = 0;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            hash = Mine();
            watch.Stop();
            timetaken = watch.ElapsedMilliseconds;
            MiningMethod = "None";
        }


        public Transactions CreateRewardTransaction(List<Transactions>transactions)
        {
            List<Transactions> orderedtransactions = new List<Transactions>(); 
            //orderedtransactions = transactions.OrderBy(Block => Block.fee);
            List<Transactions> selectedtransactions = new List<Transactions>();
            if (MiningMethod == "Greedy")
            {
                for(int i = 0; i < (orderedtransactions.Count/2); i++)
                {
                    //selectedtransactions.Add(orderedtransactions[i]);
                }                
            } else if (MiningMethod == "Altruistic")
            {
                for (int i = 0; i < (orderedtransactions.Count / 2); i++)
                {
                   // selectedtransactions.Add(orderedtransactions[(orderedtransactions.Count / 2) + i]);
                }
            } else if (MiningMethod == "Random")
            {
                var rand = new Random();
                for (int i = 0; i < (orderedtransactions.Count / 2); i++)
                {
                    
                    //selectedtransactions.Add(orderedtransactions[rand.Next(orderedtransactions.Count)]);
                }
            }else
            {
                selectedtransactions = transactions;
            }
            fees = selectedtransactions.Aggregate(0.0, (acc, t) => acc + t.fee);
            
            return new Transactions("Mine Rewards", MinerAddress, (reward + fees), 0, "");
        }

        public Block(Block lastblock, List<Transactions> transactions, int difficult,int miningmethod , String address = "")
        {
            this.timestamp = DateTime.Now;
            this.index = lastblock.index + 1;
            difficulty = difficult;
            this.prevhash = lastblock.hash;
            var watch = new System.Diagnostics.Stopwatch();
            
            watch.Start();
            hash = Mine();
            watch.Stop();
            timetaken = watch.ElapsedMilliseconds;
            if(miningmethod == 0)
            {
                MiningMethod = "Greedy";
            }else if(miningmethod == 1)
            {
                MiningMethod = "Altruistic";
            } else if(miningmethod == 2)
            {
                MiningMethod = "Random";
            } else
            {
                MiningMethod = "None";
            }
            MinerAddress = address;
            merkleroot = MerkleRoot(transactionList);         
            transactions.Add(CreateRewardTransaction(transactions));
            

            transactionList = transactions;
        }
        public Block(int index, String prevhash)
        {
            this.timestamp = DateTime.Now;
            this.index = index + 1;
            this.prevhash = hash;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            hash = Mine();
            watch.Stop();
            timetaken = watch.ElapsedMilliseconds;
        }
        public Block(Block lastblock)
        {
            this.timestamp = DateTime.Now;
            this.index = lastblock.index + 1;
            this.prevhash = lastblock.hash;
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            hash = Mine();
            watch.Stop();
            timetaken = watch.ElapsedMilliseconds;
        }
        public String CreateHash()
        {
            String hash = String.Empty;

            SHA256 hasher = SHA256Managed.Create();
            String input = index.ToString() + timestamp.ToString() + prevhash + nonce.ToString() + reward.ToString() + merkleroot;

            Byte[] hashByte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            foreach (byte x in hashByte)
            {
                hash += String.Format("{0:x2}", x);
            }
            return hash;
        }

        public String Mine()
        {
            String hash = CreateHash();

            String re = new string('0', difficulty);

            
            while (!hash.StartsWith(re))
            {
                nonce++;
                hash = CreateHash();
            }

            return hash;
        }

        public static String MerkleRoot(List<Transactions> transactionList)
        {
            List<String> hashes = transactionList.Select(t => t.hash).ToList();
            if(hashes.Count == 0)
            {
                return String.Empty;

            }
            if (hashes.Count == 1)
            {
                return HashCode.HashTools.combineHash(hashes[0],hashes[0]);

            }
            while(hashes.Count != 1)
            {
                List<String> MerkleLeaves = new List<String>();
                for(int i = 0; i<hashes.Count; i += 2)
                {
                    if(i == hashes.Count - 1)
                    {
                        MerkleLeaves.Add(HashCode.HashTools.combineHash(hashes[i], hashes[i]));

                    }
                    else
                    {
                        MerkleLeaves.Add(HashCode.HashTools.combineHash(hashes[i], hashes[i+1]));
                    }
                }
                hashes = MerkleLeaves;
            }
            return hashes[0];
        }


        public override string ToString()
        {
            String output = String.Empty;
            transactionList.ForEach(t => output += (t.ToString() + "\n"));
            return "Index: " + index.ToString()
                +"\nTimestamp: " + timestamp.ToString()
                + "\nPrevious hash: " + prevhash + 
                "\nHash: " + hash
                + "\nNonce: " + nonce.ToString()                 
                + "\nDifficulty: " + difficulty.ToString()
                + "\nReward: " + reward.ToString()
                + "\nFee's: " + fees.ToString()
                + "\nMiners Address: " + MinerAddress
                +"\nMining Method: " + MiningMethod
                + "\nTime Taken: " + timetaken +"ms"
                + "\nTransactions: \n" + output + "\n";
        }
    }
}
