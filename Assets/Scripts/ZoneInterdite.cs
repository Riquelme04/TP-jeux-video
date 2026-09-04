using UnityEngine;

public class ZoneInterdite : MonoBehaviour
{
    [SerializeField] private Transform pointDepart;

    private void OnTriggerEnter2D(Collider2D autre)
    {
        if (pointDepart == null)
        {
            return; Debug.LogError("Le point de départ n'est pas assigné.");
        }
        if (!autre.CompareTag("Player"))
                return; autre.transform.position = pointDepart.position;
            Debug.Log("Le robot retourne au point de départ.");

        // TODO : filtrer l'objet touché.
        // TODO : empêcher le déplacement si PointDepart est absent.
        // TODO : retourner le joueur à sa position initiale.
    }

    /*
     * BANQUE DE LIGNES — GROUPE B
     * La ligne return; doit être utilisée aux deux endroits appropriés.
     *
     * if (pointDepart == null)
     * autre.transform.position = pointDepart.position;
     * return;
     * if (!autre.CompareTag("Player"))
     * Debug.Log("Le robot retourne au point de départ.");
     * Debug.LogError("Le point de départ n'est pas assigné.");
     */
}
