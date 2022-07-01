
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bounce : MonoBehaviour
{
    public Rigidbody rb ;
    public float bounce = 5f;
    public GameObject canvas;

public int t=1;
   void  OnCollisionEnter(Collision collision) 
   {
       rb.velocity = new Vector3 (rb.velocity.x,bounce,rb.velocity.y);

       if (collision.gameObject.tag == "Final"){
        SceneManager.LoadScene("SecondLevel");
       }
       if(collision.gameObject.tag == "Last")
       {
           if(t==1)
canvas.SetActive(true);
          
       }

       if(collision.gameObject.tag == "Obstacle")
       {

           Invoke("calling", 0.2f);
       }
   }

   void calling()
   {
       SceneManager.LoadScene("SecondLevel");
   }
 
   

}
