using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CódigoExplo : MonoBehaviour
{
    public AudioSource Boom;
   public void SoundExplo()
   {
        Boom.Play();
   }
   public void DestroyExplosion()
   {
        
        Destroy(this.gameObject);
        
   }
    

    
}
