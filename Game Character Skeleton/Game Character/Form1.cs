using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
    public partial class Form1 : Form
    {

        CharaterInput formTextInputWorker;
        GameManager gameWorker;

        public Form1()
        {
            InitializeComponent();
             gameWorker = new GameManager();
             formTextInputWorker = new CharaterInput();
             DisplayPlayers(gameWorker.gameCharaterDic);
            
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            if (formTextInputWorker.CheckStringInput(txtName.Text.Trim()) == 0)
            {
                Addplayer();
            }
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void DisplayPlayers(Dictionary<String,Character> PlayersToDisplay)
        {


            foreach (KeyValuePair<String, Character> currentCharacter in PlayersToDisplay)
            {
                checkedListBox1.Items.Add(currentCharacter.Value.characterName);
                checkedListBox2.Items.Add(currentCharacter.Value.characterName);
            }

        }

        public void Addplayer()
        {
            clearListCheckboxs();

            Dictionary<String,Character> displayDic = new Dictionary<string,Character>();

            if(rdKing.Checked)
            {
                displayDic = gameWorker.AddCharater(new King(txtName.Text.Trim()));
            }
            else if (rdQueen.Checked)
            {
                displayDic = gameWorker.AddCharater(new Queen(txtName.Text.Trim()));
            }
            else if (rdKnight.Checked)
            {
                displayDic = gameWorker.AddCharater(new Knight(txtName.Text.Trim()));
            }
            else if (rdTroll.Checked)
            {
                displayDic = gameWorker.AddCharater(new King(txtName.Text.Trim()));
            }


            DisplayPlayers(displayDic);
     
        }

        public void clearListCheckboxs()
        {
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
        }

    }
}
