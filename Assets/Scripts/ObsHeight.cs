using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsHeight : MonoBehaviour
{
    public float randomDis = 2;
    public float smoothness = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position += Vector3.up * Mathf.PerlinNoise(Time.timeSinceLevelLoad/ smoothness, 4.5f)*randomDis*2-Vector3.up*randomDis;
    }
}
