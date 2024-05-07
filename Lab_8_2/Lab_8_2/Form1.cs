using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_8_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Probability of events
            double[] probabilities = { 0.1, 0.2, 0.3, 0.4};

            // Initialize the random number generator
            Random random = new Random();

            // Get event number
            int eventIndex = GetEventIndex(probabilities, random);

            switch (eventIndex)
            {
                case 0:
                    ans.Text = ("Yes");
                    break;
                case 1:
                    ans.Text = ("No");
                    break;
                case 2:
                    ans.Text = ("Maybe");
                    break;
                case 3:
                    ans.Text = ("I don't know");
                    break;
                default:
                    ans.Text = ("Сосредоточьтесь и спросите снова");
                    break;
            }

        }
        private int GetEventIndex(double[] probabilities, Random random)
        {
            
            // Randomly generate a probability value
            double randomValue = random.NextDouble();   // datchik

            // Calculate event number
            int eventIndex = 0;
            double cumulativeProbability = 0;
            foreach (var probability in probabilities)
            {
                cumulativeProbability += probability;
                if (randomValue <= cumulativeProbability)
                {
                    break;
                }
                eventIndex++;
            }

            return eventIndex;
        }
    }
}
