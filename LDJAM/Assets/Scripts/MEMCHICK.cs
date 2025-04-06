using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MEMCHICK : MonoBehaviour
{
    [SerializeField] GameObject _canvas;
    [SerializeField] GameObject _floor;
    [SerializeField] bool _eternal;
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
                if (!_eternal)
                {
                    StartCoroutine(Activate());
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
    IEnumerator Activate()
    {
        yield return new WaitForSeconds(5);
        _floor.SetActive(true);
    }
}
