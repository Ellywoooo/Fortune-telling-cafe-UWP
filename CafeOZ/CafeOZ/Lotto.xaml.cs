using CafeOZ.Models;
using System;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CafeOZ
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Lotto : Page
    {
        private LottoGenerater row = new LottoGenerater();

        public Lotto()
        {
            this.InitializeComponent();
            ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(App.DeviceMinimumScreenWidth, App.DeviceMinimumScreenHeight));
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

        }

        //Ticket button click
        private void Pressbtn_Click(object sender, RoutedEventArgs e)
        {
            //If the user entered the number
            try
            {
                int lucky;

                //Get the number from user and initalize to lucky
                lucky = int.Parse(TextBoxTicket.Text);

                //If user inputs the 1 to 20
                if (0 < lucky && lucky < 21)
                {
                    //Ticket header
                    TextBlockTicket.Text = "--------------------------------------\n";
                    TextBlockTicket.Text = TextBlockTicket.Text + "--                                                --\n";
                    TextBlockTicket.Text = TextBlockTicket.Text + "--             Lotto Ticket              --\n";
                    TextBlockTicket.Text = TextBlockTicket.Text + "--                                                --\n";
                    TextBlockTicket.Text = TextBlockTicket.Text + "--------------------------------------\n";

                    // Loop through that number of Lucky Dips
                    for (int num = 0; num < lucky; num++)
                    {
                        TextBlockTicket.Text = TextBlockTicket.Text + "--                                                --\n";
                        TextBlockTicket.Text = TextBlockTicket.Text + "--         ";

                        row.GenerateNumbers();
                        row.PrintNumbers(TextBlockTicket);

                        TextBlockTicket.Text = TextBlockTicket.Text + "     --\n";
                        TextBlockTicket.Text = TextBlockTicket.Text + "--                                                --\n";
                        TextBlockTicket.Text = TextBlockTicket.Text + "--------------------------------------\n";
                    }

                }

                else
                {
                    MessageDialog failmsg = new MessageDialog("Please enter the number 1 to 20");
                    failmsg.ShowAsync();

                    TextBoxTicket.Text = "";
                }
            }
            //If the user entered a character
            catch
            {
                MessageDialog failmsg = new MessageDialog("Please enter a number (1 to 20)!!");
                failmsg.ShowAsync();

                TextBoxTicket.Text = "";
            }

        }

    }
}
