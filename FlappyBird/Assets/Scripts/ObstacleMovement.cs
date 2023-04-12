using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float startingX = 10;
    [SerializeField] private float minX = -17;

    [SerializeField] private float maxY = 2;
    [SerializeField] private float minY = -2;

    private float randomY;

    private void Start()
    {
        randomY = Random.Range(maxY, minY);

        transform.position = new Vector3(transform.position.x, randomY, 0);
    }


    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        randomY = Random.Range(maxY, minY);

        if (transform.position.x < minX)
        {
            transform.position = new Vector3(startingX,randomY,0);
        }


    }
}
