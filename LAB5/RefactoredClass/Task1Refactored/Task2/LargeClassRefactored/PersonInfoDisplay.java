package Task2.LargeClassRefactored;

public class PersonInfoDisplay {
    public void displayInfo(Person person, FriendManager friendManager, EnemyManager enemyManager,
            TaskManager taskManager) {
        System.out.println("Name: " + person.getName());
        System.out.println("Age: " + person.getAge());
        System.out.println("Gender: " + person.getGender());
        System.out.println("Friends: " + friendManager.getFriends());
        System.out.println("Enemies: " + enemyManager.getEnemies());
        System.out.println("Tasks: " + taskManager.getTasks());
    }
}