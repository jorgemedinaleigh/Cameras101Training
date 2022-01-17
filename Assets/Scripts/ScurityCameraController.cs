using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScurityCameraController : MonoBehaviour
{
    [SerializeField] float camAngle = 35f;
    [SerializeField] float rotationFrequency = 0.5f;
    [SerializeField] float camRoute;
    [SerializeField] float camOffset;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotationAngle = Mathf.Sin(Time.time * rotationFrequency) * camRoute;
 
        transform.rotation = Quaternion.Euler(camAngle, rotationAngle + camOffset, 0f);
    }
}
