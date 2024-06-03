package Task2.LargeClassRefactored;

import java.util.ArrayList;
import java.util.List;

public class EnemyManager {
    private List<String> enemies = new ArrayList<>();

    public void addEnemy(String enemy) {
        enemies.add(enemy);
    }

    public void removeEnemy(String enemy) {
        enemies.remove(enemy);
    }

    public List<String> getEnemies() {
        return enemies;
    }
}
