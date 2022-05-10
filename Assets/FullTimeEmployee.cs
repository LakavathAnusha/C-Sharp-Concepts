using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FullTimeEmployee : Employee
{
    private void Start()
    {
        CalculateMonthlySalary();
    }
    public int salary;
    public override void CalculateMonthlySalary()
    {
        Debug.Log(salary);
    }
}