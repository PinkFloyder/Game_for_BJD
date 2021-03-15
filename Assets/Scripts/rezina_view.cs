using UnityEngine;

public class rezina_view : MonoBehaviour
{
    public float step;
    public Vector3 startPosition;
    public Vector3 endPosition;
    private float _progres;
    
    public volatile GameObject wood;
    public volatile bool check = false;
    

    private void OnMouseDown()
    {
        check = !check;
    }

    private void FixedUpdate()
    {
        if (check) { 
            wood.transform.position = Vector3.Lerp(startPosition, endPosition, _progres);
            _progres += step;
                
        }
        else { 
            wood.transform.position = Vector3.Lerp(startPosition, endPosition, _progres);
            _progres -= step;
        }
    }
}
