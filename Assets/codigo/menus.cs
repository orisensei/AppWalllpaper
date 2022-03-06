using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menus : MonoBehaviour {


    public GameObject Panel;

    public void AbriPanel() {

        if(Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }

    }
}
