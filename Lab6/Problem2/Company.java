package PatternsGOF.Lab6.Problem2;

import java.util.List;
import java.util.Map;

public class Company {
    private List<Employee> employees;
    private Map<Employee, Double> employeeSalaries;

    public void printEmployeeSalaries() {
        for (Employee employee : employees) {
            System.out.println(employee.getName() + ": " + getSalary(employee));
        }
    }

    public double getSalary(Employee employee) {
        return employeeSalaries.get(employee);
    }

    public void setSalary(Employee employee, double salary) {
        employeeSalaries.put(employee, salary);
    }
}
