using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float spinX = 0f;
    [SerializeField] float spinY = 0.5f;
    [SerializeField] float spinZ = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(spinX, spinY, spinZ);
    }
}
