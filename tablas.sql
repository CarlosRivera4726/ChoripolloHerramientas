
-- Tabla Usuario	
CREATE TABLE Usuario (
  id INT PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(50),
  apellido VARCHAR(50),
  genero VARCHAR(10)
);

-- Tabla Proveedor
CREATE TABLE Proveedor (
  id INT PRIMARY KEY IDENTITY(1,1),
  nombre VARCHAR(50),
  telefono VARCHAR(20)
);

-- Tabla Producto
CREATE TABLE Producto (
  id INT PRIMARY KEY IDENTITY(1,1),
  proveedor INT,
  nombre VARCHAR(50),
  precio_compra DECIMAL(10, 2),
  precio_venta DECIMAL(10, 2),
  stock INT,
  FOREIGN KEY (proveedor) REFERENCES Proveedor(id)
);

-- Tabla Factura
CREATE TABLE Factura (
  id INT PRIMARY KEY IDENTITY(1,1),
  usuario INT,
  fecha DATE,
  FOREIGN KEY (usuario) REFERENCES Usuario(id)
);

-- Tabla DetalleFactura
CREATE TABLE DetalleFactura (
  id_detalle INT PRIMARY KEY IDENTITY(1,1),
  factura INT,
  producto INT,
  cantidad INT,
  precio DECIMAL(10, 2),
  FOREIGN KEY (factura) REFERENCES Factura(id),
  FOREIGN KEY (producto) REFERENCES Producto(id)
);