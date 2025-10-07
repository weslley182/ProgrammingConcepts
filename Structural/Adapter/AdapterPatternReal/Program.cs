using AdapterPatternReal.Dto;
using AdapterPatternReal.Interface;
using AdapterPatternReal.Services;

var req = new PaymentRequest("cust_123", 49.90m, "USD");

IPaymentGateway stripe = new StripeAdapter(new StripeClient());
var stripeRes = await stripe.ChargeAsync(req);
Console.WriteLine($"[Client] Stripe => Success={stripeRes.Success}, Tx={stripeRes.TransactionId}, Err='{stripeRes.Error}'");
Console.WriteLine();

IPaymentGateway paypal = new PaypalAdapter(new PaypalClient());
var paypalRes = await paypal.ChargeAsync(req);
Console.WriteLine($"[Client] PayPal => Success={paypalRes.Success}, Tx={paypalRes.TransactionId}, Err='{paypalRes.Error}'");

Console.WriteLine("\nDone.");