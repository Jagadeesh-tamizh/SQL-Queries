USE master;

-- Create the TrainOps database IF NOT EXISTS
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'TrainOps')
BEGIN
    CREATE DATABASE TrainOps;
    PRINT 'TrainOps database created successfully.';
END
ELSE
BEGIN
    PRINT 'TrainOps database already exists.';
END

GO

-- Switch to the TrainOps database
USE TrainOps;
GO
