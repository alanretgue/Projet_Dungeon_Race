using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnPLayer : MonoBehaviour
{
    [SerializeField] private Transform player;
    public Transform RespawnPos;

    // Ce script doit être appliqué sur un objet joueur mais pour fonctionner il nécessite la création d'un objet checkpoint

    private void OnCollisionEnter(Collision collision)
    {
        //Pour l'instant inutile
        if (collision.gameObject.layer == LayerMask.NameToLayer("DeadZone"))
        {
            player.transform.position = RespawnPos.position;
            player.transform.rotation = RespawnPos.rotation;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Déplace le joueur sans le détruire au dernier point de réapparition
        if (other.gameObject.layer == LayerMask.NameToLayer("DeadZone"))
        {
            player.transform.position = RespawnPos.position;
            player.transform.rotation = RespawnPos.rotation;
        }
        // Applique un nouveau point de réapparition à chaque checkpoint
        if (other.gameObject.layer == LayerMask.NameToLayer("checkpoint"))
        {
            RespawnPos = other.gameObject.transform;
        }
    }
}
