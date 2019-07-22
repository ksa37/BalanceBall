using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        a = GameObject.Find("DeathMenu_stage5");
        a.SetActive(false);
    }

    GameObject a;
    // Update is called once per frame
    void Update()
    {
        Vector3 pos1;
        Vector3 pos2;
        Vector3 pos3;
        Vector3 pos4;
        Vector3 bottom;
        bottom = GameObject.Find("bottom_stage5").transform.position;
        pos1 = GameObject.Find("sphere_stage5_1").transform.position - bottom;
        pos2 = GameObject.Find("sphere_stage5_2").transform.position - bottom;
        pos3 = GameObject.Find("sphere_stage5_3").transform.position - bottom;
        pos4 = GameObject.Find("sphere_stage5_4").transform.position - bottom;

        if (pos1.y > 14 || pos1.y < -7 || pos2.y > 14 || pos2.y < -7 || pos3.y > 14 || pos3.y < -7 || pos4.y > 14 || pos4.y < -7)
        {
            a.SetActive(true);
            Debug.Log("Game Over");
        }
    }
}
