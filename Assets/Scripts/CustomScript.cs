using UnityEngine;

public class CustomScript : MonoBehaviour
{
    [Tooltip("The object that will be spawned")]
    public GameObject prefab = null;
    [Tooltip("The Transform where the object is spawned")]
    public Transform spawnTransform = null;
    public void Spawn(){
        GameObject customSpawn1 = Instantiate(prefab, spawnTransform.position, spawnTransform.rotation);
        GameObject customSpawn2 = Instantiate(prefab, spawnTransform.position, spawnTransform.rotation);
        GameObject customSpawn3 = Instantiate(prefab, spawnTransform.position, spawnTransform.rotation);
        customSpawn1.transform.rotation = Random.rotation;
        customSpawn2.transform.rotation = Random.rotation;
        customSpawn3.transform.rotation = Random.rotation;

        float launchSpeed = Random.Range(0.5f, 1.5f);
        // Vector3 force = spawnTransform.forward * launchSpeed;
        Vector3 randomForce1 = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), 1f);
        Vector3 randomForce2 = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), 1f);
        Vector3 randomForce3 = new Vector3(Random.Range(-0.1f, 0.1f), Random.Range(-0.1f, 0.1f), 1f);

        customSpawn1.GetComponent<Rigidbody>().AddForce(randomForce1);
        customSpawn1.GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)));
        
        customSpawn2.GetComponent<Rigidbody>().AddForce(randomForce2);
        customSpawn2.GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)));
        
        customSpawn3.GetComponent<Rigidbody>().AddForce(randomForce3);
        customSpawn3.GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)));
    
    }



}