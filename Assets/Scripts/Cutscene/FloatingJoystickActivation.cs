using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingJoystickActivation : MonoBehaviour
{
    [SerializeField] public GameObject floatingJoystick;

    // Update is called once per frame
    void Update()
    {
        floatingJoystick.SetActive(true);
    }
}
