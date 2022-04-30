using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    [SerializeField]
    private Vector3 offset;

    [Range(0,1)]
    public float suavidade = 0.2f;
    public Transform jogador;

    // Update is called once per frame
    void fixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, jogador.position + offset, suavidade);
        transform.LookAt(jogador);
    }
}
