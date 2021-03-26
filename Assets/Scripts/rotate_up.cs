using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class rotate_up : MonoBehaviour
{
    private List<GameObject> list1= new List<GameObject>();
    private List<GameObject> list2= new List<GameObject>();
    public GameObject material;
    private GameObject res;
    public int delete_index;
    private Renderer _renderer;
    private Color _color;
    public bool click;
    public TextMeshPro stop;
    
    public float speed;
    public Vector3 destination;
    public Vector3 destination2;
    
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _color = _renderer.material.color;
        
        res = GameObject.Find("result_background");
        
        list1.Add(GameObject.Find("wood_background"));
        list1.Add(GameObject.Find("rezina_background"));
        list1.Add(GameObject.Find("metall_background"));
        list1.Add(GameObject.Find("10mm_background"));
        list1.Add(GameObject.Find("50mm_background"));
        list1.RemoveAt(delete_index);
        
        list2.Add(GameObject.Find("5cm_background"));
        list2.Add(GameObject.Find("10cm_background"));
        list2.Add(GameObject.Find("15cm_background"));
        list2.Add(GameObject.Find("20cm_background"));
        list2.Add(GameObject.Find("25cm_background"));
        list2.Add(GameObject.Find("30cm_background"));
        list2.Add(GameObject.Find("40cm_background"));
        
        
    }

    public void setClick()
    {
        if (!click)
        {
            stop.text = "Stop";
            _renderer.material.color = Color.red;
            if (list2[0].GetComponent<rotate_left>().click)
                list2[0].GetComponent<rotate_left>().setClick();
        }
        else
        {
            list2[0].GetComponent<rotate_left>().setClick();
            stop.text = "";
            _renderer.material.color = _color;
            
        }
        
        click = !click;
    }

    void OnMouseDown()
    {
        foreach (var o in list2)
        {
            if (o.GetComponent<rotate_left>().click)
                o.GetComponent<rotate_left>().setClick();
        }

        foreach (var o in list1)
        {
            if (o.GetComponent<rotate_up>().click)
                o.GetComponent<rotate_up>().setClick();
        }
        
        setClick();
        
        res.GetComponent<result_button>().getResult();
    } 
    
    void FixedUpdate()
    {
        if (click)
        {
            material.transform.position = Vector3.Lerp(material.transform.position, destination, speed);
        }
        else
            material.transform.position = Vector3.Lerp(material.transform.position, destination2, speed);
    }
}
