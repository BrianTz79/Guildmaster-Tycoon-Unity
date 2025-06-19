// Adventurer.cs

// Nota que esta clase NO tiene ": MonoBehaviour".
// Esto significa que es una clase de C# pura, un simple contenedor de datos.
// No la podemos arrastrar a un objeto de Unity, y eso es lo que queremos.
public class Adventurer
{
    // --- Campos (Variables) ---
    // Aquí guardamos toda la información de un aventurero.
    public string adventurerName;
    public int level;
    public string adventurerClass; // "Guerrero", "Mago", "Pícaro", etc.

    // --- Constructor ---
    // Un constructor es un método especial que se usa para crear un "objeto" nuevo
    // a partir de esta clase. Nos obliga a darle los datos básicos al crearlo.
    public Adventurer(string name, int lvl, string advClass)
    {
        // Usamos "this" para diferenciar la variable de la clase (this.adventurerName)
        // del parámetro que recibimos en el método (name).
        this.adventurerName = name;
        this.level = lvl;
        this.adventurerClass = advClass;
    }

    // Más adelante podríamos añadir métodos aquí, como:
    // public void LevelUp() { ... }
    // public void TakeDamage(int amount) { ... }
}