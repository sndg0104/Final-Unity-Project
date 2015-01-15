using UnityEngine;
using System.Collections;

public class CoinCollision : MonoBehaviour {

    public int scoreValue = 1;

    void Start()
    {
    }
    
    private void OnCollisionEnter(Collision enemy)
    {
        Debug.Log(enemy.gameObject.name);
        if (enemy.gameObject.name == "Cylinder")
        {
            Destroy(enemy.gameObject);
            ScoreManager.score += scoreValue;
        }
        
    }
}
