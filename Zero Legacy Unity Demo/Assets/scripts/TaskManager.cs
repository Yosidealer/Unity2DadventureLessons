using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public task[] tasks; // array of tasks to manage
    public bool allDone = false; // whether all tasks are done or not

    void Update()
    {
        allDone = true; // assume all tasks are done until we find one that is not

        foreach (task t in tasks) // loop through each task in the array
        {
            if (!t.done) // if the task is not done
            {
                allDone = false; // set allDone to false and break out of the loop
            }
        }
    }
}