using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carController : MonoBehaviour
{
    private float m_horizontalInput;
    private float m_verticalInput;
    private float m_steeringAngle;

    public WheelCollider frontDriverW, frontPassengerW;
    public WheelCollider rearDriverW, rearPassengerW;
    public float maxSteerAngle = 30;
    public float motorForce = 50;
    private Rigidbody carrigid;

    void Start()
    {
        carrigid = GetComponent<Rigidbody>();
    }

    public void GetInput()
    {
        
        m_horizontalInput = Input.GetAxis("Horizontal");
        m_verticalInput = Input.GetAxis("Vertical");
    }

    private void Steer()
    {
        m_steeringAngle = maxSteerAngle * m_horizontalInput;
        frontDriverW.steerAngle = m_steeringAngle*2;
        frontPassengerW.steerAngle = m_steeringAngle*2;
    }

    private void Accelerate()
    {
        frontDriverW.motorTorque = m_verticalInput * motorForce;
        frontPassengerW.motorTorque = m_verticalInput * motorForce;
    }

    private void Update()
    {
        GetInput();
        Steer();
        Accelerate();
    }
}
