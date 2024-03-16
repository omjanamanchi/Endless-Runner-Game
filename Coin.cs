using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Coin : MonoBehaviour
{

    [SerializeField] float turnSpeed = 90f;
    private GameObject player; 
    private GameManager inst;
    


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        inst = player.GetComponent<GameManager>();
    }


    private void OnTriggerEnter(Collider other)
    {
        
        if(other.gameObject.GetComponent<Obstacle>() != null)
        {
            Destroy(gameObject);
            return;
        }
        
        
        if(other.gameObject.name != "Player")
        {
            return;
        }

        Destroy(gameObject); 
        inst.increasePoints();
       
    }
    
    

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, turnSpeed * Time.deltaTime);
    }
}
