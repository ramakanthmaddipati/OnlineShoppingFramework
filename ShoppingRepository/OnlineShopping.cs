using ShoppingEntity;
using ShoppingMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingRepository
{
    class OnlineShopping : IShopping
    {

        private readonly HCLDBEntities _context;
        public Shopping()
        {
            _context = new HCLDBEntities();
        }
        public Shopping(HCLDBEntities context)
        {
            _context = context;
        }
        public IEnumerable<ProductCategory> GetAll()
        {
            return _context.ProductCategories.ToList();
        }
        public void AddProduct(Product p)
        {
            throw new NotImplementedException();
        }



        public void AddToCart(List<CartItem> cartlst)
        {
            throw new NotImplementedException();
        }



        public void DeleteProductById(int Id)
        {
            throw new NotImplementedException();
        }



        public List<Category> GetAllCategories()
        {
            return _context.Categories.ToList();
        }



        public List<Product> GetCategoryByName(String categoryName)
        {
            //select Id,CategoryId,Price,Quantity,Description,Picture from Product where 
            //CategoryId=(select CategoryId from ProductCategory where categoryname like @cn)



            return _context.Products.ToList().Find(categoryName);



            //List<Product> lstp = db.Products.Where(x => x.CategoryId.Equals(db.ProductCategories.Where(y => y.Categoryname.Contains(categoryName)))).ToList();



            //var p = _context.Products.Where(c => c.ProductCategory.Categoryname == categoryName).Join(_context.ProductCategories,
            //                                      Product => Product.CategoryId,
            //                                      C => C.CategoryId,
            //                                      (Product, C) => new
            //                                      {
            //                                          product = Product.Id,
            //                                          picture = Product.Picture,
            //                                          price = Product.Price



            //                                          //brand = Product.Brand,
            //                                          ////content = Product.Content,
            //                                          ////productId = Product.ProductId,
            //                                          ////categoryId = C.CategoryId
            //                                      });
            //return (List<Product>)p ;
            //return lstp;



        }



        public List<Product> GetProductByProductId(int Id)
        {
            return _context.Products.ToList();
        }



        public void UpdateProductById(Product p)
        {
            throw new NotImplementedException();
        }
    }
}
