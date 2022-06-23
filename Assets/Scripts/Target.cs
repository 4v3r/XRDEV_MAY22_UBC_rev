using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float yAmplitude = 0.5f;
    public float ySpeed = 1;

    public float xAmplitude = 0.5f;
    public float xSpeed = 1;

    public float zAmplitude = 0.5f;
    public float zSpeed = 1;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }


    void Update()
    {
        transform.position = new Vector3(
            startPosition.x + Mathf.Sin(Time.timeSinceLevelLoad * xSpeed) * xAmplitude,
            startPosition.y + Mathf.Cos(Time.timeSinceLevelLoad * ySpeed) * yAmplitude,
            startPosition.z + Mathf.Sin(Time.timeSinceLevelLoad * zSpeed) * zAmplitude
            );
    }

    //Detect Collision
    private void OnCollisionEnter(Collision col)
    {
        //filter food items only
        if(col.gameObject.CompareTag("fooditem"))
        {
            GameManager.Instance.TargetHit();

            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
