using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mochila : MonoBehaviour
{
    public GameObject semente1;
    public GameObject semente2;
    public GameObject semente3;
    public GameObject semente4;
    public GameObject semente5;
    public GameObject semente6;
    public GameObject semente7;
    public GameObject semente8;
    // Start is called before the first frame update
    void Start()
    {
        Player player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
            
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.tag == "sementeA");
        {
            
        }
    }
}
