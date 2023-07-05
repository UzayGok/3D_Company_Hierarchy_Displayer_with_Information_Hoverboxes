using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSphere : MonoBehaviour
{
    public Node node;

    public ClickSphere(Node node)
    {
        this.node = node;
    }

    public void Outline()
    {
        node.sphere.GetComponent<Outline>().enabled = true;

        Node previous = node;
        while (previous.previous != null)
        {
            previous.leadingEdge.GetComponent<Outline>().enabled = true;
            if (previous.previous.sphere.GetComponent<Outline>().enabled != false)
                break;
            previous = previous.previous;
            previous.sphere.GetComponent<Outline>().enabled = true;
        }
        foreach (Node n in node.children)
            n.clickSphere.GetComponent<ClickSphere>().OutlineChildrenRec();
    }

    void OutlineChildrenRec()
    {
        foreach (Node n in node.children)
        {
            n.clickSphere.GetComponent<ClickSphere>().OutlineChildrenRec();
        }
        node.sphere.GetComponent<Outline>().enabled = true;
        node.leadingEdge.GetComponent<Outline>().enabled = true;
    }

    public void UndoOutline()
    {
        node.sphere.GetComponent<Outline>().enabled = false;

        if (node.previous != null)
        {
            node.leadingEdge.GetComponent<Outline>().enabled = false;
        }
    }
}
