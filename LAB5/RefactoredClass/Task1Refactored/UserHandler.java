import java.util.List;

public class UserHandler {
    private List<User> users;

    public UserHandler(List<User> users) {
        this.users = users;
    }

    public void processUserList() {
        for (User user : users) {
            processUser(user);
        }
    }

    private void processUser(User user) {
        System.out.println("Processing user: " + user.getUsername());
        if (user.isAdmin()) {
            System.out.println("Admin user detected!");
        }
    }

    public int countAdminUsers() {
        int adminCount = 0;
        for (User user : users) {
            if (user.isAdmin()) {
                adminCount++;
            }
        }
        return adminCount;
    }

    public void addUser(User user) {
        users.add(user);
    }

    public void sendEmailToUser(User user) {
        
         EmailService.sendEmail(user.getEmail(), "Subject", "Message body");
    }
}