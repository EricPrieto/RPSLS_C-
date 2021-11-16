using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLs
{
    public class Player
    {
        //member variable
        public string name;
        public List<string> gestures;
        int win =0;
        int lose = 0;
        int tie =0;

        //member methods
        public Player()
        {
            gestures = new List<string>();
            CreateGesture();
        }

         public void CreateGesture()
        {
            gestures.Add("rock");
            gestures.Add("paper");
            gestures.Add("scissors");
            gestures.Add("lizard");
            gestures.Add("spock");
        }
    }
}
