using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mymove : MonoBehaviour {

    Camera cam;

    void Start()
    {
        if (cam == null)
            cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float distance = transform.position.z - cam.transform.position.z;
            Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
            position = cam.ScreenToWorldPoint(position);
            transform.position = position;
        }

    }
}
