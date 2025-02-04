using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    [SerializeField]
    private float _speed = 3.0f;
    [SerializeField]
    private int powerupID; // 0 = TripleShot, 1 = Speed, 2 = Shields
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * _speed * Time.deltaTime);
        if(transform.position.y <= -5f)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Player")
        {
            Player player = other.transform.GetComponent<Player>();
            if (player != null)
            {
                if (powerupID == 0)
                {
                    player.TripleShotActive();
                }
                else if (powerupID == 1)
                {
                    // enable speed
                }
                else if (powerupID == 2)
                {
                    // enable shields
                }
                player.TripleShotActive();
            }
            Destroy(this.gameObject);
        }
    }
}
