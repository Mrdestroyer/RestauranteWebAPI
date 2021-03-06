CREATE TABLE USUARIO(
    ID INTEGER PRIMARY KEY AUTOINCREMENT,
    NOMBRE_USUARIO VARCHAR(60) NOT NULL,
    CONTRASENA VARCHAR(150) NOT NULL,
    CORREO VARCHAR(120),
    NOMBRE VARCHAR(80),
    ROLL VARCHAR(30)
);

insert into USUARIO values(
	1,
	"soy_admin",
	"root",
	"admin@admin.com",
	"Groot",
	"1"
)

CREATE TABLE PEDIDO(
    ID INTEGER PRIMARY KEY AUTOINCREMENT,
    NOMBRE_PRODUCTO TEXT,
    DESCRIPCION TEXT,
    PRECIO NUMERIC,
    FOTO TEXT,
    CATEGORIA VARCHAR(50),
    CANTIDAD INTEGER,
    ESTADO INTEGER,
    ID_USUARIO INTEGER REFERENCES USUARIO,
	COMENTARIO TEXT
);

SELECT * from PEDIDO


INSERT INTO PEDIDO VALUES(
	1,
	"Pasta",
	"N/A",
	12300,
	"URL_FOTO",
	"N/A",
	2,
	0,
	1,
	"N/A"
);


CREATE TABLE PRODUCTO(
	ID INTEGER PRIMARY KEY AUTOINCREMENT,
	NOMBRE_PRODUCTO TEXT,
	DESCRIPCION TEXT,
	PRECIO NUMERIC,
	FOTO TEXT,
	CATEGORIA INTEGER
);

CREATE TABLE QUEJAS (
	ID INTEGER PRIMARY KEY AUTOINCREMENT,
	NOMBRE_EMISOR VARCHAR(90),
	CORREO VARCHAR(180),
	QUEJA TEXT
)

