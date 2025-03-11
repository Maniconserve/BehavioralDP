// Create payment processor
using StrategyDP;

PaymentProcessor paymentProcessor = new PaymentProcessor();

// Process credit card payment
paymentProcessor.SetPaymentStrategy(new CreditCardPayment());
paymentProcessor.ProcessPayment(100.0);

// Process PayPal payment
paymentProcessor.SetPaymentStrategy(new PayPalPayment());
paymentProcessor.ProcessPayment(50.0);

// Process Bitcoin payment
paymentProcessor.SetPaymentStrategy(new BitcoinPayment());
paymentProcessor.ProcessPayment(200.0);