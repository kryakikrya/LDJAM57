using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Checker : MonoBehaviour
{

    [SerializeField] GameObject _canvas;
    [SerializeField] ObjectToInteract _object;
    [SerializeField] SpriteRenderer _objectSpriteRenderer;
    [SerializeField] Sprite _spriteAfterInteract;
    [SerializeField] GameObject _kids;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !_object.GetIsActive())
        {
            _canvas.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Input.GetKey("e"))
            {
                    _object.ActivateObject();
                    _objectSpriteRenderer.sprite = _spriteAfterInteract;
                    _canvas.SetActive(false);
                _kids.SetActive(true);
                }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _canvas.SetActive(false);
        }
    }
}
