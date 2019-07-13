# finalADS
pregunta 1
optimizar el query
SELECT *
FROM Students c1
join (select c2.student_id from students c2  
WHERE  SUBSTRING(email, 0, CHARINDEX('@', email, 0)) = 'JPerez')
as c3 on c1.student_id = c3.student_id;

pregunta 3

Database migrations: es el proceso que necesitamos para compartir los datos de un sistema a otro, mientras cambiamos el sistema de almacenamiento donde se encuentran los datos

Continuous integration, deployment and delivery: consiste en hacer integraciones automaticas de un proyecto
Clean and scalable architecture: arquitectura limpia es que los objetos que coordina se encuentran dentro del dominio y la arquitectura escalable propiedad deseable de un sistema, red o un proceso, que indica su habilidad para reaccionar y adaptarse sin perder su calidad
