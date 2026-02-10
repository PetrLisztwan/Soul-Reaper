using UnityEngine;

public class EraChanger : MonoBehaviour
{
    private EnemySpawner newBoss;
    private EnemyData Data;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (newBoss == null)
        {
            Debug.Log("Boss has died");
        }
    }
}
