using Unity.VisualScripting;
using UnityEngine;

public class MouseCheck : MonoBehaviour
{
    private float _distance = Mathf.Infinity;
    [SerializeField] private LayerMask _rayLayer;
    [SerializeField] private GameObject _tower;

    [SerializeField] private GameObject _coolTower;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //create a ray cast and set it to the mouses cursor position in game
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, _distance, _rayLayer))
            {
                
                Instantiate(_tower, hit.transform.position, Quaternion.identity);

                Debug.DrawLine(ray.origin, hit.point);
                Debug.Log(hit.point);

            }
        }
    }

    public void PlaceCoolTower(GameObject _tower){
        _tower = _coolTower;
    }
}
