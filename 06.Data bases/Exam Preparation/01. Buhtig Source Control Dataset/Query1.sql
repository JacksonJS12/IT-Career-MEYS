create schema exam_prep_1;
use exam_prep_1;

# Exercise  1
select id, username
from users
order by id asc;

# Exercise  2
select *
from repositories_contributors
where repository_id = contributor_id
order by repository_id;

# Exercise 3
select i.id, concat(u.username, ' : ' , i.title) as `issue_assignee`
from issues as i
join users as u
	on i.assignee_id = u.id
order by i.id desc;

# Exercise 4
select f1.id, f1.name, concat(f1.size, 'KB') as `size`
from files as f1
left join files as f2
	on f1.id = f2.parent_id
where f2.id is null
order by f1.id asc;

# Exercise 5
select r.id, r.name, (select count(*) from issues as i where i.repository_id = r.id) as `issues`
from repositories as r
order by `issues` desc, r.id asc
limit 5;

# Exercise 6
select r.id, r.name, 
	(select count(*) from commits as c where c.repository_id = r.id) as `commits`,
	(select count(*) from repositories_contributors as rc where rc.repository_id = r.id) as `contributors`
from repositories as r
order by `contributors` desc, r.id asc
limit 1;

# Exercise 7
select r.id, r.name, count(distinct c.contributor_id) as `users`
from repositories as r
left join commits as c
	on c.repository_id = r.id
group by r.id
order by `users` desc, r.id asc;	

