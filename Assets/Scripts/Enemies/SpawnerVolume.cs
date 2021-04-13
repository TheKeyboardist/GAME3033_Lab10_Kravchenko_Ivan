using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random =  UnityEngine.Random;
[RequireComponent(typeof(BoxCollider))]
public class SpawnerVolume : MonoBehaviour
{

    private BoxCollider collider;
    private void Awake()
    {
        collider = GetComponent<BoxCollider>();
    }

    public Vector3 GetPositionInBounds()
    {
        Bounds boxBounds = collider.bounds;
        return new Vector3(Random.Range(
                                        boxBounds.min.x, boxBounds.max.x), 
                                        transform.position.y, 
                                        Random.Range(boxBounds.min.z, boxBounds.max.z));
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
