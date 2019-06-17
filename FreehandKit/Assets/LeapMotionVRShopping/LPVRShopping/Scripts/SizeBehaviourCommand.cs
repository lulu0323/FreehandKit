using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeBehaviourCommand : ICommand
{
    private GameObject gameObject;
    private Vector3 originalScale;
    private ISizeBehavior sizeBehavior = new OriginalSize();

    public SizeBehaviourCommand(GameObject gameObject, Vector3 vector3, ISizeBehavior sizeBehavior)
    {
        this.gameObject = gameObject;
        this.originalScale = vector3;
        this.sizeBehavior = sizeBehavior;
    }

    public void execute()
    {
        sizeBehavior.switchSize(gameObject, originalScale);
    }
}
