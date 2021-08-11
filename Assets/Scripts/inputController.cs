using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inputController : MonoBehaviour
{
    public static Action<int> OnJoystickVMove = delegate { };
    public static Action<int> OnJoystickHMove = delegate { };
    public static Action OnButtonDown = delegate { };
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            OnJoystickHMove.Invoke(0);
        }
        else if(Input.GetAxis("Horizontal") < 0)
        {
            OnJoystickHMove.Invoke(1);
        }
        else if (Input.GetAxis("Horizontal") == 0)
        {
            OnJoystickHMove.Invoke(2);
        }

            if (Input.GetAxis("Vertical") > 0)
        {
            OnJoystickVMove.Invoke(0);
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            OnJoystickVMove.Invoke(1);
        }
        else if (Input.GetAxis("Vertical") == 0)
        {
            OnJoystickVMove.Invoke(2);
        }

        if (Input.GetButtonDown("Submit") )
        {
            
            OnButtonDown.Invoke();
        }
    }
}
