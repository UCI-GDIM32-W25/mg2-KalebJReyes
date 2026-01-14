using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _jumpHeight = 1.0f;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private GameController _gameController;

    private bool _isGrounded;
    public int _coinsCollected;

    // Start is called before the first frame update
    void Start()
    {
        _coinsCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space") && _isGrounded) 
        {
            _isGrounded = false;

            _rb.velocity = new Vector2(_rb.velocity.x, _jumpHeight);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ground")) 
        {
            _isGrounded = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Coin")) 
        {
            _coinsCollected++;
            Destroy(collision.gameObject);
            _gameController.UpdateText(_coinsCollected);
        }
    }
}
