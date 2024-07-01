using MarketCRM;
using MarketCRM.Business;
using MarketCRM.Entity;

CategoriyaManager categoryManager = new(1, "Cateqory");
Categoriya electronics = new(1, "Electronics");
Categoriya groceries = new(2, "Groceries");
categoryManager.AddCategory(electronics);
categoryManager.AddCategory(groceries);

ProductManager productManager = new (1, "Product", 1000.00, "Electronics");
Product laptop = new Product(1, "Laptop", 1000.00, "electronics");
Product phone = new Product(2, "Phone", 500.00, "electronics");
Product apple = new Product(3, "Apple", 100.00, "groceries");
productManager.AddProduct(laptop);
productManager.AddProduct(phone);
productManager.AddProduct(apple);

electronics.AddCategory(laptop);
electronics.AddProduct(phone);
groceries.AddProduct(apple);

UserManager userManager = new(1, "Admin1", 28, "+99451", "admin1@gmail.com", "admin12", "role0");
Admin admin = new(1, "Admin", 30, "+99450", "admin1@gmail.com", "password", "role1");
userManager.AddUser(admin);

Seller seller = new Seller(2, "Seller1", 25, "+994", "seller1@gmail.com", "password", "role2");
userManager.AddUser(seller);

Kassir kassir = new(3, "Kassir1", 27, "+99470", "kassir1@gmail.com", "password", "role3");
userManager.AddUser(kassir);

//Məhsulların Siyahısı
Console.WriteLine("Məhsulların ümumi siyahısı:");
productManager.ListProducts();

Console.WriteLine("Kateqoriyalara görə məhsulların siyahısı:");
categoryManager.ListCategories();

seller.SellProduct(laptop);
kassir.ProcessTransaction();

List<User> userlist = new List<User>();
List<Product> productlist = new List<Product>();
Console.WriteLine(userlist);
Console.WriteLine(productlist);



