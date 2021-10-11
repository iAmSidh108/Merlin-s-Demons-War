using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Image playerImage = null;
    public Image frameImage = null;
    public Image healthNumberImage = null;
    public Image glowImage = null;

    public int health = 5;
    public int mana = 1;

    public bool isPlayer;
    public bool isFire; // whether an enemy is a fire monster or not

    public GameObject[] manaballs = new GameObject[5];

    private Animator animator = null;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();  
    }
    internal void PlayerHitAnim()
    {
        if (animator != null)
            animator.SetTrigger("Hit");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
