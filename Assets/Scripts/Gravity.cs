using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour {
    const float G = .6674f;
    public Rigidbody rb;
    private void FixedUpdate() {
        Gravity[] gravitators = FindObjectsOfType<Gravity>();
        foreach (Gravity gravitator in gravitators) {
            if (gravitator != this) {
                attract(gravitator);
            }
        }
    }
    void attract(Gravity targetObject) {
        Rigidbody toGravitate = targetObject.rb;

        Vector3 direction = rb.position - toGravitate.position;
        float distance = direction.magnitude;

        float forceMagnitude = G * (rb.mass * toGravitate.mass) / Mathf.Pow(distance, 2);

        Vector3 force = direction.normalized * forceMagnitude;

        toGravitate.AddForce(force);
    }
    
}
