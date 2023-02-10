using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionReponse : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject == player)
        {
            Vector3 force = this.transform.position - collision.collider.gameObject.transform.position;
            force.Normalize();
            force = force * 200f;
            this.GetComponent<Rigidbody>().AddForce(force);
        }
    }
}
