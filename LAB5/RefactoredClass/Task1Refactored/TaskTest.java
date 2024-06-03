import java.util.ArrayList;
import java.util.List;

public class TaskTest {
    public static void main(String[] args) {

        List<User> users = new ArrayList<>();
        users.add(new User("admin1", "admin1@gmail.com", "password1", "address1"));
        users.add(new User("user2", "user2@gmail.com", "password2", "address2"));
        users.add(new User("admin3", "admin3@gmail.com", "password3", "address3"));

        UserHandler processor = new UserHandler(users);

        System.out.println("Processing user list:");
        processor.processUserList();

        int adminCount = processor.countAdminUsers();
        System.out.println("Number of admin users: " + adminCount);

        User newUser = new User("user4", "user4@example.com", "password4", "address4");
        processor.addUser(newUser);
        System.out.println("Added new user: " + newUser.getUsername());

        System.out.println("Processing updated user list:");
        processor.processUserList();

        processor.sendEmailToUser(newUser);
    }
}