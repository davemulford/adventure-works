CREATE TABLE department (
    DepartmentID SERIAL NOT NULL CONSTRAINT PK_Department_DepartmentID PRIMARY KEY,
    Name VARCHAR(50) NOT NULL,
    GroupName VARCHAR(50) NOT NULL,
    ModifiedDate TIMESTAMP NOT NULL
);

INSERT INTO department (DepartmentID, Name, GroupName, ModifiedDate) VALUES (1, 'Engineering', 'Research and Development', '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO department (DepartmentID, Name, GroupName, ModifiedDate) VALUES (2, 'Tool Design', 'Research and Development', '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO department (DepartmentID, Name, GroupName, ModifiedDate) VALUES (3, 'Sales', 'Sales and Marketing', '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO department (DepartmentID, Name, GroupName, ModifiedDate) VALUES (4, 'Marketing', 'Sales and Marketing', '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO department (DepartmentID, Name, GroupName, ModifiedDate) VALUES (5, 'Purchasing', 'Inventory Management', '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO department (DepartmentID, Name, GroupName, ModifiedDate) VALUES (6, 'Research and Development', 'Research and Development', '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO department (DepartmentID, Name, GroupName, ModifiedDate) VALUES (7, 'Production', 'Manufacturing', '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO department (DepartmentID, Name, GroupName, ModifiedDate) VALUES (8, 'Production Control', 'Manufacturing', '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO department (DepartmentID, Name, GroupName, ModifiedDate) VALUES (9, 'Human Resources', 'Executive General and Administration', '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO department (DepartmentID, Name, GroupName, ModifiedDate) VALUES (10, 'Finance', 'Executive General and Administration', '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO department (DepartmentID, Name, GroupName, ModifiedDate) VALUES (11, 'Information Services', 'Executive General and Administration', '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO department (DepartmentID, Name, GroupName, ModifiedDate) VALUES (12, 'Document Control', 'Quality Assurance', '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO department (DepartmentID, Name, GroupName, ModifiedDate) VALUES (13, 'Quality Assurance', 'Quality Assurance', '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO department (DepartmentID, Name, GroupName, ModifiedDate) VALUES (14, 'Facilities and Maintenance', 'Executive General and Administration', '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO department (DepartmentID, Name, GroupName, ModifiedDate) VALUES (15, 'Shipping and Receiving', 'Inventory Management', '2008-04-30T00:00:00.000'::TIMESTAMP);
INSERT INTO department (DepartmentID, Name, GroupName, ModifiedDate) VALUES (16, 'Executive', 'Executive General and Administration', '2008-04-30T00:00:00.000'::TIMESTAMP);

SELECT setval('department_departmentid_seq'::regclass, 16);
