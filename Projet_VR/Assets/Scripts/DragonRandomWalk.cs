using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonRandomWalk : MonoBehaviour
{

    public float mrange = 25.0f ;
    Terrain terrain ;
    Vector2 lastPos ;
    UnityEngine.AI.NavMeshAgent mAgent ;
    Vector2 randomPos ;

    // Start is called before the first frame update
    void Start()
    {
        mAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        terrain = Terrain.activeTerrain ;
    }

    // Update is called once per frame
    void Update()
    {
        if(mAgent.pathPending || mAgent.remainingDistance > 0.1f){
            return ;
        }
        // Génère une nouvelle destination aléatoire en coordonnées locales de la heightmap.
        float xLocal = Random.Range(0, terrain.terrainData.size.x);
        float zLocal = Random.Range(0, terrain.terrainData.size.z);
        float y = terrain.SampleHeight(new Vector3(xLocal, 0, zLocal));

        // Convertit les coordonnées locales en coordonnées mondiales.
        randomPos = terrain.transform.TransformPoint(new Vector3(xLocal, y, zLocal));

        // Applique la destination.
        mAgent.destination = randomPos;
    }
}
