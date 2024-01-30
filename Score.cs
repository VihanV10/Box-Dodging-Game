using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public Transform cube;
    public TextMeshProUGUI score;
    public float initialZ;
    // Start is called before the first frame update
    void Start()
    {
        initialZ = cube.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        float newZ = cube.position.z - initialZ;
        score.text = newZ.ToString("0");
    }
}
