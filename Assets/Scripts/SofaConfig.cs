using System.Collections.Generic;
using UnityEngine;


public class SofaConfig : MonoBehaviour
{

    [SerializeField]
    GameObject Model;
    [SerializeField]
    List<GameObject> Parts;


    public void SetMaterial(Material mat)
    {
        gameObject.GetComponent<MeshRenderer>().material = mat;
    }


    public void ChangeMaterial(Material mat)
    {
        foreach (GameObject part in Parts)
        {
            if (part != null)
            {
                part.GetComponent<SkinnedMeshRenderer>().material = mat;
            }
        }
    }


    public GameObject FindObject(GameObject parent, string name)
    {
        Transform[] trs = parent.GetComponentsInChildren<Transform>(true);
        foreach (Transform t in trs)
        {
            if (t.name == name)
            {
                return t.gameObject;
            }
        }
        return null;
    }

}
