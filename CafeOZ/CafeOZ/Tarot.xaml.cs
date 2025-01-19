using CafeOZ.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CafeOZ
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Tarot : Page
    {
        //Number of clicking
        private int number = 0;
        private List<TarotCard> Tcard;
       
        //Create Pcard list to store picked images
        private List<TarotCard> Pcard = new List<TarotCard>();
        public Tarot()
        {
            this.InitializeComponent();
            ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(App.DeviceMinimumScreenWidth, App.DeviceMinimumScreenHeight));
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

            Tcard = Reading.GetReading();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Lock the device sizing for the application
            //ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
        }

        //Card changing
        private void Spreadbtn_Tapped(object sender, TappedRoutedEventArgs e)
        {   
            //Number for condition
            number += 1;
            
            //Generate random number of card list
            Random random = new Random();
            int randomcount = random.Next(0, Tcard.Count);

            if (number == 1)
            {
                //Store the random card into randomCard listitem
                Pcard.Add(Tcard[randomcount]);
                
                //Initialising first card to random card image 
                Img1.Source = Tcard[randomcount].Image;
            }

            else if(number == 2)
            {
                //Store the random card into randomCard listitem
                Pcard.Add(Tcard[randomcount]);

                //Initialising first card to random card image 
                Img2.Source = Tcard[randomcount].Image;

            }

            else if (number ==3)
            {
                //Store the random card into randomCard listitem
                Pcard.Add(Tcard[randomcount]);

                //Initialising first card to random card image 
                Img3.Source = Tcard[randomcount].Image;

                //Store picked card's name into the array

                //Pause the time before move to description page
                TimePause(Pcard);
            }
            
        }
        
        //Time pausing and move to description page
        private async void TimePause(List<TarotCard> Pcard)
        {
            //Pause 1.5 sec 
            await Task.Delay(1500);

            //Move to the Card description page with pickedImg array
            Frame.Navigate(typeof(TarotDes), Pcard);
        }
    }
}