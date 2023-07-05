using UnityEngine;

public class Employee
{
   public string location="";
   public string department="";
   public string company="";
   public string uniqueId="";
   public int satisfaction=0;
   public int hierarchicalLevel=0;
   public string bossId="";

   public Employee(string location, string department, string company, string uniqueId, int satisfaction, int hierarchicalLevel, string bossId){
    this.location=location;
    this.department=department;
    this.company=company;
    this.uniqueId=uniqueId;
    this.satisfaction=satisfaction;
    this.hierarchicalLevel=hierarchicalLevel;
    this.bossId=bossId;
   }

}
