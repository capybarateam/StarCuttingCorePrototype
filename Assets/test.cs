using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BLINDED_AM_ME;

public class test : MonoBehaviour
{

    public Material capMaterial;

    bool isCut = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButtonDown(1))
        //{
        //    Debug.Log("Click");
        //    RaycastHit hit;

        //    if (Physics.Raycast(transform.position, transform.up, out hit))
        //    {
        //        Debug.Log("Hit");
        //        GameObject[] pieces = MeshCut.Cut(hit.collider.gameObject, transform.position, transform.up, capMaterial);

        //        if (!pieces[1].GetComponent<Rigidbody>())
        //            pieces[1].AddComponent<Rigidbody>();
        //        Destroy(pieces[1], 1);
        //    }

        //}
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isCut)
        {
            isCut = true;
            GameObject[] pieces = MeshCut.Cut(other.gameObject, transform.position, transform.up, capMaterial);

            if (!pieces[1].GetComponent<Rigidbody>())
                pieces[1].AddComponent<Rigidbody>();
            Destroy(pieces[1], 1);
        }
    }
}
