using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Coin : MonoBehaviour {

    [SerializeField] float turnSpeed = 90f;
    public AudioClip CoinSound;

    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.GetComponent<Obstacle>() != null) {
            Destroy(gameObject);
            return;
        }

        // Check that the object we collided with is the player
        if (other.gameObject.name != "Catrina") {
            return;
        }

        // Add to the player's score
        GameManager.inst.IncrementScore();

        // Destroy this coin object
        AudioSource.PlayClipAtPoint(CoinSound, transform.position);
        Destroy(gameObject);
    }

    private void Start () {

	}

	private void Update () {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
	}
}