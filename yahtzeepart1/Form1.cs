#region using statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace yahtzeepart1
{
    public partial class Form1 : Form
    {
        

        Image[] diceimages;
        int[] dice;
        Random rand;

       

        
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //alle plaatjes voor de dobbelstenen
            diceimages = new Image[7];
            diceimages[0] = Properties.Resources._120px_Dice_0;
            diceimages[1] = Properties.Resources.Alea_1;
            diceimages[2] = Properties.Resources.Alea_2;
            diceimages[3] = Properties.Resources.Alea_3;
            diceimages[4] = Properties.Resources.Alea_4;
            diceimages[5] = Properties.Resources.Alea_5;
            diceimages[6] = Properties.Resources.Alea_6;

            dice = new int[5] { 0, 0, 0, 0, 0, };

            rand = new Random();


        }

        

        
        private void dobbelen_Click(object sender, EventArgs e)
        {
            Rolldice();
        }

        //dit rolled de dice 
        private void Rolldice()
        {
            for (int i = 0; i < dice.Length; i++)
                    dice[i] = rand.Next(1, 7);
            


            pictureBox1.Image = diceimages[dice[0]];
            pictureBox2.Image = diceimages[dice[1]];
            pictureBox3.Image = diceimages[dice[2]];
            pictureBox4.Image = diceimages[dice[3]];
            pictureBox5.Image = diceimages[dice[4]];
        }

        

        //spelregel knop 
        private void spelregels_Click(object sender, EventArgs e)
        {

        }

        //hier hoeven we niks mee ik kan ze gewoon niet wegkrijgen
        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_stop4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
