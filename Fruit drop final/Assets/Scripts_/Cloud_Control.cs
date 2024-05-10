using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cloud_Control : MonoBehaviour
{
    public Transform[] fruitObj;
    static public string spawnedYet = "n";
    static public Vector2 cloudxPos;
    static public Vector2 spawnPos;
    static public string newfruit = "n";
    static public int whichFruit = 0;
    [SerializeField] Text ScoreTxt;
    int Score =0;
    void Update()
    {
        SpawnFruit();
        replaceFruit();

        if(Input.GetKey("a"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2 (-3, 0);
        }

        if(Input.GetKey("d"))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2 (3, 0);
        }

        if((!Input.GetKey("a")) && (!Input.GetKey("d")))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2 (0, 0);
        }

        cloudxPos = transform.position;

        if ((Input.GetKeyDown("space")) && (spawnedYet == "y"))
        {
            spawnedYet = "n";
        }
    }

    void SpawnFruit()
    {
        if(spawnedYet == "n")
        {
            StartCoroutine(spawntimer());
            spawnedYet = "w";
        }
    }

    void replaceFruit()
    {
        if(newfruit == "y")
        {
            if(whichFruit == 5)
            {
                Score += 5;
            }
            else
            {
                Score++;
            }
            ScoreTxt.text = "Score : " + Score;
            newfruit = "n";
            Instantiate(fruitObj[whichFruit+1], spawnPos, fruitObj[0].rotation);
        }
    }

    IEnumerator spawntimer()
    {
        yield return new WaitForSeconds(.75f);
        Instantiate(fruitObj[Random.Range(0, 3)], transform.position, fruitObj[0].rotation);
        spawnedYet = "y";
    }
}
