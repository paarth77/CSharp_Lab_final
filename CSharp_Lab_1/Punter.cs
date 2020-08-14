using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Races
{
    class Punter
    {
        public int Amount;
        public int Dog;
        public int Cash;
        public Bet myBet;
        public Label MyLabel;
        public Radiobuttom MyRadioButtom;
        public string Name;
        public string WinningDog;
        public Guy Bettor;

        public Punter(int Amount, int Dog, int Cash, Bet myBet, Label MyLabel, Radiobuttom MyRadioButtom, string Name, string WinningDog, Guy which)
        {
            this.Amount = Amount;
            this.Dog = Dog;
            this.Cash = Cash;
            this.myBet = myBet;
            this.MyLabel = MyLabel;
            this.MyRadioButtom = MyRadioButtom;
            this.Name = Name;
            this.WinningDog = WinningDog;
            Bettor = which;
        }

        public string GetDescription()
        {
            return "";
        }

        public int PayOut(int Winner)
        {
            if (Dog == Winner)
            {
                return 2 * Amount;
            }
            else
            {
                return -Amount;
            }
        }



    }
}
