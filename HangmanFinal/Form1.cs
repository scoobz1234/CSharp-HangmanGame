using HangmanFinal.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace HangmanFinal
{
    public partial class frmMainWindow : Form
    {
        public frmMainWindow()
        {
            InitializeComponent();
        }

        //CONTAINER FOR THE GENERATED WORD (Word to be guessed)
        private string GeneratedWord;
        //CONTAINER FOR THE LABELS WE WILL CREATE
        private List<Label> LetterLabels = new List<Label>();
        //KEEPS TRACK OF HOW MANY MISSES PLAYER HAS HAD...
        private int missed = 0;
        // HOW MANY CHANCES THE PLAYER HAS...
        private readonly int chances = 6;

        //ALL THE BODY PARTS SO WE CAN DRAW THE HANGMAN
        private enum Hangman
        {
            Head,
            Body,
            Left_Leg,
            Right_Leg,
            Right_Arm,
            Left_Arm
        }

        // START OF APPLICATION WILL RUN THIS FUNCTION... //
        private void FrmMainWindow_Shown(object sender, EventArgs e)
        {
            DrawPost();
        }

        // HERE WE ARE DRAWING THE HANGING POST //
        private void DrawPost()
        {
            //CREATE THE GRAPHICS OBJECT...
            Graphics g = pnlHangman.CreateGraphics();
            //CREATE THE PEN OBJECT...
            Pen p = new Pen(Color.DarkKhaki, 10);

            // points are start x and start y, end x and end y.
            // points are local to the object your drawing on...
            // in this case its our panel and the top left is 0,0
            // this is regardless of where on the form the panel is...

            g.DrawLine(p, new Point(540, 450), new Point(540, 80));     // NOOSE //
            g.DrawLine(p, new Point(600, 450), new Point(200, 450));    // TOP //
            g.DrawLine(p, new Point(545, 75), new Point(350, 75));      // POST //
            g.DrawLine(p, new Point(350, 70), new Point(350, 120));     // BOTTOM //

            CreateLetterLabels();

        }

        // THIS FUNCTION HANDLES THE CREATION OF THE HUNG MAN'S BODY... //
        private void DrawHangmanParts(Hangman h)
        {
            Graphics g = pnlHangman.CreateGraphics();
            Pen p = new Pen(Color.Blue, 2);

            switch (h)
            {
                case Hangman.Head:
                    //draw a circle, use pen then x, y then width and height...
                    g.DrawEllipse(p, 320, 120, 60, 60);
                    break;
                case Hangman.Body:
                    g.DrawLine(p, new Point(350,180), new Point(350,300));
                    break;
                case Hangman.Left_Arm:
                    g.DrawLine(p, new Point(350, 210), new Point(280, 150));
                    break;
                case Hangman.Right_Arm:
                    g.DrawLine(p, new Point(350, 210), new Point(420, 150));
                    break;
                case Hangman.Left_Leg:
                    g.DrawLine(p, new Point(350, 300), new Point(300, 400));
                    break;
                case Hangman.Right_Leg:
                    g.DrawLine(p, new Point(350, 300), new Point(400, 400));
                    break;
            }
        }

        // CREATES THE LABELS //
        private void CreateLetterLabels()
        {
            // GET A RANDOM WORD //
            GeneratedWord = Picker.SelectWord();
            //splits the word into an array of chars.
            char[] chars = GeneratedWord.ToCharArray();
            //find how much space we have in the group box...
            int freeSpace = gbWordBox.Width / chars.Length;

            //loop through the chars array and create labels
            for (int i = 0; i < chars.Length; i++)
            {
                CreateLabelObject(i, freeSpace);
            }
            // SET THE LABEL FOR WORD LENGTH TO THE LENGTH OF THE WORD...
            lblLetterCount.Text = "Word Length: " + chars.Length.ToString();
        }

        // FUNCTION TO CREATE THE INDIVIDUAL NUMBER OF LABELS THAT THE GENERATED WORD IS... //
        private void CreateLabelObject(int i, int space)
        {
            LetterLabels.Add(new Label()); //create a new label and add it to the array..
            LetterLabels[i].Location = new Point((i * space) + 35, gbWordBox.Height / 2); //the y always stay the same
            LetterLabels[i].Text = "_";  // sets the text of the label to an underline
            LetterLabels[i].ForeColor = Color.White; //set the font color
            LetterLabels[i].BackColor = Color.Transparent; //set the background to black
            LetterLabels[i].Parent = gbWordBox; //parent the letter label(child) to the word box
            LetterLabels[i].BringToFront(); //make sure its in front...
            LetterLabels[i].CreateControl(); //create the control for the label
        }

        // IF THE PLAYER PRESSES THE GUESS LETTER BUTTON... //
        private void BtnGuessLetter_Click(object sender, EventArgs e)
        {
            // set the guessed leter which is techincally a string...
            // so we convert it to an array of chars, and since there is
            // only one, we use the 0 index, and then set that to letter.
            char letter = entLetterGuess.Text.ToUpper().ToCharArray()[0];
            // clear the letter AFTER we get a copy of it...
            entLetterGuess.Clear();
            // check if the letter is actually a letter...
            if (!char.IsLetter(letter))
            {
                MessageBox.Show("Please enter letters only!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // weve made it this far so its a letter...
            // now we check if the generated word contains the letter
            if (GeneratedWord.Contains(letter))
            {
                //create an array of the letters in the generated word
                char[] letters = GeneratedWord.ToCharArray();
                //iterate through the length of the array
                for (int i = 0; i < letters.Length; i++)
                {
                    //if the guessed letter equals a letter in the letters array, then we change its text to the guessed letter
                    if (letters[i] == letter)
                        LetterLabels[i].Text = letter.ToString();
                }
                //this is a check to see if there are any blank letters left, if not you win, if so..return and do nothing...
                foreach (Label l in LetterLabels)                
                    if (l.Text == "_") return;
                Win();
            }
            //if the generated word doesnt contain the guessed letter, then its wrong and we continue
            else
            {
                Message("Sorry, That letter isn't in the word!", "Sorry");
                // add the guessed letter to the guessed letters label so the user can track what they have tried...
                lblGuessed.Text += " " + letter.ToString() + ",";
                // and because we missed, we draw a hangman part. we use the number of misses as the index and cast it as Hangman (enum)
                // so basically it returns the part that is at that index in the enumerator.
                DrawHangmanParts((Hangman)missed);
                // then we add to the missed count..
                missed++;
                // and check if we have any misses left...
                CheckMisses();
            }
        }

        // IF THE PLAYER DECIDES TO GUESS A WORD, WE DO IT HERE... //
        private void BtnWordGuess_Click(object sender, EventArgs e)
        {
            //if the guessed word is the generated word, then player won!
            if (entWordGuess.Text == GeneratedWord)
            {
                Win();
            }
            else
            {
                Message("Wrong!", "Sorry");
                DrawHangmanParts((Hangman)missed);
                missed++;
                CheckMisses();
            }
            entWordGuess.Clear();
        }


        // RESET THE GAME, CLEAR CANVAS, NEW WORD, REDRAW POST, RESET MISSED. //
        private void ResetGame()
        {
            Graphics g = pnlHangman.CreateGraphics();
            g.Clear(pnlHangman.BackColor);
            GeneratedWord = Picker.SelectWord();
            DrawPost();
            lblGuessed.Text = "Guessed: ";
            entLetterGuess.Text = "";
            entWordGuess.Text = "";
            missed = 0;
        }

        // Make sending messages a bit easier, and cleaner... //
        private void Message(string message, string title)
        {
            MessageBox.Show(message, title);
        }

        // CHECK IF THE PLAYER HAS EXPENDED THEIR CHANCES... //
        private void CheckMisses()
        {
            if (missed == chances) Loss();
        }

        private void Win()
        {
            Message("Congratulations! You guessed the word!", "Win");
            ResetGame();
        }

        private void Loss()
        {
            Message("You have been hung! The word was: " + GeneratedWord, "Loss");
            ResetGame();
        }
    }
}
