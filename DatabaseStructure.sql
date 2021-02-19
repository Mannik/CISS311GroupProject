USE master;

-- ************************************** [Create DB]
IF DB_ID(N'TinyCollege') IS NOT NULL DROP DATABASE TinyCollege;
CREATE DATABASE TinyCollege;
GO

-- ************************************** [Student]

CREATE TABLE [Student]
(
 [StudentID] int IDENTITY (10000, 1) NOT NULL ,
 [FirstName] nvarchar(15) NOT NULL ,
 [LastName]  nvarchar(15) NOT NULL ,
 [Credits]   tinyint NOT NULL ,


 CONSTRAINT [PK_student] PRIMARY KEY CLUSTERED ([StudentID] ASC)
);
GO

-- ************************************** [Employee]

CREATE TABLE [Employee]
(
 [EmployeeID] int IDENTITY (1000, 1) NOT NULL ,
 [FirstName]  nvarchar(15) NOT NULL ,
 [LastName]   nvarchar(15) NOT NULL ,
 [IsAdmin]    bit NOT NULL ,


 CONSTRAINT [PK_employee] PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
);
GO

-- ************************************** [Course]

CREATE TABLE [Course]
(
 [CourseID]   int NOT NULL ,
 [Title]      nvarchar(50) NOT NULL ,
 [Seats]      tinyint NOT NULL ,
 [Instructor] int NOT NULL ,


 CONSTRAINT [PK_course] PRIMARY KEY CLUSTERED ([CourseID] ASC),
 CONSTRAINT [FK_60] FOREIGN KEY ([Instructor])  REFERENCES [Employee]([EmployeeID])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_61] ON [Course] 
 (
  [Instructor] ASC
 )

GO

-- ************************************** [CoursexStudent]

CREATE TABLE [CoursexStudent]
(
 [StudentID] int NOT NULL ,
 [CourseID]  int NOT NULL ,
 [Grade]     char(10) NOT NULL ,


 CONSTRAINT [FK_67] FOREIGN KEY ([StudentID])  REFERENCES [Student]([StudentID]),
 CONSTRAINT [FK_72] FOREIGN KEY ([CourseID])  REFERENCES [Course]([CourseID])
);
GO


CREATE NONCLUSTERED INDEX [fkIdx_68] ON [CoursexStudent] 
 (
  [StudentID] ASC
 )

GO

CREATE NONCLUSTERED INDEX [fkIdx_73] ON [CoursexStudent] 
 (
  [CourseID] ASC
 )

GO