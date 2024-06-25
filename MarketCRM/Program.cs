

// METODLAR prodaktin, add update deleted getallprodakt  prodact tipinden prodat yazirsan metodun icinde mehsullarin icin gezirsen
// for la metodu run edende list tipinden prodati oxud prodatkti liste yigin  listi fora sal tek tek oxut
// prodat . protakt item beraberdi id uygunu tap add hissede
//  foricle prodatk listinin icin tek tek gezdiz deyirsen itm.id = prodat.id updet. prodat   
using MarketCRM.Business;
using MarketCRM.Entity;


//Prodact prodact = new();



ProductManager productManager = new ();
UserManager userManager = new ();
CategoriyaManager categoryManager = new ();


Product product1 = new Product(1, "Alma", 5.0, "Fruits");
productManager.AddProduct(product1);

Seller seller1 = new Seller(1, "Aslan Aslanli");
userManager.AddUser(seller1);


Categoriya category1 = new Categoriya(1, "Fruits");
categoryManager.AddCategory(category1);

Console.WriteLine("Products:");
productManager.ListProducts();

// İstifadəçiləri siyahı şəklində konsola yazdırmaq
Console.WriteLine("\nUsers:");
userManager.ListUsers();

// Kateqoriyaları siyahı şəklində konsola yazdırmaq
Console.WriteLine("\nCategories:");
categoryManager.ListCategories();


List<User> userlist = new List<User>();
List<Product> productlist = new List<Product>();

User user1 = new()
{
    ID = 0,
    FullName = "User1",
    Age = 25,
    Number = "994",
    Role = "Kassir",
};



AdminManager adminManager = new();

UserManager cashier1 = new();

adminManager.AddUser(user1);



