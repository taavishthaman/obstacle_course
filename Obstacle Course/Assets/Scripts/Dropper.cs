using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer renderer; 
    Rigidbody rigidBody;
    float elapsedTime = 0;
    [SerializeField] float timeToWait = 3000f;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.time;
        if(elapsedTime > timeToWait){
            Debug.Log("Elapsed time is more than "+3+" seconds");
            rigidBody.useGravity = true;
            renderer.enabled = true;
        }
    }

    void OnCollisionEnter(Collision other){
        rigidBody.isKinematic = true;
    }
}
