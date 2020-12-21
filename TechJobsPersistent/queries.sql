#Part 1
SELECT COLUMN_NAME, DATA_TYPE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE table_schema = "techjobs"
AND table_name = "jobs";


#Part 2
SELECT name
FROM employers
WHERE location = "St. Louis City";

#Part 3

