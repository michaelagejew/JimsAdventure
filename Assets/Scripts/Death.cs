using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    bool killed = false;
    private void Update(){
        if(transform.position.y < -10f && !killed){
            kill();
        }
    }
private void OnCollisionEnter(Collision collision)
{
   if(collision.gameObject.CompareTag("Flag"))
   {
    kill();
   } 
}
void kill()
{
    GetComponent<MeshRenderer>().enabled = false;
    GetComponent<Rigidbody>().isKinematic = true;
    GetComponent<MovementPlayer>().enabled = false;
    Invoke(nameof(ReloadLevel), 2f);
    killed = true;
}

void ReloadLevel()
{
SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
}
