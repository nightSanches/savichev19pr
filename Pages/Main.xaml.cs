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
            items.Add(new Item("Диван", 10000, "01.jpg"));
            items.Add(new Item("Стол письменный", 9000, "02.jpg"));
            items.Add(new Item("Стол кухонный", 5000, "03.jpg"));
            items.Add(new Item("Диван-кровать", 12000, "04.jpg"));
            items.Add(new Item("Шкаф", 16000, "05.jpg"));
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
