using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerScript : MonoBehaviour
{
    // Use this for initialization
    public float MoveSpeed;
    public float Rotate;
    public Rigidbody2D Fire;
    int HP = 100;
    bool Alive = true;
    //private HealthBarScript HealthBar;

    private void Die()
    {
        Debug.Log("You are Dead");
        Alive = false;
    }

    public void TakeDamage(int Damage)
    {
        Debug.Log("You were hit for " + Damage + " damage.");
        HP -= Damage;
        Debug.Log("You're HP is now " + HP);
        //HealthBar.SetHP(HP);
        if (HP < 0)
        {
            HP = 0;
            Die();
        }
    }

    private
    void Start()
    {
        MoveSpeed = 10f;
        //HealthBar = GameObject.Find("Health Bar").GetComponent<HealthBarScript>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Alive)
        {
            if (Input.GetKey("left shift"))
            {
                MoveSpeed = 20f;
            }
            else
            {
                MoveSpeed = 10f;
            }
            transform.Translate(((MoveSpeed + 1) * Input.GetAxis("Horizontal")) * Time.deltaTime, Input.GetAxis("Jump") / 4f, ((MoveSpeed + 1) * Input.GetAxis("Vertical") * Time.deltaTime));

            if (Input.GetButtonDown("Fire1"))
            {
                Rigidbody2D clone;
                clone = Instantiate(Fire, transform.position, transform.rotation);
                clone.velocity = transform.TransformDirection(Vector3.forward * 10);
            }
		}
    }
    private void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.tag != "nocollide")
        {
            MoveSpeed = 0.0f;
        }
    }
    private void OnCollisionExit2D(Collision2D Collision)
    {
        if (Collision.gameObject.tag == "nocollide")
        {
            MoveSpeed = 10f;
        }
    }
}
