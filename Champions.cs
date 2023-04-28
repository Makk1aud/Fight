using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Файтинг
{
    
    public partial class Champions : Form
    {
        static public int lenghtImages;
        public int indexPlayer;
        public int indexAI;
        public string namePlayer;

        public static string connectString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source =LeaderBoard.mdb;";
        private OleDbConnection myConnection;
        //создание объектов класса для распределения их способностей
        public Player realPlayer = new Player();
        public Player AI = new Player();

        public int[,] feature = new int[5, 3];
        
        AboutCharacters AboutCharacters = new AboutCharacters();
        public Champions()
        {
            InitializeComponent();
            myConnection = new OleDbConnection(connectString);
            myConnection.Open();
            
        }

        public int[,] FeatureCharacters()
        {
            int[,] features = new int[6,4];
            string query = "Select headDamage, bodyDamage, feetDamage, criticalDamage From Characters";
            OleDbCommand command = new OleDbCommand(query, myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            int counter = 0;
            while(reader.Read())
            {
                features[counter, 0] = Convert.ToInt32(reader[0]);
                features[counter, 1] = Convert.ToInt32(reader[1]);
                features[counter, 2] = Convert.ToInt32(reader[2]);
                features[counter, 3] = Convert.ToInt32(reader[3]);
                counter++;
            }
            return features;
        }

        private void Champions_Load(object sender, EventArgs e)
        {          
            lenghtImages = imageCharacters.Images.Count - 1;
            aboutPlayerCharacter.BackColor = BackColor;
            PlayerCharacterName.Text = AboutCharacters.Names[indexPlayer];
            AICharacterName.Text = AboutCharacters.Names[indexAI];
            feature = FeatureCharacters();
            FillFeature(indexPlayer, playerHeadDamage, playerBodyDamage, playerFeetDamage, playerCritDamage);
            FillFeature(indexAI, AiHeadDamage, AiBodyDamage, AiFeetDamage, AiCritDamage);
        }

        public int IndexUp(int index)
        {          
            return index < lenghtImages ? ++index : 0;
        }

        public void FillFeature(int index, TextBox head, TextBox body, TextBox feet, TextBox critical)
        {
            head.Text = feature[index, 0].ToString();
            body.Text = feature[index, 1].ToString();
            feet.Text = feature[index, 2].ToString();
            critical.Text = feature[index, 3].ToString();
        }

        public int IndexDown(int index)
        {
            return index > 0 ? --index : lenghtImages;
        }

        private void Right_Click(object sender, EventArgs e)
        {
            if(PlayerRadio.Checked)
            {
                indexPlayer = IndexUp(indexPlayer);
                ChangePlayerChampion(indexPlayer);               
            }
            else
            {
                indexAI = IndexUp(indexAI);
                ChangeAIChampion(indexAI);
            }
        }
        private void ChangeFocus(object sender, EventArgs e)
        {
            Right.Focus();
        }

        public void ChangePlayerChampion(int indexPlayer)
        {
            playerChampion.Image = imageCharacters.Images[indexPlayer];
            aboutPlayerCharacter.Text = AboutCharacters.aboutCharacters[indexPlayer];
            PlayerCharacterName.Text = AboutCharacters.Names[indexPlayer];
            FillFeature(indexPlayer, playerHeadDamage, playerBodyDamage, playerFeetDamage, playerCritDamage);
        }

        public void ChangeAIChampion(int indexAI)
        {
            AIChampion.Image = imageCharacters.Images[indexAI];
            aboutAICharacter.Text = AboutCharacters.aboutCharacters[indexAI];
            AICharacterName.Text = AboutCharacters.Names[indexAI];
            FillFeature(indexAI, AiHeadDamage, AiBodyDamage, AiFeetDamage, AiCritDamage);
        }

        private void Left_Click(object sender, EventArgs e)
        {
            if (PlayerRadio.Checked)
            {
                indexPlayer = IndexDown(indexPlayer);
                ChangePlayerChampion(indexPlayer);
            }
            else
            {
                indexAI = IndexDown(indexAI);
                ChangeAIChampion(indexAI);
            }
        }

        private void Champions_FormClosing(object sender, FormClosingEventArgs e)
        {
            myConnection.Close();
            Application.Exit();
        }
        
        public Player FillingChampion(Player player, int index)
        {
            string query = $"Select * FROM Characters where Index = {index + 1}";
            OleDbCommand command = new OleDbCommand(query,myConnection);
            OleDbDataReader reader = command.ExecuteReader();
            reader.Read();
            
            player.headDamage = int.Parse(reader[1].ToString());
            player.bodyDamage = int.Parse(reader[2].ToString());
            player.feetDamage = int.Parse(reader[3].ToString());
            player.criticalDamage = int.Parse(reader[7].ToString());
            return player;
        }
        
        private void startButton_Click(object sender, EventArgs e)
        {
            Fight fight = new Fight(indexPlayer, indexAI, namePlayer, FillingChampion(realPlayer, indexPlayer), FillingChampion(AI, indexAI));
            fight.Show();
            Hide();
        }
    }
}
