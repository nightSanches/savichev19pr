using savichev19pr.Classes;
using System.Collections.Generic;
using System.Windows.Controls;

namespace savichev19pr.Pages
{
    public partial class Main : Page
    {
        public List<Item> items = new List<Item>();
        public Main()
        {
            InitializeComponent();
            items.Add(new Item("Шкаф", 20000, "01.jpg"));
            LoadItems();
        }

        public void LoadItems()
        {
            parent.Children.Clear();

            foreach (Item item in items)
            {
                parent.Children.Add(new Elements.Item(item));
            }
        }
    }
}
