using UnityEngine;

public class rezina_view : MonoBehaviour
{
    public GameObject material;
    public bool click;

    
    public float speed;
    public Vector3 destination;
    public Vector3 destination2;
    void FixedUpdate()
    {
        if (click)
        {
            material.transform.position = Vector3.Lerp(material.transform.position, destination, speed);
        }
        else
            material.transform.position = Vector3.Lerp(material.transform.position, destination2, speed);
    }

    private void OnMouseDown()
    {
        click = !click;
    }
}
