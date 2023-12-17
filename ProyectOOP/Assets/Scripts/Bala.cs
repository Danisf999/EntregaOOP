using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float _bulletSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destroy(this.gameObject, 5f);
    }

    private void FixedUpdate()
    {
        rb.AddForce(Vector3.forward * _bulletSpeed * Time.deltaTime, ForceMode.Impulse);
    }
}
