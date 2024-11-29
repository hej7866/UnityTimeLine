using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAni : MonoBehaviour
{
    private Animator animator;
    public string boolName;


    void Start()
    {
        animator = GetComponent<Animator>();  
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            bool curr = animator.GetBool(boolName);
            animator.SetBool(boolName, !curr);
        }
    }
}

public class BoxAni : TestAni
{
    
}
