using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody2D monRigidBody;
    public float speed;
    public GameObject drops;
    //public ScoreText scoreText;


    private Ennemis ennemy;


    // Start is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.up*speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        ennemy = collision.gameObject.GetComponent<Ennemis>();
        if (ennemy)
        {
            Instantiate(drops, transform.position, Quaternion.identity);
            //scoreText.updateScore();
            Destroy(collision.gameObject);
            Destroy(gameObject);
           
        }
    }
}
