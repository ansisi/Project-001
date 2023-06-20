using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float minIdleTime = 1f;
    public float maxIdleTime = 3f;
    public float minMoveTime = 2f;
    public float maxMoveTime = 5f;

private Vector3 randomDestination;
    private float idleTime;
    private float moveTime;

    private void Start()
    {
        SetRandomDestination();
    }

    private void Update()
    {
        if (idleTime > 0)
        {
            idleTime -= Time.deltaTime;
            if (idleTime <= 0)
            {
                SetRandomDestination();
            }
        }
        else
        {
            MoveToDestination();
            if (moveTime > 0)
            {
                moveTime -= Time.deltaTime;
            }
            else
            {
                idleTime = Random.Range(minIdleTime, maxIdleTime);
                moveTime = 0;
            }
        }
    }

    private void SetRandomDestination()
    {
        randomDestination = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));
        moveTime = Random.Range(minMoveTime, maxMoveTime);
    }

    private void MoveToDestination()
    {
        transform.position = Vector3.MoveTowards(transform.position, randomDestination, moveSpeed * Time.deltaTime);
        if (transform.position == randomDestination)
        {
            idleTime = Random.Range(minIdleTime, maxIdleTime);
            moveTime = 0;
        }
    }



}
