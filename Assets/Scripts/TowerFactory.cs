﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerFactory : MonoBehaviourSingleton<TowerFactory>
{
    [SerializeField] Tower towerPrefab;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Build(Vector3 pos)
    {
        Tower tower = Instantiate(towerPrefab, pos, Quaternion.identity);
        tower.transform.parent = transform;
    }
}
