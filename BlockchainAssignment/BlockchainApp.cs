using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        BlockChain blockchain;
        public BlockchainApp()
        {
            InitializeComponent();
            blockchain = new BlockChain();
            richTextBox1.Text = "New BlockChain initialised";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (Int32.TryParse(textBox1.Text, out index))
            {
                richTextBox1.Text = blockchain.getBlockasString(index);
            }
                
        }

        private void GenWallet_Click(object sender, EventArgs e)
        {
            String privKey;
            Wallet.Wallet mynewWallet = new Wallet.Wallet(out privKey);
            textBox2.Text = mynewWallet.publicID;
            textBox3.Text = privKey;
        }

        private void ValKeys_Click(object sender, EventArgs e)
        {
            if(Wallet.Wallet.ValidatePrivateKey(textBox3.Text, textBox2.Text))
            {
                richTextBox1.Text = "Keys are Valid";
            }
            else
            {
                richTextBox1.Text = "Keys are Invalid";
            }
        }

        private void CreateTransaction_Click(object sender, EventArgs e)
        {
            Transactions transaction = new Transactions(textBox2.Text, textBox6.Text, Double.Parse(textBox4.Text), Double.Parse(textBox5.Text), textBox3.Text);

            blockchain.transactionpool.Add(transaction);
            richTextBox1.Text = transaction.ToString();
        }

        private void GenNewBlock_Click(object sender, EventArgs e)
        {
            List<Transactions> transactions = blockchain.getPendingTransactions();
            long prevtime = blockchain.getLastBlock().timetaken;
            int prevdifficulty = blockchain.getLastBlock().difficulty;
            if (prevtime > 1000)
            {
                prevdifficulty--;

            }
            if (prevtime < 500)
            {
                prevdifficulty++;
            }
            Block newBlock = new Block(blockchain.getLastBlock(), transactions,prevdifficulty,blockchain.miningmethod, textBox2.Text);
            blockchain.Blocks.Add(newBlock);
            richTextBox1.Text = blockchain.ToString();
        }

        private void ValChain_Click(object sender, EventArgs e)
        {
           

            if (blockchain.Blocks.Count == 1)
            {
                if (!blockchain.validateMerkleRoot(blockchain.Blocks[0]))
                {
                    richTextBox1.Text = "BlockChain is invalid";
                }
                else
                {
                    richTextBox1.Text = "BlockChain is valid";
                }
                return;
            }

            for(int i = 1; i < blockchain.Blocks.Count - 1; i++)
            {
                if(blockchain.Blocks[i].prevhash != blockchain.Blocks[i - 1].hash || !blockchain.validateMerkleRoot(blockchain.Blocks[i]))
                {
                    richTextBox1.Text = "BlockChain is invalid";
                    return;
                }
                
            }
            richTextBox1.Text = "Blockchain is valid";
            
        }

        private void CheckBal_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = blockchain.GetBalance(textBox2.Text).ToString() + " ReadingUniCoin";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            blockchain.miningmethod = comboBox1.SelectedIndex;
        }


    }
}
