using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICommand
{
    void execute();
}

public class NoCommand : ICommand
{
    public void execute() { }
}

public class RemoteControl : MonoBehaviour
{
    private GameObject m_gameObject;
    private Vector3 originalScale;
    private ICommand command = new NoCommand();

    void Start()
    {
        DetectionManager.Get().getCurrentObject += GetCurrentObject;
    }

    public void GetCurrentObject(GameObject currentObject)
    {
        if (currentObject != null)
        {
            this.m_gameObject = currentObject;
            this.originalScale = m_gameObject.transform.localScale;
        }
    }

    //MENU COMMAND
    public void OpenMenuCommand()
    {
        if (m_gameObject != null)
        {
            command = new OpenMenuCommand(m_gameObject);
            command.execute();
        }
        else { Debug.Log("WE DONOT HAVE A OBJECT."); }
    }

    public void CloseMenuCommand()
    {
        if (m_gameObject != null)
        {
            command = new CloseMenuCommand(m_gameObject);
            command.execute();
        }
        else { Debug.Log("WE DONOT HAVE A OBJECT."); }
    }

    //COLOR COMMAND
    public void RedColorCommand()
    {
        if (m_gameObject != null)
        {
            command = new ColorBehaviourCommand(m_gameObject, new RedColor());
            command.execute();
        }
        else { Debug.Log("WE DONOT HAVE A OBJECT."); }
    }

    public void BlueColorCommand()
    {
        if (m_gameObject != null)
        {
            command = new ColorBehaviourCommand(m_gameObject, new BlueColor());
            command.execute();
        }
        else { Debug.Log("WE DONOT HAVE A OBJECT."); }
    }

    public void GreenColorCommand()
    {
        if (m_gameObject != null)
        {
            command = new ColorBehaviourCommand(m_gameObject, new GreenColor());
            command.execute();
        }
        else { Debug.Log("WE DONOT HAVE A OBJECT."); }
    }

    //SIZE COMMAND
    public void OriginalSizeCommand()
    {
        if (m_gameObject != null)
        {
            command = new SizeBehaviourCommand(m_gameObject, originalScale, new OriginalSize());
            command.execute();
        }
        else { Debug.Log("WE DONOT HAVE A OBJECT."); }
    }

    public void SmallSizeCommand()
    {
        if (m_gameObject != null)
        {
            command = new SizeBehaviourCommand(m_gameObject, originalScale, new SmallSize());
            command.execute();
        }
        else { Debug.Log("WE DONOT HAVE A OBJECT."); }
    }

    public void LargeSizeCommand()
    {
        if (m_gameObject != null)
        {
            command = new SizeBehaviourCommand(m_gameObject, originalScale, new LargeSize());
            command.execute();
        }
        else { Debug.Log("WE DONOT HAVE A OBJECT."); }
    }

}
