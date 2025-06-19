// MissionManager.cs

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Este sí es un MonoBehaviour porque vivirá en la escena.
public class MissionManager : MonoBehaviour
{
    // Una lista pública para guardar las misiones disponibles en el tablón.
    public List<Mission> availableMissions = new List<Mission>();

    void Start()
    {
        // Creamos algunas misiones de prueba al iniciar el juego.
        CreateTestMissions();
        PrintMissionsToConsole();
    }

    void CreateTestMissions()
    {
        // Usamos el constructor de nuestra clase Mission.
        availableMissions.Add(new Mission("Plaga de Ratas", "El sótano de la posada está infestado de ratas gigantes.", 1, 50));
        availableMissions.Add(new Mission("Escolta de Caravana", "Protege una caravana de mercaderes en su camino al Paso Solitario.", 3, 200));
        availableMissions.Add(new Mission("El Lamento de la Banshee", "Una banshee aterroriza el viejo cementerio. Acaba con ella.", 5, 1000));
    }

    void PrintMissionsToConsole()
    {
        Debug.Log("--- Misiones Disponibles en el Tablón ---");
        foreach (Mission mission in availableMissions)
        {
            Debug.Log($"Misión: {mission.missionTitle} | Dificultad: {mission.difficulty} | Recompensa: {mission.goldReward} Oro");
        }
    }
}