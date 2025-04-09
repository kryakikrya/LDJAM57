using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Comix1 : MonoBehaviour
{

    [SerializeField] List<Sprite> list = new List<Sprite>();
    private int id = 0;
    [SerializeField] Image image;
    private void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            if (id > 0)
            {
                id -= 1;
                image.sprite = list[id];
            }
        }
        if (Input.GetKeyDown("d"))
        {
            if (id < list.Count - 1)
            {
                id += 1;
                image.sprite = list[id];
            }
        }
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(1);
        }
    }
}
