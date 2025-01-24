using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjderController : MonoBehaviour
{
    [SerializeField] private float  speed;
    private FixedJoystick fixedJoystick;
    private Rigidbody rigibody;
    private void OnEnable()
    {
        fixedJoystick = FindObjectOfType<FixedJoystick>();
        rigibody = gameObject.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        float xVal = fixedJoystick.Horizontal;
        float yVal = fixedJoystick.Vertical;
        Vector3 hareket = new Vector3(xVal, 0, yVal);
        rigibody.velocity = hareket * speed;
        if(xVal!= 0 && yVal!= 0)
        {
            transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(xVal, yVal) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }
    }
}
