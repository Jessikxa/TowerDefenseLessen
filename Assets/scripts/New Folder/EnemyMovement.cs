using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float Speed = 5f;
    private Transform _target;
    private int wavePointIndex = 0;
    void Start()
    {

        if (WaypointsHandler.Waypoints == null || WaypointsHandler.Waypoints.Count == 0)
        {
            Debug.LogError("No waypoints found in WaypointsHandler");
            _target = null;
            enabled = false;
            return;
        }

        _target = WaypointsHandler.Waypoints[wavePointIndex];

        Debug.Log($"starting enemy at waypoint 0: {WaypointsHandler.Waypoints[0].name}");

        
    }

    // Update is called once per frame
    void Update()
    {
        if(_target == null)
        {
            Debug.LogError("Target is null");
            return;
        }

        Vector3 dir = _target.position - transform.position;

        transform.Translate(dir.normalized * Speed * Time.deltaTime, Space.World);

        if(Vector3.Distance(transform.position, _target.position) < 0.1f)
        {
            Debug.Log("Reached waypoint!");
            GetNextWayPoint();
        }
    }

    void GetNextWayPoint()
    {
        if (wavePointIndex >= WaypointsHandler.Waypoints.Count - 1)
        {
            Debug.Log("reached end of path, destroying enemy");
            Destroy(gameObject);
            return;

           
        }
        wavePointIndex++;
        _target = WaypointsHandler.Waypoints[wavePointIndex];
    }
}
