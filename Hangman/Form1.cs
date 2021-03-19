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

        string Word;
        string displayWord;
        int GeussesNum;






        private void frmHangman_Load(object sender, EventArgs e)
        {

            Word = Word + "COMPUTER";
            GeussesNum = 0;
            lblWord.Text = "_ _ _ _ _ _ _ _";
        }

        private void btnGeuss_Click(object sender, EventArgs e)
        {











        }
    }
}
