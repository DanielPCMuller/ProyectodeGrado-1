create table usuarios(
Identificacion varchar (50) primary key,
Nombres_Persona varchar (50),
Apellidos_Persona varchar (50),
fecha_Nacimiento varchar (50),
Telefono varchar (50),
Clave varchar (50)
);

create table inventarios(
Codigo_Articulo varchar (50) primary key,
Nombre_Articulo varchar (50),
Marca_Articulo varchar (50),
Empresa_Pedido varchar (50),
Fecha_Compra varchar (50),
Cantidad varchar (50),
Precio_Compra varchar (50),
Precio_venta varchar (50),
Utilidad varchar (50)
);

create table ordenes(
Numero_Pedido varchar (50) primary key,
Articulos_Solicitados varchar (50),
Fecha_Pedido varchar (50),
Cantidad varchar (50),
Precio_Compra varchar (50)
);

create table clientes(
Tipo_Identificacion varchar (50) primary key,
Identificacion varchar (50),
Nombres_Cliente varchar (50),
Apellidos_Cliente varchar (50),
Telefono varchar (50)
);
