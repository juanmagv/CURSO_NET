CREATE TABLE CLIENTE(
IDCLIENTE VARCHAR(5)NOT NULL,
APELLIDOS VARCHAR(30) NOT NULL,
NOMBRES VARCHAR(30) NOT NULL
);

CREATE TABLE MOVIMIENTO(
IDCUENTA VARCHAR(5)NOT NULL,
IDMOVIMIENTO VARCHAR(5)NOT NULL,
TIPO VARCHAR(20)NOT NULL,
MONTO FLOAT NOT NULL,
FECHA DATE NOT NULL
);

CREATE TABLE CUENTA(
IDCLIENTE  VARCHAR(5),
IDCUENTA  VARCHAR(5) NOT NULL,
SALDO FLOAT NOT NULL,
DIVISA VARCHAR(20)
);


ALTER TABLE CLIENTE add constraint pk_Idcliente  primary key(IDCLIENTE);
alter table CUENTA ADD CONSTRAINT pk_cuenta PRIMARY KEY(idcuenta),CONSTRAINT fk_cliente_cuenta foreign key (IDCLIENTE) REFERENCES CLIENTE(IDCLIENTE);
ALTER TABLE MOVIMIENTO ADD CONSTRAINT pk_idmovimiento PRIMARY KEY (IDMOVIMIENTO),CONSTRAINT fk_movimiento_cuenta FOREIGN KEY(IDCUENTA) REFERENCES CUENTA(IDCUENTA);


INSERT INTO CLIENTE (IDCLIENTE,APELLIDOS,NOMBRES)
VALUES('BA001','GARCIA FERNANDEZ','LUIS'),
('BA002','GUTIERREZ VALLINA','ANA'),
('BA003','FERNANDEZ GARCIA','ENRIQUE');



INSERT INTO CUENTA(IDCLIENTE,IDCUENTA,SALDO,DIVISA)
VALUES('BA001','CU001',13000,'EURO'),
('BA002','CU002',1500,'EURO'),
('BA003','CU003',150000,'DOLARES');

INSERT INTO MOVIMIENTO(IDCUENTA,IDMOVIMIENTO,TIPO,MONTO,FECHA)
VALUES('CU001','MO001','APERTURA',2000,'20190103'),
('CU001','MO002','IBI',250,'20201123'),
('CU002','MO003','APERTURA',20,'20150105');