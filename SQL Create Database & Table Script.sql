create Database shop_tdp;

use shop_tdp;

create table Sales (SaleID int Auto_increment,ProductName varchar(80) Not Null,Quantity int Not Null,Prices Float Not Null,SaleDate Datetime Not Null Default Current_Timestamp,Primary Key (SaleID));

