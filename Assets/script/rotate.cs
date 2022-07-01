using UnityEngine;

public class rotate : MonoBehaviour
{
    public float rotationspeed = 6f ;
    public Touch touch;


    void Start()
    {
       // Cursor.lockState = CursorLockMode.Locked;

    }

    void FixedUpdate()
    {
       if(Input.touchCount>0 )
       {
        touch = Input.GetTouch(0);
        if(touch.phase == TouchPhase.Moved)
        {
           Vector3 Rotation = Input.GetTouch(0).deltaPosition;
           transform.Rotate(0, -(Rotation.x*rotationspeed*Time.deltaTime),0);// x is taken just because of mobile 
        }
       }

    }


}
