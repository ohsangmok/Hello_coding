using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hello_code : MonoBehaviour {


    void Start()
    {
        int[] students = new int[5];

        students[0] = 100;
        students[1] = 90;
        students[2] = 80;
        students[3] = 70;
        students[4] = 60;

        for (int a = 4; a >= 0; a--)
        {
            Debug.Log((a + 1) + "번 학생의 점수 : " + students[a]);
        }
    }
       
}
