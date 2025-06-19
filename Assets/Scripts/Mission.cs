// Mission.cs

// Al igual que Adventurer, esta es una clase de datos pura, sin ": MonoBehaviour".
public class Mission
{
    public string missionTitle;
    public string description;
    public int difficulty; // Podríamos usar un número (1-5) o un enum más adelante.
    public int goldReward;

    // Un constructor para crear misiones fácilmente.
    public Mission(string title, string desc, int diff, int reward)
    {
        this.missionTitle = title;
        this.description = desc;
        this.difficulty = diff;
        this.goldReward = reward;
    }
}