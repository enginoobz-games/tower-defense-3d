﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class SnapEditor : MonoBehaviour
{
    [SerializeField] [Range(1f, 20f)] int gridSize = 10;
    [SerializeField] TextMesh coordLabel;

    Vector3 snapPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;
        transform.position = snapPos;

        coordLabel.text = snapPos.x / gridSize + "," + snapPos.z / gridSize;
    }
}
