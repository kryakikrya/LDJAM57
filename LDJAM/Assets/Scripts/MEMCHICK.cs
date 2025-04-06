using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MEMCHICK : MonoBehaviour
{
    [SerializeField] GameObject _canvas;
    [SerializeField] GameObject _floor;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _canvas.SetActive(true);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Input.GetKey("w"))
            {
                _floor.SetActive(false);
                StartCoroutine(Activate());
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
    IEnumerator Activate()
    {
        yield return new WaitForSeconds(2);
        _floor.SetActive(true);
    }
}
