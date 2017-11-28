using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace _60898
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstMasterDetailPageDetail : ContentPage
    {        
        public FirstMasterDetailPageDetail()
        {
            InitializeComponent();
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            App.Instance.MainPage = new NavigationPage(new SecondMasterDetailPage());
        }
    }
}