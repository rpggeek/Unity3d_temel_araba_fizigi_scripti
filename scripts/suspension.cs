using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suspension : MonoBehaviour
{
    public List<GameObject> wheels;
    public List<WheelCollider> colliders;
    public float ayarla = 0f;
    private int sayac = 0;

    void Start()
    {
    }
    void Update()
    {
        _suspension();
    }

    void _suspension()
    {
        foreach(GameObject tekerlek in wheels)
        {
            Quaternion quat;
            Vector3 pos;
            colliders[sayac].GetWorldPose(out pos, out quat);
            tekerlek.transform.position = pos;
            tekerlek.transform.rotation = quat;
            if (sayac < 3)
            {
                sayac++;
            }
            else
            {
                sayac = 0;
            }
        }
    }

}
