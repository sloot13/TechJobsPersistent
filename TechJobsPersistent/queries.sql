--Part 1 
--#id(int, PK), EmployerId(int), Name(varchar)

--Part 2
SELECT Name
From Employers
WHERE Location = "St. Louis City";

--Part 3
SELECT Name, Description
FROM Skills
JOIN JobSkills
ON Skills.Id = JobSkills.SkillId
wHERE JobSkills.JobId IS NOT NULL
ORDER BY Name ASC;


