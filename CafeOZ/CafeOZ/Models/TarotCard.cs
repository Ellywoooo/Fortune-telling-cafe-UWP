using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace CafeOZ.Models
{
    public class TarotCard
    {
        public string Name { get; set; }
        public string Meaning { get; set; }
        public BitmapImage Image { get; set; }

    }

    public class Reading
    {
        public static List<TarotCard> GetReading()
        {
            var reading = new List<TarotCard>();

            reading.Add(new TarotCard 
            {
                Name = "The Fool", 
                Meaning = "The Fool tarot card is the number 0 of the Major Arcana, which stands for unlimited potential. " +
                "To see the Fool card generally indicates that you’re on the verge of an unexpected and exciting new adventure in your daily life. This may require you to take a blind leap of faith." +
                " \nThere will be a rewarding experience that will contribute to your growth as a human being.The new adventure could be literal and may involve traveling to a new land or territories you’ve never visited.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/0.png"))
            });
            
            reading.Add(new TarotCard
            {
                Name = "The Magician",
                Meaning = "The Magician tarot card reveals how determination and willpower can realize your wishes and desires. " +
                "When this card appears in your reading, you can be assured that you have the drive to make your dreams happen." +
                "\nRemember: You’re powerful! And the outer world will follow if you create your inner world. " +
                "Yet, you have to focus and concentrate on achieving your dream. Get rid of any discretions and make a detailed plan to stay on track.!",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/1.png"))
            });
            reading.Add(new TarotCard
            {
                Name = "The High Priestess",
                Meaning = "When the High Priestess appears upright in a Tarot reading, she usually indicates a time for learning and listening to your intuition rather than prioritizing your intellect and conscious mind." +
                "\nThe High Priestess tells you to slow down," +
                "reflect on what you’ve learned, and acquire even more knowledge before deciding or taking action." +
                "\nHer wisdom encourages you to relinquish the grip of anxiety over the result.Instead," +
                "\nplace your faith in the discernment of these metaphorical gatekeepers." +
                "\nLastly,the High Priestess figure embodies the serenity of trust and the power of surrender, inviting you to step into the unknown with a courageous and open heart." +
                "Listen to your inner voice!",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/2.png"))
            });
            reading.Add(new TarotCard
            {
                Name = "The Empress",
                Meaning = "In a reading, the upright Empress tarot card calls on you to connect with your feminine side.\n" +
                " This can be translated in many ways – think of creativity, elegance, sensuality, fertility, and nurturing. \n" +
                "She tells you to be kind to yourself and search for beauty and happiness. \n" +
                "he Empress often brings strong bursts of creative or artistic energy.\n" +
                "This creative energy may be in a painting or art project and other forms of expressing yourself creatively, like music or drama.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/3.png"))
            });
            reading.Add(new TarotCard
            {
                Name = "The Emperor",
                Meaning = "As the counterpart of the Empress, the Emperor signifies the husband who is constant and trustworthy.\n" +
                " He is confident, in control of his emotions, and an example of masculine energy. \n" +
                "He is the paternal figure who brings structure and security, creates rules and systems, and conveys knowledge.\n" +
                "As a ruler, he leads with a firm hand and demands respect and authority. \n" +
                "With careful planning, a highly organized approach, and perseverance, the Emperor can overcome any problem.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/4.png"))
            }); 
            reading.Add(new TarotCard
            {
                Name = "The Hierophant",
                Meaning = "When the Hierophant tarot card is upright in a reading, it represents a necessity to follow existing conventions, " +
                "rules, or a well-established procedure.\nIt advises you to maintain conventional boundaries that are considered a standard method." +
                "Rather than being inventive and breaking norms, you will be familiarized with certain traditions, beliefs and systems that have existed for a long time.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/5.png"))
            });
            reading.Add(new TarotCard
            {
                Name = "The Lovers",
                Meaning = "The Lovers tarot card in the upright position can imply that you have major life-changing choices or dilemmas. " +
                "Temptation is often part of that choice or dilemma." +
                "\n>ou may feel unsure about your direction or who to trust.Or you may have to choose between contradicting and equally unifying options." +
                "The Lovers in Tarot advises you not to go for the easy road(temptation).",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/6.png"))
            });
            reading.Add(new TarotCard
            {
                Name = "The Chariot",
                Meaning = "When the upright Chariot tarot card shows up in a tarot reading, it tells you that now is the time to get what you want. Consider this card as a sign of encouragement." +
                "The Chariot is about overcoming obstacles and achieving goals through determination, focus, and willpower." +
                "\nYou will feel motivated, ambitious, and in control. " +
                "This will help you get a stagnant situation moving again and overcome all the challenges in your path.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/7.png"))
            });
            reading.Add(new TarotCard
            {
                Name = "Strength",
                Meaning = "As the name suggests, the upright Strength tarot card represents strength, courage, persuasion, and patience. " +
                "\nIt tells you you have the power and strength to overcome any obstacle – just like the Chariot. " +
                "\nHowever, you’ll need to act gracefully and sensibly rather than just using brutal force when pulling the strength.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/8.png"))
            });
            reading.Add(new TarotCard
            {
                Name = "The Hermit",
                Meaning = "In the upright position, the Hermit’s a compelling card. Just as beacons of light often guide ships to the shore, this sage is ushering in a period of personal growth and exploration." +
                "\nThe Hermit represents wisdom earned by seeking the highest truth." +
                "\nOften, looking for answers requires time alone with few distractions." +
                "\nIt requires introspection and concentrating less on the senses.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/9.png"))
            });
            reading.Add(new TarotCard
            {
                Name = "Wheel Of Fortune",
                Meaning = "Jupiter, the planet of good fortune and expansion, rules the Wheel of Fortune. " +
                "\nIf the Wheel of Fortune tarot card arrives upright, you’re lucky. " +
                "\nWhether you believe in destiny or not, things are lining up for your benefit. " +
                "\nThink of surprising offers and new opportunities.Your vision will also increase as life’s tempo cranks up.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/10.png"))
            });
            reading.Add(new TarotCard
            {
                Name = "Justice",
                Meaning = "In the upright position, the Justice tarot card represents cause, effect, and balanced thought and action. " +
                "\nSometimes we find ourselves the victims of someone else’s malicious intent." +
                "\nIf you have been wronged in any way, Justice arrives to restore balance and order. " +
                "\nThis isn’t to say that things will turn out as you want." +
                "\nHowever, pulling this card in reading supports the adage “All’s well that ends well.”",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/11.png"))
            });
            reading.Add(new TarotCard
            {
                Name = "The Hanged Man",
                Meaning = "The Hanged Man represents ‘the waiting game,’ often a part of life progression. " +
                "\nAlthough we are rarely happy about being stuck in limbo, there are times when nothing else can be done, and we are forced to be still, according to the Hanged Man." +
                "\nThis often requires sacrificing people and things we would rather hold on to.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/12.png"))
            });
            reading.Add(new TarotCard
            {
                Name = "Death",
                Meaning = "One of the reasons that the Death card is such a powerful one in the Upright position is because it carries so many different meanings. " +
                "\nFor many readings, the Death Tarot card signifies completing a chapter, putting the past behind you, and cutting out what is unnecessary." +
                "\nIt can also signify a transition or middle ground between one phase of life and the next." +
                "\nThe key is to welcome the Death card in a tarot spread instead of avoiding it." +
                "\nWhat path is number thirteen trying to point you toward ? After all, there is no new beginning without an ending.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/13.png"))
            });
            reading.Add(new TarotCard
            {
                Name = "Temperance",
                Meaning = "Avoid all extreme situations when pulling the Temperance card in your reading. " +
                "\nAlthough there are times to ‘go for the jugular,’ this isn’t the angel’s message." +
                "\nSome situations are complicated and require patience and special care, even when your emotions tell you to react." +
                "\nTemperance is a skill; like any other skill, practice makes perfect. Hold back from quick judgment." +
                "\nResist the temptation to react immediately.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/14.png"))
            });
            reading.Add(new TarotCard
            {
                Name = "Devil",
                Meaning = "The Devil is the card of illusion. " +
                "\nAlthough you have total control of your life, beliefs, and choices, the Devil card symbolizes how addiction, depression, and unhealthy bonds can make you feel out of control. " +
                "\nEven social media, exercise, and work can be embodied by the Devil when in excess. " +
                "\nRegardless of the nature of your particular problem, the message of the Devil is clear: redirect your attention away from the satisfaction of desires and toward the things that matter.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/15.png"))
            });
            reading.Add(new TarotCard
            {
                Name = "The Tower",
                Meaning = "If we had to redesign the Tower card to a more modern-day representation, a crashing airplane would be an accurate alternative image. " +
                "\nThe Tower signifies destruction." +
                "\nIf you’ve received the Upright Tower tarot card, prepare for things to be leveled and dismantled." +
                "\nAs with all losses, this will probably be a painful process." +
                "\nIt can also lead to a fresh start.Before making these positive changes, you must face the truth about a situation.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/16.png"))
            });
            reading.Add(new TarotCard
            {
                Name = "The star",
                Meaning = "The universe abundantly blesses you (we). We are continually attracting what we desire through our beliefs and thoughts. " +
                "\nWhen the Star arrives in the upright position, it usually follows a difficult change or traumatic event. " +
                "\nGoing through something challenging can take the wind out of our sails and cause us to feel like things will never be the same." +
                "\nThis might be true. Death, loss, heartbreak, and other painful events can change us forever." +
                "\nThis doesn’t mean we can’t build something better.What is it that you’re trying to heal from ? " +
                "\nThe Upright Star wants you to open your heart, realize your inner strength, and have faith that the best is yet to come.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/17.png"))

            });
            reading.Add(new TarotCard
            {
                Name = "The Moon",
                Meaning = "When the Moon tarot card appears in a reading upright, it can mean that you’re allowing your imagination and emotions to take control of your life." +
                "\nThis may be linked to anxieties, fears, or self-deception. " +
                "\nThe Moon falling in a reading is a warning in a sense." +
                "\nYou’re the crawfish rising from the sea.If you trust your intuition and push forward, you will receive deliverance from what binds you." +
                "\nBut first, you must be willing to face the reality of the situation.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/18.png"))

            });
            reading.Add(new TarotCard
            {
                Name = "The Sun",
                Meaning = "The Sun tarot card in the upright position shows positivity and fulfillment in your life. " +
                "\nThings will quickly improve if you have been through a hard time and the Sun falls upright. " +
                "\nThe Sun reminds us to look at the bright side of things and remind ourselves that hard times don’t last forever." +
                "\nEven when faced with difficulties, we can choose to ‘make lemonade out of lemons’ and embrace life lessons for what they’re: learning tools.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/19.png"))

            });
            reading.Add(new TarotCard
            {
                Name = "Judgment",
                Meaning = "Now is the perfect time to weigh your actions and see that they align with your values and beliefs. " +
                "\nDo the things you did in the past or today reflect your core values and belief ? " +
                "\nDo they direct you to your goals and purpose ? " +
                "\nWithout having the clarity of knowing who you truly are, you can’t answer these questions." +
                "\nTake time to ponder on things before going on with your life.In the end, this will be worth it.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/20.png"))

            });
            reading.Add(new TarotCard
            {
                Name = "The World",
                Meaning = "To encounter the upright World card in a tarot reading is to encounter success and accomplishment." +
                "\nIt means that a long-term project, period of study, or any other major event in your life has come full circle and that you accomplished your goals and aspirations. " +
                "\nDespite your difficulties and hardships, you stood strong and persevered.Your seeds will bloom, and you’re reaping the fruit of your labor." +
                "\nEverything has come together, and you’re in the right place, doing the right thing, achieving what you have envisioned. " +
                "\nBe proud of what you’ve learned, your progression, and your achievements." +
                "\nReflecting on what you’ve already accomplished may be what you need to complete your project.",
                Image = new BitmapImage(new Uri("ms-appx:///Tarot/21.png"))

            });

            return reading;
  
        }
    }
}
