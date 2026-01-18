using System.Windows;
using SloppyJoeSnacks.Components;

namespace SloppyJoeSnacks
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
            MenuItem[] menuItems = new MenuItem[5];
            string guacamolePrice;

            for (int i = 0; i < 5; i++)
            {
                menuItems[i] = new MenuItem();
                if(i >= 3)
                {
                    menuItems[i].Breads = new string[] { "Whole Wheat", "Sourdough", "Rye", "Gluten-Free" };
                }
                menuItems[i].Generator();

            }
                item1.Text = menuItems[0].Description;
                price1.Text = menuItems[0].Price;
                item2.Text = menuItems[1].Description;
                price2.Text = menuItems[1].Price;
                item3.Text = menuItems[2].Description;
                price3.Text = menuItems[2].Price;
                item4.Text = menuItems[3].Description;
                price4.Text = menuItems[3].Price;
                item5.Text = menuItems[4].Description;
                price5.Text = menuItems[4].Price;

                MenuItem specialMenuItem = new MenuItem()
                {
                    Breads = new string[] { "Brioche", "Ciabatta", "Pretzel" },
                    Proteins = new string[] { "Pulled Pork", "Grilled Chicken", "Roast Beef" },
                    Condiments = new string[] { "BBQ Sauce", "Honey Mustard", "Chipotle Mayo", "Papaya Sauce" }
                };

                specialMenuItem.Generator();

                item6.Text = specialMenuItem.Description;
                price6.Text = specialMenuItem.Price;

                MenuItem guacamoleMenuItem = new MenuItem();
                guacamoleMenuItem.Generator();
                guacamolePrice = guacamoleMenuItem.Price;

                guacamole.Text = $"Add Guacamole for {guacamolePrice}";


        }
    }
}