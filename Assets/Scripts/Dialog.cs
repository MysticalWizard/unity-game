using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Dialog : MonoBehaviour {

  public TextMeshProUGUI textDisplay;
  public string[] sentences;
  private int index;
  public float typingSpeed;

  void Start(){



    IEnumerator Type(){

      foreach(char letter in sentences[index].ToCharArray()){
      textDisplay.text += letter;
      yield return new WaitForSeconds(typingSpeed);
      }
    }
  }
    // Start is called before the first frame update
}
