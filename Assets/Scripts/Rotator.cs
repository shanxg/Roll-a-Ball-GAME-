﻿using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate (new Vector3 (15.0f, 30.0f, 45.0f) * Time.deltaTime);
    }
}
