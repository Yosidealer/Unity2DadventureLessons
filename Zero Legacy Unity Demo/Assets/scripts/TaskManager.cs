using UnityEngine;

public class TaskManager : MonoBehaviour
{
    public task[] tasks;
    public bool allDone = false;

    void Update()
    {
        allDone = true;

        foreach (task t in tasks)
        {
            if (!t.done)
            {
                allDone = false;
            }
        }
    }
}