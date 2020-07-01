namespace War
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
            this.player2Name = new System.Windows.Forms.Label();
            this.player1Name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.player1Card = new System.Windows.Forms.PictureBox();
            this.player2Card = new System.Windows.Forms.PictureBox();
            this.winner = new System.Windows.Forms.Label();
            this.player1TotalCards = new System.Windows.Forms.Label();
            this.player2TotalCards = new System.Windows.Forms.Label();
            this.player1DrawPile = new System.Windows.Forms.PictureBox();
            this.player2DrawPile = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player1Card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1DrawPile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2DrawPile)).BeginInit();
            this.SuspendLayout();
            // 
            // player2Name
            // 
            this.player2Name.AutoSize = true;
            this.player2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Name.Location = new System.Drawing.Point(574, 13);
            this.player2Name.Name = "player2Name";
            this.player2Name.Size = new System.Drawing.Size(79, 29);
            this.player2Name.TabIndex = 0;
            this.player2Name.Text = "label1";
            // 
            // player1Name
            // 
            this.player1Name.AutoSize = true;
            this.player1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Name.Location = new System.Drawing.Point(133, 13);
            this.player1Name.Name = "player1Name";
            this.player1Name.Size = new System.Drawing.Size(79, 29);
            this.player1Name.TabIndex = 1;
            this.player1Name.Text = "label2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(319, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 53);
            this.button1.TabIndex = 2;
            this.button1.Text = "Fight!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "VS";
            // 
            // player1Card
            // 
            this.player1Card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1Card.Location = new System.Drawing.Point(200, 147);
            this.player1Card.Name = "player1Card";
            this.player1Card.Size = new System.Drawing.Size(100, 136);
            this.player1Card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1Card.TabIndex = 4;
            this.player1Card.TabStop = false;
            // 
            // player2Card
            // 
            this.player2Card.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2Card.Location = new System.Drawing.Point(471, 147);
            this.player2Card.Name = "player2Card";
            this.player2Card.Size = new System.Drawing.Size(100, 136);
            this.player2Card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2Card.TabIndex = 5;
            this.player2Card.TabStop = false;
            // 
            // winner
            // 
            this.winner.AutoSize = true;
            this.winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winner.Location = new System.Drawing.Point(364, 74);
            this.winner.Name = "winner";
            this.winner.Size = new System.Drawing.Size(51, 20);
            this.winner.TabIndex = 6;
            this.winner.Text = "label2";
            this.winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.winner.Visible = false;
            // 
            // player1TotalCards
            // 
            this.player1TotalCards.AutoSize = true;
            this.player1TotalCards.Location = new System.Drawing.Point(135, 74);
            this.player1TotalCards.Name = "player1TotalCards";
            this.player1TotalCards.Size = new System.Drawing.Size(67, 13);
            this.player1TotalCards.TabIndex = 7;
            this.player1TotalCards.Text = "Total Cards: ";
            // 
            // player2TotalCards
            // 
            this.player2TotalCards.AutoSize = true;
            this.player2TotalCards.Location = new System.Drawing.Point(579, 73);
            this.player2TotalCards.Name = "player2TotalCards";
            this.player2TotalCards.Size = new System.Drawing.Size(67, 13);
            this.player2TotalCards.TabIndex = 8;
            this.player2TotalCards.Text = "Total Cards: ";
            // 
            // player1DrawPile
            // 
            this.player1DrawPile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player1DrawPile.Location = new System.Drawing.Point(33, 147);
            this.player1DrawPile.Name = "player1DrawPile";
            this.player1DrawPile.Size = new System.Drawing.Size(100, 136);
            this.player1DrawPile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player1DrawPile.TabIndex = 9;
            this.player1DrawPile.TabStop = false;
            // 
            // player2DrawPile
            // 
            this.player2DrawPile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player2DrawPile.Location = new System.Drawing.Point(643, 147);
            this.player2DrawPile.Name = "player2DrawPile";
            this.player2DrawPile.Size = new System.Drawing.Size(100, 136);
            this.player2DrawPile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2DrawPile.TabIndex = 10;
            this.player2DrawPile.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.player2DrawPile);
            this.Controls.Add(this.player1DrawPile);
            this.Controls.Add(this.player2TotalCards);
            this.Controls.Add(this.player1TotalCards);
            this.Controls.Add(this.winner);
            this.Controls.Add(this.player2Card);
            this.Controls.Add(this.player1Card);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.player1Name);
            this.Controls.Add(this.player2Name);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.player1Card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2Card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player1DrawPile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2DrawPile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label player2Name;
        private System.Windows.Forms.Label player1Name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox player1Card;
        private System.Windows.Forms.PictureBox player2Card;
        private System.Windows.Forms.Label winner;
        private System.Windows.Forms.Label player1TotalCards;
        private System.Windows.Forms.Label player2TotalCards;
        private System.Windows.Forms.PictureBox player1DrawPile;
        private System.Windows.Forms.PictureBox player2DrawPile;
    }
}

