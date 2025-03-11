// Create products
using VisitorDP;

IProduct book = new Book(50.0);
IProduct electronics = new Electronics(200.0);

// Create shopping cart
ShoppingCart cart = new ShoppingCart();
cart.AddProduct(book);
cart.AddProduct(electronics);

// Apply fixed discount
IVisitor fixedDiscount = new FixedDiscountVisitor(10.0);
cart.ApplyDiscount(fixedDiscount);

// Apply percentage discount
IVisitor percentageDiscount = new PercentageDiscountVisitor(20.0);
cart.ApplyDiscount(percentageDiscount);