using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMLbot;
using System.Speech;
using System.Speech.Synthesis;
namespace Artificial_Intelligence_Chatbot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            GetBotResponse();
        }

        public void GetBotResponse()
        {
            Bot AI = new Bot();
            AI.loadSettings(); //It will Load Settings from its Config Folder with this code
            AI.loadAIMLFromFiles(); //With this Code It Will Load AIML Files from its AIML Folder
            AI.isAcceptingUserInput = false; //With this Code it will Disable UserInput For Now
            User myuser = new User("Username Here", AI); //With This Code We Will Add The User Through AI/Bot
            AI.isAcceptingUserInput = true; //Now The User Input is Enabled Again with this Code
            Request r = new Request(InputBox.Text, myuser, AI); //With This Code it will Request The Response From AIML Folders
            Result res = AI.Chat(r); //With This Code It Will Get Result
            OutputBox.Text = "Efface C# Bot: " + res.Output; //With this Code It Will Write the Result of Textbox1 Response to Textbox2 text
            //Now Coding Is Finished!
            //Now Add/Copy & Paste AIML Folder & Config Folder to the Project Directory
            //Now Test the Bot (Without Voice)

            //Now Adding Bot Voice
            SpeechSynthesizer reader = new SpeechSynthesizer(); //Add System.Speech Reference First In Order To Creating It.
            reader.Speak(res.Output); //Set Reader To Response Output of AIML To Speak

        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                GetBotResponse();
                e.Handled = e.SuppressKeyPress = true; //This Code for Disabling Beep Sound On Enter Key
            }
        }

      
    }
}
