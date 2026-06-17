using System.Collections.Generic;

namespace OnlineOrdering;

public class Order
{
    private readonly Customer _customer;
    private readonly List<Product> _products = new List<Product>();

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalOrderCost()
    {
        double total = 0;
        foreach (Product product in _products)
        {
            total += product.CalculateTotalCost();
        }

        string customerAddress = _customer.GetAddress() ?? string.Empty;
        double shippingCost = customerAddress.Contains("USA") || customerAddress.EndsWith("USA") ? 5.00 : 35.00;
        return total + shippingCost;
    }

    public string GetPackingLabel()
    {
        string label = "--- Packing Label ---\n";
        foreach (Product product in _products)
        {
            label += $"Product: {product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        string address = _customer.GetAddress() ?? string.Empty;
        return $"--- Shipping Label ---\n{_customer.GetName()}\n{address}\n";
    }
}