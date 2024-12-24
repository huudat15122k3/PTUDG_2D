using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenepersist : MonoBehaviour
{
    void Awake()
    {
        // 1. Ki?m tra xem c� bao nhi�u phi�n b?n GameSession ?ang t?n t?i trong c?nh (scene).
        int numScenePersist = FindObjectsOfType<Scenepersist>().Length;
        // 2. N?u ?� c� h?n 1 GameSession (khi quay l?i m?t scene kh�c ho?c reload scene), th� ph� h?y ??i t??ng hi?n t?i.
        if (numScenePersist > 1)
        {
            Destroy(gameObject);// H?y ??i t??ng hi?n t?i v� ?� c� GameSession kh�c t?n t?i.
        }
        else
        {
            // 3. N?u kh�ng c� GameSession kh�c, ??i t??ng n�y s? ???c gi? l?i khi t?i m�n ch?i m?i.
            DontDestroyOnLoad(gameObject);
        }
    }

    public void ResetScenePersist()
    {
        Destroy(gameObject);
    }
}
