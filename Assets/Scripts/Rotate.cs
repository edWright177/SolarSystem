using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    public int rotationAmount;
    void Update() {
        transform.Rotate(Vector3.up * Time.deltaTime * rotationAmount);
    }
}
