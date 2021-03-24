using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class rotate_arrow : MonoBehaviour
{
    public int i = 120;
    public float speed = 0.01f;

    private Quaternion quaternion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (i)
        {
            case 10:
                transform.rotation = Quaternion.Euler(0.178f, -0.408f, -60.369f);
                break;
            case 15:
                transform.rotation = Quaternion.Euler(5.166f, -9.240001f, -52.933f);
                break;
            case 40:
                transform.rotation = Quaternion.Euler(5.778f, -4.824f, -40.873f);
                break;
            case 50:
                transform.rotation = Quaternion.Euler(6.157f, -3.907f, -36.844f);
                break;
            case 60:
                transform.rotation = Quaternion.Euler(6.682f, -2.159f, -29.413f);
                break;
            case 80:
                transform.rotation = Quaternion.Euler(7.027f, 1.78f, -13.251f);
                break;
            case 100:
                transform.rotation = Quaternion.Euler(5.658f, 7.144001f, 9.416f);
                break;
            case 120:
                transform.rotation = Quaternion.Euler(3.243f, 10.68f, 26.784f);
                break;
        }
    }
}
