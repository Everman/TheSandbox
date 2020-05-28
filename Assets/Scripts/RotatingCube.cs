using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RotatingCube : MonoBehaviour
{
    [SerializeField] private float rotatingSpeed = 50.0f;

    // Update is called once per frame
    void Update()
    {

        float rotatingSpeedNormalized = rotatingSpeed * Time.deltaTime;
      
        Vector3 rotationPower = new Vector3(rotatingSpeedNormalized, rotatingSpeedNormalized, rotatingSpeedNormalized);

        transform.Rotate(rotationPower);
    }
}
