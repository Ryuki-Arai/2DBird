﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour
{
    void Update()
    {
        transform.position = new Vector3(transform.position.x + 0.02f,transform.position.y,transform.position.z);

        if (transform.position.x > 10.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
