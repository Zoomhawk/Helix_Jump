using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pressbutton : MonoBehaviour
{

  public Canvas trans ;
 public void PlayGame()
  {
      trans.enabled = false;
  }
  public void QuitGame()
  {
    Application.Quit();
  }
}
