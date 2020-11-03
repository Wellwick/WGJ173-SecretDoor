using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starfield : MonoBehaviour {
    [SerializeField]
    private Transform startLocation;

    [SerializeField]
    private int starCount = 5000;

    [SerializeField]
    private float starDistanceMin = 2000f, starDistanceMax = 4000f;

    [SerializeField]
    private GameObject star;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < starCount; i++) {
            float dist = Random.Range(starDistanceMin, starDistanceMax);
            Vector3 location = (Random.onUnitSphere * dist) + startLocation.position;
            GameObject s = Instantiate(star, location, Quaternion.identity, transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
