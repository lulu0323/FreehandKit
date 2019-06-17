using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBehaviourCommand : ICommand
{
    private GameObject gameObject;
    private IColorBehavior colorBehavior = new OriginalColor();

    public ColorBehaviourCommand(GameObject gameObject, IColorBehavior colorBehavior)
    {
        this.gameObject = gameObject;
        this.colorBehavior = colorBehavior;
    }

    public void execute()
    {
        colorBehavior.switchColor(gameObject);
    }
}