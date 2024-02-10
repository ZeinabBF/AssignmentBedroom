using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private GameObject bulbLight;
    private GameObject bulbLight1;
    // Start is called before the first frame update
    void Start()
    {
        bulbLight = GameObject.Find("Bulb_01");
        bulbLight1 = GameObject.Find("Bulb_02");
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void Bulb()
    {

        bulbLight.GetComponent<Renderer>().material.color = new Color(0, 204, 102);
        bulbLight1.GetComponent<Renderer>().material.color = new Color(0, 204, 102);

    }

}
