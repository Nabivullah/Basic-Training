--top 5 - no condition applied when using this, cant use offset with this 
--offset - used for skipping the rows


select top 5 * from employee order by salary desc

select * from employee order by salary desc offset 1 rows fetch next 5 rows only
