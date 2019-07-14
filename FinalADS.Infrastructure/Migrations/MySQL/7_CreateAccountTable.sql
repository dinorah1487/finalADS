
CREATE TABLE autor(
  account_id INT   UNSIGNED AUTO_INCREMENT PRIMARY KEY,
  nombres VARCHAR(50)    ,
  apellidos varchar (50)  ,
  institucion varchar (50)  ,
  nroarticulos int   ,
  created_at_utc TIMESTAMP DEFAULT CURRENT_TIMESTAMP   
ON UPDATE CURRENT_TIMESTAMP  ,
  updated_at_utc TIMESTAMP DEFAULT CURRENT_TIMESTAMP  
ON UPDATE CURRENT_TIMESTAMP   
    
 
 )  