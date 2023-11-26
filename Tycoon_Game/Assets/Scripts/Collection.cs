using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collection : MonoBehaviour
{
    //if player is close enough to crates/money, they dissapear and player earns points

    private int Points;
    [SerializeField] private Text pointsText;


    private void OnCollisionEnter(Collision collision)
    {
        GameObject.Destroy(collision.gameObject);
        GameObject.Find("Conveyor").GetComponent<Conveyor>().onConveyor.Remove(collision.gameObject);
        Points += 1;
    }

    private void Update()
    {
        pointsText.text = ("Points: " + Points);
    }





}
