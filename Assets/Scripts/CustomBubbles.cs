using UnityEngine;

public class CustomBubbles : MonoBehaviour
{
    [Tooltip("The object that will be spawned")]
    public GameObject prefab = null;
    [Tooltip("The Transform where the object is spawned")]
    public Transform spawnTransform = null;
    public void Spawn(){
        GameObject bubble = Instantiate(prefab, spawnTransform.position, spawnTransform.rotation);
        bubble.transform.rotation = Random.rotation;
        float launchSpeed = Random.Range(0.5f, 1.5f);
        Vector3 force = spawnTransform.forward * launchSpeed;
        bubble.GetComponent<Rigidbody>().AddForce(force);
        bubble.GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)));
    
    }



}