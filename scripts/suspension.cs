using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suspension : MonoBehaviour
{
    public List<GameObject> wheels;
    public List<WheelCollider> colliders;
    public float ayarla = 0f;
    private int counter = 0;

    void Start()
    {
    }
    void Update()
    {
        _suspension();
    }

    void _suspension()
    {
        foreach(GameObject wheel in wheels)
        {
            Quaternion quat;
            Vector3 pos;
            colliders[sayac].GetWorldPose(out pos, out quat);
            wheel.transform.position = pos;
            wheel.transform.rotation = quat;
            if (counter < 3)
            {
                counter++;
            }
            else
            {
                counter = 0;
            }
        }
    }

}
