# SQL-Queries

Certainly! Here are **some essential SQL Server queries** that every developer should be familiar with:

1. **Create Table**: To create a new table in SQL Server, use the following syntax:
    ```sql
    CREATE TABLE TableName (
        Id INT,
        Name NVARCHAR(500),
        Age INT
    );
    ```
2. **Create Table with Primary Key**: To create a table with a primary key, use:
    ```sql
    CREATE TABLE TableName (
        Id INT PRIMARY KEY,
        Name NVARCHAR(500),
        Age INT
    );
    ```
3. **Create Table with Primary Key and Identity Column**: For an auto-incrementing identity column:
    ```sql
    CREATE TABLE TableName (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Name NVARCHAR(500),
        Age INT
    );
    ```
4. **Insert Values into SQL Server Table**: To add data to a table:
    ```sql
    INSERT INTO TableName (Name, Age)
    VALUES ('Max', 30);
    ```
5. **Insert Multiple Rows in a Single Query**: Insert multiple records at once:
    ```sql
    INSERT INTO TableName (Name, Age)
    VALUES ('Max', 30), ('John', 28), ('Jack', 31);
    ```
6. **Update Query**:
    - Update a single record:
        ```sql
        UPDATE TableName
        SET Name = 'Max Payne'
        WHERE Id = 1;
        ```
    - Update all records:
        ```sql
        UPDATE TableName
        SET Age = 31;
        ```
7. **Delete Query**:
    - Delete a single record:
        ```sql
        DELETE FROM TableName
        WHERE Id = 1;
        ```
    - Delete all records:
        ```sql
        DELETE FROM TableName;
        ```
8. **Select**:
    - Select all columns from a table:
        ```sql
        SELECT * FROM TableName;
        ```
    - Select specific columns:
        ```sql
        SELECT ColumnName1, ColumnName2
        FROM TableName;
        ```
9. **Create View**: A view is a virtual table based on a SQL statement:
    ```sql
    CREATE VIEW view_name AS
    SELECT Id, Name, Age
    FROM TableName;
    ```
    Usage: `SELECT * FROM view_name;`
10. **Create Stored Procedure**:
    ```sql
    CREATE PROCEDURE getInfoFromTable AS
    SELECT * FROM TableName;
    ```
11. **Get All Column Names from Table**:
    - Retrieve column names:
        ```sql
        SELECT COLUMN_NAME
        FROM INFORMATION_SCHEMA.COLUMNS
        WHERE TABLE_NAME = 'TableName';
        ```
    - Get column names with data types:
        ```sql
        SELECT COLUMN_NAME, DATA_TYPE
        FROM INFORMATION_SCHEMA.COLUMNS
        WHERE TABLE_NAME = 'TableName';
        ```
12. **Search Column Name from Database**:
    - Find matching column names:
        ```sql
        SELECT c.name AS ColName, t.name AS TableName
        FROM sys.columns c
        JOIN sys.tables t ON c.object_id = t.object_id;
        ```

Certainly! Let's explore examples for various SQL queries and commands in Microsoft SQL Server:

1. **SELECT Query**:
    - Retrieve all rows and columns from the `Product` table:
        ```sql
        SELECT *
        FROM Production.Product;
        ```

2. **INSERT INTO Query**:
    - Add a new product to the `Product` table:
        ```sql
        INSERT INTO Production.Product (Name, ListPrice)
        VALUES ('New Product', 99.99);
        ```

3. **UPDATE Query**:
    - Update the price of an existing product:
        ```sql
        UPDATE Production.Product
        SET ListPrice = 109.99
        WHERE ProductID = 123;
        ```

4. **DELETE Query**:
    - Remove a product from the `Product` table:
        ```sql
        DELETE FROM Production.Product
        WHERE ProductID = 456;
        ```

5. **CREATE TABLE Statement**:
    - Create a new table named `Customers`:
        ```sql
        CREATE TABLE Customers (
            CustomerID INT PRIMARY KEY,
            FirstName NVARCHAR(50),
            LastName NVARCHAR(50)
        );
        ```

6. **ALTER TABLE Statement**:
    - Add a new column to the `Customers` table:
        ```sql
        ALTER TABLE Customers
        ADD Email NVARCHAR(100);
        ```

7. **CREATE VIEW Statement**:
    - Create a view that displays customer names:
        ```sql
        CREATE VIEW vw_CustomerNames AS
        SELECT CustomerID, CONCAT(FirstName, ' ', LastName) AS FullName
        FROM Customers;
        ```

8. **Stored Procedure**:
    - Create a stored procedure to retrieve order details:
        ```sql
        CREATE PROCEDURE GetOrderDetails
        @OrderID INT
        AS
        BEGIN
            SELECT * FROM Sales.OrderDetail WHERE OrderID = @OrderID;
        END;
        ```

9. **JOIN Query**:
    - Retrieve product details along with order quantities:
        ```sql
        SELECT p.Name, sod.OrderQty
        FROM Production.Product p
        INNER JOIN Sales.SalesOrderDetail sod ON p.ProductID = sod.ProductID;
        ```

10. **DISTINCT Query**:
    - Get unique job titles from the `Employee` table:
        ```sql
        SELECT DISTINCT JobTitle
        FROM HumanResources.Employee;
        ```

11. **SELECT INTO Query**:
    - Create a temporary table with bicycle data:
        ```sql
        USE tempdb;
        IF OBJECT_ID(N'#Bicycles', N'U') IS NOT NULL
            DROP TABLE #Bicycles;
        SELECT *
        INTO #Bicycles
        FROM AdventureWorks2022.Production.Product
        WHERE ProductSubcategoryID = 1;
        ```

Feel free to explore and adapt these examples to your specific scenarios! 🚀

Source: Conversation with Bing, 4/2/2024
(1) SELECT examples (Transact-SQL) - SQL Server | Microsoft Learn. https://learn.microsoft.com/en-us/sql/t-sql/queries/select-examples-transact-sql?view=sql-server-ver16.
(2) Queries - SQL Server | Microsoft Learn. https://learn.microsoft.com/en-us/sql/t-sql/queries/queries?view=sql-server-ver16.
(3) SQL Commands: The Complete List (w/ Examples) – Dataquest. https://www.dataquest.io/blog/sql-commands/.
(4) 20 Basic SQL Query Examples for Beginners | LearnSQL.com. https://learnsql.com/blog/basic-sql-query-examples/.
