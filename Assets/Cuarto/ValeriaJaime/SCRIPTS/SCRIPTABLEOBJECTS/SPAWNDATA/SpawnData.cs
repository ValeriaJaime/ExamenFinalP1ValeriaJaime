using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ValeriaJaime
{

    [CreateAssetMenu(fileName = "New Spawn Data", menuName = "Valeria Jaime/Scriptable Objects/Spawn Data", order = 2)]
    public class SpawnData : ScriptableObject
    {

        public GameObject[] enemies; // Todos los tipos de enemigos que van a spawnear
        public int amount; // Cantidad de enemigos a spawnear
        public float spawnRate; // Cada cuanto van a spawnear los enemigos

    }

}

