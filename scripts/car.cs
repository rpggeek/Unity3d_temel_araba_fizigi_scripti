using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    public GameObject onSol, onSag, arkaSol, arkaSag;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        onSag.transform.position += new Vector3(0.01f, 0, 0);
    }
}
