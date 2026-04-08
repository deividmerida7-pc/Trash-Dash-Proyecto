using UnityEngine;

public class Parte_Carro : MonoBehaviour
{
    public string NombreParte;
    public Deteccion_Collider Deteccion;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Deteccion = GetComponentInParent<Deteccion_Collider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(Deteccion != null)
        {
            Deteccion.RecibirImpacto(NombreParte, other.gameObject);
        }
    }
}
