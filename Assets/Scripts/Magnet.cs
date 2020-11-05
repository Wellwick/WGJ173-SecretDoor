using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    [SerializeField]
    private Rigidbody affected;

    [SerializeField]
    private float minimumEffectRange = 0.2f, magnetForce = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate() {
        if (Vector3.Distance(affected.transform.position, transform.position) < minimumEffectRange) {
            Vector3 direction = transform.position - affected.transform.position;
            affected.AddForce(direction.normalized, ForceMode.Force);
        }
    }
}
