using DemocracyApp.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace DemocracyApp.Pages
{
    public partial class HomePage : ContentPage
    {
        private UserPassword user;

        public HomePage(UserPassword user)
        {
            InitializeComponent();

            this.user = user;

            this.Padding = Device.OnPlatform(
                new Thickness(10, 20, 10, 10),
                new Thickness(10),
                new Thickness(10));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            userNameLabel.Text = user.FullName;
            if (!string.IsNullOrEmpty(user.Photo))
            {
                var url = string.Format(
                    "http://www.zulu-software.com/Democracy{0}",
                    user.Photo.Substring(1));
                photoImage.Source = url;
            }
            photoImage.HeightRequest = 280;
            photoImage.WidthRequest = 280;
        }
    }
}
