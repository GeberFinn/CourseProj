using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConScr : MonoBehaviour
{
    public GameObject PJPlatform;
    public GameObject DangPlatform;
    public GameObject PlatForm;
    public GameObject Checker;

    [Range(0, 10)]
    public int Complexity;
    bool DangNext;
    public int NumberOfPlat;

    void Start()
    {
        DangNext = false;
        Generate();

    }

    void Generate()
    {

        Vector3 checker = new Vector3(0, 0, 0);
        Vector3[] platArr = new Vector3[NumberOfPlat];
        platArr[0] = new Vector3(0,0,0);

        for (int i = 1; i < platArr.Length; i++)
        {

            platArr[i] = new Vector3(Random.Range(-2.5f, 2.5f), platArr[i-1].y + Random.Range(0.5f, 2.0f), 0f);

        }

        for (int i = 0; i < NumberOfPlat-2; i++)
        {

            if (platArr[i + 2].y - platArr[i].y > 3.4f)
            {
                Instantiate(PJPlatform, this.transform.position + platArr[i], Quaternion.identity);
            }
            else
                Instantiate(PlatForm, this.transform.position + platArr[i], Quaternion.identity);
        }


        checker.y = this.transform.position.y + platArr[NumberOfPlat / 2].y;
        
        Instantiate(Checker, checker, Quaternion.identity);


























        //    Vector3 pprev = new Vector3(0, 0, 0);
        //    Vector3 prevPos = new Vector3(0, 0, 0);
        //    Vector3 curPos = new Vector3(0, 0, 0);
        //    Vector3 startPos = new Vector3(0, 0, 0);
        //    Vector3 checkPos = new Vector3(0, 0, 0);






        //    for (int i = 0; i < NumberOfPlat; i++)
        //    {



        //        if ((Random.Range(1, 10) > Complexity) || (DangNext == false))
        //        {
        //            curPos = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(0.5f, 2.0f), 0f);
        //            startPos.y += curPos.y;
        //            startPos.x = curPos.x;
        //            Instantiate(PlatForm, this.transform.position + startPos, Quaternion.identity);
        //            DangNext = true;

        //        }
        //        else
        //        {
        //            if (prevPos.x > 0.0f)
        //            {
        //                curPos = new Vector3(Random.Range(-0.5f, -2.5f), Random.Range(0.5f, 2.0f), 0f);
        //                startPos.y += curPos.y;
        //                startPos.x = curPos.x;
        //            }
        //            else
        //            {
        //                curPos = new Vector3(Random.Range(0.5f, 2.0f), Random.Range(0.5f, 2.0f), 0f);
        //                startPos.y += curPos.y;
        //                startPos.x = curPos.x;
        //            }
        //            Instantiate(DangPlatform, this.transform.position + startPos, Quaternion.identity);
        //            DangNext = false;

        //        }

        //        prevPos = curPos;
        //    }


        //    checkPos.y = startPos.y + -5;

        //    Instantiate(Checker, this.transform.position + checkPos, Quaternion.identity);
        //}

    }
}
