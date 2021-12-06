create database pedidos;
use pedidos;
create table clientes(
idCliente  bigint not null primary key identity(1,1),
	nombres varchar(75),
	apellidos varchar(75),
	telefono varchar(15),
	direccion varchar(75),
	ciudad varchar(50),
	departamento varchar(50),
	estado varchar(1)
);
create table pedidos(
	idPedido bigint not null primary key identity(1,1),
	idCliente bigint not null references clientes(idCliente),
	fechaPedido datetime,
	fechaEsperada datetime,
	comentarios varchar(200),
	estado varchar(15)
);
create table productos(
	idProducto bigint not null primary key identity(1,1),
	producto varchar(100),
	descripcion varchar(200),
	cantidadEnStock int,
	precioVenta decimal(15,2),
	estado varchar(1)
);
create table detalle_pedido(
	idDetallePedido bigint not null primary key identity(1,1),
	idPedido bigint references pedidos(idPedido),
	idProducto bigint not null references productos(idProducto),
	precioUnidad decimal(15,2),
	numeroLinea smallint,
	estado varchar(1)
);