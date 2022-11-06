using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace OrganizingMenu
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MakeTheMenu();
        }
        private void MakeTheMenu()
        {
            MenuItem[] menuitems = new MenuItem[5];
            string gucamolePrice;
            for (int i = 0; i < 5; i++)
            {
                menuitems[i] = new MenuItem();
                if (i >= 3)
                {
                    menuitems[i].Breads = new string[] { "Plain begel", "Onion begel", "pumpernickel begel", "Everything begel" };
                }
                menuitems[i].Generate();
            }
                item1.Text = menuitems[0].Description;
                price1.Text = menuitems[0].Price;
                item2.Text = menuitems[1].Description;
                price2.Text = menuitems[1].Price;
                item3.Text = menuitems[2].Description;
                price3.Text = menuitems[2].Price;
                item4.Text = menuitems[3].Description;
                price4.Text = menuitems[3].Price;
                item5.Text = menuitems[4].Description;
                price5.Text = menuitems[4].Price;

                MenuItem specialMenuItem = new MenuItem()
                {
                    Proteins = new string[] { "Organic ham", "Mushroom Patty", "Mortadella" },
                    Breads = new string[] { "a gluten free roll", "a wrap", "pita" },
                    Condiments = new string[] { "dijon mustard", "miso dressing", "au jus" }
                };
                specialMenuItem.Generate();
                item6.Text = specialMenuItem.Description;
                price6.Text = specialMenuItem.Price;

                MenuItem gucamoleMenuItem = new MenuItem();
                gucamoleMenuItem.Generate();
                gucamolePrice = gucamoleMenuItem.Price;
                guacamole.Text = "Add Guacamole for " + gucamoleMenuItem.Price;
            
        }
    }
}
