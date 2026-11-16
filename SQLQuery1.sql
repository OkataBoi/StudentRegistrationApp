INSERT INTO dbo.Students
    (FullName, Programme, Email, BirthDate, Address)
VALUES
    (N'Ama Mensah', N'BSc Information Technology', N'ama@example.com', '2004-05-12', N'Adenta'),
    (N'Kojo Asare', N'BSc Computer Science', N'kojo@example.com', '2003-08-20', N'Tema');

SELECT * FROM dbo.Students ORDER BY Id;