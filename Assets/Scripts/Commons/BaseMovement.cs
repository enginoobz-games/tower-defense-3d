﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour
{
    [SerializeField] float speed = 10f;

    [Tooltip("Delay time after reach each point")]
    [SerializeField] float delay = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    protected IEnumerator FollowPath(List<Transform> path)
    {
        foreach (Transform point in path)
        {
            // wait until reach next point
            yield return StartCoroutine(MoveTowards(point));
            // delay time after reach each point
            yield return new WaitForSeconds(delay);
        }
    }

    protected IEnumerator MoveTowards(Transform point)
    {
        while (transform.position != point.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, point.position, speed * Time.deltaTime);

            // wait until next frame
            yield return null;
        }
    }
}
