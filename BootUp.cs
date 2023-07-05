using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BootUp : MonoBehaviour
{
    public GameObject myGameObject;
    public GameObject myCylinder;
    public GameObject myClickSphere;

    List<Node> nodesList = new List<Node>();

    public float lowestY = 0;
    public float highestDistance = 0;
    public bool updated = false;
    public float test1 = 0F;

    public void calcLowestY(float newY)
    {
        if (newY < lowestY)
            lowestY = newY;
    }

    public void calculateHighestDistance(float newDistance)
    {
        if (newDistance > highestDistance)
            highestDistance = newDistance;
    }

    private static Employee[] employees = new Employee[]
    {
        new Employee("Germany", "Chief", "Google Munich", "employee1", 100, 0, null),
        //new Employee("Germany", "Chief", "Google Munich", "employee11", 65, 0, null),
        // new Employee("Germany", "Chief", "Google Munich", "employee12", 55, 0, null),
        //  new Employee("Germany", "Chief", "Google Munich", "employee13", 75, 0, null),
        new Employee("Germany", "Sales", "Google Munich", "employee2", 45, 1, "employee1"),
        new Employee("Germany", "Marketing", "Google Munich", "employee3", 3, 1, "employee1"),
        new Employee("Germany", "Marketing", "Google Munich", "employee4", 26, 1, "employee1"),
        new Employee("Germany", "Marketing", "Google Munich", "employee5", 47, 1, "employee1"),
        new Employee("Germany", "Marketing", "Google Munich", "employee6", 1, 1, "employee1"),
        new Employee("Germany", "Marketing", "Google Munich", "employee7", 99, 1, "employee1"),
        new Employee("Germany", "Marketing", "Google Munich", "employee8", 78, 1, "employee1"),
        new Employee("Germany", "Sales", "Google Munich", "employee9", 35, 2, "employee2"),
        new Employee("Germany", "Sales", "Google Munich", "employee10", 100, 2, "employee2"),
        new Employee("Germany", "Sales", "Google Munich", "employee11", 90, 2, "employee2"),
        new Employee("Germany", "Sales", "Google Munich", "employee12", 50, 2, "employee2"),
        new Employee("Germany", "Sales", "Google Munich", "employee13", 49, 2, "employee2"),
        new Employee("Germany", "Sales", "Google Munich", "employee14", 35, 2, "employee3"),
        new Employee("Germany", "Sales", "Google Munich", "employee15", 100, 2, "employee3"),
        new Employee("Germany", "Sales", "Google Munich", "employee16", 90, 2, "employee3"),
        new Employee("Germany", "Sales", "Google Munich", "employee17", 50, 2, "employee3"),
        new Employee("Germany", "Sales", "Google Munich", "employee18", 35, 2, "employee4"),
        new Employee("Germany", "Sales", "Google Munich", "employee19", 50, 2, "employee4"),
        new Employee("Germany", "Sales", "Google Munich", "employee20", 0, 2, "employee4"),
        new Employee("Germany", "Sales", "Google Munich", "employee21", 49, 2, "employee4"),
        new Employee("Germany", "Sales", "Google Munich", "employee22", 51, 2, "employee4"),
        new Employee("Germany", "Sales", "Google Munich", "employee23", 35, 2, "employee5"),
        new Employee("Germany", "Sales", "Google Munich", "employee24", 100, 2, "employee5"),
        new Employee("Germany", "Sales", "Google Munich", "employee25", 90, 2, "employee5"),
        new Employee("Germany", "Sales", "Google Munich", "employee26", 50, 2, "employee5"),
        new Employee("Germany", "Sales", "Google Munich", "employee27", 50, 2, "employee6"),
        new Employee("Germany", "Sales", "Google Munich", "employee28", 0, 2, "employee6"),
        new Employee("Germany", "Sales", "Google Munich", "employee29", 51, 2, "employee6"),
        new Employee("Germany", "Sales", "Google Munich", "employee30", 35, 2, "employee7"),
        new Employee("Germany", "Sales", "Google Munich", "employee31", 100, 2, "employee7"),
        new Employee("Germany", "Sales", "Google Munich", "employee32", 35, 2, "employee8"),
        new Employee("Germany", "Sales", "Google Munich", "employee33", 100, 2, "employee8"),
        new Employee("Germany", "Sales", "Google Munich", "employee34", 90, 2, "employee8"),
        new Employee("Germany", "Sales", "Google Munich", "employee35", 35, 3, "employee9"),
        new Employee("Germany", "Sales", "Google Munich", "employee36", 100, 3, "employee9"),
        new Employee("Germany", "Sales", "Google Munich", "employee37", 90, 3, "employee9"),
        new Employee("Germany", "Sales", "Google Munich", "employee38", 49, 3, "employee9"),
        new Employee("Germany", "Sales", "Google Munich", "employee39", 51, 3, "employee9"),
        new Employee("Germany", "Sales", "Google Munich", "employee40", 49, 3, "employee9"),
        new Employee("Germany", "Sales", "Google Munich", "employee41", 51, 3, "employee9"),
        new Employee("Germany", "Sales", "Google Munich", "employee42", 35, 3, "employee10"),
        new Employee("Germany", "Sales", "Google Munich", "employee43", 100, 3, "employee10"),
        new Employee("Germany", "Sales", "Google Munich", "employee44", 50, 3, "employee10"),
        new Employee("Germany", "Sales", "Google Munich", "employee45", 49, 3, "employee11"),
        new Employee("Germany", "Sales", "Google Munich", "employee46", 51, 3, "employee11"),
        new Employee("Germany", "Sales", "Google Munich", "employee47", 51, 3, "employee11"),
        new Employee("Germany", "Sales", "Google Munich", "employee48", 51, 3, "employee11"),
        new Employee("Germany", "Sales", "Google Munich", "employee49", 49, 3, "employee12"),
        new Employee("Germany", "Sales", "Google Munich", "employee50", 51, 3, "employee12"),
        new Employee("Germany", "Sales", "Google Munich", "employee51", 35, 3, "employee12"),
        new Employee("Germany", "Sales", "Google Munich", "employee52", 100, 3, "employee12"),
        new Employee("Germany", "Sales", "Google Munich", "employee53", 50, 3, "employee13"),
        new Employee("Germany", "Sales", "Google Munich", "employee54", 0, 3, "employee13"),
        new Employee("Germany", "Sales", "Google Munich", "employee55", 51, 3, "employee13"),
        new Employee("Germany", "Sales", "Google Munich", "employee56", 35, 3, "employee14"),
        new Employee("Germany", "Sales", "Google Munich", "employee57", 100, 3, "employee14"),
        new Employee("Germany", "Sales", "Google Munich", "employee58", 50, 3, "employee14"),
        new Employee("Germany", "Sales", "Google Munich", "employee59", 0, 3, "employee15"),
        new Employee("Germany", "Sales", "Google Munich", "employee60", 0, 3, "employee15"),
        new Employee("Germany", "Sales", "Google Munich", "employee61", 0, 3, "employee15"),
        new Employee("Germany", "Sales", "Google Munich", "employee62", 0, 3, "employee16"),
        new Employee("Germany", "Sales", "Google Munich", "employee63", 0, 3, "employee16"),
        new Employee("Germany", "Sales", "Google Munich", "employee64", 0, 3, "employee16"),
        new Employee("Germany", "Sales", "Google Munich", "employee65", 0, 3, "employee18"),
        new Employee("Germany", "Sales", "Google Munich", "employee66", 0, 3, "employee18"),
        new Employee("Germany", "Sales", "Google Munich", "employee67", 0, 3, "employee19"),
        new Employee("Germany", "Sales", "Google Munich", "employee68", 0, 3, "employee19"),
        new Employee("Germany", "Sales", "Google Munich", "employee69", 0, 3, "employee19"),
        new Employee("Germany", "Sales", "Google Munich", "employee70", 0, 3, "employee19"),
        new Employee("Germany", "Sales", "Google Munich", "employee71", 0, 3, "employee19"),
        new Employee("Germany", "Sales", "Google Munich", "employee72", 0, 3, "employee20"),
        new Employee("Germany", "Sales", "Google Munich", "employee73", 0, 3, "employee20"),
        new Employee("Germany", "Sales", "Google Munich", "employee74", 0, 3, "employee20"),
        new Employee("Germany", "Sales", "Google Munich", "employee75", 0, 3, "employee21"),
        new Employee("Germany", "Sales", "Google Munich", "employee76", 0, 3, "employee21"),
        new Employee("Germany", "Sales", "Google Munich", "employee77", 0, 3, "employee22"),
        new Employee("Germany", "Sales", "Google Munich", "employee78", 0, 3, "employee22"),
        new Employee("Germany", "Sales", "Google Munich", "employee79", 0, 3, "employee23"),
        new Employee("Germany", "Sales", "Google Munich", "employee80", 0, 3, "employee23"),
        new Employee("Germany", "Sales", "Google Munich", "employee81", 0, 3, "employee25"),
        new Employee("Germany", "Sales", "Google Munich", "employee82", 0, 3, "employee25"),
        new Employee("Germany", "Sales", "Google Munich", "employee83", 0, 3, "employee25"),
        new Employee("Germany", "Sales", "Google Munich", "employee84", 0, 3, "employee26"),
        new Employee("Germany", "Sales", "Google Munich", "employee85", 0, 3, "employee26"),
        new Employee("Germany", "Sales", "Google Munich", "employee86", 0, 3, "employee29"),
        new Employee("Germany", "Sales", "Google Munich", "employee87", 0, 3, "employee29"),
        new Employee("Germany", "Sales", "Google Munich", "employee88", 0, 3, "employee29"),
        new Employee("Germany", "Sales", "Google Munich", "employee89", 0, 3, "employee32"),
        new Employee("Germany", "Sales", "Google Munich", "employee90", 0, 4, "employee32"),
        new Employee("Germany", "Sales", "Google Munich", "employee91", 0, 4, "employee34"),
        new Employee("Germany", "Sales", "Google Munich", "employee92", 0, 4, "employee34"),
        new Employee("Germany", "Sales", "Google Munich", "employee93", 15, 4, "employee17"),
        new Employee("Germany", "Sales", "Google Munich", "employee94", 0, 4, "employee17"),
        new Employee("Germany", "Sales", "Google Munich", "employee95", 0, 4, "employee17"),
        new Employee("Germany", "Sales", "Google Munich", "employee96", 0, 4, "employee17"),
        new Employee("Germany", "Sales", "Google Munich", "employee97", 0, 4, "employee17"),
        new Employee("Germany", "Sales", "Google Munich", "employee98", 0, 4, "employee17"),
        new Employee("Germany", "Sales", "Google Munich", "employee99", 0, 4, "employee24"),
        new Employee("Germany", "Sales", "Google Munich", "employee100", 0, 4, "employee24"),
        new Employee("Germany", "Sales", "Google Munich", "employee101", 0, 4, "employee24"),
        new Employee("Germany", "Sales", "Google Munich", "employee102", 0, 4, "employee24"),
        new Employee("Germany", "Sales", "Google Munich", "employee103", 0, 4, "employee24"),
        new Employee("Germany", "Sales", "Google Munich", "employee104", 0, 4, "employee27"),
        new Employee("Germany", "Sales", "Google Munich", "employee105", 0, 4, "employee27"),
        new Employee("Germany", "Sales", "Google Munich", "employee106", 0, 4, "employee27"),
        new Employee("Germany", "Sales", "Google Munich", "employee107", 0, 4, "employee27"),
        new Employee("Germany", "Sales", "Google Munich", "employee108", 0, 4, "employee27"),
        new Employee("Germany", "Sales", "Google Munich", "employee109", 0, 4, "employee27"),
        new Employee("Germany", "Sales", "Google Munich", "employee110", 0, 4, "employee24"),
        new Employee("Germany", "Sales", "Google Munich", "employee111", 0, 4, "employee28"),
        new Employee("Germany", "Sales", "Google Munich", "employee112", 0, 4, "employee28"),
        new Employee("Germany", "Sales", "Google Munich", "employee113", 0, 4, "employee28"),
        new Employee("Germany", "Sales", "Google Munich", "employee114", 0, 4, "employee28"),
        new Employee("Germany", "Sales", "Google Munich", "employee115", 0, 4, "employee28"),
        new Employee("Germany", "Sales", "Google Munich", "employee116", 0, 4, "employee28"),
        new Employee("Germany", "Sales", "Google Munich", "employee117", 0, 4, "employee30"),
        new Employee("Germany", "Sales", "Google Munich", "employee118", 0, 4, "employee30"),
        new Employee("Germany", "Sales", "Google Munich", "employee119", 0, 4, "employee30"),
        new Employee("Germany", "Sales", "Google Munich", "employee120", 0, 4, "employee30"),
        new Employee("Germany", "Sales", "Google Munich", "employee121", 0, 4, "employee31"),
        new Employee("Germany", "Sales", "Google Munich", "employee122", 0, 4, "employee31"),
        new Employee("Germany", "Sales", "Google Munich", "employee123", 0, 4, "employee31"),
        new Employee("Germany", "Sales", "Google Munich", "employee124", 0, 4, "employee33"),
        new Employee("Germany", "Sales", "Google Munich", "employee125", 0, 4, "employee33"),
        new Employee("Germany", "Sales", "Google Munich", "employee126", 0, 4, "employee33"),
        new Employee("Germany", "Sales", "Google Munich", "employee127", 0, 4, "employee33"),
        new Employee("Germany", "Sales", "Google Munich", "employee128", 0, 4, "employee35"),
        new Employee("Germany", "Sales", "Google Munich", "employee129", 0, 4, "employee35"),
        new Employee("Germany", "Sales", "Google Munich", "employee130", 0, 4, "employee36"),
        new Employee("Germany", "Sales", "Google Munich", "employee131", 0, 4, "employee36"),
        new Employee("Germany", "Sales", "Google Munich", "employee132", 15, 4, "employee36"),
        new Employee("Germany", "Sales", "Google Munich", "employee133", 0, 4, "employee37"),
        new Employee("Germany", "Sales", "Google Munich", "employee134", 0, 4, "employee37"),
        new Employee("Germany", "Sales", "Google Munich", "employee135", 0, 4, "employee38"),
        new Employee("Germany", "Sales", "Google Munich", "employee136", 0, 4, "employee38"),
        new Employee("Germany", "Sales", "Google Munich", "employee137", 0, 4, "employee39"),
        new Employee("Germany", "Sales", "Google Munich", "employee138", 0, 4, "employee40"),
        new Employee("Germany", "Sales", "Google Munich", "employee139", 0, 4, "employee40"),
        new Employee("Germany", "Sales", "Google Munich", "employee140", 0, 4, "employee40"),
        new Employee("Germany", "Sales", "Google Munich", "employee141", 0, 4, "employee41"),
        new Employee("Germany", "Sales", "Google Munich", "employee142", 0, 4, "employee42"),
        new Employee("Germany", "Sales", "Google Munich", "employee143", 0, 4, "employee42"),
        new Employee("Germany", "Sales", "Google Munich", "employee144", 0, 4, "employee42"),
        new Employee("Germany", "Sales", "Google Munich", "employee145", 0, 4, "employee43"),
        new Employee("Germany", "Sales", "Google Munich", "employee146", 0, 4, "employee43"),
        new Employee("Germany", "Sales", "Google Munich", "employee147", 0, 4, "employee44"),
        new Employee("Germany", "Sales", "Google Munich", "employee148", 0, 4, "employee44"),
        new Employee("Germany", "Sales", "Google Munich", "employee149", 15, 4, "employee44"),
        new Employee("Germany", "Sales", "Google Munich", "employee150", 0, 4, "employee44"),
        new Employee("Germany", "Sales", "Google Munich", "employee151", 0, 4, "employee45"),
        new Employee("Germany", "Sales", "Google Munich", "employee152", 0, 4, "employee46"),
        new Employee("Germany", "Sales", "Google Munich", "employee153", 0, 4, "employee46"),
        new Employee("Germany", "Sales", "Google Munich", "employee154", 0, 4, "employee47"),
        new Employee("Germany", "Sales", "Google Munich", "employee155", 0, 4, "employee47"),
        new Employee("Germany", "Sales", "Google Munich", "employee156", 0, 4, "employee47"),
        new Employee("Germany", "Sales", "Google Munich", "employee157", 0, 4, "employee48"),
        new Employee("Germany", "Sales", "Google Munich", "employee158", 0, 4, "employee49"),
        new Employee("Germany", "Sales", "Google Munich", "employee159", 0, 4, "employee50"),
        new Employee("Germany", "Sales", "Google Munich", "employee160", 0, 4, "employee51"),
        new Employee("Germany", "Sales", "Google Munich", "employee161", 0, 4, "employee51"),
        new Employee("Germany", "Sales", "Google Munich", "employee162", 0, 4, "employee52"),
        new Employee("Germany", "Sales", "Google Munich", "employee163", 0, 4, "employee53"),
        new Employee("Germany", "Sales", "Google Munich", "employee164", 0, 4, "employee53"),
        new Employee("Germany", "Sales", "Google Munich", "employee165", 0, 4, "employee54"),
        new Employee("Germany", "Sales", "Google Munich", "employee166", 0, 4, "employee55"),
        new Employee("Germany", "Sales", "Google Munich", "employee167", 0, 4, "employee56"),
        new Employee("Germany", "Sales", "Google Munich", "employee168", 0, 4, "employee57"),
        new Employee("Germany", "Sales", "Google Munich", "employee169", 0, 4, "employee57"),
        new Employee("Germany", "Sales", "Google Munich", "employee170", 15, 4, "employee58"),
        new Employee("Germany", "Sales", "Google Munich", "employee171", 0, 4, "employee58"),
        new Employee("Germany", "Sales", "Google Munich", "employee172", 0, 4, "employee59"),
        new Employee("Germany", "Sales", "Google Munich", "employee173", 0, 4, "employee60"),
        new Employee("Germany", "Sales", "Google Munich", "employee174", 0, 4, "employee60"),
        new Employee("Germany", "Sales", "Google Munich", "employee175", 0, 4, "employee61"),
        new Employee("Germany", "Sales", "Google Munich", "employee176", 0, 4, "employee62"),
        new Employee("Germany", "Sales", "Google Munich", "employee177", 0, 4, "employee63"),
        new Employee("Germany", "Sales", "Google Munich", "employee178", 0, 4, "employee63"),
        new Employee("Germany", "Sales", "Google Munich", "employee179", 0, 4, "employee64"),
        new Employee("Germany", "Sales", "Google Munich", "employee180", 0, 4, "employee65"),
        new Employee("Germany", "Sales", "Google Munich", "employee181", 0, 4, "employee65"),
        new Employee("Germany", "Sales", "Google Munich", "employee182", 0, 4, "employee66"),
        new Employee("Germany", "Sales", "Google Munich", "employee183", 0, 4, "employee67"),
        new Employee("Germany", "Sales", "Google Munich", "employee184", 15, 4, "employee68"),
        new Employee("Germany", "Sales", "Google Munich", "employee185", 0, 4, "employee69"),
        new Employee("Germany", "Sales", "Google Munich", "employee186", 0, 4, "employee70"),
        new Employee("Germany", "Sales", "Google Munich", "employee187", 0, 4, "employee71"),
        new Employee("Germany", "Sales", "Google Munich", "employee188", 0, 4, "employee71"),
        new Employee("Germany", "Sales", "Google Munich", "employee189", 0, 4, "employee72"),
        new Employee("Germany", "Sales", "Google Munich", "employee190", 0, 4, "employee72"),
        new Employee("Germany", "Sales", "Google Munich", "employee191", 0, 4, "employee73"),
        new Employee("Germany", "Sales", "Google Munich", "employee192", 0, 4, "employee73"),
        new Employee("Germany", "Sales", "Google Munich", "employee193", 0, 4, "employee74"),
        new Employee("Germany", "Sales", "Google Munich", "employee194", 0, 4, "employee74"),
        new Employee("Germany", "Sales", "Google Munich", "employee195", 15, 4, "employee75"),
        new Employee("Germany", "Sales", "Google Munich", "employee196", 0, 4, "employee75"),
        new Employee("Germany", "Sales", "Google Munich", "employee197", 0, 4, "employee75"),
        new Employee("Germany", "Sales", "Google Munich", "employee198", 0, 4, "employee75"),
        new Employee("Germany", "Sales", "Google Munich", "employee199", 0, 4, "employee76"),
        new Employee("Germany", "Sales", "Google Munich", "employee200", 15, 4, "employee76"),
        new Employee("Germany", "Sales", "Google Munich", "employee201", 0, 4, "employee77"),
        new Employee("Germany", "Sales", "Google Munich", "employee202", 0, 4, "employee77"),
        new Employee("Germany", "Sales", "Google Munich", "employee203", 0, 4, "employee77"),
        new Employee("Germany", "Sales", "Google Munich", "employee204", 0, 4, "employee78"),
        new Employee("Germany", "Sales", "Google Munich", "employee205", 0, 4, "employee79"),
        new Employee("Germany", "Sales", "Google Munich", "employee206", 0, 4, "employee80"),
        new Employee("Germany", "Sales", "Google Munich", "employee207", 0, 4, "employee81"),
        new Employee("Germany", "Sales", "Google Munich", "employee208", 0, 4, "employee81"),
        new Employee("Germany", "Sales", "Google Munich", "employee209", 0, 4, "employee82"),
        new Employee("Germany", "Sales", "Google Munich", "employee210", 0, 4, "employee82"),
        new Employee("Germany", "Sales", "Google Munich", "employee211", 0, 4, "employee83"),
        new Employee("Germany", "Sales", "Google Munich", "employee212", 0, 4, "employee83"),
        new Employee("Germany", "Sales", "Google Munich", "employee213", 0, 4, "employee83"),
        new Employee("Germany", "Sales", "Google Munich", "employee214", 0, 4, "employee84"),
        new Employee("Germany", "Sales", "Google Munich", "employee215", 0, 4, "employee84"),
        new Employee("Germany", "Sales", "Google Munich", "employee216", 0, 4, "employee85"),
        new Employee("Germany", "Sales", "Google Munich", "employee217", 15, 4, "employee85"),
        new Employee("Germany", "Sales", "Google Munich", "employee218", 0, 4, "employee86"),
        new Employee("Germany", "Sales", "Google Munich", "employee219", 15, 4, "employee86"),
        new Employee(
            "Germany",
            "Sales",
            "Google Munich",
            "Lorem ipsum dolor sit amet",
            0,
            4,
            "employee87"
        ),
        new Employee("Germany", "Sales", "Google Munich", "employee221", 15, 4, "employee87"),
        new Employee("Germany", "Sales", "Google Munich", "employee222", 0, 4, "employee88"),
        new Employee("Germany", "Sales", "Google Munich", "employee223", 0, 4, "employee88"),
        new Employee("Germany", "Sales", "Google Munich", "employee224", 15, 4, "employee89"),
        new Employee("Germany", "Sales", "Google Munich", "employee225", 0, 4, "employee89"),






    };

    private static GameObject[] spheres = new GameObject[employees.Length];

    private static float powerOf2(int hiLevel)
    {
        float total = 0;
        for (int i = 0; i < hiLevel; i++)
        {
            total += 1F / Mathf.Pow(2, i);
        }
        return total;
    }

    private static float[] calculate(int position, int total, float bias, float window)
    {
        float angle = (window / total) * (position + 0.5F) + (bias - window / 2);

        return new float[] { Mathf.Sin(Mathf.PI * angle / 180), Mathf.Cos(Mathf.PI * angle / 180) };
    }

    private static int calTurn(Node n)
    {
        int i = 0;
        foreach (Node node in n.previous.previous.children)
        {
            if (n.previous.employee.uniqueId == node.employee.uniqueId)
                return i;
            i++;
        }
        return i;
    }

    private static int calTurn2(Node n)
    {
        int i = 0;
        foreach (Node node in n.previous.previous.children)
        {
            i++;
            i += node.children.Count;
        }
        return i;
    }

    // Start is called before the first frame update
    void Start()
    {
        IDictionary<string, Node> nodes = new Dictionary<string, Node>();

        //--------------------------------------------------------------------------------------------------------------------
        //Create the nodes in a List

        for (int i = 0; i < employees.Length; i++)
        {
            Node newNode =
                employees[i].bossId != null
                    ? new Node(employees[i], nodes[employees[i].bossId])
                    : new Node(employees[i], null);
            nodes.Add(employees[i].uniqueId, newNode);
            if (newNode.previous != null)
                nodes[employees[i].bossId].children.Add(newNode);
            nodesList.Add(newNode);
        }

        int factor = 0;

        foreach (Node n in nodesList)
        {
            GameObject sphere = Instantiate(myGameObject);
            float[] position;
            if (n.previous != null && n.previous.previous != null)
            {
                float addX = 0F;
                float addZ = 0F;
                int i = 0;
                foreach (Node nn in n.previous.children)
                {
                    if (nn.employee.uniqueId == n.employee.uniqueId)
                        break;
                    i++;
                }

                float angleToOrigin =
                    Mathf.Rad2Deg
                    * Mathf.Atan2(
                        n.previous.sphere.transform.position.x,
                        n.previous.sphere.transform.position.z
                    );

                addX = Mathf.Sin(Mathf.PI * angleToOrigin / 180) * n.employee.hierarchicalLevel;
                addZ = Mathf.Cos(Mathf.PI * angleToOrigin / 180) * n.employee.hierarchicalLevel;
                position = calculate(
                    i,
                    n.previous.children.Count,
                    angleToOrigin,
                    360.0F / n.previous.previous.children.Count
                );

                sphere.transform.position = new Vector3(
                    position[0]
                        * (
                            n.employee.hierarchicalLevel
                            + n.previous.children.Count
                            + calTurn(n) * 2F
                            + i
                            + (calTurn2(n)) / 4F * (i)
                        )
                        + n.previous.sphere.transform.position.x
                        + addX,
                    -n.employee.hierarchicalLevel * 12
                        + powerOf2(n.employee.hierarchicalLevel) * 2.4F,
                    position[1]
                        * (
                            n.employee.hierarchicalLevel
                            + n.previous.children.Count
                            + calTurn(n) * 2F
                            + i
                            + (calTurn2(n)) / 4F * (i)
                        )
                        + n.previous.sphere.transform.position.z
                        + addZ
                );

                calcLowestY(sphere.transform.position.y);
                calculateHighestDistance(
                    Vector3.Distance(sphere.transform.position, new Vector3(0, 0, 0))
                );
            }
            else if (n.previous != null)
            {
                float addX = 0F;
                float addZ = 0F;
                int i = 0;
                foreach (Node nn in n.previous.children)
                {
                    if (nn.employee.uniqueId == n.employee.uniqueId)
                        break;
                    i++;
                }

                float angleToOrigin =
                    Mathf.Rad2Deg
                    * Mathf.Atan2(
                        n.previous.sphere.transform.position.x,
                        n.previous.sphere.transform.position.z
                    );
                addX = Mathf.Sin(Mathf.PI * angleToOrigin / 180) * n.employee.hierarchicalLevel;
                addZ = Mathf.Cos(Mathf.PI * angleToOrigin / 180) * n.employee.hierarchicalLevel;
                position = calculate(i, n.previous.children.Count, angleToOrigin, 360.0F);

                sphere.transform.position = new Vector3(
                    position[0]
                        * (3 + n.employee.hierarchicalLevel + n.previous.children.Count + i * 2F)
                        + n.previous.sphere.transform.position.x
                        + addX,
                    -n.employee.hierarchicalLevel * 12
                        + powerOf2(n.employee.hierarchicalLevel) * 2.4F,
                    position[1]
                        * (3 + n.employee.hierarchicalLevel + n.previous.children.Count + i * 2F)
                        + n.previous.sphere.transform.position.z
                        + addZ
                );

                calcLowestY(sphere.transform.position.y);
                calculateHighestDistance(
                    Vector3.Distance(sphere.transform.position, new Vector3(0, 0, 0))
                );
            }
            else
            {
                int i = 0;
                int ii = 0;
                bool seen = false;
                foreach (Employee e in employees)
                {
                    if (e.hierarchicalLevel == n.employee.hierarchicalLevel && e.bossId == null)
                        i++;
                    if (e.uniqueId == n.employee.uniqueId)
                    {
                        seen = true;
                    }
                    else if (!seen)
                    {
                        ii++;
                    }
                }
                if (ii == 0)
                {
                    sphere.transform.position = new Vector3(
                        0,
                        -n.employee.hierarchicalLevel * 12
                            + powerOf2(n.employee.hierarchicalLevel) * 2.4F,
                        0
                    );
                    calcLowestY(sphere.transform.position.y);
                    calculateHighestDistance(
                        Vector3.Distance(sphere.transform.position, new Vector3(0, 0, 0))
                    );
                }
                else
                {
                    position = calculate(ii, i, 0, 360.0F);
                    sphere.transform.position = new Vector3(
                        position[0],
                        -n.employee.hierarchicalLevel * 12
                            + powerOf2(n.employee.hierarchicalLevel) * 2.4F,
                        position[1]
                    );

                    calcLowestY(sphere.transform.position.y);
                    calculateHighestDistance(
                        Vector3.Distance(sphere.transform.position, new Vector3(0, 0, 0))
                    );
                }
            }

            //Coloring the nodes
            sphere.GetComponent<Renderer>().material.color = new Color(
                5 * (1F - n.employee.satisfaction / 100F),
                5 * n.employee.satisfaction / 100F,
                0
            );

            sphere.AddComponent<Sphere>();
            sphere.GetComponent<Sphere>().node = n;
            n.sphere = sphere;

            //Adding invisible clickSpheres

            GameObject clickSphere = Instantiate(myClickSphere);
            clickSphere.transform.position = n.sphere.transform.position;
            clickSphere.AddComponent<ClickSphere>();
            clickSphere.GetComponent<ClickSphere>().node = n;
            n.clickSphere = clickSphere;
            // Generate cylinder

            if (n.previous != null)
            {
                GameObject cylinder = Instantiate(myCylinder);
                Vector3 path = n.sphere.transform.position - n.previous.sphere.transform.position;
                path = path / 2;
                cylinder.transform.position = n.previous.sphere.transform.position + path;
                cylinder.transform.LookAt(n.sphere.transform);
                cylinder.transform.Rotate(90, 0, 0);
                cylinder.transform.localScale = new Vector3(
                    0.1F,
                    Vector3.Distance(
                        n.sphere.transform.position,
                        n.previous.sphere.transform.position
                    ) / 2F,
                    0.1F
                );
                cylinder.GetComponent<Renderer>().material.color =
                    (
                        n.sphere.GetComponent<Renderer>().material.color
                        + n.previous.sphere.GetComponent<Renderer>().material.color
                    ) / 2;
                n.leadingEdge = cylinder;
            }
            factor++;
        }
    }

    void Update()
    {
        foreach (Node n in nodesList)
        {
            n.clickSphere.GetComponent<ClickSphere>().UndoOutline();
        }

        TooltipSystem.Hide();

        //------------------------------------------------------------------------------------------------------------------------
        //Here on is the tooltip


        Ray ray = gameObject.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);

        RaycastHit[] hits;
        hits = Physics.RaycastAll(ray);

        List<RaycastHit> filtered = new List<RaycastHit>();
        foreach (RaycastHit hit in hits)
        {
            if (hit.collider.gameObject.GetComponent<ClickSphere>() != null)
                filtered.Add(hit);
        }
        hits = filtered.ToArray();

        if (hits.Length > 0)
        {
            int i = 1;
            float smallestDistance = Vector2.Distance(
                Camera.main.WorldToScreenPoint(hits[0].collider.transform.position),
                Input.mousePosition
            );
            GameObject closest = hits[0].collider.gameObject;
            while (i < hits.Length)
            {
                RaycastHit hit = hits[i];
                Vector2 _2dCoordinates = Camera.main.WorldToScreenPoint(
                    hit.collider.transform.position
                );
                if (Vector2.Distance(Input.mousePosition, _2dCoordinates) < smallestDistance)
                {
                    smallestDistance = Vector2.Distance(Input.mousePosition, _2dCoordinates);
                    closest = hit.collider.gameObject;
                }
                i++;
            }

            test1 = smallestDistance;
            Employee e = closest.GetComponent<ClickSphere>().node.employee;
            string content =
                "Department: "
                + e.department
                + "\nCompany: "
                + e.company
                + "\nLocation: "
                + e.location
                + "\nEmployee #UniqueID: "
                + e.uniqueId;
            string header = "Satisfaction: " + e.satisfaction + "%";
            TooltipSystem.Show(content, header);
            closest.GetComponent<ClickSphere>().Outline();
        }
    }
}
