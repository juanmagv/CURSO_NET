
--1�
SELECT IDCUENTA,APELLIDOS FROM CUENTA INNER JOIN CLIENTE ON CUENTA.IDCLIENTE=CLIENTE.IDCLIENTE WHERE APELLIDOS LIKE 'G%';

--2�
SELECT MOVIMIENTO.IDMOVIMIENTO,CLIENTE.APELLIDOS,SALDO  FROM CLIENTE INNER JOIN CUENTA ON CLIENTE.IDCLIENTE=CUENTA.IDCLIENTE INNER JOIN MOVIMIENTO ON CUENTA.IDCUENTA=MOVIMIENTO.IDCUENTA WHERE APELLIDOS LIKE '%VALLINA%' AND DIVISA='EURO';

--3�
SELECT MOVIMIENTO.IDMOVIMIENTO,CLIENTE.APELLIDOS,CUENTA.IDCUENTA,DIVISA  FROM CLIENTE INNER JOIN CUENTA ON CLIENTE.IDCLIENTE=CUENTA.IDCLIENTE INNER JOIN MOVIMIENTO ON CUENTA.IDCUENTA=MOVIMIENTO.IDCUENTA WHERE APELLIDOS LIKE '%VALLINA%'
AND DIVISA='EURO' ORDER BY IDCUENTA;

--4�
SELECT MOVIMIENTO.IDMOVIMIENTO,CLIENTE.APELLIDOS  FROM CLIENTE INNER JOIN CUENTA ON CLIENTE.IDCLIENTE=CUENTA.IDCLIENTE INNER JOIN MOVIMIENTO ON CUENTA.IDCUENTA=MOVIMIENTO.IDCUENTA WHERE APELLIDOS LIKE '%VALLINA%' OR APELLIDOS LIKE '%RODRIGUEZ%';