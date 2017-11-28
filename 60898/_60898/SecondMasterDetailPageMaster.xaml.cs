using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace _60898
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public SecondMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new SecondMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class SecondMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<SecondMasterDetailPageMenuItem> MenuItems { get; set; }

            public SecondMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<SecondMasterDetailPageMenuItem>(new[]
                {
                    new SecondMasterDetailPageMenuItem { Id = 0, Title = "Page 1" },
                    new SecondMasterDetailPageMenuItem { Id = 1, Title = "Page 2" },
                    new SecondMasterDetailPageMenuItem { Id = 2, Title = "Page 3" },
                    new SecondMasterDetailPageMenuItem { Id = 3, Title = "Page 4" },
                    new SecondMasterDetailPageMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}