using UnityEngine;

public class Player_Movimiento : MonoBehaviour
{
    public float VelocidadMaxima;
    public float LimiteGiro;
    public float GiroY;
    public float MovZ;


    public float VelocidadActual;
    public float Aceleracion = 8f;
    public float VelocidadMax = 20f;
    public float Desaceleracion = 10f;

    public float PlacaVelocidad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Acelerar_Y_Girar();
    }

    public void Acelerar_y_Frenar()
    {
        GiroY = Input.GetAxis("Horizontal");
        MovZ = Input.GetAxis("Vertical");

        Vector3 mov = new Vector3(0, 0, MovZ);
        transform.Translate(mov * VelocidadMaxima * Time.deltaTime);

        if (MovZ < 0 || MovZ > 0)
        {
            Vector3 direccion = new Vector3(0, GiroY, 0);
            transform.Rotate(direccion * LimiteGiro * Time.deltaTime);
        }
    }

    public void Acelerar_Y_Girar()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        bool Acelerando = Input.GetKey(KeyCode.X);

        if(Acelerando)
        {
            VelocidadActual += Aceleracion * Time.deltaTime;
            VelocidadActual = Mathf.Clamp(VelocidadActual, 0f, VelocidadMax);
        }
        else
        {
            VelocidadActual -= Desaceleracion * Time.deltaTime;
            VelocidadActual = Mathf.Clamp(VelocidadActual, 0f, VelocidadMax);
        }

        if(VelocidadActual < 0 || VelocidadActual > 0)
        {
            transform.Translate(Vector3.forward * VelocidadActual * Time.deltaTime);
            transform.Rotate(Vector3.up * Horizontal * LimiteGiro * Time.deltaTime);
        }
        
    }

}
