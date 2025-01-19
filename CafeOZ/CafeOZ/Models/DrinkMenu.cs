using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeOZ.Models
{
    public class DrinkMenu
    {
        public string MenuList { get; set; }
        public string Cost { get; set; }
        public string Image { get; set; }
    }
    public class MenuBorad
    {
        public static List<DrinkMenu> GetMenus()
        {
            var menu = new List<DrinkMenu>();

            menu.Add(new DrinkMenu { MenuList = "ESPRESSO", Cost = "$4.00", Image = "Assets/Espresso.jpg" });
            menu.Add(new DrinkMenu { MenuList = "AMERICANO", Cost = "$4.50", Image = "Assets/AMERICANO.jpg" });
            menu.Add(new DrinkMenu { MenuList = "LATTE", Cost = "$4.50", Image = "Assets/LATTE.jpg" });
            menu.Add(new DrinkMenu { MenuList = "CAPPUCCINO", Cost = "$4.50", Image = "Assets/CAPPUCCINO.jpg" });
            menu.Add(new DrinkMenu { MenuList = "MOCHACCINO", Cost = "$4.80", Image = "Assets/MOCHACCINO.jpg" });
            menu.Add(new DrinkMenu { MenuList = "CARAMEL LATTE", Cost = "$4.80", Image = "Assets/CARAMEL LATTE.jpg" });
            menu.Add(new DrinkMenu { MenuList = "LONG BLACK", Cost = "$4.00", Image = "Assets/LONG BLACK.jpg" });
            menu.Add(new DrinkMenu { MenuList = "CHAI LATTE", Cost = "$4.80", Image = "Assets/CHAI LATTE.jpg" });
            menu.Add(new DrinkMenu { MenuList = "TURKISH COFFEE", Cost = "$5.00", Image = "Assets/TURKISH COFFEE.jpg" });
            menu.Add(new DrinkMenu { MenuList = "HOT CHOCOLATE", Cost = "$4.00", Image = "Assets/HOT CHOCOLATE.jpg" });
            menu.Add(new DrinkMenu { MenuList = "FLAT WHITE", Cost = "$4.00", Image = "Assets/FLAT WHITE.jpg" });
            menu.Add(new DrinkMenu { MenuList = "FLUFFY", Cost = "FREE", Image = "Assets/FLUFFY.jpg" });
            menu.Add(new DrinkMenu { MenuList = "ENGLISH BREAKFAST", Cost = "$4.30", Image = "Assets/ENGLISH BREAKFAST.jpg" });
            menu.Add(new DrinkMenu { MenuList = "EARL GREY", Cost = "$4.30", Image = "Assets/EARL GREY.jpg" });
            menu.Add(new DrinkMenu { MenuList = "PEPPERMINT", Cost = "$4.30", Image = "Assets/PEPPERMINT.jpg" });

            return menu;
        }

    }
}
