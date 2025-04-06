using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class InteractScript : MonoBehaviour
{

    [SerializeField] GameObject _canvas;
    [SerializeField] ObjectToInteract _object;
    [SerializeField] SpriteRenderer _objectSpriteRenderer;
    [SerializeField] Sprite _spriteAfterInteract;
    [SerializeField] PlayerMovement _player;
    [SerializeField] GameObject _teleportPosition;
    [SerializeField] bool _teleport;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && _object.GetIsActive() == false)
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
                if (!_teleport)
                {
                    _object.ActivateObject();
                    _objectSpriteRenderer.sprite = _spriteAfterInteract;
                    _canvas.SetActive(false);
                }
                else
                {
                    _player.transform.position = _teleportPosition.transform.position;
                }
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
