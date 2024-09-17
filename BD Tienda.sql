create database tienda;

use tienda;

create table productos(
idproducto int primary key auto_increment,
nombre varchar(50),
descripcion varchar(200),
precio decimal(18,2));

delimiter $$
drop procedure if exists insertar;
create procedure insertar(
in p_nombre varchar(50),
in p_descripcion varchar(200),
in p_precio decimal(18,2))
begin 
	insert into productos (nombre, descripcion, precio) values(p_nombre,p_descripcion,p_precio);
end $$

delimiter $$
drop procedure if exists modificar;
create procedure modificar(
in p_id int,
in p_nombre varchar(50),
in p_descripcion varchar(200),
in p_precio decimal(18,2))
begin 
    update productos 
    set nombre = p_nombre, 
        descripcion = p_descripcion, 
        precio = p_precio 
    where idproducto = p_id;
end$$

delimiter $$
drop procedure if exists eliminar;
create procedure eliminar(
in p_id int)
begin
	delete from productos where idproducto = p_id;
end $$
