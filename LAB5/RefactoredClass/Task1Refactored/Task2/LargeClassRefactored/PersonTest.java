package Task2.LargeClassRefactored;

public class PersonTest {
    public static void main(String[] args) {
        Person person = new Person("Alice", 30, "Female");
        FriendManager friendManager = new FriendManager();
        EnemyManager enemyManager = new EnemyManager();
        TaskManager taskManager = new TaskManager();
        PersonInfoDisplay display = new PersonInfoDisplay();

        friendManager.addFriend("Bob");
        enemyManager.addEnemy("Charlie");
        taskManager.addTask("Complete project");

        display.displayInfo(person, friendManager, enemyManager, taskManager);
    }
}
