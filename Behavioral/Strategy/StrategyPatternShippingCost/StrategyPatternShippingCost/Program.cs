using StrategyPatternShippingCost.Costs;
using StrategyPatternShippingCost.Service;

var service = new ShippingService();
var productValue = 0;

service.SetStrategy(new NationalShippingStrategy());
productValue = 200;
Console.WriteLine($"National Shipping Cost, for a Product value {productValue}: {service.GetShippingCost(productValue)}");

service.SetStrategy(new InternationalShippingStrategy());
productValue = 200;
Console.WriteLine($"International Shipping Cost, for a Product value {productValue}: {service.GetShippingCost(productValue)}");

service.SetStrategy(new ExpressShippingStrategy());
productValue = 200;
Console.WriteLine($"Express Shipping Cost, for a Product value {productValue}: {service.GetShippingCost(productValue)}");
