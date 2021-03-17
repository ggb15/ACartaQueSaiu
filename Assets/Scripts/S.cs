using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Update();
    }

    // Update is called once per frame
    void Update()
    {
        string[] baralho =
            {
"As Paus", "2 Paus", "3 Paus",  "4 Paus","5 Paus","6 Paus","7 Paus","8 Paus","9 Paus","10 Paus","Valete Paus","Dama Paus","Rei Paus", "As Ouros", "2 Ouros", "3 Ouros",  "4 Ouros","5 Ouros","6 Ouros","7 Ouros","8 Ouros","9 Ouros","10 Ouros","Valete Ouros","Dama Ouros","Rei Ouros",
"As Espadas", "2 Espadas", "3 Espadas",  "4 Espadas","5 Espadas","6 Espadas","7 Espadas","8 Espadas","9 Espadas","10 Espadas","Valete Espadas","Dama Espadas","Rei Espadas", "As Copas", "2 Copas", "3 Copas",  "4 Copas","5 Copas","6 Copas","7 Copas","8 Copas","9 Copas","10 Copas","Valete Copas","Dama Copas","Rei Copas"
            };
        Debug.Log("Clica no espaço para sair uma carta aletatória");

        while (Input.GetKeyDown("space"))
        {
            Debug.Log("A carta que saiu foi: " + baralho[Random.Range(1,53)]);
        };
    }
}
