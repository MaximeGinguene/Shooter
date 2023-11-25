using UnityEngine;

public class MovementEtTir : MonoBehaviour
{
    public GameObject bullet;
    public Transform parent;
    public Transform limitL;
    public Transform limitR;
    public float speed = 0.2f;
    public Drop drop; 

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, parent.position, parent.rotation);
        }
       
        if (Input.GetKeyDown(KeyCode.Space))
        {
           
            if (Drop.dropCount >= 5)
            {
              
                Instantiate(bullet, parent.position + new Vector3(-1, 0, 0), parent.rotation);
                Instantiate(bullet, parent.position, parent.rotation);
                Instantiate(bullet, parent.position + new Vector3(1, 0, 0), parent.rotation);
            }
        }

        if (transform.position.x < limitL.position.x)
        {
            transform.position = new Vector3(limitR.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitR.position.x)
        {
            transform.position = new Vector3(limitL.position.x, transform.position.y, transform.position.z);
        }
    }
}
