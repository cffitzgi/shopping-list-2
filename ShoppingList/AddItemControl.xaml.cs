using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShoppingList
{
    /// <summary>
    /// Interaction logic for AddItemControl.xaml
    /// </summary>
    public partial class AddItemControl : UserControl
    {
        public AddItemControl()
        {
            InitializeComponent();
            AddItemButton.Click += OnAddItemButtonClick;
        }

        protected void OnAddItemButtonClick(object sender, RoutedEventArgs args)
        {
            var item = ItemToAdd.Text;
            /*
            var data = (ShoppingListData) DataContext; // Error if cast is impossible

            var data2 = DataContext as ShoppingListData; // Value of null if cast is impossible
            if(data2 != null)
            {
                // Safe to work with data2
            }//*/

            if(DataContext is ShoppingListData data)
            {
                if(ItemToAdd.Text != "") data.Add(ItemToAdd.Text);
                ItemToAdd.Text = "";
            }
        }
    }
}
