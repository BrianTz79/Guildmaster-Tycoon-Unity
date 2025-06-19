// GuildManager.cs

using System.Collections;
using System.Collections.Generic; // ¡Necesitamos esto para usar Listas!
using UnityEngine;
using TMPro; // <--- ¡AÑADE ESTA LÍNEA! Es la solución al error.

// Nota que esta clase SÍ tiene ": MonoBehaviour".
// Esto nos permite arrastrarla a un objeto en nuestra escena de Unity.
public class GuildManager : MonoBehaviour
{
        // --- Referencias de UI ---
    // La plantilla (Prefab) para mostrar un aventurero en la UI.
    public GameObject adventurerUIPrefab;
    // El objeto "Padre" que contendrá nuestra lista de aventureros en la UI.
    public Transform adventurerListParent;

    // --- Campos (Variables) ---
    // Creamos una lista pública para guardar a todos nuestros aventureros.
    // Al ser pública, ¡la podremos ver en el editor de Unity!
    public List<Adventurer> adventurers = new List<Adventurer>();

    // El método Start() es llamado por Unity una sola vez, justo al principio
    // del juego, después de que todos los objetos son creados.
    void Start()
    {
        Debug.Log("¡El GuildManager ha empezado! Creando aventureros de prueba...");
        
        // Creamos los aventureros como antes.
        adventurers.Add(new Adventurer("Grog", 5, "Bárbaro"));
        adventurers.Add(new Adventurer("Vex'ahlia", 4, "Exploradora"));
        adventurers.Add(new Adventurer("Scanlan", 3, "Bardo"));

        // Después de crearlos, le decimos a la UI que se actualice.
        UpdateAdventurerUI();
    }

    void UpdateAdventurerUI()
    {
        // Limpiamos la lista por si había algo antes (útil para el futuro).
        foreach (Transform child in adventurerListParent)
        {
            Destroy(child.gameObject);
        }

        // Por cada aventurero en nuestra lista de datos...
        foreach (Adventurer adventurer in adventurers)
        {
            // 1. Creamos una nueva instancia de nuestra plantilla (Prefab).
            GameObject adventurerRow = Instantiate(adventurerUIPrefab, adventurerListParent);

            // 2. Buscamos el componente de texto en esta nueva instancia.
            // Ahora C# ya sabe qué es un TextMeshProUGUI gracias al "using TMPro;"
            TextMeshProUGUI textComponent = adventurerRow.GetComponent<TextMeshProUGUI>();

            // 3. Actualizamos el texto con los datos del aventurero.
            textComponent.text = $"{adventurer.adventurerName} - {adventurer.adventurerClass} Nv. {adventurer.level}";
        }
    }
}