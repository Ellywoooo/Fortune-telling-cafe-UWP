using Windows.Foundation;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Controls.Maps;
using Windows.Devices.Geolocation;
using Windows.Storage.Streams;
using System;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CafeOZ
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Location : Page
    {
        MapControl TestMap2 = new MapControl();
        //Pin stream
        RandomAccessStreamReference mapIconStreamReference1;
        public Location()
        {
            this.InitializeComponent();
            ApplicationView.GetForCurrentView().TryResizeView(new Size(App.DeviceScreenWidth, App.DeviceScreenHeight));
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(App.DeviceMinimumScreenWidth, App.DeviceMinimumScreenHeight));
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

            TestMap2.ZoomInteractionMode = MapInteractionMode.GestureAndControl;
            TestMap2.TiltInteractionMode = MapInteractionMode.GestureAndControl;
            TestMap2.MapServiceToken = "h1bEzT5NsdVcnAumbtFn~g49bqDHwWhLRwq9csN1ePA~Au0p5uboCSquVGnwhrlwTljRlURvNCrf0BG-PZe_uVQKy2k0YXxI-EsgVlzkBjgb";
            
            //Push Pin image
            mapIconStreamReference1 = RandomAccessStreamReference.CreateFromUri(new Uri("ms-appx:///Assets/PinIcon.png"));
        }


        private void TestMap1_Loaded(object sender, RoutedEventArgs e)
        {
            MapIcon mapIcon1 = new MapIcon();

            // Set the start up possition to the poly
            TestMap1.Center = new Geopoint(new BasicGeoposition
            {
                Latitude = -38.141057,
                Longitude = 176.244376
            });

            
            mapIcon1.Location = TestMap1.Center;
            mapIcon1.NormalizedAnchorPoint = new Point(0.5, 1.0);
            mapIcon1.Title = "Cafe OZ";

            mapIcon1.Image = mapIconStreamReference1;
            mapIcon1.ZIndex = 0;
            TestMap1.MapElements.Add(mapIcon1);

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
    }
}
