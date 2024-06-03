package Task2.OrderRefactored;

import java.util.Arrays;

public class OrderTest {
    public static void main(String[] args) {
        Order order = new Order("John Doe", Arrays.asList("item1", "item2"));
        OrderProcessor processor = new OrderProcessor();
        processor.processOrder(order);

        System.out.println("Total price: " + order.getTotalPrice());
    }
}
