
SELECT  Employees.employeeId , employeeName, Employees.employeePhone, Employees.employeeFatherName, Employees.employeeCNIC,
  Employees.employeeAddress, Employees.employeeLocation, EmployeeEmergency.name, EmployeeEmergency.relation,EmployeeEmergency.contact,
  EmployeeEmergency.location  from   [Employees] 
INNER JOIN  [EmployeeEmergency] ON  Employees.employeeId = EmployeeEmergency.employeeId