
using NestedObjects;
using System.ComponentModel.DataAnnotations;

Advisor compSciAdvisor = new()
{
	Email = "email123@cptc.edu",
	FullName = "Tom Smith",
	OfficeLocation = "B17 Rm110"
};

Student stu1 = new()
{
	FirstName = "Mike",
	LastName = "Man",
	DateOfBirth = new DateOnly(2000, 2, 12),
	AssignedAdvisor = compSciAdvisor,
	PhoneNumber = "2535733161",
	SchoolEmail = "Mike.Man@students.cptc.edu"
};

Console.WriteLine($"Student: {stu1.FirstName} has {stu1.AssignedAdvisor.FullName}");