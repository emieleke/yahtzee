﻿#region using statements
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
        public bool alGestoptDobbel1 = false;
        public bool alGestoptDobbel2 = false;
        public bool alGestoptDobbel3 = false;
        public bool alGestoptDobbel4 = false;
        public bool alGestoptDobbel5 = false;
        //De dobbelstenen
        public int dobbel1 = 0;
        public int dobbel2 = 0;
        public int dobbel3 = 0;
        public int dobbel4 = 0;
        public int dobbel5 = 0;

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




        public void dobbelen_Click(object sender, EventArgs e)
        {
            Rolldice();
            if (alGestoptDobbel1 != true)
            {
                dobbel1 = (dice[0]);
            }
            if (alGestoptDobbel1 != true)
            {
                dobbel2 = (dice[1]);
            }
            if (alGestoptDobbel1 != true)
            {
                dobbel3 = (dice[2]);
            }
            if (alGestoptDobbel1 != true)
            {
                dobbel4 = (dice[3]);
            }
            if (alGestoptDobbel1 != true)
            {
                dobbel5 = (dice[4]);
            }

            
            int score = dobbel1 + dobbel2 + dobbel3 + dobbel4 + dobbel5;
            textBox1.Text = Convert.ToString(score);





            if (dobbel1 == dobbel2 && dobbel2 == dobbel3 && dobbel3 == dobbel4 && dobbel4 == dobbel5)
            {
                bonus_textbox.Text = "yahtzee!";
            }
        }

        //dit veranderd de plaatjes
        private void Rolldice()
        {
            for (int i = 0; i < dice.Length; i++)
                dice[i] = rand.Next(1, 7);


            if (alGestoptDobbel1 != true)
            {
                pictureBox1.Image = diceimages[dice[0]];
            }
            if (alGestoptDobbel2 != true)
            {
                pictureBox2.Image = diceimages[dice[1]];
            }
            if (alGestoptDobbel3 != true)
            {
                pictureBox3.Image = diceimages[dice[2]];
            }
            if (alGestoptDobbel4 != true)
            {
                pictureBox4.Image = diceimages[dice[3]];
            }
            if (alGestoptDobbel5 != true)
            {
                pictureBox5.Image = diceimages[dice[4]];
            } 


        }



        //spelregel knop 
        private void spelregels_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Spelregels Yahtzee \nHoe werkt het? \nHet spel Yahtzee is een dobbelspel dat gespeeld wordt met 5 dobbelstenen en een scoreblok. Elke speler mag per beurt maximaal 3 x met de dobbelstenen gooien en proberen een zo hoog mogelijke score te behalen die hij kan opschrijven bij een van de combinaties op het scoreblok. Je bent verplicht om na elke beurt een vakje in te kruisen. \n                                                                                                                         Scores:\nBovenste vakken Bij de vakken 1 t / m 6 is het aantal punten gelijk aan het aantal keer dat een dobbelsteen het overeenkomstige aantal ogen aanwijst, vermenigvuldigd met het aantal ogen.\nOnderste vakken:\nDrie gelijke: De score is het totaal van alle ogen, als er minstens 3 dobbelstenen met hetzelfde aantal ogen zijn.\nVier gelijke: De score is het totaal van alle ogen, als er minstens 4 dobbelstenen met hetzelfde aantal ogen zijn.\nleine straat: 30 punten voor 4 oplopende dobbelstenen. (de volgorde speelt geen rol)\nGrote straat: 40 punten voor 5 oplopende dobbelstenen. (de volgorde speelt geen rol)\nFull House: 25 punten voor 3 gelijke en één paar. (5 gelijke telt niet als Full House, tenzij het vak Yahtzee reeds ingevuld is).\nKans: De score is het totaal aantal ogen van alle dobbelstenen.\nYahtzee: 50 punten als alle dobbelstenen hetzelfde aantal ogen hebben.");
        }



        private void stop_dice1_Click(object sender, EventArgs e)
        {
            if (alGestoptDobbel1 != true)
            {
                alGestoptDobbel1 = true;
            }
        }


        private void stop_dice2_Click(object sender, EventArgs e)
        {
            if (alGestoptDobbel2 != true)
            {
                alGestoptDobbel2 = true;
            }
        }

        private void stop_dice3_Click(object sender, EventArgs e)
        {
            if (alGestoptDobbel3 != true)
            {
                alGestoptDobbel3 = true;
            }
        }

        private void stop_dice4_Click(object sender, EventArgs e)
        {
            if (alGestoptDobbel4 != true)
            {
                alGestoptDobbel4 = true;
            }
        }

        private void stop_dice5_Click(object sender, EventArgs e)
        {
            if (alGestoptDobbel5 != true)
            {
                alGestoptDobbel5 = true;
            }
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
        private void score_textbox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_stop2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bonus_textbox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}