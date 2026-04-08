using UnityEngine;

public class Colisiones_VIda_InteraccionesObjetos : MonoBehaviour
{
    public GameObject Explosion;
    public GameObject Punto_Explosion;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Explosion")
        {
            Destroy(collision.transform.gameObject);
            

            Instantiate(Explosion, Punto_Explosion.transform.position, Punto_Explosion.transform.rotation);
        }
    }
}
