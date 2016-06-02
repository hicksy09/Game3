namespace Game3
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.progressEnemyHealth = new System.Windows.Forms.ProgressBar();
            this.pictureEnemy = new System.Windows.Forms.PictureBox();
            this.labelEnemyHealth = new System.Windows.Forms.Label();
            this.progressPlayerHealth = new System.Windows.Forms.ProgressBar();
            this.progressPlayerMana = new System.Windows.Forms.ProgressBar();
            this.labelPlayerMana = new System.Windows.Forms.Label();
            this.labelPlayerHealth = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEnemy)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(435, 590);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(195, 61);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(333, 508);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(102, 45);
            this.btnAttack.TabIndex = 1;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Visible = false;
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(626, 508);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(102, 45);
            this.btnRest.TabIndex = 2;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Visible = false;
            // 
            // progressEnemyHealth
            // 
            this.progressEnemyHealth.Location = new System.Drawing.Point(333, 440);
            this.progressEnemyHealth.Name = "progressEnemyHealth";
            this.progressEnemyHealth.Size = new System.Drawing.Size(395, 42);
            this.progressEnemyHealth.TabIndex = 3;
            this.progressEnemyHealth.Visible = false;
            // 
            // pictureEnemy
            // 
            this.pictureEnemy.Location = new System.Drawing.Point(305, 77);
            this.pictureEnemy.Name = "pictureEnemy";
            this.pictureEnemy.Size = new System.Drawing.Size(463, 330);
            this.pictureEnemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureEnemy.TabIndex = 4;
            this.pictureEnemy.TabStop = false;
            this.pictureEnemy.Visible = false;
            // 
            // labelEnemyHealth
            // 
            this.labelEnemyHealth.AutoSize = true;
            this.labelEnemyHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEnemyHealth.Location = new System.Drawing.Point(493, 421);
            this.labelEnemyHealth.Name = "labelEnemyHealth";
            this.labelEnemyHealth.Size = new System.Drawing.Size(104, 16);
            this.labelEnemyHealth.TabIndex = 5;
            this.labelEnemyHealth.Text = "Enemy Health";
            this.labelEnemyHealth.Visible = false;
            // 
            // progressPlayerHealth
            // 
            this.progressPlayerHealth.Location = new System.Drawing.Point(39, 628);
            this.progressPlayerHealth.Name = "progressPlayerHealth";
            this.progressPlayerHealth.Size = new System.Drawing.Size(272, 23);
            this.progressPlayerHealth.TabIndex = 6;
            this.progressPlayerHealth.Visible = false;
            // 
            // progressPlayerMana
            // 
            this.progressPlayerMana.Location = new System.Drawing.Point(788, 628);
            this.progressPlayerMana.Name = "progressPlayerMana";
            this.progressPlayerMana.Size = new System.Drawing.Size(272, 23);
            this.progressPlayerMana.TabIndex = 7;
            this.progressPlayerMana.Visible = false;
            // 
            // labelPlayerMana
            // 
            this.labelPlayerMana.AutoSize = true;
            this.labelPlayerMana.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerMana.Location = new System.Drawing.Point(919, 607);
            this.labelPlayerMana.Name = "labelPlayerMana";
            this.labelPlayerMana.Size = new System.Drawing.Size(49, 18);
            this.labelPlayerMana.TabIndex = 8;
            this.labelPlayerMana.Text = "Mana";
            this.labelPlayerMana.Visible = false;
            // 
            // labelPlayerHealth
            // 
            this.labelPlayerHealth.AutoSize = true;
            this.labelPlayerHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayerHealth.Location = new System.Drawing.Point(147, 607);
            this.labelPlayerHealth.Name = "labelPlayerHealth";
            this.labelPlayerHealth.Size = new System.Drawing.Size(56, 18);
            this.labelPlayerHealth.TabIndex = 9;
            this.labelPlayerHealth.Text = "Health";
            this.labelPlayerHealth.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 686);
            this.Controls.Add(this.labelPlayerHealth);
            this.Controls.Add(this.labelPlayerMana);
            this.Controls.Add(this.progressPlayerMana);
            this.Controls.Add(this.progressPlayerHealth);
            this.Controls.Add(this.labelEnemyHealth);
            this.Controls.Add(this.pictureEnemy);
            this.Controls.Add(this.progressEnemyHealth);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.btnNewGame);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEnemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.ProgressBar progressEnemyHealth;
        private System.Windows.Forms.PictureBox pictureEnemy;
        private System.Windows.Forms.Label labelEnemyHealth;
        private System.Windows.Forms.ProgressBar progressPlayerHealth;
        private System.Windows.Forms.ProgressBar progressPlayerMana;
        private System.Windows.Forms.Label labelPlayerMana;
        private System.Windows.Forms.Label labelPlayerHealth;
    }
}

