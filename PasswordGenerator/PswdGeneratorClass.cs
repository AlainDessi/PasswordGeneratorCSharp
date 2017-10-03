using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    class PswdGenerator
    {

        private int nbCaract;

        private string[] listOfCaract = new string[] {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l",
                "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x",
                "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L",
                "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X",
                "Y", "Z",
        };

        // constructor
        public PswdGenerator(int nbCaract)
        {
            this.nbCaract = nbCaract;
        }

        // get the nb of caractère
        public int getNbCaract()
        {
            return this.nbCaract;
        }

        // generate a password
        public string generatePaswd()
        {
            int nbCaractInList = this.listOfCaract.Length;
            int counterOutput = 0;
            string password = "";

            Random rnd = new Random();

            while(counterOutput < this.nbCaract)
            {
                password = password + this.listOfCaract[rnd.Next(0, nbCaractInList)];
                counterOutput++;
            }

            return password;
        }
    }
}
