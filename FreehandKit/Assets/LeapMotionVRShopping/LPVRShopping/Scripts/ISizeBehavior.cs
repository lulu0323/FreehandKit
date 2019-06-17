using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISizeBehavior
{
    void switchSize(GameObject gameObject, Vector3 originalScale);
}

public class OriginalSize : ISizeBehavior
{
    //private GameObject gameObject;

    public void switchSize(GameObject gameObject, Vector3 originalScale)
    {
        gameObject.transform.localScale = originalScale * 1f;
    }
}

public class SmallSize : ISizeBehavior
{
    //private GameObject gameObject;

    public void switchSize(GameObject gameObject, Vector3 originalScale)
    {
        gameObject.transform.localScale = originalScale * 0.5f;
    }
}

public class LargeSize : ISizeBehavior
{
    //private GameObject gameObject;

    public void switchSize(GameObject gameObject, Vector3 originalScale)
    {
        gameObject.transform.localScale = originalScale * 1.5f;
    }
}
