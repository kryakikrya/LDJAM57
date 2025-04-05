using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectToInteract : MonoBehaviour
{
    private bool _isActive = false;
    public void ActivateObject()
    {
        _isActive = true;
    }
    public bool GetIsActive()
    {
        return _isActive;
    }
}
