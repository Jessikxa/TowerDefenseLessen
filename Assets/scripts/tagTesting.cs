using UnityEngine;

public class tagTesting : MonoBehaviour
{
    [SerializeField] private GameObject[] allObjects;
    void Start()
    {
        allObjects = GameObject.FindGameObjectsWithTag("Tower");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
