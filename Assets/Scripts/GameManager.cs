using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int numberOfCollectable = 0;
    public float timeRemaining = 20f;
    public UIManager uIManager;


    private void Awake()
    {
        uIManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>();
    }

    public void CollisionDetected(Collision collision,FPController player)
    {

        if (collision.gameObject.CompareTag("Collectable"))
        {
            Destroy(collision.gameObject);
            numberOfCollectable += 1;
            uIManager.ShowScore(numberOfCollectable);
        }
    }
    private void FixedUpdate()
    {
        if (timeRemaining <= 0.0f)
        {
            timeRemaining = 0;
            uIManager.ShowGameOver();
            uIManager.UpdateTime(timeRemaining);
        }
        else
        {
            timeRemaining -= Time.deltaTime;
            uIManager.UpdateTime(timeRemaining);
        }
    }

}
