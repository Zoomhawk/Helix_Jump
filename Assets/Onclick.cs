using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Onclick : MonoBehaviour
{
  public Canvas cans;
  
public void Restart()
{
 SceneManager.LoadScene("FirstLevel");
 cans.enabled = false;
}

public void Quit()
{
    Application.Quit();

}


}
