using System.Collections;
using System.Collections.Generic;
using UnityEngine;

enum RobotStates { Counting, Inspecting}

public class GorillaLook : MonoBehaviour
{
    [SerializeField] public float startInspectionTime;
    [SerializeField] private AudioSource jingleSource;

    private float currentInspectionTime;
    private RobotStates currentState = RobotStates.Counting;

    private Animator animator;
    
    private Mover player;

	private void Awake()
	{
    }

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Mover>();
        jingleSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        currentInspectionTime = startInspectionTime;
    }

    // Update is called once per frame
    void Update()
    {       
        StateMachine();               
    }
    private void StateMachine()
	{
        switch (currentState)
		{
            case RobotStates.Counting:
                Count();
                break;
            case RobotStates.Inspecting:
                Inspect();
                break;
            default:
                break;
		}
	}


    private void Count()
	{
        if (!jingleSource.isPlaying)
		{
            animator.SetTrigger("Look");
            currentState = RobotStates.Inspecting;
        }
    }

    private void Inspect()
	{
        if(currentInspectionTime > 0)
		{
            currentInspectionTime -= Time.deltaTime;

			if (player.IsMoving())
			{
                player.Die();
			}
		}
		else
		{
            currentInspectionTime = startInspectionTime;
            animator.SetTrigger("Look");

            jingleSource.Play();
            currentState = RobotStates.Counting;
		}
	}
}
