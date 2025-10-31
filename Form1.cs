using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Messaging;
using System.Text;
using System.Runtime.CompilerServices;

namespace MSMQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public class GenerateRandomNumbers
        {
                private string _randomNumber;
                private  Random _rng = new Random(); // Shared RNG instance
                

            public GenerateRandomNumbers()
            {
               
            }

            public string RandomNumber 
            { 
                get
                {
                    return _randomNumber;
                }
                set
                {
                    _randomNumber = _rng.Next().ToString();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        GenerateRandomNumbers myRandom = new GenerateRandomNumbers();
            

            textNumbers.Text = myRandom.RandomNumber;

            System.Messaging.Message msg = new System.Messaging.Message();
            msg.Body = myRandom;

            MessageQueue msgQ = new MessageQueue(".\\Private$\\billpay");
            msgQ.Send(msg);

            
            Object o = new Object();
            System.Type[] arrTypes = new System.Type[2];
            arrTypes[0] = myRandom.GetType();
            arrTypes[1] = o.GetType();
            msgQ.Formatter = new XmlMessageFormatter(arrTypes);
            myRandom = ((GenerateRandomNumbers)msgQ.Receive().Body);

            StringBuilder sb = new StringBuilder();
            sb.Append("Random number {0}: "+myRandom.RandomNumber);
            sb.Append("\n");

            MessageBox.Show(sb.ToString(), "Message Received!");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string queuePath = @".\Private$\MyQueue";

            if (!MessageQueue.Exists(queuePath))
            {
                Console.WriteLine("Queue does not exist.");
                return;
            }

            using (MessageQueue queue = new MessageQueue(queuePath))
            {
                queue.Formatter = new XmlMessageFormatter(new string[] { "System.String" });

                try
                {
                    System.Messaging.Message msg = queue.Receive(); // Blocks until a message is available
                    string body = msg.Body.ToString();
                    textRead.Text= body;
                   // Console.WriteLine($"Received message: {body}");
                }
                catch (MessageQueueException mqe)
                {
                    Console.WriteLine($"MSMQ Error: {mqe.Message}");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string queuePath = @".\Private$\MyQueue";

            if (!MessageQueue.Exists(queuePath))
            {
                Console.WriteLine("Queue does not exist.");
                return;
            }

            using (MessageQueue queue = new MessageQueue(queuePath))
            {
                queue.Formatter = new XmlMessageFormatter(new string[] { "System.String" });

                try
                {
                    System.Messaging.Message msg = queue.Receive(); // Waits for a message
                    string messageText = msg.Body.ToString();

                    textPrint.Text = messageText;
                    //Console.WriteLine($"Received message: {messageText}");
                }
                catch (MessageQueueException mqe)
                {
                    //Console.WriteLine($"MSMQ error: {mqe.Message}");
                    textPrint.Text = $"MSMQ error: {mqe.Message}";
                }
            }
        }
    }
}
