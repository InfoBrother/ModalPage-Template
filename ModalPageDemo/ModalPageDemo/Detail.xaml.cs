using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ModalPageDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Detail : ContentPage
	{
		public Detail ()
		{
			InitializeComponent ();
		}

        async void OnDismissButtonClicked(object sender, EventArgs args)
        {
            await Navigation.PopModalAsync();
        }
    }
}