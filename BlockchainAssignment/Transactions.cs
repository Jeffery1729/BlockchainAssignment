using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    

    class Transactions
    {
        public String hash;
        String signature;
        public String senderAddress;
        public String recipientAddress;
        DateTime timestamp;
        public double fee;
        public double amount;
        Random rand = new Random();
        public Transactions(String from, String to, double amount, double fee, String privateKey)
        {
            this.senderAddress = from;
            this.recipientAddress = to;
            this.amount = amount;
            this.fee = fee;
            this.timestamp = DateTime.Now;
            this.hash = Createhash();
            this.signature = Wallet.Wallet.CreateSignature(from, privateKey, this.hash);
        }
        public Transactions(String from, String to, String privateKey)
        {
            this.senderAddress = from;
            this.recipientAddress = to;
            this.amount = rand.Next(101);
            this.fee = rand.Next(11);
            this.timestamp = DateTime.Now;
            this.hash = Createhash();
            this.signature = Wallet.Wallet.CreateSignature(from, privateKey, this.hash);
        }
        public String Createhash()
        {
            String hash = String.Empty;

            SHA256 hasher = SHA256Managed.Create();
            String input = timestamp.ToString() + senderAddress + recipientAddress + amount.ToString() + fee.ToString();
            Byte[] hashbyte = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

            foreach (byte x in hashbyte)
            {
                hash += String.Format("{0:x2}", x);
            }

            return hash;
        }
        public override string ToString()
        {
            return "Transaction hash: " + hash + "\nDigital Signature: " + signature + "\nTime stamp: " + timestamp.ToString() + "\nTransferred: " + amount.ToString() + " ReadingUniCoin" + "\nFee: " + fee.ToString() + "\nSender Address: " + senderAddress + "\nRecipient Address: " + recipientAddress + "\n";
        }
    }

}
