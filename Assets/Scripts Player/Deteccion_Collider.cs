using UnityEngine;

public class Deteccion_Collider : MonoBehaviour
{
    public bool Carro = false;

    public GameObject Punto_Explosion;
    public GameObject Particula_Craneo;

    public GameObject RespawnPlayer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RecibirImpacto(string ParteGolpeada, GameObject ObjetoGolpeado)
    {
        if (Carro) return;
        Debug.Log("Golpe en:" + ParteGolpeada);

        if(ObjetoGolpeado.CompareTag("Explosion"))
        {
            if(ParteGolpeada == "Parachoques")
            {
                ReiniciarPlayer();
                Explotar();
            }
        }

        if(ObjetoGolpeado.CompareTag("Terreno"))
        {
            if(ParteGolpeada == "Cuerpo")
            {
                ReiniciarPlayer();
                Explotar();
            }
        }
    }

    public void Explotar()
    {
        Debug.Log("El Carro Exploto");

        Instantiate(Particula_Craneo, Punto_Explosion.transform.position, Punto_Explosion.transform.rotation);
    }

    public void ReiniciarPlayer()
    {
        RespawnPlayer.SetActive(false);
    }
}
