package Task2.OrderRefactored;

import java.util.List;

public class Order {
    private String customerName;
    private List<String> items;
    private double totalPrice;

    public Order(String customerName, List<String> items) {
        this.customerName = customerName;
        this.items = items;
        this.totalPrice = new PriceCalculator().calculateTotalPrice(items);
    }

    public String getCustomerName() {
        return customerName;
    }

    public List<String> getItems() {
        return items;
    }

    public double getTotalPrice() {
        return totalPrice;
    }
}