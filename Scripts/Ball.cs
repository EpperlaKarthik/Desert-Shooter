using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private Vector3 direction;
	private float speed;
	private bool hasBeenShot;

	public bool hitTarget;
	public bool correctTarget;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (hasBeenShot == true && hitTarget == false) {
			transform.position += direction * speed * Time.deltaTime;
		}
	}

	public void ShootTo (Vector3 targetPosition, float kickSpeed) {
		if (hasBeenShot == true) {
			return;
		}

		direction = (targetPosition - transform.position).normalized;
		speed = kickSpeed;

		hasBeenShot = true;
	}

	void OnTriggerEnter (Collider otherCollider) {
		if (otherCollider.tag == "CorrectArea") {
			hitTarget = true;
			correctTarget = true;
		} else if (otherCollider.tag == "WrongArea") {
			hitTarget = true;
			correctTarget = false;
		}
	}
}
