using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] public string direction;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (direction == "forward")
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (direction == "backward")
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
         Debug.Log(other.gameObject.tag+" entered");
        if (other.gameObject.tag == "destroy_wall")
        {
            Destroy(this.gameObject);
           
        }
    }
}
