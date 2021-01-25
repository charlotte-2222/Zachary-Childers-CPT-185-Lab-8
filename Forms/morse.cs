//Zachary Childers
//CPT-185-A01S
//Spartanburg Community College
//Wow this one was hard :O
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace Zachary_Childers_CPT_185_Lab_8.Forms
{
    public partial class morse : Form
    {
        public morse()
        {
            InitializeComponent();
        }
        private void btnMorse_Click(object sender, EventArgs e)
        {
            Dictionary<char, string> MorseDict = new Dictionary<char, string>(){
            {'a',".-"},{'b',"-..."},{'c',"-.-."},{'d',"-.."},{'e',"."},{'f',"..-."},
            {'g',"--."},{'h',"...."},{'i',".."},{'j',".---"},{'k',"-.-"},{'l',".-.."},
            {'m',"--"},{'n',"-."},{'o',"---"},{'p',".--."},{'q',"--.-"},{'r',".-."},
            {'s',"..."},{'t',"-"},{'u',"..-"},{'v',"...-"},{'w',".--"},{'x',"-..-"},
            {'y',"-.--"},{'z',"--.."},{' ',"/"},{'1',".----"},{'2',"..---"},{'3',"...--"},
            {'4',"....-"},{'5',"....."},{'6',"-...."},{'7',"--..."},{'8',"---.."},{'9',"----."},
            {'0',"-----"},{'.',".-.-.-"},{',',"--..--"},{'?',"..--.."},{'/',"-..-."},
            {'-',"-....-"},{'(',"-.--."},{')',"-.--.-"},{'!',"-.-.--"},{':',"---..."},
            {';',"-.-.-."},{'=',"-...-"},{'+',".-.-."},{'_',"..--.-"},{'"',".-..-."},
            {'@',".--.-."},{'\'',".----."}
            };
            string phrase = txtMorseInput.Text;
            string translated = "";
            try
            {
                foreach (char i in phrase)
                {
                    if (i >= 65 && i <= 90)
                    {
                        translated += MorseDict[char.ToLower(i)] + " ";
                    }
                    else
                    {
                        translated += MorseDict[i] + "\n";
                    }
                }
                lblSaid.Visible = true;
                txtSaid.Visible = true;
                txtSaid.Text = phrase;
                txtMorseOut.Text = translated;
                txtMorseInput.Text = "";
                txtMorseInput.Focus();

            }
            catch
            {
                txtMorseOut.Text = "Hey! That's not aplhanumeric!!!\n" +
                 "[A-Z]\n" +
                 "[0-9]\n" +
                 "Try again..please!";
                lblSaid.Visible = true;
                txtSaid.Visible = true;
                txtSaid.Text = phrase;
            }

        }
        private void btnCopy_Click(object sender, EventArgs e)
        {

            // Copy the content of translation to the clipboard

            try
            {

                Clipboard.SetText(txtMorseOut.Text);

            }
            catch
            {
                txtMorseOut.Text = "Hey!\n" +
                    "You didn't enter anything to be copied!\n" +
                    "\nI guess you could copy this though!!";

            }

        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtMorseInput.Text = "";
            txtMorseOut.Text = "";
            txtBinOut.Text = "";
            lblSaid.Visible = false;
            txtSaid.Visible = false;
            txtSaid.Text = "";
            txtMorseInput.Focus();
        }

        private void iconExt_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            Dictionary<char, string> MorseDict2 = new Dictionary<char, string>(){
            {'a',".-"},{'b',"-..."},{'c',"-.-."},{'d',"-.."},{'e',"."},{'f',"..-."},
            {'g',"--."},{'h',"...."},{'i',".."},{'j',".---"},{'k',"-.-"},{'l',".-.."},
            {'m',"--"},{'n',"-."},{'o',"---"},{'p',".--."},{'q',"--.-"},{'r',".-."},
            {'s',"..."},{'t',"-"},{'u',"..-"},{'v',"...-"},{'w',".--"},{'x',"-..-"},
            {'y',"-.--"},{'z',"--.."},{' ',"/"},{'1',".----"},{'2',"..---"},{'3',"...--"},
            {'4',"....-"},{'5',"....."},{'6',"-...."},{'7',"--..."},{'8',"---.."},{'9',"----."},
            {'0',"-----"},{'.',".-.-.-"},{',',"--..--"},{'?',"..--.."},{'/',"-..-."},
            {'-',"-....-"},{'(',"-.--."},{')',"-.--.-"},{'!',"-.-.--"},{':',"---..."},
            {';',"-.-.-."},{'=',"-...-"},{'+',".-.-."},{'_',"..--.-"},{'"',".-..-."},
            {'@',".--.-."},{'\'',".----."}
            };
            string playPhrase = txtSaid.Text;
            int counter = 0;
            //On click, will scan dict/key and play back .wav
            //all other processes will be put on hold for this event
            //I have read of/know of ways to fix this, but haven't implement them
            //this just gets the job done.
            foreach (char character in playPhrase)
            {
                counter += 1;
                int percentage = (counter * 100) / playPhrase.Length;
                if (MorseDict2.ContainsKey(character))
                {
                    if (character == 'a')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseA);
                        audio.PlaySync();

                    }
                    if (character == 'b')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseB);
                        audio.PlaySync();
                    }
                    if (character == 'c')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseC);
                        audio.PlaySync();
                    }
                    if (character == 'd')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseD);
                        audio.PlaySync();
                    }
                    if (character == 'e')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseE);
                        audio.PlaySync();
                    }
                    if (character == 'f')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseF);
                        audio.PlaySync();
                    }
                    if (character == 'g')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseG);
                        audio.PlaySync();
                    }
                    if (character == 'h')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseH);
                        audio.PlaySync();
                    }
                    if (character == 'i')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseI);
                        audio.PlaySync();
                    }
                    if (character == 'j')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseJ);
                        audio.PlaySync();
                    }
                    if (character == 'k')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseK);
                        audio.PlaySync();
                    }
                    if (character == 'l')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseL);
                        audio.PlaySync();
                    }
                    if (character == 'm')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseM);
                        audio.PlaySync();
                    }
                    if (character == 'n')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseN);
                        audio.PlaySync();
                    }
                    if (character == 'o')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseO);
                        audio.PlaySync();
                    }
                    if (character == 'p')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseP);
                        audio.PlaySync();
                    }
                    if (character == 'q')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseQ);
                        audio.PlaySync();
                    }
                    if (character == 'r')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseR);
                        audio.PlaySync();
                    }
                    if (character == 's')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseS);
                        audio.PlaySync();
                    }
                    if (character == 't')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseT);
                        audio.PlaySync();
                    }
                    if (character == 'u')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseU);
                        audio.PlaySync();
                    }
                    if (character == 'v')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseV);
                        audio.PlaySync();
                    }
                    if (character == 'w')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseW);
                        audio.PlaySync();
                    }
                    if (character == 'x')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseX);
                        audio.PlaySync();
                    }
                    if (character == 'y')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseY);
                        audio.PlaySync();
                    }
                    if (character == 'z')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morseZ);
                        audio.PlaySync();
                    }
                    if (character == '0')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morse_0);
                        audio.PlaySync();
                    }
                    if (character == '1')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morse_1);
                        audio.PlaySync();
                    }
                    if (character == '2')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morse_2);
                        audio.PlaySync();
                    }
                    if (character == '3')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morse_3);
                        audio.PlaySync();
                    }
                    if (character == '4')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morse_4);
                        audio.PlaySync();
                    }
                    if (character == '5')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morse_5);
                        audio.PlaySync();
                    }
                    if (character == '6')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morse_6);
                        audio.PlaySync();
                    }
                    if (character == '7')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morse_7);
                        audio.PlaySync();
                    }
                    if (character == '8')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morse_8);
                        audio.PlaySync();
                    }
                    if (character == '9')
                    {
                        SoundPlayer audio = new SoundPlayer(Properties.Resources.morse_9);
                        audio.PlaySync();
                    }
                    lblSaid.Visible = true;
                    txtSaid.Visible = true;
                    txtSaid.Text = playPhrase;
                    txtMorseInput.Text = "";
                    txtMorseInput.Focus();
                }
                else
                {
                         txtMorseOut.Text = "Either your string wasn't AlphaNumeric, or there is an error with the associated .wav files. \n" +
                      "\nPlease ensure that all files are loaded properly and try again." +
                       "\n\nthis may have been entered: " + playPhrase;
                         lblSaid.Visible = true;
                         txtSaid.Visible = true;
                }
            }
        }
        // Binary converter
        private void btnToBinary_Click(object sender, EventArgs e)
        {
            Dictionary<char, string> BinaryLmao = new Dictionary<char, string>() {
            { 'a',"01100001"},{ 'b',"01100010"},{ 'c',"01100011"},{ 'd',"01100100"},{ 'e',"01100101"},{ 'f',"01100110"},
            { 'g',"01100111"},{ 'h',"01101000"},{ 'i',"01101001"},{ 'j',"01101010"},{ 'k',"01101011"},{ 'l',"01101100"},
            { 'm',"01101101"},{ 'n',"01101110"},{ 'o',"01101111"},{ 'p',"01110000"},{ 'q',"01110001"},{ 'r',"01110010"},
            { 's',"01110011"},{ 't',"01110100"},{ 'u',"01110101"},{ 'v',"01110110"},{ 'w',"01110111"},{ 'x',"01111000"},
            { 'y',"01111001"},{ 'z',"01111010"},{ ' ',"/"},{ '1',"1"},{ '2',"10"},{ '3',"11"},
            { '4',"100"},{ '5',"101"},{ '6',"110"},{ '7',"111"},{ '8',"1000"},{ '9',"1000"},
            { '0',"0"},{ '.',"00101110"},{ ',',"00101100"},{ '?',"00111111"},{ '/',"00101111"},
            { '-',"00101101"},{ '(',"00101000"},{ ')',"00101001"},{ '!',"00100001"},
            }; //Dict for base10
                //all char go to.Lower(), no need to make two dict
            string binPhrase = txtMorseInput.Text;
            string binTrans = "";
            try
            {
                foreach (char i in binPhrase)
                {
                    if (i >= 65 && i <= 90)
                    {
                        binTrans +=
                            BinaryLmao[char.ToLower(i)] + " ";
                    }
                    else
                    {
                        binTrans += BinaryLmao[i] + " ";
                    }
                }
                txtBinOut.Text = binTrans;
                lblSaid.Visible = true;
                txtSaid.Visible = true;
                txtSaid.Text = binPhrase;
                txtMorseInput.Text = "";
                txtMorseInput.Focus();

            }
            catch //error catching, reporting
            {
                txtMorseOut.Text = "Your string probably wasn't AlphaNumeric...." +
                    "\n\nThis may have been entered: " + binPhrase +
                    "\nAlphaNumeric =\n[A-Z]\n[0-9]";
                lblSaid.Visible = true;
                txtSaid.Visible = true;
                txtSaid.Text = binPhrase;
            }
        }

        private void morse_Load(object sender, EventArgs e)
        {
            txtMorseInput.Focus();
        }
    }
}





            