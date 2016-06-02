using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Player Player_One = new Player(100, 100, 20);
        Enemy Enemy_One = new Enemy(100, 5);

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome!" +"\n" + "\n" + "You're about to embark upon a journey that " +
                "will see you matched up against some of the most fierce beasts known to man. Good luck!");

            btnNewGame.Visible = false;
            btnAttack.Visible = true;
            btnRest.Visible = true;
            progressEnemyHealth.Visible = true;
            progressPlayerHealth.Visible = true;
            progressPlayerMana.Visible = true;
            labelEnemyHealth.Visible = true;
            labelPlayerHealth.Visible = true;
            labelPlayerMana.Visible = true;
            pictureEnemy.Visible = true;

            pictureEnemy.Image = Game3.Properties.Resources.EnemyOne;
            progressEnemyHealth.Value = Enemy_One.Health;

        }
    }
}
