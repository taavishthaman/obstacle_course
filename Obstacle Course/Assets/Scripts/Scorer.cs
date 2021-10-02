using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int score = 0;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag != "hit"){
            score++;
            Debug.Log("You have bumped into a thing this many times: "+score);
        }
    }
}
