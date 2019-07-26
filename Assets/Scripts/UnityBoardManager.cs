// using UnityEngine;
// using UnityEngine.Networking;
// 
// public class BoardManager : MonoBehaviour
// {
//     public InfoManagment UIInformation;
//     public GameObject enemyPrefab;
//     public GameObject Player;
//     public int numberOfEnemies;
//     public float spawnTime = 120f;            // How long between each spawn.    
//     public int SkillValue = 0;
//     public int HealtValue = 100;
//     void Start()
//     {
//         InvokeRepeating("Spawn", spawnTime, spawnTime);
// 
//     }
//     public void PlayerHealtAttack(int value = 0)
//     {
//         HealtValue += value;
//         UIInformation.UpdateHealt();
//     }
//     public void PlayerSkillUpdate(int value = 0)
//     {
//         SkillValue += value;
//         UIInformation.UpdateSkill();
//     }
//     //public PlayerHealth playerHealth;       // Reference to the player's heatlh.
//     //public GameObject enemy;                // The enemy prefab to be spawned.
//     //public float spawnTime = 3f;            // How long between each spawn.
//     //public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
// 
// 
//     //void Start()
//     //{
//     //    // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
//     //    InvokeRepeating("Spawn", spawnTime, spawnTime);
//     //}
// 
// 
//     void Spawn()
//     {
//         // If the player has no health left...
//         //if (playerHealth.currentHealth <= 0f)
//         //{
//         //    // ... exit the function.
//         //    return;
//         //}
//         for (int i = 0; i < numberOfEnemies; i++)
//         {
//             //var spawnPosition = new Vector3(
//             //    Random.Range(40.0f, 40.0f),
//             //    Random.Range(40.0f, 40.0f),
//             //    0.0f);
// 
//             //var spawnRotation = Quaternion.Euler(
//             //    0.0f,
//             //    Random.Range(0, 40),
//             //    0.0f);
//             var spawnPosition = new Vector3(Player.transform.position.x + Random.Range(0f, 40f),
//                 Player.transform.position.y + +Random.Range(0f, 40f),
//                 0.0f);
// 
//             var spawnRotation = Quaternion.Euler(
//                 0.0f,
//                 Random.Range(0, 40),
//                 0.0f);
// 
//             //.gameObject.tag == "Player"
//             var enemy = (GameObject)Instantiate(enemyPrefab, spawnPosition, spawnRotation);
//             //NetworkServer.Spawn(enemy);
// 
//             //Invoke("Die", 1f);
//         }
//         //    // Find a random index between zero and one less than the number of spawn points.
//         //    int spawnPointIndex = Random.Range(0, spawnPoints.Length);
// 
//         //// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
//         //Instantiate(enemy, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
//     }
// }