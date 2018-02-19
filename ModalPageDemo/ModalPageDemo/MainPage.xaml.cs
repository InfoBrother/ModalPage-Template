using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ModalPageDemo
{
	public partial class MainPage : ContentPage
	{
        List<gallery> dogs;

        public MainPage()
        {
            InitializeComponent();

            SetupData();
            listView.ItemsSource = dogs;
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                var detailPage = new Detail();
                detailPage.BindingContext = e.SelectedItem as gallery;
                listView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }

        void SetupData()
        {
            dogs = new List<gallery>();
            dogs.Add(new gallery
            {
                 Name = "German Shepherd",
                iconsource = "pic1.png"
            });

            dogs.Add(new gallery
            {
                Name = "Rottweiler",
                iconsource = "pic2.png"
            });

            dogs.Add(new gallery
            {
                Name = "Bulldog",
                iconsource = "pic3.png"
            });

            dogs.Add(new gallery
            {
                Name = "Siberian husky",
                iconsource = "pic4.png"
            });

            dogs.Add(new gallery
            {
                Name = "Shetland sheepdog",
                iconsource = "pic5.png"
            });

        }
    }
}
