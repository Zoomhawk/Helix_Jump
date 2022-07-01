using UnityEngine;

public class Camrafollow : MonoBehaviour
{
   public  Vector3 offset;
    public Transform trans;
    public float smoothspeed = 0.04f;
    
void Start()
{
 offset = transform.position - trans.position;
}
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 newspeed = Vector3.Lerp(transform.position, trans.position + offset ,smoothspeed);
        transform.position = newspeed; // ??
    }
}
