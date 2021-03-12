using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    bool walking = false;
    public GameObject cauldron,win;
    Vector3 spawnpoint;
    // Start is called before the first frame update
    void Start()
    {
        win.SetActive(false);
        spawnpoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(walking)
        {
            transform.position = transform.position + Camera.main.transform.forward*1.0f*Time.deltaTime;
        }
        if (transform.position.y < -10f)
        {
            transform.position = spawnpoint;
        }
        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0.5f));
        RaycastHit hit;
        if(Physics.Raycast(ray,out hit))
        {
            if (hit.collider.tag.Contains("floor"))
            {
                walking = false;
            }
            else
                walking = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag== "Cauldron")
        {
            Destroy(cauldron.gameObject);
            Debug.Log("Find the Exit......... ");
        }
        if (other.gameObject.tag == "Fireball")
        {
            Destroy(other.gameObject);
            Debug.Log("Find the Exit......... ");
        }

        if (other.gameObject.name == "all")
        { win.SetActive(true); }
            
    }
}
