using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalScript : MonoBehaviour
{
    [SerializeField] private GameObject Portal;
    private bool activatePortal = true;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            portalActivate();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            portalDesactivate();
        }
    }

    private void portalActivate()
    {
        Debug.Log("Anda");
        Portal.SetActive(true);
        activatePortal = true;
    }

    private void portalDesactivate()
    {
        Portal.SetActive(false);
        activatePortal = false;
    }
}
