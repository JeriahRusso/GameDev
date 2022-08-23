using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int counter;
    private int rand;

    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        counter = 3;
        rand = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject.tag == "Red" && counter == 100)
        {
            this.gameObject.SetActive(false);
        }
        else if (this.gameObject.tag == "Blue" && counter == rand)
        {
            rend.enabled = false;
        }
        counter++;
        Debug.Log(this.gameObject.name + ":" + counter);
    }
}
