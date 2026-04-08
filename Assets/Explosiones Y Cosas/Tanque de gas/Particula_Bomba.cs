using UnityEngine;

public class Particula_Bomba : MonoBehaviour
{
    public GameObject Particula_Bomb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Parachoques")
        {
            Instantiate(Particula_Bomb, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
