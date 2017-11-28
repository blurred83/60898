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
    public partial class FirstMasterDetailPage : MasterDetailPage
    {
        public FirstMasterDetailPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;

            Detail = new FirstMasterDetailPageDetail();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //var item = e.SelectedItem as FirstMasterDetailPageMenuItem;
            //if (item == null)
            //    return;

            //var page = (Page)Activator.CreateInstance(item.TargetType);
            //page.Title = item.Title;

            //Detail = new NavigationPage(page);
            //IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}