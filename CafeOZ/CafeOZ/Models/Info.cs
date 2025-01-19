using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOZ.Models
{
    public class Info
    {
        //Coffee info
        public string Step { get; set; }
        public string Image { get; set; }
        public string Reading { get; set; }
    }
    public class CoffeeList
    {
        public static List<Info> GetInfos()
        {
            var coffee = new List<Info>();

            coffee.Add(new Info { Step = "Step.1 Drink the coffee consciously.", Image = "Assets/Coffee3.jpg", 
                                Reading = "Sipping coffee allows you to infuse your intention into it." +
                                "\nFor best results, just leave at least one sip's worth of liquid."
            });

            coffee.Add(new Info { Step = "Step.2 Swirl the Cup Three Times", Image = "Assets/Turkishcoffee.jpg", 
                                Reading = "After you've finished drinking, you must cover the cup with a saucer and rotate it three times counterclockwise."
            });

            coffee.Add(new Info { Step = "Step.3 Flip the Cup and Lift it From the Saucer", Image = "Assets/Turkishcoffee2.png",
                                Reading = "Next, you’ll need to flip your cup while using the saucer to keep the top of the cup covered.\n"+
                                "After the cup has been turned over and set, allow the grounds to cool for 5 to 10 minutes."
            });

            coffee.Add(new Info { Step = "Step.4 Categorize Cup Areas by Life Themes", Image = "Assets/Turkishcoffee.jpg", 
                                Reading = "Before you start looking for symbols, categorize areas in five section divisions. " +
                                " \n\n1. Handle side (left or right, depending on which hand held it) = This will be the love section."+
                                " \n2. Front rim side(opposite of the handle) = This section will deal with your finances and wealth." +
                                " \n3. Bottom of cup = This part of your cup will discuss home and family matters." +
                                " \n4. Upper rim(upper side between the handle and front rim) = You can look into your present energy here." +
                                " \n5. Lower rim(lower side between the handle and “front” rim) = This area will bring you insights about the future." });

            coffee.Add(new Info { Step = "Step.5 Begin Your Interpretation", Image = "Assets/Turkishcoffee3.jpg", 
                                Reading = "Look around you for any symbols and note whether they have a positive or negative vibe." });


            return coffee;
        }
    }
}
