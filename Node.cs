using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
   public Employee employee;
   public List<Node> children= new List<Node>();
   public Node previous;
   public GameObject sphere;
   public GameObject leadingEdge;
   public GameObject clickSphere;

   public Node(Employee employee, Node previous){
    this.employee=employee;
    this.previous=previous;
    this.children= new List<Node>();
   }
}
