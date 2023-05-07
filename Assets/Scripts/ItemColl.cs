using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemColl : MonoBehaviour
{
      int keys = 0;
 //   [SerializeField] Text keysText;
    [SerializeField] AudioSource collS;
private void OnTriggerEnter(Collider collision){
    if(collision.gameObject.CompareTag("piece"))
    {
        Destroy(collision.gameObject);
        keys++;
       // keysText.text = "Keys: " + keys;
        collS.Play();
    }
}
}

