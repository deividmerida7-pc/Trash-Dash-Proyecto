using UnityEngine;

public class Potenciadores_Herramientas : MonoBehaviour
{
    public bool GasCargado;
    public GameObject GasDrop;
    public GameObject TanqueGas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GasDrop == true)
        {
            if (Input.GetKeyDown(KeyCode.V))
            {
                Instantiate(TanqueGas, GasDrop.transform.position, GasDrop.transform.rotation);
                GasCargado = false;
            }

        }
    }
}
