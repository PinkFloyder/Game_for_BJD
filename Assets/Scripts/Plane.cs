using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    private GameObject _gameObject;
    
    void Start()
    {
        _gameObject = GameObject.Find("result_background");
    }


    public void OnMouseDown()
    {
        _gameObject.GetComponent<result_button>().onClick();
    }
}
