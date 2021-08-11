using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandController : MonoBehaviour
{
    public static Action OnHandFree = delegate { };

    [SerializeField]
    private Animator _animator;
    [SerializeField]
    private float _speed = 50f;
    private bool _down = false;
    private bool _up = false;
    private float _hightPosition = 2.5f;
    // Start is called before the first frame update
    void Start()
    {
        inputController.OnJoystickVMove += VMove;
        inputController.OnJoystickHMove += HMove;
        inputController.OnButtonDown += Down;
        HandTrigger.OnToy += Up;
    }

    // Update is called once per frame
    void Update()
    {
        if(_down == true)
        {
            transform.position -= new Vector3(0, _speed * Time.deltaTime, 0);
        }
        if (_up == true)
        {
            transform.position += new Vector3(0, _speed * Time.deltaTime, 0);
        }
        if(transform.position.y > _hightPosition)
        {
            _up = false;
            transform.position = new Vector3(transform.position.x, _hightPosition , transform.position.z);
            _animator.SetTrigger("Release");
            OnHandFree.Invoke();
        }
        if (transform.position.y < 0)
        {
            _up = true;
        }
    }
    public void Down()
    {
        _up = false;
        _down = true; 
    }
    public void Up()
    {
        StartCoroutine(UpCoroutine());
    }

    IEnumerator UpCoroutine()
    {
        Debug.Log("bb");
        _down = false;
        _animator.SetTrigger("Grab");
        yield return new WaitForSeconds(2);
        _up = true;
    }
    public void VMove(int dir)
    {
        switch (dir)
        {
            case 0:
                transform.position += new Vector3(_speed*Time.deltaTime,0,0);
                break;
            case 1:
                transform.position -= new Vector3(_speed * Time.deltaTime, 0, 0);
                break;
            case 2:
                break;
            default:
                break;

        }
    }
    public void HMove(int dir)
    {
        switch (dir)
        {
            case 0:
                transform.position += new Vector3(0, 0, _speed * Time.deltaTime);
                break;
            case 1:
                transform.position -= new Vector3(0, 0, _speed * Time.deltaTime);
                break;
            case 2:
                break;
            default:
                break;

        }
    }
}
