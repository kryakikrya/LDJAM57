using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Animation : MonoBehaviour
{
    [SerializeField] List<Sprite> list = new List<Sprite>();
    private int id = 0;
    [SerializeField] Image image;
    [SerializeField] GameObject text;
    
    private void Start()
    {
        StartCoroutine(Animate());
    }
    IEnumerator Animate()
    {
        while (id < list.Count - 1)
        {
            yield return new WaitForSeconds(0.8f);
            id += 1;
            image.sprite = list[id];
        }
        text.SetActive(true);
    }
}
