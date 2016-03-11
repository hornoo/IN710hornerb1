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

        //Set tech input checkin class
        CharaterInput formTextInputWorker;
        //set game namager class
        GameManager gameWorker;

        public Form1()
        {
            InitializeComponent();
            //Instantiate game manager, text input worker and see charater checklist boxs
             gameWorker = new GameManager();
             formTextInputWorker = new CharaterInput();
             DisplayPlayers(gameWorker.gameCharaterDic);
            
        }

        //Add a player to the game
        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            //If text input is not to long run add player method.
            if (formTextInputWorker.CheckStringInput(txtName.Text.Trim()) == 0)
            {
                Addplayer();
            }
            else
            {//else update charater displays with current charaters
                clearListCheckboxs();
                DisplayPlayers(gameWorker.gameCharaterDic);
            }
        }

        //Run battle method to allow players to battle
        private void btnBattle_Click(object sender, EventArgs e)
        {
            //run battle method
            battle();
        }

        //change pl;ayer weapon
        private void button1_Click(object sender, EventArgs e)
        {
            //for each player that is checked in the checkitem checkbox pass their name and new weapon into the game manager change weapon method 
            foreach(object item in checkedListBox2.CheckedItems)
            {//select weapon returns a weapon object depending on what radio button is selected ont he form
                gameWorker.changeWeapon(selectedWeapon(), item.ToString());
            }
        }

        //Display players in the checklist boxs from dictionary of players passed in.
        public void DisplayPlayers(Dictionary<String,Character> PlayersToDisplay)
        {

            foreach (KeyValuePair<String, Character> currentCharacter in PlayersToDisplay)
            {
                checkedListBox1.Items.Add(currentCharacter.Value.characterName);
                checkedListBox2.Items.Add(currentCharacter.Value.characterName);
            }

        }

        //check which player type iradio button is selected, pass name and player object into game worked to add to game display new list of players
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
            else 
            {
                displayDic = gameWorker.AddCharater(new Troll(txtName.Text.Trim()));
            }

            DisplayPlayers(displayDic);
     
        }

        //clear checked list boxes
        public void clearListCheckboxs()
        {
            checkedListBox1.Items.Clear();
            checkedListBox2.Items.Clear();
        }

        //Return weapon object of which weapon is selected 
        public IWeapon selectedWeapon()
        {
            if(rdBow.Checked)
            {
                return new Bow();
            }else if(rdKnife.Checked)
            {
                return new Knife();
            }else if(rdSword.Checked)
            {
                return new Sword();
            }else
            {
                return null;
            }
        }

        //battle players
        public void battle()
        {
            //check how many items are selected, present error is more or less than 2 players selected
            if (checkedListBox1.CheckedItems.Count > 2 || checkedListBox1.CheckedItems.Count < 2)
            {
                MessageBox.Show("Exactly 2 players must be select to battle!");
            }
            else
            {

                listBox1.Items.Clear();
                //Foreach player that is selected in the checked list box, run their Staname, Declaim and useweapon methods. 
                foreach (object player in checkedListBox1.CheckedItems)
                {


                    listBox1.Items.Add(gameWorker.gameCharaterDic[player.ToString()].StateName());
                    listBox1.Items.Add(gameWorker.gameCharaterDic[player.ToString()].Declaim());
                    listBox1.Items.Add(gameWorker.gameCharaterDic[player.ToString()].weapon.UseWeapon());
                    listBox1.Items.Add("");

                }
            }
        }
    }
}
