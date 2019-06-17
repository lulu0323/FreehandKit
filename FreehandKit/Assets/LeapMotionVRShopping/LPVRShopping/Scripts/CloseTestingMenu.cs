using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseTestingMenu : ICommand
{
    private GameObject m_object;
    private GameObject childObject;

    public CloseTestingMenu(GameObject ob1)
    {
        this.m_object = ob1;

        if (m_object.transform.GetChild(0).gameObject != null)
        {
            childObject = m_object.transform.GetChild(0).gameObject;
        }
    }

    public void execute()
    {
        if (childObject != null)
        {
            if (childObject.activeSelf)
            {
                childObject.SetActive(false);
            }
        }
    }
}
