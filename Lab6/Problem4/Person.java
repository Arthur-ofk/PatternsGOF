package PatternsGOF.Lab6.Problem4;

public class Person {
    private String name;
    private String street;
    private String city;
    private String country;

    // Конструктор, геттери та сеттери...

    public void printAddress() {
        System.out.println("Address: " + street + ", " + city + ", " + country);
    }
}
