using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Races
{
    class Factory
    {
        public string Name;
        public int GuyNumber;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;
        public Factory(string name, int Guynumber, int Cash, Label MyLabel, RadioButton guyButton)
        {
            Name = name;
            this.Cash = Cash;
            this.GuyNumber = GuyNumber;
            this.MyLabel = MyLabel;
            MyRadioButton = guyButton;
            MyBet = null;

        }
        public void UpdateLabels()
        {
            MyRadioButton.Text = Name + " has " + Cash + " bucks!";
            if (MyBet == null)
            {
                MyLabel.Text = Name;
            }
            else
            {
                MyLabel.Text = Name + " has bet " + MyBet.Amount + " bucks on dog number " + MyBet.Dog;
            }


        }

        public void ClearBet()
        {
            MyBet = null;
        }

        public bool PlaceBet(int Amount, int Dog)
        {
            MyBet = new Bet(Amount, Dog, this);
            UpdateLabels();
            return false;
        }

        public void Collect(int Winner)
        {
            Cash += MyBet.PayOut(Winner);
        }


    }
}
