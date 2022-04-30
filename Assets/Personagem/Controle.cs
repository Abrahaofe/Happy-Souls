using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controle : MonoBehaviour
{
    [SerializeField]
    private float vel = 6, velRot = 100;

    [SerializeField]
    private Animator heroiAnim;

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis("Vertical") * vel;
        float rotacao = Input.GetAxis("Horizontal") * velRot;

        move *= Time.deltaTime;
        rotacao *= Time.deltaTime;

        transform.Rotate(0, rotacao, 0);

        if(move != 0)
        {
            heroiAnim.SetBool("Andar", true);
        }
        else
        {
            heroiAnim.SetBool("Andar", false);
        }

    }
}
