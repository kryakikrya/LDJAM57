using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToInteract : MonoBehaviour
{
    private bool _isActive = false;
    [SerializeField] Switch _switch;
    [SerializeField] bool _necessarily;
    public void ActivateObject()
    {
        if (!_isActive && _necessarily)
        {
            Debug.Log(_switch.GetSum());
            _switch.IncreaseSum();
        }
        _isActive = true;
    }
    public bool GetIsActive()
    {
        return _isActive;
    }
}
