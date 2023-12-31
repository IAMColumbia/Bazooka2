using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

//used by the game manager to control enemy spawn
public class EnemySpawnManager : MonoBehaviour
{
    //the stats of the enemy that will be spawned
    EnemyInfo tempEnemyInfo;

    //the database of all enemy stats
    public List<EnemyInfo> enemyDatabase;

    //this is the spawned enemy
    GameObject tempGameObject;

    //this tracks all enemies the player hasn't seen yet, based on the enemy database
    List<string> listOfUnseenEnemiesInCurrentPlaythough;

    public void Start()
    {
        //create an enemy database that will be used by the spawn manager
        enemyDatabase = new EnemyDatabase().enemyDatabase;

        //create the list of enemies the player hasn't seen yet
        listOfUnseenEnemiesInCurrentPlaythough = new List<string>();

        //fill the list of enemies the player hasn't seen yet with info from the enemy database
        foreach(EnemyInfo enemy in enemyDatabase) {listOfUnseenEnemiesInCurrentPlaythough.Add(enemy.name);}


    }

    //used by a button to spawn an enemy the player hasn't seen yet at the location of an enemy spawn node
    public void SpawnEnemy(Vector3 position)
    {
        //stores info for an enemy the player hasn't seen yet
        tempEnemyInfo = enemyDatabase.First(enemy => listOfUnseenEnemiesInCurrentPlaythough.Contains(enemy.name));

        //load the appropriate enemy prefab based on the enemy name
        tempGameObject = LoadResource(tempEnemyInfo.name);

        //instantiate the prefab at the passed in position (an enemy spawn node)
        tempGameObject = Instantiate(tempGameObject, position, new Quaternion(0,0,0,0));

        //sets the name of the game object to the enemy's name in the database
        tempGameObject.name = tempEnemyInfo.name;

        //sets the health of the enemy from the database
        tempGameObject.GetComponent<EnemyBehavior>().health = tempEnemyInfo.HP;

        //sets the def of the enemy from the database (no use in this game, but it sets it)
        tempGameObject.GetComponent<EnemyBehavior>().DEF = tempEnemyInfo.DEF;

        //sets the MP of the enemy from the database (no use in this game, but it sets it)
        tempGameObject.GetComponent<EnemyBehavior>().MP = tempEnemyInfo.MP;

        //sets the def of the enemy from the database
        //(This is currently only used for the knight. It sets a value in the weapon database for the knight's weapon.)
        tempGameObject.GetComponent<EnemyBehavior>().AP = tempEnemyInfo.AP;

        //removes the spawned enemy from the list of enemies the player hasn't encountered this playthrough
        listOfUnseenEnemiesInCurrentPlaythough.Remove(tempEnemyInfo.name);

    }

    //used to quickly load an object as a game object
    public GameObject LoadResource(string name)
    {
        //loads an object in the resources folder as a game object
        return Resources.Load(name) as GameObject;
    }


}
