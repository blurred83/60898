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
    public partial class SecondMasterDetailPage : MasterDetailPage
    {
        public SecondMasterDetailPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;

            Detail = new SecondMasterDetailPageDetail();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            MasterPage.ListView.SelectedItem = null;
        }
    }
}