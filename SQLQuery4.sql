CREATE DATABASE CollegeDB;


USE CollegeDB;


CREATE TABLE Student (
    StudentID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50),
    Age INT,
    Course NVARCHAR(50)
);


INSERT INTO Student (Name, Age, Course)
VALUES ('Varudhini', 20, 'Computer Science'),
       ('Kavya', 22, 'Mathematics');
