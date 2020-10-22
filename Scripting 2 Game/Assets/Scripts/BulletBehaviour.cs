using System.Collections;
using System.Collections.Generic;
using UnityEngine; 

public class BulletBehaviour : MonoBehaviour
{
    private Rigidbody rBody;
    public float bulletForce;
    private float lifeTime; 

    private IEnumerator Start()
    {
        rBody = GetComponent<Rigidbody>();
        
        rBody.AddRelativeForce(Vector3.forward * bulletForce);
        yield break;
        //yield return new WaitForSeconds(lifeTime);
        Destroy(gameObject);
    }
}
