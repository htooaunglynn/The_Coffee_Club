CREATE TABLE Owner(
Id INT PRIMARY KEY NOT NULL,
UserName VARCHAR(255) NOT NULL,
Email VARCHAR(255) NOT NULL,
Password VARCHAR(255) NOT NULL,
ComfirmPassword VARCHAR(255) NOT NULL,
);

SELECT * FROM Owner ORDER BY Id;

INSERT INTO Owner VALUES(1,'Su Thi Sa','suthisa@gmail.com','thisa123','thisa123');
INSERT INTO Owner VALUES(2,'Mizuki','mizuki@gmail.com','mizuh2o','mizuh2o');

UPDATE Owner SET UserName ='SuThiSAR' , Email ='su@gmail.com' , Password ='sa123' , ComfirmPassword = 'sa123' WHERE Id=1;