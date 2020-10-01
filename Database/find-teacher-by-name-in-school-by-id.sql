USE PasswordWeb
GO

SELECT t.* FROM Teacher as t
LEFT JOIN [TeachesAt] as ta ON ta.TeacherId = t.Id
WHERE ta.[SchoolId] = 1
AND t.[Name] LIKE '% Rubio' 
GO