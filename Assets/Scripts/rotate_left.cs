using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_left : MonoBehaviour
{
    private List<GameObject> list1 = new List<GameObject>();
    private List<GameObject> list2 = new List<GameObject>();
    public GameObject material;
    private GameObject res;
    public int delete_index;
    private Renderer _renderer;
    private Color _color;
    public bool click;
    
    public float speed;
    public Vector3 destination;
    public Vector3 destination2;
    
    void Start()
    {
        _renderer = GetComponent<Renderer>();
        _color = _renderer.material.color;
        
        res = GameObject.Find("result_background");
        
        list2.Add(GameObject.Find("wood_background"));
        list2.Add(GameObject.Find("rezina_background"));
        list2.Add(GameObject.Find("metall_background"));
        list2.Add(GameObject.Find("10mm_background"));
        list2.Add(GameObject.Find("50mm_background"));
        
        list1.Add(GameObject.Find("5cm_background"));
        list1.Add(GameObject.Find("10cm_background"));
        list1.Add(GameObject.Find("15cm_background"));
        list1.Add(GameObject.Find("20cm_background"));
        list1.Add(GameObject.Find("25cm_background"));
        list1.Add(GameObject.Find("30cm_background"));
        list1.Add(GameObject.Find("40cm_background"));
        list1.RemoveAt(delete_index);
        
        res.GetComponent<result_button>().getResult();
    }
    
    public void setClick()
    {
        if (!click)
        {
            _renderer.material.color = Color.red;
        }
        else
        {
            _renderer.material.color = _color;
        }
        click = !click;
    }

    public void OnMouseDown()
    {
        if (click) return;
        foreach (var o in list1)
        {
            if (o.GetComponent<rotate_left>().click)
            {
                o.GetComponent<rotate_left>().setClick();
                break;
            }
        }
        
        foreach (var o in list2)
        {
            if (o.GetComponent<rotate_up>().click)
                return;
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
