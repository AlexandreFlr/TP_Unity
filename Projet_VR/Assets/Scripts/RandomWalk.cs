using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI ;

public class RandomWalk : MonoBehaviour
{
    public float mrange = 25.0f ;
    Vector2 lastPos ;
    UnityEngine.AI.NavMeshAgent mAgent ;
    Vector2 randomPos ;

    // Start is called before the first frame update
    void Start()
    {
        mAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        if(mAgent.pathPending || mAgent.remainingDistance > 0.1f){
            return ;
        }
        randomPos = Random.insideUnitCircle*mrange ;
        if(randomPos == lastPos){
            randomPos = Random.insideUnitCircle*mrange ;
        }
        mAgent.destination = new Vector3(randomPos.x, 0, randomPos.y);
    }
}
