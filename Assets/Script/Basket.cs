using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Basket : MonoBehaviour
{
    [Header("Set Dynamically")]
    public Text scoreGT;
    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        scoreGT = scoreGO.GetComponent<Text>();
        scoreGT.text = "0";
        
    }

    // Update is called once per frame
    void Update()
    {
        //position of mouse
        Vector3 mousePos2D = Input.mousePosition;

        //z position of Camera sets how far mouse is
        mousePos2D.z = -Camera.main.transform.position.z;

        //convert 2D to 3D
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);

        //move basket to the position of the mouse
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    private void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if (collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);
            int score = int.Parse(scoreGT.text);
            score += 100;
            //converts score total to string and displays it
            scoreGT.text=score.ToString()
        }
    }
}
