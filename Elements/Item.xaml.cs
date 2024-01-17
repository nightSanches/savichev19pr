using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace savichev19pr.Elements
{
    public partial class Item : UserControl
    {
        public Item(Classes.Item item)
        {
            InitializeComponent();

            if (item != null)
            {
                if (File.Exists(Directory.GetCurrentDirectory() + "/Images/" + item.src))
                {
                    image.Source = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + "/Images/" + item.src));
                }
                price.Content = item.price;
                name.Content = item.name;
            }
        }
    }
}
