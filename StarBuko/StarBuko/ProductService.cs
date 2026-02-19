using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuko
{
    /// <summary>
    /// Service class responsible for managing product data.
    /// This can be easily extended to load from a database in the future.
    /// </summary>
    public class ProductService
    {
        private List<Product> _products;

        public ProductService()
        {
            InitializeProducts();
        }

        /// <summary>
        /// Initializes the product catalog.
        /// TODO: Replace this with database loading in the future.
        /// </summary>
        private void InitializeProducts()
        {
            _products = new List<Product>
            {
                new Product
                {
                    Name = "Creamy Pure Matcha Latte",
                    BasePrice = 180.00m,
                    ProductImage = Properties.Resources.matcha_latte
                },
                new Product
                {
                    Name = "XOXO Frappuccino",
                    BasePrice = 150.00m,
                    ProductImage = Properties.Resources.xoxo_frappucino
                },
                new Product
                {
                    Name = "Strawberry Açaí with Lemonade",
                    BasePrice = 160.00m,
                    ProductImage = Properties.Resources.strawberry_acai
                },
                new Product
                {
                    Name = "Pink Drink with Strawberry Açaí",
                    BasePrice = 165.00m,
                    ProductImage = Properties.Resources.pink_drink
                },
                new Product
                {
                    Name = "Dragon Drink with Mango Dragonfruit",
                    BasePrice = 170.00m,
                    ProductImage = Properties.Resources.dragon_drink
                },
                new Product
                {
                    Name = "Strawberries Cream Frappuccino",
                    BasePrice = 175.00m,
                    ProductImage = Properties.Resources.strawberries_cream
                },
                new Product
                {
                    Name = "Chocolate Chip Cream Frappuccino",
                    BasePrice = 180.00m,
                    ProductImage = Properties.Resources.chocolate_chip
                },
                new Product
                {
                    Name = "Dark Caramel Coffee Frappuccino",
                    BasePrice = 170.00m,
                    ProductImage = Properties.Resources.dark_caramel_frappucino
                }
            };
        }

        /// <summary>
        /// Gets all available products.
        /// </summary>
        public List<Product> GetAllProducts()
        {
            return _products;
        }

        /// <summary>
        /// Gets a product by its name.
        /// </summary>
        public Product GetProductByName(string name)
        {
            return _products.FirstOrDefault(p => p.Name == name);
        }

        /// <summary>
        /// Gets a product by index.
        /// </summary>
        public Product GetProductByIndex(int index)
        {
            if (index >= 0 && index < _products.Count)
                return _products[index];
            return null;
        }

        /// <summary>
        /// Gets the total number of products.
        /// </summary>
        public int GetProductCount()
        {
            return _products.Count;
        }

        // Future methods for database integration:
        // public async Task<List<Product>> LoadProductsFromDatabaseAsync()
        // public async Task<bool> AddProductAsync(Product product)
        // public async Task<bool> UpdateProductAsync(Product product)
        // public async Task<bool> DeleteProductAsync(int productId)
    }
}
