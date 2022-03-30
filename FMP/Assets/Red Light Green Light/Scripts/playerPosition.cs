using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPosition : MonoBehaviour
{
    [SerializeField]
    public List<float> playerPositionList;

    public int maxPlayer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if(playerPositionList.Count == maxPlayer)
        {
            foreach(var x in playerPositionList)
            {
                Debug.Log(x.ToString());
            }
        }
        */
    }
}
