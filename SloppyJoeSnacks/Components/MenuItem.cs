namespace SloppyJoeSnacks.Components
{
    class MenuItem
    {
        // Menu Components
        Random random = new Random();
        public string[] Breads = { "White", "Wheat", "Rye", "Sourdough", "Baguette" };
        public string[] Proteins = { "Beef", "Turkey", "Ham", "Chicken", "Tofu" };
        public string[] Condiments = { "Ketchup", "Mayo", "Yellow mustard", "Rose Sauce", "BBQ Sauce"};
        public string Description = "";
        public string Price;

        /// <summary>
        /// Generates a random sandwich by selecting a bread, protein, and condiment from predefined lists.
        /// </summary>
        /// <remarks>This method selects random elements from the available bread, protein, and condiment
        /// collections. The generated sandwich components can be used for display, testing, or further processing. This
        /// method does not return or store the generated values; callers should access the selected items directly if
        /// needed.</remarks>
        public void Generator()
        {
            string randomBread = Breads[random.Next(Breads.Length)];
            string randomProtein = Proteins[random.Next(Breads.Length)];
            string randomCondiment = Condiments[random.Next(Condiments.Length)];
            Description = $"{randomBread} with {randomProtein} and {randomCondiment}";

            decimal bucks = random.Next(2, 5);
            decimal cents = random.Next(1, 98);
            decimal price = bucks * (cents * 0.1M);
            Price = price.ToString("c");
        }
    }
}
