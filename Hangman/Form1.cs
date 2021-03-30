using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class frmHangman : Form
    {
        public frmHangman()
        {
            InitializeComponent();
        }

        Random generator = new Random();

        string[] Words = { "COMPUTER", "APPLE", "WINDOW", "HORSE", "MOVIE", "lions", "BRAIN","YELLOW","ANIMALS","GORILLA","TEMPLE","GIANT","WALL","URETHRA","ANTIDISARTHERUM" };
        string displayWord = "_ _ _ _ _ _ _ _";

        int Lives;
        int random;
        string entered;
        int indexnum;
        string secretWord;
        



        private void frmHangman_Load(object sender, EventArgs e)
        {
            random = generator.Next(0, 5);
            
            Lives = 6;
            
            secretWord = Words[0];
            
            if (random == 0) 
            {
                secretWord = Words[0];
                displayWord = "_ _ _ _ _ _ _ _";
            }

            else if (random == 1) 
            {
                secretWord = Words[1];
                displayWord = "_ _ _ _ _";
            }

            else if (random == 2)
            {
                secretWord = Words[2];
                displayWord = "_ _ _ _ _ _";
            }
            else if (random  ==3)
            {
                secretWord = Words[3];
                displayWord = "_ _ _ _ _";
            }
            else if (random == 4)
            {
                secretWord = Words[4];
                displayWord = "_ _ _ _ _";
            }

            

            



        }

        private void btnGeuss_Click(object sender, EventArgs e)
        {
            
            entered = txtGeuss.Text;

            if (secretWord.Contains(txtGeuss.Text.ToUpper()))
            {
                indexnum = secretWord.IndexOf(entered.ToUpper());
                label1.Text = indexnum + "";
                displayWord = displayWord.Remove(indexnum*2,1);
                displayWord = displayWord.Insert(indexnum*2,entered);
                indexnum = secretWord.LastIndexOf(entered.ToUpper());
                displayWord = displayWord.Remove(indexnum * 2, 1);
                displayWord = displayWord.Insert(indexnum * 2, entered);




            }

            else
            {
                Lives -= 1;
                entered= lstGeussed.Text;
            }

            if (Lives == 5)
            {
                imgHangingMan.Image = Properties.Resources.Mistake1;
            }
            else if (Lives == 4)
            {
                imgHangingMan.Image = Properties.Resources.Mistake2;

            }

            else if (Lives == 3)
            {
                imgHangingMan.Image = Properties.Resources.Mistake3;

            }

            else if (Lives == 2)
            {
                imgHangingMan.Image = Properties.Resources.Mistake4;
            }
            else if ( Lives == 1 )
            {
                imgHangingMan.Image = Properties.Resources.Mistake5;
            }
            else if (Lives ==0)
                {
                imgHangingMan.Image = Properties.Resources.Dead;
            }

            lblLives.Text = Lives + "";

            lblWord.Text = displayWord;







        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f2 = new Form3();
            f2.ShowDialog();
        }
    }
}
