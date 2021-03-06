USE master;

-- ************************************** [Create DB]
IF DB_ID(N'TinyCollege') IS NOT NULL DROP DATABASE TinyCollege;
CREATE DATABASE TinyCollege;
GO

USE TinyCollege;

GO

-- ************************************** [Student]
CREATE TABLE student

(

           studentId         INT NOT NULL IDENTITY(10000, 1),

           firstName NVARCHAR(15) NOT NULL,
		   
		   lastName NVARCHAR(15) NOT NULL,
		   
		   credits INT NOT NULL,

           CONSTRAINT pk_student PRIMARY KEY (studentId)

);

-- ************************************** [Employee]
CREATE TABLE employee

(

           employeeId INT NOT NULL IDENTITY(1000, 1),
		   
		   firstName NVARCHAR(15) NOT NULL,
		   
		   lastName NVARCHAR(15) NOT NULL,
		   
		   isAdmin BIT NOT NULL,

           CONSTRAINT pk_employee PRIMARY KEY (employeeId)

);

-- ************************************** [Course]
CREATE TABLE course

(

           courseId INT NOT NULL IDENTITY,

           title NVARCHAR(100) NOT NULL,

           employeeId INT NOT NULL,
		   
		   seats TINYINT NOT NULL,
		   
		   maxSeats tinyint NOT NULL,
		   
		   isAvailable BIT NOT NULL,

           CONSTRAINT pk_course PRIMARY KEY (courseId),

           CONSTRAINT fk_course_employee FOREIGN KEY (employeeId)

                  REFERENCES employee(employeeId)

);

-- ************************************** [CoursexStudent]
 CREATE TABLE courseXstudent
 (

           studentId INT NOT NULL,

           courseId INT NOT NULL,
		   
		   grade CHAR(10) ,

           

           CONSTRAINT fk_cxs_student FOREIGN KEY (studentId)

                  REFERENCES student(studentId),
		    CONSTRAINT fk_cxs_course FOREIGN KEY (courseId)
				  REFERENCES course(courseId)
);
-- ************************************** [Starting Data]
INSERT INTO student (firstName, lastName, credits) VALUES ('Zachary', 'Bowen', 83);
INSERT INTO student (firstName, lastName, credits) VALUES ('Brent', 'McKinney', 102);
INSERT INTO student (firstName, lastName, credits) VALUES ('Steven', 'Applegarth', 34);

INSERT INTO employee(firstName, lastName, isAdmin) VALUES ('Mark', 'Chambers', 1);
INSERT INTO employee(firstName, lastName, isAdmin) VALUES ('Felicha', 'Cross', 0);

INSERT INTO course(title, employeeId, seats, maxSeats, isAvailable) VALUES ('Agile Delevopment', 1000, 2, 22, 1);
INSERT INTO course(title, employeeId, seats, maxSeats, isAvailable) VALUES ('Software Design', 1001, 1, 22, 1);

INSERT INTO courseXstudent(studentId, courseId, grade) VALUES (10000, 1, 'A');
INSERT INTO courseXstudent(studentId, courseId, grade) VALUES (10001, 1, 'C');
INSERT INTO courseXstudent(studentId, courseId, grade) VALUES (10002, 2, 'B');
