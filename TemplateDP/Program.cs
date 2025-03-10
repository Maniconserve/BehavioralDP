using TemplateDP;

Console.WriteLine("Processing Credit Card Order:");
OrderProcessTemplate order1 = new CreditCardOrder();
order1.ProcessOrder();

Console.WriteLine("\nProcessing PayPal Order:");
OrderProcessTemplate order2 = new PayPalOrder();
order2.ProcessOrder();

Console.WriteLine("\nProcessing Cash on Delivery Order:");
OrderProcessTemplate order3 = new CashOnDeliveryOrder();
order3.ProcessOrder();