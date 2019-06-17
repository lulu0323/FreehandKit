using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IColorBehavior
{
    void switchColor(GameObject gameObject);
}

public class OriginalColor : IColorBehavior
{
    //private GameObject gameObject;

    public void switchColor(GameObject gameObject)
    {
        return;
    }
}

public class RedColor : IColorBehavior
{
    //private GameObject gameObject;

    public void switchColor(GameObject gameObject)
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = Color.red;
    }
}

public class BlueColor : IColorBehavior
{
    //private GameObject gameObject;

    public void switchColor(GameObject gameObject)
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = Color.blue;
    }
}

public class GreenColor : IColorBehavior
{
    //private GameObject gameObject;

    public void switchColor(GameObject gameObject)
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
        rend.material.color = Color.green;
    }
}