using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButonController : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;
    // Start is called before the first frame update
    void Start()
    {
        inputController.OnButtonDown += Down;
    }

    public void Down()
    {
        _animator.SetTrigger("Down");
    }
}
