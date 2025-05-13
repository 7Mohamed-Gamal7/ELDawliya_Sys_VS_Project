-- ÃœÊ· «·„Â«„
CREATE TABLE Program_Design_Tasks (
    TaskID INT IDENTITY(1,1) PRIMARY KEY,
    Task_Name NVARCHAR(100) NOT NULL,
	Task_Type NVARCHAR(255),
    Task_Description NVARCHAR(MAX),
    Task_Status NVARCHAR(50) CHECK (Task_Status IN ('Not Started', 'In Progress', 'Completed')) DEFAULT 'Not Started',
    Task_Priority NVARCHAR(50) CHECK (Task_Priority IN ('Low', 'Medium', 'High')) DEFAULT 'Medium',
    StartDate DATE,
    DueDate DATE,
    AssignedTo NVARCHAR(255),
    Notes NVARCHAR(MAX),
    CreatedAt DATETIME DEFAULT GETDATE()
);