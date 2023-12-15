using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private Arma[] armas;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            
        }

        if (Input.GetMouseButtonDown(0))
        {
            armas[0].Shoot();
        
        }
    }
}
