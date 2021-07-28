using ShoppingMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingRepository
{
    public interface IShopping
    {
        //Method to get the list of products based on the Category Name searched
        List<Product> GetProductsByCategoryName(string name);
        //Method to get the list of products based on the Product Name searched
        List<Product> GetProductsByProductName(string name);
        //Method to get the Product Details based on the Product Id
        Product GetProductDetailsById(int id);
        //Method to get All the Categories present in the site
        List<Category> GetAllCategories();
        //Method to Add the Product to Cart
        void AddToCart(Cart lstOp);
        //Method to Display the Product Details present in the Cart
        List<Cart> GetCartDetails();
        //Method to Post the Product from Cart to Place the Order
        void PostToCart(Cart op);
        //Method to Delete the Product when it is placed for the order
        void DeleteOrderFromCartById(int id);
    }
}
