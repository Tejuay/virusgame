using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public MachineTimer[] objectiveTimerSpeed;

    void Start()
    {
        objectiveTimerSpeed = FindObjectsByType<MachineTimer>(FindObjectsSortMode.None);
        StartCoroutine(RandomNegativeEvent());
        StartCoroutine(RandomNegativeEvent2());
    }

    IEnumerator RandomNegativeEvent()
    {
        while(true)
        {
            yield return new WaitForSeconds(10f);

            //Selecting faster drain vs. instant damage event
            int randomEvent = 0;
            randomEvent = UnityEngine.Random.Range(1, 3);

            switch (randomEvent)
            {
                // faster drain event
                case 1:
                    int randomObjective = 0;
                    randomObjective = UnityEngine.Random.Range(1, 6);
                
                    switch (randomObjective)
                    {
                        case 1:
                            objectiveTimerSpeed[0].speed = objectiveTimerSpeed[0].speed * 2;
                            objectiveTimerSpeed[0].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(15f);
                            objectiveTimerSpeed[0].speed = objectiveTimerSpeed[0].speed / 2;
                            objectiveTimerSpeed[0].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;

                        case 2:
                            objectiveTimerSpeed[1].speed = objectiveTimerSpeed[1].speed * 2;
                            objectiveTimerSpeed[1].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(15f);
                            objectiveTimerSpeed[1].speed = objectiveTimerSpeed[1].speed / 2;
                            objectiveTimerSpeed[1].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;
                        
                        case 3:
                            objectiveTimerSpeed[2].speed = objectiveTimerSpeed[2].speed * 2;
                            objectiveTimerSpeed[2].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(15f);
                            objectiveTimerSpeed[2].speed = objectiveTimerSpeed[2].speed / 2;
                            objectiveTimerSpeed[2].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;
                        
                        case 4:
                            objectiveTimerSpeed[3].speed = objectiveTimerSpeed[3].speed * 2;
                            objectiveTimerSpeed[3].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(15f);
                            objectiveTimerSpeed[3].speed = objectiveTimerSpeed[3].speed / 2;
                            objectiveTimerSpeed[3].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;

                        case 5:
                            objectiveTimerSpeed[4].speed = objectiveTimerSpeed[4].speed * 2;
                            objectiveTimerSpeed[4].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(15f);
                            objectiveTimerSpeed[4].speed = objectiveTimerSpeed[4].speed / 2;
                            objectiveTimerSpeed[4].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;
                    }
                    break;

                // instant damage event
                case 2:
                    randomObjective = UnityEngine.Random.Range(1, 6);
                
                    switch (randomObjective)
                    {
                        case 1:
                            objectiveTimerSpeed[0].currentTimer = objectiveTimerSpeed[0].currentTimer - 20f;
                            objectiveTimerSpeed[0].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(10f);
                            objectiveTimerSpeed[0].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;

                        case 2:
                            objectiveTimerSpeed[1].currentTimer = objectiveTimerSpeed[1].currentTimer - 20f;
                            objectiveTimerSpeed[1].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(10f);
                            objectiveTimerSpeed[1].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;
                        
                        case 3:
                            objectiveTimerSpeed[2].currentTimer = objectiveTimerSpeed[2].currentTimer - 20f;
                            objectiveTimerSpeed[2].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(10f);
                            objectiveTimerSpeed[2].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;
                        
                        case 4:
                            objectiveTimerSpeed[3].currentTimer = objectiveTimerSpeed[3].currentTimer - 20f;
                            objectiveTimerSpeed[3].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(10f);
                            objectiveTimerSpeed[3].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;

                        case 5:
                            objectiveTimerSpeed[4].currentTimer = objectiveTimerSpeed[4].currentTimer - 20f;
                            objectiveTimerSpeed[4].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(10f);
                            objectiveTimerSpeed[4].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;
                    }
                    break;
            }
        }
    }


    IEnumerator RandomNegativeEvent2()
    {
        while(true)
        {
            yield return new WaitForSeconds(3f);

            //Selecting faster drain vs. instant damage event
            int randomEvent = 0;
            randomEvent = UnityEngine.Random.Range(1, 3);

            switch (randomEvent)
            {
                // faster drain event
                case 1:
                    int randomObjective = 0;
                    randomObjective = UnityEngine.Random.Range(1, 6);
                
                    switch (randomObjective)
                    {
                        case 1:
                            objectiveTimerSpeed[0].speed = objectiveTimerSpeed[0].speed * 1.5f;
                            objectiveTimerSpeed[0].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(7.5f);
                            objectiveTimerSpeed[0].speed = objectiveTimerSpeed[0].speed / 1.5f;
                            objectiveTimerSpeed[0].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;

                        case 2:
                            objectiveTimerSpeed[1].speed = objectiveTimerSpeed[1].speed * 1.5f;
                            objectiveTimerSpeed[1].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(7.5f);
                            objectiveTimerSpeed[1].speed = objectiveTimerSpeed[1].speed / 1.5f;
                            objectiveTimerSpeed[1].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;
                        
                        case 3:
                            objectiveTimerSpeed[2].speed = objectiveTimerSpeed[2].speed * 1.5f;
                            objectiveTimerSpeed[2].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(7.5f);
                            objectiveTimerSpeed[2].speed = objectiveTimerSpeed[2].speed / 1.5f;
                            objectiveTimerSpeed[2].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;
                        
                        case 4:
                            objectiveTimerSpeed[3].speed = objectiveTimerSpeed[3].speed * 1.5f;
                            objectiveTimerSpeed[3].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(7.5f);
                            objectiveTimerSpeed[3].speed = objectiveTimerSpeed[3].speed / 1.5f;
                            objectiveTimerSpeed[3].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;

                        case 5:
                            objectiveTimerSpeed[4].speed = objectiveTimerSpeed[4].speed * 1.5f;
                            objectiveTimerSpeed[4].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(7.5f);
                            objectiveTimerSpeed[4].speed = objectiveTimerSpeed[4].speed / 1.5f;
                            objectiveTimerSpeed[4].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;
                    }
                    break;

                // instant damage event
                case 2:
                    randomObjective = UnityEngine.Random.Range(1, 6);
                
                    switch (randomObjective)
                    {
                        case 1:
                            objectiveTimerSpeed[0].currentTimer = objectiveTimerSpeed[0].currentTimer - 10f;
                            objectiveTimerSpeed[0].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(3f);
                            objectiveTimerSpeed[0].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;

                        case 2:
                            objectiveTimerSpeed[1].currentTimer = objectiveTimerSpeed[1].currentTimer - 10f;
                            objectiveTimerSpeed[1].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(3f);
                            objectiveTimerSpeed[1].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;
                        
                        case 3:
                            objectiveTimerSpeed[2].currentTimer = objectiveTimerSpeed[2].currentTimer - 10f;
                            objectiveTimerSpeed[2].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(3f);
                            objectiveTimerSpeed[2].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;
                        
                        case 4:
                            objectiveTimerSpeed[3].currentTimer = objectiveTimerSpeed[3].currentTimer - 10f;
                            objectiveTimerSpeed[3].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(3f);
                            objectiveTimerSpeed[3].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;

                        case 5:
                            objectiveTimerSpeed[4].currentTimer = objectiveTimerSpeed[4].currentTimer - 10f;
                            objectiveTimerSpeed[4].gameObject.GetComponent<SpriteRenderer>().color = Color.red;
                            yield return new WaitForSeconds(3f);
                            objectiveTimerSpeed[4].gameObject.GetComponent<SpriteRenderer>().color = Color.white;
                            break;
                    }
                    break;
            }
        }
    }
}
