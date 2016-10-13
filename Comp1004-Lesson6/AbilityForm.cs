using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp1004_Lesson6
{
    public partial class AbilityForm : Form
    {
        // class variables
        private Random _random;

        // initialize variables in the constructor
        public AbilityForm()
        {
            InitializeComponent();
            _initialize();
        }

        /// <summary>
        /// this method is used to initialize class member variables
        /// </summary>
        private void _initialize()
        {
            this._random = new Random(); // instantiate object of type Random
        }

        private void RollAbilitiesButton_Click(object sender, EventArgs e)
        {
            // call roll abilities method
            RollAbilities();
        }

        /// <summary>
        /// this method generates 6 abilities for the character sheet
        /// </summary>
        private void RollAbilities()
        {
            // roll 4d6 and assign the value to each ability
            Program.character.Strength = Roll4d6();
            StrengthTextBox.Text = Program.character.Strength.ToString();

            Program.character.Dexterity = Roll4d6();
            DexterityTextBox.Text = Program.character.Dexterity.ToString();

            Program.character.Constitution = Roll4d6();
            ConstitutionTextBox.Text = Program.character.Constitution.ToString();

            Program.character.Intelligence = Roll4d6();
            IntelligenceTextBox.Text = Program.character.Intelligence.ToString();

            Program.character.Wisdom = Roll4d6();
            WisdomTextBox.Text = Program.character.Wisdom.ToString();

            Program.character.Charisma = Roll4d6();
            CharismaTextBox.Text = Program.character.Charisma.ToString();
        }

        /// <summary>
        /// This method rolls 4d6 and returns the highest 3 dice
        /// </summary>
        private int Roll4d6()
        {
            List<int> dice = new List<int>(); // instantiates an empty integer list

            // roll 4d6
            for (int count = 0; count < 4; count++)
            {
                dice.Add(this._random.Next(6) + 1);
            }

            dice.Sort();

            dice.RemoveAt(0);

            return dice.Sum();
        }

        private void AbilityForm_Load(object sender, EventArgs e)
        {
            RollAbilities();
        }
    }
}
