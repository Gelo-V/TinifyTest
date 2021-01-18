using System.Diagnostics;
using System.Threading.Tasks;
using TinifyAPI;
using Xamarin.Forms;

namespace TinifyTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Task.Run(async () =>
            {
                try
                {
                    Tinify.Key = "PUT_AN_API_KEY_HERE";
                    bool validKey = await Tinify.Validate();
                    Debug.WriteLine($"[TINIFY]: Was conexion valid?: {validKey}");
                }
                catch (System.Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            });
        }
    }
}
