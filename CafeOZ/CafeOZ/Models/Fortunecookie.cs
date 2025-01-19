using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOZ.Models
{
    public class Fortunecookie
    {

        private List<string> randomText = new List<string>
        {
          
            "The worst enemy to creativity is self-doubt.",
            "If we wait until we're ready, we'll be waiting for the rest of our lives.",
            "You are your best thing.",
            "We don't stop going to school when we graduate.",
            "Do it scared.",
            "Look how far you've come.",
            "Every good and perfect gift is from above.",
            "You love peace.",
            "Do not be afraid of competition.",
            "You are kind and friendly.",
            "You are wise beyond your years.",
            "Expect the unexpected.",
            "Stay healthy. Walk a mile.",
            "Borrow money from a pessimist. They don't expect it back.",
            "Bloom where you are planted.",
            "Happy News is on its way."

        };

        public List<string> GetRandomTextList()
        {
            return randomText;
        }
    }
}
