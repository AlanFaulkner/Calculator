namespace CodeWithXandi
{
    partial class UI
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
            this.Title = new System.Windows.Forms.Label();
            this.ComputerResponse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UserInput = new System.Windows.Forms.TextBox();
            this.InputGuess = new System.Windows.Forms.Button();
            this.StartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(78, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(128, 20);
            this.Title.TabIndex = 0;
            this.Title.Text = "Guess The Number";
            // 
            // ComputerResponse
            // 
            this.ComputerResponse.AutoSize = true;
            this.ComputerResponse.Location = new System.Drawing.Point(111, 58);
            this.ComputerResponse.Name = "ComputerResponse";
            this.ComputerResponse.Size = new System.Drawing.Size(0, 13);
            this.ComputerResponse.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Your Number";
            this.label1.Visible = false;
            // 
            // UserInput
            // 
            this.UserInput.Location = new System.Drawing.Point(142, 117);
            this.UserInput.Name = "UserInput";
            this.UserInput.Size = new System.Drawing.Size(100, 20);
            this.UserInput.TabIndex = 3;
            this.UserInput.Visible = false;
            // 
            // InputGuess
            // 
            this.InputGuess.Location = new System.Drawing.Point(102, 143);
            this.InputGuess.Name = "InputGuess";
            this.InputGuess.Size = new System.Drawing.Size(75, 23);
            this.InputGuess.TabIndex = 4;
            this.InputGuess.Text = "Guess!";
            this.InputGuess.UseVisualStyleBackColor = true;
            this.InputGuess.Visible = false;
            this.InputGuess.Click += new System.EventHandler(this.InputGuess_Click);
            // 
            // StartGame
            // 
            this.StartGame.Location = new System.Drawing.Point(102, 88);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(75, 23);
            this.StartGame.TabIndex = 5;
            this.StartGame.Text = "Start";
            this.StartGame.UseVisualStyleBackColor = true;
            this.StartGame.Click += new System.EventHandler(this.StartGame_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 178);
            this.Controls.Add(this.StartGame);
            this.Controls.Add(this.InputGuess);
            this.Controls.Add(this.UserInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComputerResponse);
            this.Controls.Add(this.Title);
            this.Name = "UI";
            this.Text = "Number Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label ComputerResponse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserInput;
        private System.Windows.Forms.Button InputGuess;

        #endregion

        private System.Windows.Forms.Button StartGame;
    }
}