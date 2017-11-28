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
    public partial class FirstMasterDetailPageMaster : ContentPage
    {
        public ListView ListView;

        public FirstMasterDetailPageMaster()
        {
            InitializeComponent();

            BindingContext = new FirstMasterDetailPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class FirstMasterDetailPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<FirstMasterDetailPageMenuItem> MenuItems { get; set; }

            public FirstMasterDetailPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<FirstMasterDetailPageMenuItem>(new[]
                {
                    new FirstMasterDetailPageMenuItem { Id = 0, Title = "Page 1" },
                    new FirstMasterDetailPageMenuItem { Id = 1, Title = "Page 2" },
                    new FirstMasterDetailPageMenuItem { Id = 2, Title = "Page 3" },
                    new FirstMasterDetailPageMenuItem { Id = 3, Title = "Page 4" },
                    new FirstMasterDetailPageMenuItem { Id = 4, Title = "Page 5" },
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