namespace TicTacToe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a2 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.ptsPlayer = new System.Windows.Forms.Label();
            this.ptsDraw = new System.Windows.Forms.Label();
            this.ptsOpponent = new System.Windows.Forms.Label();
            this.PlayerName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.OpponentName = new System.Windows.Forms.Label();
            this.Tie = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbOpponentName = new System.Windows.Forms.TextBox();
            this.tbPlayerName = new System.Windows.Forms.TextBox();
            this.lblOpponentName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gameStart = new System.Windows.Forms.Button();
            this.playAgainstComputer = new System.Windows.Forms.Button();
            this.playAgaistPlayer = new System.Windows.Forms.Button();
            this.playAsO = new System.Windows.Forms.Button();
            this.playAsX = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(109, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem1,
            this.exitToolStripMenuItem1});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.newGameToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem1
            // 
            this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            this.newGameToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.newGameToolStripMenuItem1.Text = "New Game";
            this.newGameToolStripMenuItem1.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.aboutToolStripMenuItem.Text = "Help";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // a2
            // 
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(110, 38);
            this.a2.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(75, 75);
            this.a2.TabIndex = 2;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.btn_click);
            this.a2.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            this.a2.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            // 
            // a1
            // 
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(25, 39);
            this.a1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(75, 75);
            this.a1.TabIndex = 3;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.btn_click);
            this.a1.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            this.a1.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            // 
            // a3
            // 
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(195, 38);
            this.a3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 5);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(75, 75);
            this.a3.TabIndex = 4;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.btn_click);
            this.a3.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            this.a3.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(110, 123);
            this.b2.Margin = new System.Windows.Forms.Padding(5);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 75);
            this.b2.TabIndex = 5;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.btn_click);
            this.b2.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            this.b2.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(195, 123);
            this.b3.Margin = new System.Windows.Forms.Padding(5);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 75);
            this.b3.TabIndex = 6;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.btn_click);
            this.b3.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            this.b3.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(25, 124);
            this.b1.Margin = new System.Windows.Forms.Padding(5);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 75);
            this.b1.TabIndex = 7;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.btn_click);
            this.b1.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            this.b1.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(25, 209);
            this.c1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 3);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(75, 75);
            this.c1.TabIndex = 8;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.btn_click);
            this.c1.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            this.c1.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            // 
            // c2
            // 
            this.c2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(110, 208);
            this.c2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 3);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(75, 75);
            this.c2.TabIndex = 9;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.btn_click);
            this.c2.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            this.c2.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            // 
            // c3
            // 
            this.c3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(195, 208);
            this.c3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 3);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(75, 75);
            this.c3.TabIndex = 10;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.btn_click);
            this.c3.MouseEnter += new System.EventHandler(this.cell_MouseEnter);
            this.c3.MouseLeave += new System.EventHandler(this.cell_MouseLeave);
            // 
            // ptsPlayer
            // 
            this.ptsPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptsPlayer.Location = new System.Drawing.Point(34, 31);
            this.ptsPlayer.Name = "ptsPlayer";
            this.ptsPlayer.Size = new System.Drawing.Size(30, 30);
            this.ptsPlayer.TabIndex = 12;
            this.ptsPlayer.Text = "0";
            this.ptsPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptsDraw
            // 
            this.ptsDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptsDraw.Location = new System.Drawing.Point(120, 31);
            this.ptsDraw.Name = "ptsDraw";
            this.ptsDraw.Size = new System.Drawing.Size(30, 30);
            this.ptsDraw.TabIndex = 14;
            this.ptsDraw.Text = "0";
            this.ptsDraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptsOpponent
            // 
            this.ptsOpponent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ptsOpponent.Location = new System.Drawing.Point(197, 31);
            this.ptsOpponent.Name = "ptsOpponent";
            this.ptsOpponent.Size = new System.Drawing.Size(30, 30);
            this.ptsOpponent.TabIndex = 16;
            this.ptsOpponent.Text = "0";
            this.ptsOpponent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSize = true;
            this.PlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerName.Location = new System.Drawing.Point(17, 0);
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.Size = new System.Drawing.Size(75, 16);
            this.PlayerName.TabIndex = 17;
            this.PlayerName.Text = "Player (X)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OpponentName);
            this.panel1.Controls.Add(this.ptsPlayer);
            this.panel1.Controls.Add(this.ptsDraw);
            this.panel1.Controls.Add(this.ptsOpponent);
            this.panel1.Controls.Add(this.Tie);
            this.panel1.Controls.Add(this.PlayerName);
            this.panel1.Location = new System.Drawing.Point(12, 289);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 79);
            this.panel1.TabIndex = 18;
            // 
            // OpponentName
            // 
            this.OpponentName.AutoSize = true;
            this.OpponentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpponentName.Location = new System.Drawing.Point(169, 0);
            this.OpponentName.Name = "OpponentName";
            this.OpponentName.Size = new System.Drawing.Size(98, 16);
            this.OpponentName.TabIndex = 19;
            this.OpponentName.Text = "Computer (O)";
            // 
            // Tie
            // 
            this.Tie.AutoSize = true;
            this.Tie.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tie.Location = new System.Drawing.Point(119, 0);
            this.Tie.Name = "Tie";
            this.Tie.Size = new System.Drawing.Size(31, 16);
            this.Tie.TabIndex = 20;
            this.Tie.Text = "TIE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbOpponentName);
            this.panel2.Controls.Add(this.tbPlayerName);
            this.panel2.Controls.Add(this.lblOpponentName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.gameStart);
            this.panel2.Controls.Add(this.playAgainstComputer);
            this.panel2.Controls.Add(this.playAgaistPlayer);
            this.panel2.Controls.Add(this.playAsO);
            this.panel2.Controls.Add(this.playAsX);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(-3, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(309, 371);
            this.panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "I want to play as:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbOpponentName
            // 
            this.tbOpponentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOpponentName.Location = new System.Drawing.Point(175, 228);
            this.tbOpponentName.Name = "tbOpponentName";
            this.tbOpponentName.Size = new System.Drawing.Size(111, 26);
            this.tbOpponentName.TabIndex = 10;
            this.tbOpponentName.Text = "Player 2";
            this.tbOpponentName.Visible = false;
            // 
            // tbPlayerName
            // 
            this.tbPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPlayerName.Location = new System.Drawing.Point(175, 185);
            this.tbPlayerName.Name = "tbPlayerName";
            this.tbPlayerName.Size = new System.Drawing.Size(111, 26);
            this.tbPlayerName.TabIndex = 9;
            this.tbPlayerName.Text = "Player 1";
            // 
            // lblOpponentName
            // 
            this.lblOpponentName.AutoSize = true;
            this.lblOpponentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpponentName.Location = new System.Drawing.Point(7, 228);
            this.lblOpponentName.Name = "lblOpponentName";
            this.lblOpponentName.Size = new System.Drawing.Size(142, 20);
            this.lblOpponentName.TabIndex = 8;
            this.lblOpponentName.Text = "Player 2 is called:";
            this.lblOpponentName.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Player 1 is called:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "I want to play against:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gameStart
            // 
            this.gameStart.Font = new System.Drawing.Font("Matura MT Script Capitals", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameStart.Location = new System.Drawing.Point(65, 271);
            this.gameStart.Name = "gameStart";
            this.gameStart.Size = new System.Drawing.Size(158, 61);
            this.gameStart.TabIndex = 4;
            this.gameStart.Text = "Let\'s Play";
            this.gameStart.UseVisualStyleBackColor = true;
            this.gameStart.Click += new System.EventHandler(this.gameStart_Click);
            // 
            // playAgainstComputer
            // 
            this.playAgainstComputer.AutoSize = true;
            this.playAgainstComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainstComputer.Location = new System.Drawing.Point(153, 124);
            this.playAgainstComputer.Name = "playAgainstComputer";
            this.playAgainstComputer.Size = new System.Drawing.Size(108, 35);
            this.playAgainstComputer.TabIndex = 3;
            this.playAgainstComputer.Text = "Computer";
            this.playAgainstComputer.UseVisualStyleBackColor = true;
            this.playAgainstComputer.Click += new System.EventHandler(this.playAgainstComputer_Click);
            // 
            // playAgaistPlayer
            // 
            this.playAgaistPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgaistPlayer.Location = new System.Drawing.Point(23, 124);
            this.playAgaistPlayer.Name = "playAgaistPlayer";
            this.playAgaistPlayer.Size = new System.Drawing.Size(108, 35);
            this.playAgaistPlayer.TabIndex = 2;
            this.playAgaistPlayer.Text = "Human";
            this.playAgaistPlayer.UseVisualStyleBackColor = true;
            this.playAgaistPlayer.Click += new System.EventHandler(this.playAgaistPlayer_Click);
            // 
            // playAsO
            // 
            this.playAsO.AutoSize = true;
            this.playAsO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAsO.Location = new System.Drawing.Point(164, 49);
            this.playAsO.Name = "playAsO";
            this.playAsO.Size = new System.Drawing.Size(75, 35);
            this.playAsO.TabIndex = 1;
            this.playAsO.Text = "O";
            this.playAsO.UseVisualStyleBackColor = true;
            this.playAsO.Click += new System.EventHandler(this.playAsO_Click);
            // 
            // playAsX
            // 
            this.playAsX.AutoSize = true;
            this.playAsX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAsX.Location = new System.Drawing.Point(56, 49);
            this.playAsX.Name = "playAsX";
            this.playAsX.Size = new System.Drawing.Size(75, 35);
            this.playAsX.TabIndex = 0;
            this.playAsX.Text = "X";
            this.playAsX.UseVisualStyleBackColor = true;
            this.playAsX.Click += new System.EventHandler(this.playAsX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 372);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.a2);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label ptsPlayer;
        private System.Windows.Forms.Label ptsDraw;
        private System.Windows.Forms.Label ptsOpponent;
        private System.Windows.Forms.Label PlayerName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OpponentName;
        private System.Windows.Forms.Label Tie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gameStart;
        private System.Windows.Forms.Button playAgainstComputer;
        private System.Windows.Forms.Button playAgaistPlayer;
        private System.Windows.Forms.Button playAsO;
        private System.Windows.Forms.Button playAsX;
        private System.Windows.Forms.TextBox tbOpponentName;
        private System.Windows.Forms.TextBox tbPlayerName;
        private System.Windows.Forms.Label lblOpponentName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}

