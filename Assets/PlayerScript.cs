using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerScript : MonoBehaviour
{
    // Use this for initialization
    public float MoveSpeed;
    public float Rotate;
    CursorLockMode MouseLock;
    int HP = 100;
    bool Alive = true;
	bool right = true;
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
        MoveSpeed = 1f;
        MouseLock = CursorLockMode.Locked;
        //HealthBar = GameObject.Find("Health Bar").GetComponent<HealthBarScript>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Alive)
        {
            if (Input.GetKey("left shift"))
            {
                MoveSpeed = 2f;
            }
            else
            {
                MoveSpeed = 1f;
            }
            transform.Translate(((MoveSpeed + 1) * Input.GetAxis("Horizontal")) * Time.deltaTime, Input.GetAxis("Jump") / 4f, ((MoveSpeed + 1) * Input.GetAxis("Vertical") * Time.deltaTime));
			if((Input.GetAxis("Horizontal") > 0) && (right == false))
			{
				right = true;
				transform.Rotate(0, 180, 0);
			}
			else if((Input.GetAxis("Horizontal") < 0) && (right == true))
			{
				right = false;
				transform.Rotate(0, 180, 0);
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
            MoveSpeed = 1f;
        }
    }
}
