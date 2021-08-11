using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        inputController.OnJoystickVMove += VMove;
        inputController.OnJoystickHMove += HMove;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HMove(int dir)
    {
        switch (dir)
        {
            case 0:
                transform.eulerAngles = new Vector3(30,0, transform.eulerAngles.z);
                break;
            case 1:
                transform.eulerAngles = new Vector3(-30, 0, transform.eulerAngles.z);
                break;
            case 2:
                transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z);
                break;
            default:
                break;

        }
    }
    public void VMove(int dir)
    {
        switch (dir)
        {
            case 0:
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, 30);
                break;
            case 1:
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, -30);
                break;
            case 2:
                transform.eulerAngles = new Vector3(transform.eulerAngles.x, 0, 0);
                break;
            default:
                break;

        }
    }
}
