
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public int WallCount;
    public int RandRange;
    public float DistanceBetween;
    public GameObject Wall;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < WallCount; i++) 
        {
            Vector3 pos = this.transform.position;
            pos.z += DistanceBetween * i;
            pos.x += Random.Range(-RandRange, RandRange);
            //creating a random range of distance
            var newBlock = Instantiate(Wall, pos, this.transform.rotation);    
            newBlock.transform.parent = this.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
