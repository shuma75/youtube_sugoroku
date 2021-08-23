using UnityEngine;


public class grid_connection : MonoBehaviour
{
    [SerializeField] int connection_number;
    public GameObject[] Station = new GameObject[4];
    [SerializeField] GameObject Arrow;
    public GameObject ArrowPrefab;

    private void OnValidate()
    {
        foreach (Transform Arrow_Destroy in transform) Destroy(Arrow_Destroy);
        int i;
        Debug.Log("呼ばれたよ");
        for (i = 0; i < connection_number; i++)
        {
            Vector3 station_potision = Station[i].transform.position;
            Arrow = Instantiate(ArrowPrefab, new Vector3(station_potision.x - transform.position.x, 0.8f, station_potision.z - transform.position.z),
                Quaternion.Euler(transform.eulerAngles.x, transform.eulerAngles.y, transform.eulerAngles.z));
            Arrow.transform.parent = this.transform;
        }
        
    }

}
