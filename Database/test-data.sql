USE PasswordWeb
GO
-- Insert rows into table 'School'
INSERT INTO School
( -- columns to insert data into
    [Name]
)
VALUES
( -- first row: values for the columns in the list above
 'Bethesda Elementary School'
),
( -- second row: values for the columns in the list above
 'Burton Magnet Elementary School'
),
( 
 'C.C. Spaulding Elementary'
),
(
 'Club Boulevard Magnet Elementary'
),
(
 'Creekside Elementary'
),
(
 'E.K. Powe Elementary School'
)
-- add more rows here
GO

-- Insert rows into table 'Teacher'
INSERT INTO Teacher
( -- columns to insert data into
 [Name]
)
VALUES
(
 'Milton Good'
),
(
 'Harold Rubio'
),
(
    'Angelica Reid'
),
(
    'Felipe Fry'
),
(
    'Rylie Hahn'
),
(
    'Finley Black'
)
-- add more rows here
GO
-- Insert rows into table 'TeachesAt'
INSERT INTO TeachesAt
( -- columns to insert data into
 [SchoolId], [TeacherId]
)
VALUES
(
 1, 1
),
(
 1, 2
),
(
 3, 3
),
(
 4, 4
),
(
 5, 5
),
(
 6, 6
)
-- add more rows here
GO