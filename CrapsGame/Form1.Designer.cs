namespace CrapsGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.displayResults = new System.Windows.Forms.Label();
            this.diceLabel2 = new System.Windows.Forms.Label();
            this.diceLabel1 = new System.Windows.Forms.Label();
            this.currentPoint = new System.Windows.Forms.Label();
            this.instructions = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.name_label = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.playerProfileTable = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.search_label = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.update_delete_label = new System.Windows.Forms.Label();
            this.btn_clearGameHistory = new System.Windows.Forms.Button();
            this.gameDataGrid = new System.Windows.Forms.DataGridView();
            this.profileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.playerProfileTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRollDice
            // 
            this.btnRollDice.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRollDice.Font = new System.Drawing.Font("Showcard Gothic", 14.25F);
            this.btnRollDice.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnRollDice.Location = new System.Drawing.Point(152, 261);
            this.btnRollDice.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(259, 75);
            this.btnRollDice.TabIndex = 3;
            this.btnRollDice.Text = "Roll Dice";
            this.btnRollDice.UseVisualStyleBackColor = false;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // displayResults
            // 
            this.displayResults.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayResults.Location = new System.Drawing.Point(14, 399);
            this.displayResults.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.displayResults.Name = "displayResults";
            this.displayResults.Size = new System.Drawing.Size(538, 142);
            this.displayResults.TabIndex = 4;
            this.displayResults.Text = "Roll the dice to play";
            this.displayResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // diceLabel2
            // 
            this.diceLabel2.Image = global::CrapsGame.Properties.Resources.dice_0;
            this.diceLabel2.Location = new System.Drawing.Point(285, 166);
            this.diceLabel2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.diceLabel2.Name = "diceLabel2";
            this.diceLabel2.Size = new System.Drawing.Size(108, 112);
            this.diceLabel2.TabIndex = 2;
            // 
            // diceLabel1
            // 
            this.diceLabel1.Image = global::CrapsGame.Properties.Resources.dice_0;
            this.diceLabel1.Location = new System.Drawing.Point(185, 166);
            this.diceLabel1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.diceLabel1.Name = "diceLabel1";
            this.diceLabel1.Size = new System.Drawing.Size(108, 112);
            this.diceLabel1.TabIndex = 0;
            // 
            // currentPoint
            // 
            this.currentPoint.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.currentPoint.Location = new System.Drawing.Point(83, 342);
            this.currentPoint.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.currentPoint.Name = "currentPoint";
            this.currentPoint.Size = new System.Drawing.Size(374, 68);
            this.currentPoint.TabIndex = 5;
            this.currentPoint.Text = "Current Point:";
            this.currentPoint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // instructions
            // 
            this.instructions.Font = new System.Drawing.Font("Palatino Linotype", 16.2F, System.Drawing.FontStyle.Bold);
            this.instructions.Location = new System.Drawing.Point(49, 9);
            this.instructions.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(476, 172);
            this.instructions.TabIndex = 6;
            this.instructions.Text = "Instructions";
            this.instructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.Font = new System.Drawing.Font("Showcard Gothic", 10.2F);
            this.btn_save.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_save.Location = new System.Drawing.Point(1105, 262);
            this.btn_save.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(109, 34);
            this.btn_save.TabIndex = 11;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold);
            this.name_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.name_label.Location = new System.Drawing.Point(686, 265);
            this.name_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(67, 27);
            this.name_label.TabIndex = 12;
            this.name_label.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBox.Location = new System.Drawing.Point(763, 262);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(307, 34);
            this.nameTextBox.TabIndex = 13;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.Crimson;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.btn_delete.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_delete.Location = new System.Drawing.Point(952, 343);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(118, 47);
            this.btn_delete.TabIndex = 18;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // playerProfileTable
            // 
            this.playerProfileTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.playerProfileTable.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.playerProfileTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playerProfileTable.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerProfileTable.Location = new System.Drawing.Point(597, 469);
            this.playerProfileTable.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.playerProfileTable.Name = "playerProfileTable";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.playerProfileTable.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.playerProfileTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.playerProfileTable.RowTemplate.Height = 24;
            this.playerProfileTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.playerProfileTable.Size = new System.Drawing.Size(208, 219);
            this.playerProfileTable.TabIndex = 20;
            this.playerProfileTable.Click += new System.EventHandler(this.playerProfileTable_Click);
            this.playerProfileTable.DoubleClick += new System.EventHandler(this.playerProfileTable_DoubleClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(763, 207);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(307, 34);
            this.searchTextBox.TabIndex = 22;
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.search_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.search_label.Location = new System.Drawing.Point(768, 58);
            this.search_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(302, 37);
            this.search_label.TabIndex = 21;
            this.search_label.Text = "Select Profile To Begin";
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.Gold;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_search.Location = new System.Drawing.Point(1105, 206);
            this.btn_search.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(108, 34);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // update_delete_label
            // 
            this.update_delete_label.AutoSize = true;
            this.update_delete_label.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.update_delete_label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.update_delete_label.Location = new System.Drawing.Point(684, 115);
            this.update_delete_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.update_delete_label.Name = "update_delete_label";
            this.update_delete_label.Size = new System.Drawing.Size(504, 37);
            this.update_delete_label.TabIndex = 24;
            this.update_delete_label.Text = "Double Click Profile To Update/Delete";
            // 
            // btn_clearGameHistory
            // 
            this.btn_clearGameHistory.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_clearGameHistory.Font = new System.Drawing.Font("Showcard Gothic", 14F);
            this.btn_clearGameHistory.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btn_clearGameHistory.Location = new System.Drawing.Point(763, 343);
            this.btn_clearGameHistory.Name = "btn_clearGameHistory";
            this.btn_clearGameHistory.Size = new System.Drawing.Size(131, 47);
            this.btn_clearGameHistory.TabIndex = 25;
            this.btn_clearGameHistory.Text = "Clear";
            this.btn_clearGameHistory.UseVisualStyleBackColor = false;
            this.btn_clearGameHistory.Click += new System.EventHandler(this.btn_clearGameHistory_Click);
            // 
            // gameDataGrid
            // 
            this.gameDataGrid.AllowUserToAddRows = false;
            this.gameDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gameDataGrid.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.gameDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameDataGrid.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameDataGrid.Location = new System.Drawing.Point(803, 469);
            this.gameDataGrid.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.gameDataGrid.Name = "gameDataGrid";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gameDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gameDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Palatino Linotype", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.gameDataGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gameDataGrid.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.gameDataGrid.RowTemplate.Height = 24;
            this.gameDataGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.gameDataGrid.Size = new System.Drawing.Size(465, 219);
            this.gameDataGrid.TabIndex = 26;
            // 
            // profileName
            // 
            this.profileName.AutoSize = true;
            this.profileName.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.profileName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.profileName.Location = new System.Drawing.Point(768, 415);
            this.profileName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.profileName.Name = "profileName";
            this.profileName.Size = new System.Drawing.Size(204, 37);
            this.profileName.TabIndex = 27;
            this.profileName.Text = "Select a profile";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.profileName);
            this.Controls.Add(this.gameDataGrid);
            this.Controls.Add(this.btn_clearGameHistory);
            this.Controls.Add(this.update_delete_label);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.playerProfileTable);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.currentPoint);
            this.Controls.Add(this.displayResults);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.diceLabel2);
            this.Controls.Add(this.diceLabel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 16F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1300, 750);
            this.Name = "Form1";
            this.Text = "Craps Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playerProfileTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label diceLabel1;
        private System.Windows.Forms.Label diceLabel2;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label displayResults;
        private System.Windows.Forms.Label currentPoint;
        private System.Windows.Forms.Label instructions;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.DataGridView playerProfileTable;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label update_delete_label;
        private System.Windows.Forms.Button btn_clearGameHistory;
        private System.Windows.Forms.DataGridView gameDataGrid;
        private System.Windows.Forms.Label profileName;
    }
}

