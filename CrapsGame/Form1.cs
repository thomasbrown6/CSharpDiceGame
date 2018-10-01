#region Using Statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
//using Newtonsoft.Json
using Npgsql;
using System.Data.SqlClient;
using Newtonsoft;
#endregion

namespace CrapsGame

{
    public partial class Form1 : Form
    {
        #region Declaration
        // Defining variables

        Image[] diceImages;

        static bool pointSet = false;
        static bool playerWonOrLoss;
        static bool profile_not_selected = true;

        int[] diceNumber;

        int point;
        int player_id;
        int round;
        int point_set = 0;
        int randomValue;

        string result;

        #endregion

        #region Initialization / OnLoad

        public Form1()
        {
            InitializeComponent();
        }

        // Method that runs when the game loads
        private void Form1_Load(object sender, EventArgs e)
        {
            instructions.Text = "If you roll a 7 or 11: You Win \n If you roll a 2, 3, 12: You Lose";
            currentPoint.Text = "";

            diceImages = new Image[7];
            diceImages[0] = Properties.Resources.dice_0;
            diceImages[1] = Properties.Resources.dice_1;
            diceImages[2] = Properties.Resources.dice_2;
            diceImages[3] = Properties.Resources.dice_3;
            diceImages[4] = Properties.Resources.dice_4;
            diceImages[5] = Properties.Resources.dice_5;
            diceImages[6] = Properties.Resources.dice_6;

            // Initialize the 2 dice
            diceNumber = new int[2] { 0, 0 };

            GetProfiles();
            Reset();
            //GetSetRound();
        }

        #endregion

        #region Random JSON

        public void GenerateRandom()
        {
            // Generates a random number from JSON URL
            using (WebClient webClient = new System.Net.WebClient())
            {
                WebClient n = new WebClient();
                var random = n.DownloadString("https://rolz.org/api/?1d6.json");
                string valueOriginal = Convert.ToString(random);
                Console.WriteLine(random);

                RandomJSON JSON = new RandomJSON();

                Newtonsoft.Json.JsonConvert.PopulateObject(random, JSON);

                Int32.TryParse(JSON.result, out randomValue);

                //randomValue = JSON.result;
            }
        }

        #endregion

        #region Database Connection

        SqlConnection connection_db = new SqlConnection(@"Data Source=.;Initial Catalog=craps_game_db;Integrated Security=True");

        #endregion

        #region Game Functionality, Win / Lose Controllers

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            if (profile_not_selected)
            {
                MessageBox.Show("Must select a profile before you begin.");
            }
            else
            {
                // Generate random number on each roll from REST API
                GenerateRandom();

                // If the player hasn't won, and they're trying to roll the set point
                if (pointSet)
                {
                    RollDice();
                }
                else
                {
                    // Once player wins or lose, next click should reset the game
                    if (playerWonOrLoss)
                    {
                        resetGame();
                    }
                    // If the player neither won or loss, nor set the point yet, then it's a new game
                    // Roll Dice
                    else
                    {
                        RollDice();
                    }
                }
            }
        }

        private void RollDice()
        {
            // Loop through the array of dice and set each index to a random number from API
            for (int i = 0; i < diceNumber.Length; i++)
            {
                diceNumber[i] = randomValue;
            }
            // Set diceSum to the sum of both dice. Just to clean up code a bit
            int diceSum = diceNumber[0] + diceNumber[1];

            // If the the point is set, run this code to check dice
            // If player rolls a 7 they lose, if they roll their point they win
            if (pointSet)
            {
                // Increment round on each roll
                round++;
                // player losses
                if (diceSum == 7)
                {
                    playerLost(7, round, point_set, result);
                    pointSet = false;
                }
                // player wins
                else if (diceSum == point)
                {
                    playerWins(diceSum, round, point_set, result);
                    pointSet = false;
                }
                else
                {
                    switch (diceSum)
                    {
                        case 1:
                            keepPlaying(1, round, point_set, result);
                            break;
                        case 2:
                            keepPlaying(2, round, point_set, result);
                            break;
                        case 3:
                            keepPlaying(3, round, point_set, result);
                            break;
                        case 4:
                            keepPlaying(4, round, point_set, result);
                            break;
                        case 5:
                            keepPlaying(5, round, point_set, result);
                            break;
                        case 6:
                            keepPlaying(6, round, point_set, result);
                            break;
                        case 8:
                            keepPlaying(8, round, point_set, result);
                            break;
                        case 9:
                            keepPlaying(9, round, point_set, result);
                            break;
                        case 10:
                            keepPlaying(10, round, point_set, result);
                            break;
                        case 11:
                            keepPlaying(11, round, point_set, result);
                            break;
                        case 12:
                            keepPlaying(12, round, point_set, result);
                            break;

                    }
                }
                    
            }
            else
            {
                // Increment round on each roll
                round++;
                // If the random number is the case, do the following
                switch (diceSum)
                {
                    // If sum equals 7 or 11, player wins
                    case 7:
                        playerWins(7, round, point_set, result);
                        break;
                    case 11:
                        playerWins(11, round, point_set, result);
                        break;

                    // If sum equals 2, 3, or 12, player losses
                    case 2:
                        playerLost(2, round, point_set, result);
                        break;
                    case 3:
                        playerLost(3, round, point_set, result);
                        break;
                    case 12:
                        playerLost(12, round, point_set, result);
                        break;

                    // If the sum is anything else, set the player's point
                    case 4:
                        setPoint(4, round, point_set, result);
                        break;
                    case 5:
                        setPoint(5, round, point_set, result);
                        break;
                    case 6:
                        setPoint(6, round, point_set, result);
                        break;
                    case 8:
                        setPoint(8, round, point_set, result);
                        break;
                    case 9:
                        setPoint(9, round, point_set, result);
                        break;
                    case 10:
                        setPoint(10, round, point_set, result);
                        break;
                }

            }
                // Setting up the labels to get random image
                // The diceNumber will be a random number when the loop runs
                // If the random number is a 3, then the diceLabel will be set to diceImages[3]
                // Which will give the dice label a dice image with the value of 3
                diceLabel1.Image = diceImages[diceNumber[0]];
                diceLabel2.Image = diceImages[diceNumber[1]];
            
        }

        // ******************FUNCTIONALITY METHODS******************** //

        // If the Player rolls a 7 or 11, they win
        private void playerWins(int roll_result, int round, int point_set, string result)
        {
            displayResults.Text = "Issa Win, you rolled a " + roll_result;
            btnRollDice.Text = "Play Again?";
            System.Diagnostics.Debug.WriteLine("Issa Win, you rolled: " + roll_result);
            playerWonOrLoss = true;
            saveGameResults(roll_result, round, point_set, "Issa Win");
            MessageBox.Show("YOU WON!");
        }

        // If the Player rolls a 2, 3, or 12, they lose
        // Also if a Player rolls a 7 once the point is set, they lose
        private void playerLost(int roll_result, int round, int point_set, string result)
        {
            displayResults.Text = "Crap you lose! You rolled a " + roll_result;
            btnRollDice.Text = "Play Again?";
            System.Diagnostics.Debug.WriteLine("You lost, you rolled: " + roll_result);
            playerWonOrLoss = true;
            saveGameResults(roll_result, round, point_set, "Issa Loss");
            MessageBox.Show("Crap! You loss...");
        }

        // Method to set point
        private void setPoint(int roll_result, int round, int point_set, string result)
        {
            point = roll_result;
            point_set = point;
            displayResults.Text = "You rolled a " + roll_result + ", can you match your point and win the game? Now if you roll a 7 you lose..";
            System.Diagnostics.Debug.WriteLine("Your new point is: " + roll_result);
            currentPoint.Text = "Current Point: " + point;
            pointSet = true;
            saveGameResults(roll_result, round, point_set, "Neither");
        }

        // Method to keep playing, when user doesn't roll the set point
        private void keepPlaying(int roll_result, int round, int point_set, string result)
        {
            displayResults.Text = "You rolled a " + roll_result + ", try again. Roll a 7 and you lose..";
            System.Diagnostics.Debug.WriteLine("Bad roll, you rolled a: " + roll_result);
            pointSet = true;
            saveGameResults(roll_result, round, point_set, "Neither");
        }

        // *************************************************** //

        #endregion

        #region Get Profiles Controller

        public void GetProfiles()
            {   
                // Check to see if connection is closed, to be safe, if closed then open
                if (connection_db.State == ConnectionState.Closed)
                    connection_db.Open();

                SqlDataAdapter sqlData = new SqlDataAdapter("PlayerViewOrSearch", connection_db);
                // Must specify 'SelectCommand' when using get queries
                sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlData.SelectCommand.Parameters.AddWithValue("@name", searchTextBox.Text.Trim());
                DataTable table = new DataTable();

                // Store data in table
                sqlData.Fill(table);

                // Store data from table, in player profile grid
                playerProfileTable.DataSource = table;

                // Hide the player_id / primary key
                playerProfileTable.Columns[0].Visible = false;

                // Close connection
                connection_db.Close();
            }
        #endregion

        #region Get Game Data

        public void GetGameData()
        {
            // Check to see if connection is closed, to be safe, if closed then open
            if (connection_db.State == ConnectionState.Closed)
                connection_db.Open();

            SqlDataAdapter sqlData = new SqlDataAdapter("GetGame", connection_db);
            // Must specify 'SelectCommand' when using get queries
            sqlData.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlData.SelectCommand.Parameters.AddWithValue("@player_id", player_id);
            DataTable table = new DataTable();

            // Store data in table
            sqlData.Fill(table);

            // Store data from table, in player profile grid
            gameDataGrid.DataSource = table;

            // Hide the player_id / primary key and foreign key
            gameDataGrid.Columns[0].Visible = false;
            gameDataGrid.Columns[6].Visible = false;


            // Close connection
            connection_db.Close();
        }

        #endregion

        #region Search Button
        // Search Button OnClick Function
        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                GetProfiles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                connection_db.Close();
            }
        }

        #endregion

        #region Save / Update Button Controller

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("Please Enter Name.");
            }
            else
            {
                try
                {   // Check to see if connection is closed, to be safe
                    if (connection_db.State == ConnectionState.Closed)
                        connection_db.Open();

                    // If statement tells whether or not you're creating a profile or updating
                    if (btn_save.Text == "Save")
                    {
                        SqlCommand sqlCmd = new SqlCommand("PlayerAddOrEdit", connection_db);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Add");
                        sqlCmd.Parameters.AddWithValue("@player_id", 0);
                        sqlCmd.Parameters.AddWithValue("@name", nameTextBox.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Welcome " + nameTextBox.Text.Trim());
                        System.Diagnostics.Debug.WriteLine("Successfully Created " + nameTextBox.Text.Trim());
                    }
                    else
                    {
                        SqlCommand sqlCmd = new SqlCommand("PlayerAddOrEdit", connection_db);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                        sqlCmd.Parameters.AddWithValue("@player_id", player_id);
                        sqlCmd.Parameters.AddWithValue("@name", nameTextBox.Text.Trim());
                        sqlCmd.ExecuteNonQuery();
                        MessageBox.Show("Updated successfully");
                        System.Diagnostics.Debug.WriteLine("Updated " + nameTextBox.Text.Trim());
                    }
                    // Reset form, values
                    Reset();
                    resetGame();
                    GetProfiles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message");
                }
                finally
                {
                    connection_db.Close();
                }
            }
                
        }

        #endregion

        #region Save Game Results

        // Method to save win results in DB
        public void saveGameResults(int roll_result, int round, int point_set, string result)
        {

            try
            {   // Check to see if connection is closed, to be safe
                if (connection_db.State == ConnectionState.Closed)
                    connection_db.Open();

                // If statement tells whether or not you're creating a profile or updating

                SqlCommand sqlCmd = new SqlCommand("AddGame", connection_db);
                sqlCmd.CommandType = CommandType.StoredProcedure;

                if (result == "Issa Win")
                {
                    sqlCmd.Parameters.AddWithValue("@mode", "Win");
                    sqlCmd.Parameters.AddWithValue("@win", 1);
                    sqlCmd.Parameters.AddWithValue("@lose", 0);
                }
                else if (result == "Issa Loss")
                {
                    sqlCmd.Parameters.AddWithValue("@mode", "Lose");
                    sqlCmd.Parameters.AddWithValue("@win", 0);
                    sqlCmd.Parameters.AddWithValue("@lose", 1);
                }
                else if (result == "Neither")
                {
                    sqlCmd.Parameters.AddWithValue("@mode", "Neither");
                    sqlCmd.Parameters.AddWithValue("@win", 0);
                    sqlCmd.Parameters.AddWithValue("@lose", 0);
                }
                sqlCmd.Parameters.AddWithValue("@roll_result", roll_result);
                sqlCmd.Parameters.AddWithValue("@round", round);
                sqlCmd.Parameters.AddWithValue("@player_id", player_id);
                sqlCmd.Parameters.AddWithValue("@point_set", point_set);
                sqlCmd.ExecuteNonQuery();

                GetGameData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                connection_db.Close();
            }
        }

        #endregion
        
        #region Reset Game

        // Method to reset game
        private void resetGame()
        {
            displayResults.Text = "Roll the dice to play";
            btnRollDice.Text = "Roll Dice";
            point = 0;
            playerWonOrLoss = false;
            diceLabel1.Image = diceImages[0];
            diceLabel2.Image = diceImages[0];
            currentPoint.Text = "";
            //round = 0;
        }

        #endregion

        #region Reset Form Method
        public void Reset()
        {
            nameTextBox.Text = "";
            player_id = 0;
            btn_save.Text = "Save";
            btn_delete.Enabled = false;
        }

        #endregion

        #region Delete Profile

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                // Check to see if connection is closed, to be safe
                if (connection_db.State == ConnectionState.Closed)
                    connection_db.Open();

                //************Delete Game Data*************//
                // Delete the Game Data before the player, to not get an error
                // I'm pretty sure there's a better way to do this though
                SqlCommand sqlCmd = new SqlCommand("DeleteGameData", connection_db);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                // Pass the player id through parameter
                sqlCmd.Parameters.AddWithValue("@player_id", player_id);
                sqlCmd.ExecuteNonQuery();

                //**************Delete Player****************//
                SqlCommand sqlCmd2 = new SqlCommand("DeleteProfile", connection_db);
                sqlCmd2.CommandType = CommandType.StoredProcedure;
                // Pass the player id through parameter
                sqlCmd2.Parameters.AddWithValue("@player_id", player_id);
                sqlCmd2.ExecuteNonQuery();


                MessageBox.Show("Deleted successfully");
                Reset();
                resetGame();
                GetProfiles();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                connection_db.Close();
            }
        }

        #endregion

        #region Clear Game History

        private void btn_clearGameHistory_Click(object sender, EventArgs e)
        {
            if (profile_not_selected)
            {
                MessageBox.Show("Must select a profile before you can clear game history.");
            }
            else
            {
                try
                {
                    // Check to see if connection is closed, to be safe
                    if (connection_db.State == ConnectionState.Closed)
                        connection_db.Open();

                    // Delete the Game Data before the player, to not get an error
                    // I'm pretty sure there's a better way to do this though
                    SqlCommand sqlCmd = new SqlCommand("DeleteGameData", connection_db);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    // Pass the player id through parameter
                    sqlCmd.Parameters.AddWithValue("@player_id", player_id);
                    sqlCmd.ExecuteNonQuery();

                    MessageBox.Show("Cleared Game History");
                    round = 0;
                    Reset();
                    GetProfiles();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message");
                }
                finally
                {
                    connection_db.Close();
                }
            }
            resetGame();
            GetGameData();
            profile_not_selected = true;
        }


        #endregion

        #region Method to Get / Set Round

        public void GetSetRound()
        {
            SqlCommand command = new SqlCommand
                (
                    "SELECT TOP 1 round " +

                    "FROM Game " +

                    "WHERE player_id="+ player_id + " " +

                    "ORDER BY[round] DESC", connection_db
                );

            try
            {
                // Check to see if connection is closed, to be safe, if closed then open
                if (connection_db.State == ConnectionState.Closed)
                    connection_db.Open();

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    // Convert string round, from DB to int and set it to global round variable
                    Int32.TryParse(reader["round"].ToString(), out round);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // Close connection
                connection_db.Close();
            }
            
        }

        #endregion

        #region Select Profile

        private void playerProfileTable_Click(object sender, EventArgs e)
        {
            player_id = Convert.ToInt32(playerProfileTable.CurrentRow.Cells[0].Value.ToString());
            System.Diagnostics.Debug.WriteLine("The Player ID Selected: " + player_id);
            resetGame();
            profile_not_selected = false;
            profileName.Text = playerProfileTable.CurrentCell.Value.ToString();
            GetGameData();
            GetSetRound();
        }


        #endregion

        #region Double Click On Profile
        private void playerProfileTable_DoubleClick(object sender, EventArgs e)
        {
            // If there's a value in the row, then update
            if (playerProfileTable.CurrentRow.Index != -1)
            {
                player_id = Convert.ToInt32(playerProfileTable.CurrentRow.Cells[0].Value.ToString());
                nameTextBox.Text = playerProfileTable.CurrentRow.Cells[1].Value.ToString();
                btn_save.Text = "Update";
                btn_delete.Enabled = true;
                System.Diagnostics.Debug.WriteLine("The Player ID Selected: " + player_id);
                profile_not_selected = true;
                GetSetRound();
            }
        }
        #endregion

    }
}
