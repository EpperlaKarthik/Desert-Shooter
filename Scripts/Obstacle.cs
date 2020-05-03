using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	public Vector3[] targetPositions;

	private int currentPositionIndex;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetPosition = targetPositions [currentPositionIndex];

		transform.position = 0.92f * transform.position + 0.08f * targetPosition;

		if (Vector3.Distance(transform.position, targetPosition) < 0.1f) {
			currentPositionIndex++;
			if (currentPositionIndex >= targetPositions.Length) {
				currentPositionIndex = 0;
			}
		}
	}
}
