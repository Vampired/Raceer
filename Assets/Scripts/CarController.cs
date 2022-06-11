using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class CarController : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed = 3.0f;
    private float direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxisRaw("Horizontal");


    }
    private void FixedUpdate()
    {
        rb.velocity = Vector2.zero;
        rb.velocity = new Vector2(direction * moveSpeed, 0);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Time.timeScale = 0;
        GameOverMenu.gameObject.SetActive(true);
        Destroy(gameObject);

    }
    public Canvas GameOverMenu;
}