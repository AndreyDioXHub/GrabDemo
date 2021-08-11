using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTrigger : MonoBehaviour
{
    private bool _inProgress = false;
    public static Action OnToy = delegate { };
    public static Action OnStop= delegate { };

    private void Awake()
    {
        HandController.OnHandFree += SetInProgrees;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(_inProgress == false)
        {
            if (other.tag == "Toy")
            {
                Debug.Log("bbw");
                _inProgress = true;
                OnToy.Invoke();
            }
        }
    }

    private void SetInProgrees()
    {
        _inProgress = false;
    }
}
