using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float speed = 3.0f;
    public int maxHealth = 5;
    public int health { get { return currentHealth; }}
    int currentHealth;

    [Range(0, 5f)]
    public float movementSpeed;
    public float jumpForce;
    private Rigidbody2D rig;
    float hor;
    float ver;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        currentHealth = maxHealth;
        currentHealth = 1;
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

        //transform.position += (new Vector3(hor, ver, 0)) * movementSpeed * Time.deltaTime;
        //print(Time.deltaTime);
    }
    void FixedUpdate()
    {
        Vector2 position = rig.position;
        position.x = position.x + speed * hor * Time.deltaTime;
        position.y = position.y + speed * ver * Time.deltaTime;

        rig.MovePosition(position);
    }
    public void ChangeHealth(int amount)
    {
        currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
        Debug.Log(currentHealth + "/" + maxHealth);
    }
}
