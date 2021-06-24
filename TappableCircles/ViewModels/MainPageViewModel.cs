using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TappableCircles.ViewModels
{
    public class MainPageViewModel
    {
        public ICommand CircleTappedCommand { get; set; }

        public MainPageViewModel()
        {
            CircleTappedCommand = new Command<string>(async (string circlePos) =>
            {
                if (Xamarin.Forms.Application.Current?.MainPage is Xamarin.Forms.Page mainPage)
                    await MainThread.InvokeOnMainThreadAsync(async () => await mainPage.DisplayAlert("Tap Successful", $"You have succesfully tapped circle {circlePos}", "OK")).ConfigureAwait(false);
            });
        }
    }
}
