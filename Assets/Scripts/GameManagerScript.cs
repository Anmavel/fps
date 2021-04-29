using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    private int points;
    [SerializeField] private Text value;
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private GameObject player;


    //Game Manager , da werden die Punkte gezählt
    public void SetPoints()
    {
        points++;
        value.text = points.ToString();
        Vector3 posSpawn = player.transform.position;
        posSpawn.z += Random.Range(5f, 20);
        posSpawn.x += Random.Range(-10f, 10);
        posSpawn.y+= 0.8f;
        Instantiate(enemyPrefab, posSpawn, Quaternion.identity);

    }


}
