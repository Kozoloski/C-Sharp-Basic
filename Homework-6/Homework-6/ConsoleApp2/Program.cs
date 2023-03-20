

using ClassLibrary1.Classes;

SalesPerson person1 = new SalesPerson("Tomo", "Kozoloski");

person1.AddSuccessRevenue(4400);
person1.GetSalary();

Manager person2 = new Manager("Jonh", "Doe");

person2.AddBonus(300);
person2.GetSalary();
