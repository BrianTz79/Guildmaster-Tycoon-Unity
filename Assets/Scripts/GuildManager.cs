// GuildManager.cs

using System.Collections;
using System.Collections.Generic; // ¡Necesitamos esto para usar Listas!
using UnityEngine;

// Nota que esta clase SÍ tiene ": MonoBehaviour".
// Esto nos permite arrastrarla a un objeto en nuestra escena de Unity.
public class GuildManager : MonoBehaviour
{
    // --- Campos (Variables) ---
    // Creamos una lista pública para guardar a todos nuestros aventureros.
    // Al ser pública, ¡la podremos ver en el editor de Unity!
    public List<Adventurer> adventurers = new List<Adventurer>();

    // El método Start() es llamado por Unity una sola vez, justo al principio
    // del juego, después de que todos los objetos son creados.
    void Start()
    {
        Debug.Log("¡El GuildManager ha empezado! Creando aventureros de prueba...");

        // --- Creación de Aventureros ---
        // Usamos el "new" y el constructor que definimos en la clase Adventurer.
        Adventurer grog = new Adventurer("Grog", 5, "Bárbaro");
        Adventurer vex = new Adventurer("Vex'ahlia", 4, "Exploradora");
        Adventurer scanlan = new Adventurer("Scanlan", 3, "Bardo");

        // --- Añadir Aventureros a la Lista ---
        adventurers.Add(grog);
        adventurers.Add(vex);
        adventurers.Add(scanlan);

        // --- Verificación en Consola ---
        // Vamos a recorrer nuestra lista de aventureros y a imprimir sus datos.
        Debug.Log($"Total de aventureros en el gremio: {adventurers.Count}");

        foreach (Adventurer adventurer in adventurers)
        {
            // Usamos la interpolación de strings ($) para crear un mensaje limpio.
            Debug.Log($" -> Nombre: {adventurer.adventurerName}, Clase: {adventurer.adventurerClass}, Nivel: {adventurer.level}");
        }
    }
}