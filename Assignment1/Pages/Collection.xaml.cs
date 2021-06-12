using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml.Media.Animation;
using Assignment1.Models;
using Assignment1.Services;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;



// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Assignment1.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Collection : Page
    {
        public Collection()
        {
            this.InitializeComponent();
            GetCategory();
        }

        public async void GetCategory()
        {
            List<CatData> catDatas = new List<CatData>();
            CategoryServices service = new CategoryServices();
            
            for (int id = 1; id < 6; id++)
            {
                Category category = await service.getCategory(id);
                if (category != null)
                {
                    catDatas.Add(category.data);
                }
            }
            CatItem.ItemsSource = catDatas;

        }

        private void GridViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            
            this.Frame.Navigate(typeof(Pages.Take_Away));
        }
    }
}
