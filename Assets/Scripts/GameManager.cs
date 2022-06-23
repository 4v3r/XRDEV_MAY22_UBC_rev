using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public static int SCORE;

    [SerializeField] private BoxCollider targetBounds;
    [SerializeField] private BoxCollider foodBounds;

    [SerializeField] private GameObject targetPrefab;
    [SerializeField] private GameObject[] fooditems;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }

        Instance = this;

        SCORE = 0;
    }

    public void TargetHit()
    {
        // Get a random position
        Vector3 randomPosition = new Vector3(
            Random.Range(targetBounds.bounds.min.x, targetBounds.bounds.max.x),
            Random.Range(targetBounds.bounds.min.y, targetBounds.bounds.max.y),
            Random.Range(targetBounds.bounds.min.z, targetBounds.bounds.max.z)
            );

        // Create a new target
        Instantiate(targetPrefab, randomPosition, Quaternion.identity);  // Quaternian.identity = default Rotation


        // Create a new random food
        randomPosition = new Vector3(
            Random.Range(foodBounds.bounds.min.x, foodBounds.bounds.max.x),
            Random.Range(foodBounds.bounds.min.y, foodBounds.bounds.max.y),
            Random.Range(foodBounds.bounds.min.z, foodBounds.bounds.max.z)
            );

        Instantiate(fooditems[Random.Range(0, fooditems.Length)], randomPosition, Quaternion.identity);

        SCORE++;

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
