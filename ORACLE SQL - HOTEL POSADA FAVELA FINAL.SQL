--ESTO SE HACE EN LA SESIÓN DE SYSDBA
CONNECT / as sysdba
CREATE USER hotel IDENTIFIED BY hotel;
GRANT connect, resource TO hotel;
GRANT create session, create table, create view, create trigger, create procedure TO hotel; 
GRANT execute on dbms_crypto TO hotel;

--ESTO SE EJECUTA EN LA SESIÓN DE HOTEL
CONNECT hotel/hotel

CREATE TABLE Permiso (
  id_permiso NUMERIC(10) NOT NULL,
  nivel_permiso VARCHAR(35) NOT NULL,
  descripcion_nivel_permiso VARCHAR(110) NULL,
  CONSTRAINT pk_Pr_idPermiso PRIMARY KEY (id_permiso),
  CONSTRAINT uk_Pr_nivelPermiso UNIQUE (nivel_permiso)
);

CREATE TABLE Genero (
  id_genero NUMERIC(10) NOT NULL,
  nombre_genero VARCHAR(35) NOT NULL,
  CONSTRAINT pk_Gn_idGenero PRIMARY KEY (id_genero),
  CONSTRAINT uk_Gn_nomGenero UNIQUE (nombre_genero)
);

CREATE TABLE Tipo_Habitacion (
  id_tipo_hab NUMERIC(10) NOT NULL,
  nombre_tipo_hab VARCHAR(40) NOT NULL,
  descripcion_tip_hab VARCHAR(110) NULL,
  CONSTRAINT pk_TH_idTipoHab PRIMARY KEY (id_tipo_hab),
  CONSTRAINT uk_TH_nombTipHab UNIQUE (nombre_tipo_hab)
);

CREATE TABLE Metodo_pago (
  id_metodo_pago NUMERIC(10) NOT NULL,
  nombre_met_pago VARCHAR(35) NOT NULL,
  descripcion VARCHAR(110) NULL,
  CONSTRAINT pk_MP_idMetPago PRIMARY KEY (id_metodo_pago),
  CONSTRAINT uk_MP_nomMetPag UNIQUE (nombre_met_pago)
);

CREATE TABLE Rol (
  id_rol NUMERIC(10) NOT NULL,
  id_permiso NUMERIC(10) NOT NULL,
  nombre_rol VARCHAR(35) NOT NULL,
  descripcion_rol VARCHAR(110) NULL,
  CONSTRAINT pk_Rl_idRol PRIMARY KEY (id_rol),
  CONSTRAINT fk_rL_idPermiso FOREIGN KEY (id_permiso) REFERENCES Permiso(id_permiso),
  CONSTRAINT uk_Rl_nombRol UNIQUE (nombre_rol)
);

CREATE TABLE Cliente (
  id_cliente NUMERIC(10) NOT NULL,
  id_genero NUMERIC(10) NOT NULL,
  nombre_cliente VARCHAR(100) NOT NULL,
  paterno_cliente VARCHAR(100) NOT NULL,
  materno_cliente VARCHAR(100) NOT NULL,
  telefono_cliente VARCHAR(35) NOT NULL,
  identificacion_cliente VARCHAR(35) NOT NULL,
  nota_cliente VARCHAR(250) NULL,
  estado_cliente VARCHAR(35) NOT NULL,
  CONSTRAINT pk_Cl_idCliente PRIMARY KEY (id_cliente),
  CONSTRAINT fk_Cl_idGenero FOREIGN KEY (id_genero) REFERENCES Genero(id_genero),
  CONSTRAINT uk_Cl_telCliente UNIQUE (telefono_cliente),
  CONSTRAINT uk_Cl_IdentCliente UNIQUE (identificacion_cliente)
);

CREATE TABLE Habitacion (
  numero_habitacion NUMERIC(10) NOT NULL,
  id_tipo_hab NUMERIC(10) NOT NULL,
  precio_habitacion NUMBER(20,2) NOT NULL,
  estado_habitacion VARCHAR(35) NOT NULL,
  capacidad_habitacion NUMERIC(2) NOT NULL,
  descripcion_habitacion VARCHAR(200) NULL,
  CONSTRAINT pk_Hb_numHab PRIMARY KEY (numero_habitacion),
  CONSTRAINT fk_Hb_idTipoHab FOREIGN KEY (id_tipo_hab) REFERENCES Tipo_Habitacion(id_tipo_hab),
  CONSTRAINT ck_Hb_precioHab CHECK(precio_habitacion > 0.0),
  CONSTRAINT ck_Hb_capacidadHab CHECK(capacidad_habitacion > 0)
);

CREATE TABLE Usuario (
  id_usuario NUMERIC(10) NOT NULL,
  id_genero NUMERIC(10) NOT NULL,
  id_rol NUMERIC(10) NOT NULL,
  nombre_usuario VARCHAR(100) NOT NULL,
  paterno_usuario VARCHAR(100) NOT NULL,
  materno_usuario VARCHAR(100) NOT NULL,
  telefono_usuario VARCHAR(35) NOT NULL,
  identificacion_usuario VARCHAR(35) NOT NULL,
  direccion_usuario VARCHAR(100) NOT NULL,
  fecha_ingreso DATE NOT NULL,
  tiene_acceso_sistema VARCHAR(10) NOT NULL,
  usuario VARCHAR(100) NULL,
  contrasena VARCHAR(100) NULL,
  estado_usuario VARCHAR(100) NOT NULL,
  CONSTRAINT pk_Us_idUsuario PRIMARY KEY (id_usuario),
  CONSTRAINT fk_Us_idGenero FOREIGN KEY (id_genero) REFERENCES Genero(id_genero),
  CONSTRAINT fk_Us_idRol FOREIGN KEY (id_rol) REFERENCES Rol(id_rol),
  CONSTRAINT uk_Us_telEmpleado UNIQUE (telefono_usuario),
  CONSTRAINT uk_Us_IdentEmpleado UNIQUE (identificacion_usuario),
  CONSTRAINT uk_Us_UsuarioEmpleado UNIQUE (usuario)
);

CREATE TABLE Turno (
  id_turno NUMERIC(10) NOT NULL,
  id_usuario NUMERIC(10) NOT NULL,
  cantidad_inicial_turno NUMERIC(20,2) NOT NULL,
  cantidad_actual_turno NUMERIC(20,2) NOT NULL,
  cantidad_cierre_turno NUMERIC(20,2) NULL,
  fecha_hora_apertura DATE NOT NULL,
  fecha_hora_cierre DATE NULL,
  nota_turno VARCHAR(110) NULL,
  CONSTRAINT pk_Tr_idTurno PRIMARY KEY (id_turno),
  CONSTRAINT fk_Tr_idUsuario FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario),
  CONSTRAINT ck_Tr_cantidadInicial CHECK(cantidad_inicial_turno >= 0),
  CONSTRAINT ck_Tr_cantidadActual CHECK(cantidad_actual_turno >= 0),
  CONSTRAINT ck_Tr_fechaHoraCierre CHECK(fecha_hora_cierre > fecha_hora_apertura)
);

CREATE TABLE Egreso (
  id_egreso NUMERIC(10) NOT NULL,
  id_turno NUMERIC NOT NULL,
  cantidad_egreso NUMERIC(20,2) NOT NULL,
  fecha_hora_egreso DATE NOT NULL,
  concepto VARCHAR(110) NOT NULL,
  CONSTRAINT pk_Egr_idEgreso PRIMARY KEY (id_egreso),
  CONSTRAINT fk_Egr_idTurno FOREIGN KEY (id_turno) REFERENCES Turno(id_turno),
  CONSTRAINT ck_Egr_cantEgreso CHECK(cantidad_egreso > 0.0)
);

CREATE TABLE Reservacion (
  id_reservacion NUMERIC(10) NOT NULL,
  id_usuario NUMERIC(10) NOT NULL,
  id_cliente NUMERIC(10) NOT NULL,
  fecha_hora_reservacion DATE  NOT NULL,
  nota_reservacion VARCHAR(110) NULL,
  CONSTRAINT pk_Res_idReservacion PRIMARY KEY (id_reservacion),
  CONSTRAINT fk_Res_idUsuario FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario),
  CONSTRAINT fk_Res_idCliente FOREIGN KEY (id_cliente) REFERENCES Cliente(id_cliente)
);

CREATE TABLE Reservacion_has_Habitacion (
  numero_habitacion NUMERIC(10) NOT NULL,
  id_reservacion NUMERIC(10) NOT NULL,
  check_in_prog DATE NOT NULL,
  check_in_real DATE NULL,
  check_out_prog DATE NOT NULL,
  check_out_real DATE NULL,
  estado_reservacion VARCHAR(35) NOT NULL,
  CONSTRAINT fk_HabRes_idReservacion FOREIGN KEY (id_reservacion) REFERENCES Reservacion(id_reservacion),
  CONSTRAINT fk_HabRes_numHabitacon FOREIGN KEY (numero_habitacion) REFERENCES Habitacion(numero_habitacion),
  CONSTRAINT ck_HabRes_chekProg CHECK(check_in_prog <= check_out_prog)
);

CREATE TABLE Folio (
  id_folio NUMERIC(10) NOT NULL,
  id_reservacion NUMERIC(10) NOT NULL,
  id_usuario NUMERIC(10) NOT NULL,
  fecha_hora_folio DATE NOT NULL,
  estado_folio VARCHAR(35) NOT NULL,
  nota_folio VARCHAR(110) NULL,
  CONSTRAINT pk_Fl_idFolio PRIMARY KEY (id_folio),
  CONSTRAINT fk_Fl_idReservacion FOREIGN KEY (id_reservacion) REFERENCES Reservacion(id_reservacion),
  CONSTRAINT fk_Fl_idUsuario FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario)
);

CREATE TABLE Cargo_extra (
  id_cargo_extra NUMERIC(10) NOT NULL,
  id_folio NUMERIC(10) NOT NULL,
  concepto VARCHAR(100) NOT NULL,
  cantidad NUMERIC(5) NOT NULL,
  precio_unitario NUMERIC(20,2) NOT NULL,
  precio_total NUMERIC(20,2) NOT NULL,
  fecha_hora DATE NOT NULL,
  numero_habitacion NUMERIC(10) NOT NULL,
  CONSTRAINT pk_CarEx_idCargoExtra PRIMARY KEY (id_cargo_extra),
  CONSTRAINT fk_CarEx_idFolio FOREIGN KEY (id_folio) REFERENCES Folio(id_folio),
  CONSTRAINT ck_CarEx_cantidad CHECK(cantidad > 0),
  CONSTRAINT ck_CarEx_PrecUnitario CHECK(precio_unitario >= 0.0),
  CONSTRAINT ck_CarEx_PrecTotal CHECK(precio_total >= 0.0)
);

CREATE TABLE Pago (
  id_pago NUMERIC(10) NOT NULL,
  id_folio NUMERIC(10) NOT NULL,
  id_metodo_pago NUMERIC(10) NOT NULL,
  cantidad_pago NUMERIC(20,2) NOT NULL,
  fecha_hora_pago DATE NOT NULL,
  CONSTRAINT pk_Pagos_idPago PRIMARY KEY (id_Pago),
  CONSTRAINT fk_Pagos_idFolio FOREIGN KEY (id_folio) REFERENCES Folio(id_folio),
  CONSTRAINT fk_Pagos_idMetodoPag FOREIGN KEY (id_metodo_pago) REFERENCES Metodo_pago(id_metodo_pago),
  CONSTRAINT ck_Pagos_cantPago CHECK(cantidad_pago > 0.0)
);

--ENCRIPTACIÓN DE DATOS EN LA BD
create or replace package cryptit is
function encrypt_data(p_data in varchar2) return raw deterministic;
function decrypt_data(p_data in raw) return varchar2 deterministic;
end cryptit;
/

create or replace package body cryptit is
v_key raw(128) := utl_raw.cast_to_raw('IDEA-SOFTWARE');
function encrypt_data(p_data in varchar2) return raw deterministic
is
l_data raw(2048) := utl_raw.cast_to_raw(p_data);
l_encrypted raw(2048);
begin
null;
l_encrypted := dbms_crypto.encrypt
(src => l_data,
		typ => dbms_crypto.des_cbc_pkcs5,
 key => v_key);
return l_encrypted;
end encrypt_data;
function decrypt_data(p_data in raw) return varchar2 deterministic
is
l_decrypted raw(2048);
begin
l_decrypted := dbms_crypto.decrypt
(src => p_data,
	   typ => dbms_crypto.des_cbc_pkcs5,
 key => v_key);
 return utl_raw.cast_to_varchar2(l_decrypted);
 end decrypt_data;
 end cryptit;
 / 
 

--CREACIÓN DE TRIGGERS PARA ID AUTOMÁTICO

--SECUENCIA PARA GENERAR ID EN LAS TABLAS DE LA BD
CREATE SEQUENCE SecuenciaPermiso_ID
START WITH 1
INCREMENT BY 1  
ORDER;

CREATE SEQUENCE SecuenciaGenero_ID
START WITH 1
INCREMENT BY 1 
ORDER;

CREATE SEQUENCE SecuenciaTipHab_ID
START WITH 1
INCREMENT BY 1 
ORDER;

CREATE SEQUENCE SecuenciaMetPago_ID
START WITH 1
INCREMENT BY 1 
ORDER;

CREATE SEQUENCE SecuenciaRol_ID
START WITH 1
INCREMENT BY 1 
ORDER;

CREATE SEQUENCE SecuenciaCliente_ID
START WITH 1
INCREMENT BY 1 
ORDER;

CREATE SEQUENCE SecuenciaUsuario_ID
START WITH 1
INCREMENT BY 1 
ORDER;

CREATE SEQUENCE SecuenciaTurno_ID
START WITH 1
INCREMENT BY 1 
ORDER;

CREATE SEQUENCE SecuenciaEgreso_ID
START WITH 1
INCREMENT BY 1 
ORDER;

CREATE SEQUENCE SecuenciaReservacion_ID
START WITH 1
INCREMENT BY 1 
ORDER;   

CREATE SEQUENCE SecuenciaFolio_ID
START WITH 1
INCREMENT BY 1 
ORDER;

CREATE SEQUENCE SecuenciaCargoExtra_ID
START WITH 1
INCREMENT BY 1 
ORDER;

CREATE SEQUENCE SecuenciaPago_ID
START WITH 1
INCREMENT BY 1 
ORDER;


-- CREACION DE TRIGGER DE TABLA DE PERMISO
CREATE OR REPLACE TRIGGER Permiso_Autoincrementa
BEFORE INSERT ON Permiso
FOR EACH ROW
BEGIN
  SELECT SecuenciaPermiso_ID.NEXTVAL INTO :NEW.id_permiso FROM DUAL;
END;
/

-- CREACION DE TRIGGER DE TABLA DE GENERO
CREATE OR REPLACE TRIGGER Genero_Autoincrementa
BEFORE INSERT ON Genero
FOR EACH ROW
BEGIN
  SELECT SecuenciaGenero_ID.NEXTVAL INTO :NEW.id_genero FROM DUAL;
END;
/

-- CREACION DE TRIGGER DE TABLA DE TIPO DE HABITACIÓN
CREATE OR REPLACE TRIGGER TipHab_Autoincrementa
BEFORE INSERT ON Tipo_Habitacion
FOR EACH ROW
BEGIN
  SELECT SecuenciaTipHab_ID.NEXTVAL INTO :NEW.id_tipo_hab FROM DUAL;
END;
/

-- CREACION DE TRIGGER DE TABLA DE MÉTODO DE PAGO
CREATE OR REPLACE TRIGGER MetPago_Autoincrementa
BEFORE INSERT ON Metodo_pago
FOR EACH ROW
BEGIN
  SELECT SecuenciaMetPago_ID.NEXTVAL INTO :NEW.id_metodo_pago FROM DUAL;
END;
/

-- CREACION DE TRIGGER DE TABLA DE ROL
CREATE OR REPLACE TRIGGER Rol_Autoincrementa
BEFORE INSERT ON Rol
FOR EACH ROW
BEGIN
  SELECT SecuenciaRol_ID.NEXTVAL INTO :NEW.id_rol FROM DUAL;
END;
/

-- CREACION DE TRIGGER DE TABLA DE CLIENTE
CREATE OR REPLACE TRIGGER Cliente_Autoincrementa
BEFORE INSERT ON Cliente
FOR EACH ROW
BEGIN
  SELECT SecuenciaCliente_ID.NEXTVAL INTO :NEW.id_cliente FROM DUAL;
END;
/

-- CREACION DE TRIGGER DE TABLA DE USUARIO
CREATE OR REPLACE TRIGGER Usuario_Autoincrementa
BEFORE INSERT ON Usuario
FOR EACH ROW
BEGIN
  SELECT SecuenciaUsuario_ID.NEXTVAL INTO :NEW.id_usuario FROM DUAL;
END;
/

-- CREACION DE TRIGGER DE TABLA DE TURNO
CREATE OR REPLACE TRIGGER Turno_Autoincrementa
BEFORE INSERT ON Turno
FOR EACH ROW
BEGIN
  SELECT SecuenciaTurno_ID.NEXTVAL INTO :NEW.id_turno FROM DUAL;
END;
/

-- CREACION DE TRIGGER DE TABLA DE EGRESO
CREATE OR REPLACE TRIGGER Egreso_Autoincrementa
BEFORE INSERT ON Egreso
FOR EACH ROW
BEGIN
  SELECT SecuenciaEgreso_ID.NEXTVAL INTO :NEW.id_egreso FROM DUAL;
END;
/

-- CREACION DE TRIGGER DE TABLA DE RESERVACIÓN
CREATE OR REPLACE TRIGGER Reservacion_Autoincrementa
BEFORE INSERT ON Reservacion
FOR EACH ROW
BEGIN
  SELECT SecuenciaReservacion_ID.NEXTVAL INTO :NEW.id_reservacion FROM DUAL;
END;
/

-- CREACION DE TRIGGER DE TABLA DE FOLIO
CREATE OR REPLACE TRIGGER Folio_Autoincrementa
BEFORE INSERT ON Folio
FOR EACH ROW
BEGIN
  SELECT SecuenciaFolio_ID.NEXTVAL INTO :NEW.id_folio FROM DUAL;
END;
/

-- CREACION DE TRIGGER DE TABLA DE CARGOS EXTRA
CREATE OR REPLACE TRIGGER CargoExtra_Autoincrementa
BEFORE INSERT ON Cargo_extra
FOR EACH ROW
BEGIN
  SELECT SecuenciaCargoExtra_ID.NEXTVAL INTO :NEW.id_cargo_extra FROM DUAL;
END;
/

-- CREACION DE TRIGGER DE TABLA DE CARGOS EXTRA
CREATE OR REPLACE TRIGGER Pago_Autoincrementa
	BEFORE INSERT ON Pago
		FOR EACH ROW
			BEGIN
				SELECT SecuenciaPago_ID.NEXTVAL INTO :NEW.id_pago FROM DUAL;
	END;
/




--PROCEDIMIENTOS ALMACENADOS DE ENTRADA

------INSERT-----
--INSERT TABLA PERMISO
CREATE OR REPLACE PROCEDURE Permiso_Insertar (nivel_permisoD IN VARCHAR, descripcion_nivel_permisoD IN VARCHAR)
	AS
	BEGIN
		INSERT INTO Permiso (nivel_permiso, descripcion_nivel_permiso)
		VALUES (nivel_permisoD, descripcion_nivel_permisoD);
	END;
/

--INSERT TABLA ROL
CREATE OR REPLACE PROCEDURE Rol_Insertar (id_permiso IN NUMERIC, nombre_rol IN VARCHAR, descripcion_rol IN VARCHAR)
	AS
	BEGIN
		INSERT INTO Rol (id_permiso, nombre_rol, descripcion_rol)
		VALUES (id_permiso, nombre_rol, descripcion_rol);
	END;
/

--INSERT TABLA GÉNERO
CREATE OR REPLACE PROCEDURE Genero_Insertar (nombre_genero IN VARCHAR)
	AS
	BEGIN
		INSERT INTO Genero (nombre_genero)
		VALUES (nombre_genero);
	END;
/

--INSERT TABLA USUARIO
CREATE OR REPLACE PROCEDURE Usuario_Insertar (id_genero IN NUMERIC, id_rol IN NUMERIC, nombre_usuario IN VARCHAR, paterno_usuario IN VARCHAR, materno_usuario IN VARCHAR, telefono_usuario IN VARCHAR, identificacion_usuario IN VARCHAR, direccion_usuario IN VARCHAR, fecha_ingreso IN DATE, tiene_acceso_sistema IN VARCHAR, usuario IN VARCHAR, contrasena IN VARCHAR, estado_usuario IN VARCHAR)
	AS
	BEGIN
		INSERT INTO Usuario(id_genero, id_rol, nombre_usuario, paterno_usuario, materno_usuario, telefono_usuario, identificacion_usuario, direccion_usuario, fecha_ingreso, tiene_acceso_sistema, usuario, contrasena, estado_usuario)
		VALUES (id_genero, id_rol, nombre_usuario, paterno_usuario, materno_usuario, telefono_usuario, identificacion_usuario, direccion_usuario, fecha_ingreso, tiene_acceso_sistema, usuario, contrasena, estado_usuario);
	END;
/

--INSERT TABLA CLIENTE
CREATE OR REPLACE PROCEDURE Cliente_Insertar (id_genero IN NUMERIC, nombre_cliente IN VARCHAR, paterno_cliente IN VARCHAR, materno_cliente IN VARCHAR, telefono_cliente IN VARCHAR, identificacion_cliente IN VARCHAR, nota_cliente IN VARCHAR, estado_cliente IN VARCHAR)
	AS
	BEGIN
		INSERT INTO Cliente(id_genero, nombre_cliente, paterno_cliente, materno_cliente, telefono_cliente, identificacion_cliente, nota_cliente, estado_cliente)
		VALUES (id_genero, nombre_cliente, paterno_cliente, materno_cliente, telefono_cliente, identificacion_cliente, nota_cliente, estado_cliente);
	END;
/

--INSERT TABLA RESERVACIÓN
CREATE OR REPLACE PROCEDURE Reservacion_Insertar (id_usuario IN NUMERIC, id_cliente IN NUMERIC, fecha_hora_reservacion IN DATE, nota_reservacion IN VARCHAR)
	AS
	BEGIN
		INSERT INTO Reservacion (id_usuario, id_cliente, fecha_hora_reservacion, nota_reservacion)
		VALUES (id_usuario, id_cliente, fecha_hora_reservacion, nota_reservacion);
	END;
/

--EXECUTE Reservacion_Insertar (14,15,sysdate,'nota','Activo');

--INSERT TABLA TIPO HABITACIÓN
CREATE OR REPLACE PROCEDURE Tipo_Habitacion_Insertar (nombre_tipo_hab IN VARCHAR, descripcion_tip_hab IN VARCHAR)
	AS
	BEGIN
		INSERT INTO Tipo_habitacion(nombre_tipo_hab, descripcion_tip_hab)
		VALUES (nombre_tipo_hab, descripcion_tip_hab);
	END;
/

--INSERT TABLA HABITACIÓN
CREATE OR REPLACE PROCEDURE Habitacion_Insertar (numero_habitacion IN NUMERIC, id_tipo_hab IN NUMERIC, precio_habitacion IN NUMERIC, estado_habitacion IN VARCHAR, capacidad_habitacion IN NUMERIC, descripcion_habitacion IN VARCHAR)
	AS
	BEGIN
		INSERT INTO Habitacion(numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion)
		VALUES (numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion);
	END;
/

CREATE OR REPLACE PROCEDURE Reserv_has_Habit_Insertar (numero_habitacion IN NUMERIC, id_reservacion IN NUMERIC, check_in_prog IN VARCHAR, check_out_prog IN VARCHAR, check_in_real IN VARCHAR, check_out_real IN VARCHAR, estado_reservacion IN VARCHAR)
	AS
	BEGIN
		INSERT INTO Reservacion_has_Habitacion (numero_habitacion, id_reservacion, check_in_prog, check_out_prog, check_in_real, check_out_real, estado_reservacion)
		VALUES (numero_habitacion, id_reservacion, TO_DATE(check_in_prog, 'DD/MM/YY HH24:MI'), TO_DATE(check_out_prog, 'DD/MM/YY HH24:MI'), TO_DATE(check_in_real, 'DD/MM/YY HH24:MI'), TO_DATE(check_out_real, 'DD/MM/YY HH24:MI'), estado_reservacion);
	END;
/

--INSERT TABLA MÉTODO DE PAGO
CREATE OR REPLACE PROCEDURE Metodo_Pago_Insertar (nombre_met_pago IN VARCHAR, descripcion IN VARCHAR)
	AS
	BEGIN
		INSERT INTO Metodo_pago(nombre_met_pago, descripcion)
		VALUES (nombre_met_pago, descripcion);
	END;
/

--EXECUTE Turno_Insertar(14,500.00,500.00,null,sysdate, null,'gdgdg');

--INSERT TABLA EGRESO
CREATE OR REPLACE PROCEDURE Egreso_Insertar (id_turno IN NUMERIC, cantidad_egreso IN NUMERIC, fecha_hora_egreso IN DATE, concepto IN VARCHAR)
	AS
	BEGIN
		INSERT INTO Egreso (id_turno, cantidad_egreso, fecha_hora_egreso, concepto)
		VALUES (id_turno, cantidad_egreso, fecha_hora_egreso, concepto);
	END;
/

--INSERT TABLA FOLIO RESERVACION
CREATE OR REPLACE PROCEDURE FolioReserv_Insertar (id_reservacion IN NUMERIC, id_usuario IN NUMERIC, fecha_hora_folio IN DATE, estado_folio IN VARCHAR, nota_folio IN VARCHAR)
	AS
	BEGIN
		INSERT INTO Folio (id_reservacion, id_usuario, fecha_hora_folio, estado_folio, nota_folio)
		VALUES (id_reservacion, id_usuario, fecha_hora_folio, estado_folio, nota_folio);
	END;
/

--INSERT TABLA PAGO
CREATE OR REPLACE PROCEDURE pago_Insertar (id_folio IN NUMERIC, id_metodo_pago IN NUMERIC, cantidad_pago IN NUMERIC, fecha_hora_pago IN DATE)
	AS
	BEGIN
		INSERT INTO Pago (id_folio, id_metodo_pago, cantidad_pago, fecha_hora_pago)
		VALUES (id_folio, id_metodo_pago, cantidad_pago, fecha_hora_pago);
	END;
/



------UPDATE-----
--UPDATE TABLA PERMISO
CREATE OR REPLACE PROCEDURE Permiso_Actualizar (id_permisoD IN NUMERIC, nivel_permisoD IN VARCHAR, descripcion_nivel_permisoD IN VARCHAR)
	AS
	BEGIN
		UPDATE Permiso SET nivel_permiso = nivel_permisoD, descripcion_nivel_permiso = descripcion_nivel_permisoD
		WHERE id_permiso = id_permisoD;
	END;
/

--UPDATE TABLA ROL
CREATE OR REPLACE PROCEDURE Rol_Actualizar (id_rolD IN NUMERIC, id_permisoD IN NUMERIC, nombre_rolD IN VARCHAR, descripcion_rolD IN VARCHAR)
	AS
	BEGIN
		UPDATE Rol SET id_permiso = id_permisoD, nombre_rol = nombre_rolD, descripcion_rol = descripcion_rolD
		WHERE id_rol = id_rolD;
	END;
/

--UPDATE TABLA GENERO
CREATE OR REPLACE PROCEDURE Genero_Actualizar (id_generoD IN NUMERIC, nombre_generoD IN VARCHAR)
	AS
	BEGIN
		UPDATE Genero SET nombre_genero = nombre_generoD
		WHERE id_genero = id_generoD;
	END;
/

--UPDATE TABLA USUARIO
CREATE OR REPLACE PROCEDURE Usuario_Actualizar (id_usuarioD IN NUMERIC, id_generoD IN NUMERIC, id_rolD IN NUMERIC, nombre_usuarioD IN VARCHAR, paterno_usuarioD IN VARCHAR, materno_usuarioD IN VARCHAR, telefono_usuarioD IN VARCHAR, identificacion_usuarioD IN VARCHAR, direccion_usuarioD IN VARCHAR, tiene_acceso_sistemaD IN VARCHAR, usuarioD IN VARCHAR, contrasenaD IN VARCHAR, estado_usuarioD IN VARCHAR)
	AS
	BEGIN
		UPDATE Usuario SET id_genero = id_generoD, id_rol = id_rolD, nombre_usuario = nombre_usuarioD, paterno_usuario = paterno_usuarioD, materno_usuario = materno_usuarioD, telefono_usuario = telefono_usuarioD, identificacion_usuario = identificacion_usuarioD, direccion_usuario = direccion_usuarioD, tiene_acceso_sistema = tiene_acceso_sistemaD, usuario = usuarioD, contrasena = contrasenaD, estado_usuario = estado_usuarioD
		WHERE id_usuario = id_usuarioD;
	END;
/

--UPDATE TABLA CLIENTE
CREATE OR REPLACE PROCEDURE Cliente_Actualizar (id_clienteD IN NUMERIC, id_generoD IN NUMERIC, nombre_clienteD IN VARCHAR, paterno_clienteD IN VARCHAR, materno_clienteD IN VARCHAR, telefono_clienteD IN VARCHAR, identificacion_clienteD IN VARCHAR, nota_clienteD IN VARCHAR, estado_clienteD IN VARCHAR)
	AS
	BEGIN
		UPDATE Cliente SET id_genero = id_generoD, nombre_cliente = nombre_clienteD, paterno_cliente = paterno_clienteD, materno_cliente = materno_clienteD, telefono_cliente = telefono_clienteD, identificacion_cliente = identificacion_clienteD, nota_cliente = nota_clienteD, estado_cliente = estado_clienteD
		WHERE id_cliente = id_clienteD;
	END;
/

--UPDATE TABLA RESERVACION
CREATE OR REPLACE PROCEDURE Reservacion_Actualizar (id_reservacionD IN NUMERIC, id_usuarioD IN NUMERIC, id_clienteD IN NUMERIC, nota_reservacionD IN VARCHAR)
	AS
	BEGIN
		UPDATE Reservacion SET id_usuario = id_usuarioD, id_cliente = id_clienteD, nota_reservacion = nota_reservacionD
		WHERE id_reservacion = id_reservacionD;
	END;
/

--UPDATE TABLA TIPO HABITACION
CREATE OR REPLACE PROCEDURE Tipo_Habitacion_Actualizar (id_tipo_habD IN NUMERIC, nombre_tipo_habD IN VARCHAR, descripcion_tip_habD IN VARCHAR)
	AS
	BEGIN
		UPDATE Tipo_Habitacion SET nombre_tipo_hab = nombre_tipo_habD, descripcion_tip_hab = descripcion_tip_habD
		WHERE id_tipo_hab = id_tipo_habD;
	END;
/

--UPDATE TABLA HABITACION
CREATE OR REPLACE PROCEDURE Habitacion_Actualizar (numero_habitacionD IN NUMERIC, id_tipo_habD IN NUMERIC, precio_habitacionD IN NUMERIC, estado_habitacionD IN VARCHAR, capacidad_habitacionD IN NUMERIC, descripcion_habitacionD IN VARCHAR)
	AS
	BEGIN
		UPDATE Habitacion SET numero_habitacion = numero_habitacionD, id_tipo_hab = id_tipo_habD, precio_habitacion = precio_habitacionD, estado_habitacion = estado_habitacionD, capacidad_habitacion = capacidad_habitacionD, descripcion_habitacion = descripcion_habitacionD
		WHERE numero_habitacion = numero_habitacionD;
	END;
/

--UPDATE TABLA METODO DE PAGO
CREATE OR REPLACE PROCEDURE Metodo_Pago_Actualizar (id_metodo_pagoD IN NUMERIC, nombre_met_pagoD IN VARCHAR, descripcionD IN VARCHAR)
	AS
	BEGIN
		UPDATE Metodo_pago SET nombre_met_pago = nombre_met_pagoD, descripcion = descripcionD
		WHERE id_metodo_pago = id_metodo_pagoD;
	END;
/

--UPDATE TABLA TURNO
CREATE OR REPLACE PROCEDURE Turno_Actualizar (id_turnoD IN NUMERIC, id_usuarioD IN NUMERIC, cantidad_inicial_turnoD IN NUMERIC, cantidad_actual_turnoD IN NUMERIC, cantidad_cierre_turnoD IN NUMERIC, fecha_hora_cierreD IN DATE, nota_turnoD IN VARCHAR)
	AS
	BEGIN
		UPDATE Turno SET id_usuario = id_usuarioD, cantidad_inicial_turno = cantidad_inicial_turnoD, cantidad_actual_turno = cantidad_actual_turnoD, cantidad_cierre_turno = cantidad_cierre_turnoD, fecha_hora_cierre = fecha_hora_cierreD, nota_turno = nota_turnoD
		WHERE id_turno = id_turnoD;
	END;
/

--UPDATE TABLA EGRESO
CREATE OR REPLACE PROCEDURE Egreso_Actualizar (id_egresoD IN NUMERIC, id_turnoD IN NUMERIC, cantidad_egresoD IN NUMERIC, fecha_hora_egresoD IN DATE, conceptoD IN VARCHAR)
	AS
	BEGIN
		UPDATE Egreso SET id_turno = id_turnoD, cantidad_egreso = cantidad_egresoD, fecha_hora_egreso = fecha_hora_egresoD, concepto = conceptoD
		WHERE id_egreso = id_egresoD;
	END;
/

--UPDATE TABLA PAGO
CREATE OR REPLACE PROCEDURE Pago_Actualizar (id_pagoD IN NUMERIC, id_folioD IN NUMERIC, id_metodo_pagoD IN NUMERIC, cantidad_pagoD IN NUMERIC, fecha_hora_pagoD IN DATE)
	AS
	BEGIN
		UPDATE Pago SET id_folio = id_folioD, id_metodo_pago = id_metodo_pagoD, cantidad_pago = cantidad_pagoD, fecha_hora_pago = fecha_hora_pagoD
		WHERE id_pago = id_pagoD;
	END;
/



------DELETE-----
--DELETE TABLA PERMISO
CREATE OR REPLACE PROCEDURE Permiso_Eliminar (id_permisoD IN NUMERIC)
	AS
	BEGIN
		DELETE Permiso WHERE id_permiso = id_permisoD;
	END;
/

--DELETE TABLA ROL
CREATE OR REPLACE PROCEDURE Rol_Eliminar (id_rolD IN NUMERIC)
	AS
	BEGIN
		DELETE Rol WHERE id_rol = id_rolD;
	END;
/

--DELETE TABLA GENERO
CREATE OR REPLACE PROCEDURE Genero_Eliminar (id_generoD IN NUMERIC)
	AS
	BEGIN
		DELETE Genero WHERE id_genero = id_generoD;
	END;
/

--DELETE TABLA USUARIO
CREATE OR REPLACE PROCEDURE Usuario_Eliminar (id_usuarioD IN NUMERIC)
	AS
	BEGIN
		DELETE Usuario WHERE id_usuario = id_usuarioD;
	END;
/

--DELETE TABLA CLIENTE
CREATE OR REPLACE PROCEDURE Cliente_Eliminar (id_clienteD IN NUMERIC)
	AS
	BEGIN
		DELETE Cliente WHERE id_cliente = id_clienteD;
	END;
/

--DELETE TABLA RESERVACION
CREATE OR REPLACE PROCEDURE Reservacion_Eliminar (id_reservacionD IN NUMERIC)
	AS
	BEGIN
		DELETE Reservacion WHERE id_reservacion = id_reservacionD;
	END;
/

--DELETE TABLA TIPO HABITACION
CREATE OR REPLACE PROCEDURE Tipo_Habitacion_Eliminar (id_tipo_habD IN NUMERIC)
	AS
	BEGIN
		DELETE Tipo_Habitacion WHERE id_tipo_hab = id_tipo_habD;
	END;
/

--DELETE TABLA HABITACION
CREATE OR REPLACE PROCEDURE Habitacion_Eliminar (numero_habitacionD IN NUMERIC)
	AS
	BEGIN
		DELETE Habitacion WHERE numero_habitacion = numero_habitacionD;
	END;
/

--DELETE TABLA RESERVACION HAS HABITACION
CREATE OR REPLACE PROCEDURE Reserv_has_Habit_Eliminar(numero_habitacionD IN NUMERIC, id_reservacionD IN NUMERIC)
	AS
	BEGIN
		DELETE Reservacion_has_Habitacion WHERE numero_habitacion = numero_habitacionD
		AND id_reservacion = id_reservacionD;
	END;
/

--DELETE TABLA METODO DE PAGO
CREATE OR REPLACE PROCEDURE Metodo_Pago_Eliminar (id_metodo_pagoD IN NUMERIC)
	AS
	BEGIN
		DELETE Metodo_pago WHERE id_metodo_pago = id_metodo_pagoD;
	END;
/

--DELETE TABLA TURNO
CREATE OR REPLACE PROCEDURE Turno_Eliminar (id_turnoD IN NUMERIC)
	AS
	BEGIN
		DELETE Turno WHERE id_turno = id_turnoD;
	END;
/

--DELETE TABLA EGRESO
CREATE OR REPLACE PROCEDURE Egreso_Eliminar (id_egresoD IN NUMERIC)
	AS
	BEGIN
		DELETE Egreso WHERE id_egreso = id_egresoD;
	END;
/

--DELETE TABLA PAGO
CREATE OR REPLACE PROCEDURE Pago_Eliminar (id_pagoD IN NUMERIC)
	AS
	BEGIN
		DELETE Pago WHERE id_pago = id_pagoD;
	END;
/




--VISTAS

--VISTA DE PERMISO
CREATE OR REPLACE VIEW Vista_Todos_Permisos AS 
SELECT id_permiso As ID, nivel_permiso As "NIVEL DE PERMISO", descripcion_nivel_permiso As "DESCRIPCIÓN" 
FROM Permiso ORDER BY nivel_permiso ASC; 

--VISTA DE PERMISO
CREATE OR REPLACE VIEW Vista_Todos_Generos AS 
Select id_genero As ID, nombre_genero As "GÉNERO" 
FROM Genero ORDER BY nombre_genero ASC;

--VISTA DE ROL
CREATE OR REPLACE VIEW Vista_Todos_Roles AS 
SELECT r.id_rol As "ID ROL", p.id_permiso As "ID PERMISO", p.nivel_permiso As "NIVEL DE PERMISO", r.nombre_rol As "NOMBRE DEL ROL", r.descripcion_rol As "DESCRIPCIÓN" 
FROM Rol r, Permiso p 
WHERE r.id_permiso = p.id_permiso 
ORDER BY nivel_permiso ASC;

--VISTA DE USUARIO
CREATE OR REPLACE VIEW Vista_Todos_Usuarios AS 
SELECT u.id_usuario AS "ID USUARIO", g.id_genero AS "ID GÉNERO", r.id_rol AS "ID ROL", 
r.nombre_rol AS "ROL", u.nombre_usuario AS "NOMBRE", u.paterno_usuario AS "APELLIDO PATERNO", 
u.materno_usuario AS "APELLIDO MATERNO", g.nombre_genero AS "GÉNERO", 
u.telefono_usuario AS "TELÉFONO", u.identificacion_usuario AS "IDENTIFICACIÓN", 
u.direccion_usuario AS "DIRECCIÓN", u.fecha_ingreso AS "FECHA DE INGRESO", 
u.tiene_acceso_sistema AS "¿TIENE ACCESO?", u.usuario AS "USUARIO", 
u.contrasena AS "CONTRASEÑA", u.estado_usuario AS "ESTADO"
FROM Usuario u, Rol r, Genero g
WHERE u.id_rol = r.id_rol
AND u.id_genero = g.id_genero
ORDER BY r.nombre_rol ASC;

CREATE OR REPLACE VIEW Vista_Usuarios_Acceso AS 
SELECT u.id_usuario AS "ID USUARIO", g.id_genero AS "ID GÉNERO", r.id_rol AS "ID ROL", 
r.nombre_rol AS "ROL", u.nombre_usuario AS "NOMBRE", u.paterno_usuario AS "APELLIDO PATERNO", 
u.materno_usuario AS "APELLIDO MATERNO", g.nombre_genero AS "GÉNERO", 
u.telefono_usuario AS "TELÉFONO", u.identificacion_usuario AS "IDENTIFICACIÓN", 
u.direccion_usuario AS "DIRECCIÓN", u.fecha_ingreso AS "FECHA DE INGRESO", 
u.tiene_acceso_sistema AS "¿TIENE ACCESO?", u.usuario AS "USUARIO", 
u.contrasena AS "CONTRASEÑA", u.estado_usuario AS "ESTADO"
FROM Usuario u, Rol r, Genero g
WHERE u.id_rol = r.id_rol
AND u.id_genero = g.id_genero
				  AND u.tiene_acceso_sistema = 'Si'
                  ORDER BY nombre_rol;
				  
CREATE OR REPLACE VIEW Vista_Usuarios_SinAcceso AS 
SELECT u.id_usuario AS "ID USUARIO", g.id_genero AS "ID GÉNERO", r.id_rol AS "ID ROL", 
r.nombre_rol AS "ROL", u.nombre_usuario AS "NOMBRE", u.paterno_usuario AS "APELLIDO PATERNO", 
u.materno_usuario AS "APELLIDO MATERNO", g.nombre_genero AS "GÉNERO", 
u.telefono_usuario AS "TELÉFONO", u.identificacion_usuario AS "IDENTIFICACIÓN", 
u.direccion_usuario AS "DIRECCIÓN", u.fecha_ingreso AS "FECHA DE INGRESO", 
u.tiene_acceso_sistema AS "¿TIENE ACCESO?", u.usuario AS "USUARIO", 
u.contrasena AS "CONTRASEÑA", u.estado_usuario AS "ESTADO"
FROM Usuario u, Rol r, Genero g
WHERE u.id_rol = r.id_rol
AND u.id_genero = g.id_genero
				  AND u.tiene_acceso_sistema = 'No'
                  ORDER BY nombre_rol;
				  
CREATE OR REPLACE VIEW Vista_Usuarios_Desactivados AS 
SELECT u.id_usuario AS "ID USUARIO", g.id_genero AS "ID GÉNERO", r.id_rol AS "ID ROL", 
r.nombre_rol AS "ROL", u.nombre_usuario AS "NOMBRE", u.paterno_usuario AS "APELLIDO PATERNO", 
u.materno_usuario AS "APELLIDO MATERNO", g.nombre_genero AS "GÉNERO", 
u.telefono_usuario AS "TELÉFONO", u.identificacion_usuario AS "IDENTIFICACIÓN", 
u.direccion_usuario AS "DIRECCIÓN", u.fecha_ingreso AS "FECHA DE INGRESO", 
u.tiene_acceso_sistema AS "¿TIENE ACCESO?", u.usuario AS "USUARIO", 
u.contrasena AS "CONTRASEÑA", u.estado_usuario AS "ESTADO"
FROM Usuario u, Rol r, Genero g
WHERE u.id_rol = r.id_rol
AND u.id_genero = g.id_genero
				  AND u.estado_usuario = 'Desactivado'
                  ORDER BY nombre_rol;

--VISTA DE CLIENTE
CREATE OR REPLACE VIEW Vista_Todos_Clientes AS 
SELECT c.id_cliente AS "ID CLIENTE", g.id_genero AS "ID GÉNERO", c.nombre_cliente AS "NOMBRE", 
c.paterno_cliente AS "APELLIDO PATERNO", c.materno_cliente AS "APELLIDO MATERNO", 
g.nombre_genero AS "GÉNERO", c.telefono_cliente AS "TELÉFONO", c.identificacion_cliente AS "IDENTIFICACIÓN",
c.estado_cliente AS "ESTADO", c.nota_cliente AS "NOTA"
FROM Cliente c, Genero g
WHERE c.id_genero = g.id_genero
ORDER BY c.nombre_cliente;


CREATE OR REPLACE VIEW Vista_Clientes_Activos AS
SELECT c.id_cliente AS "ID CLIENTE", g.id_genero AS "ID GÉNERO", c.nombre_cliente AS "NOMBRE", 
                    c.paterno_cliente AS "APELLIDO PATERNO", c.materno_cliente AS "APELLIDO MATERNO", 
                    g.nombre_genero AS "GÉNERO", c.telefono_cliente AS "TELÉFONO", c.identificacion_cliente AS "IDENTIFICACIÓN",
                    c.estado_cliente AS "ESTADO", c.nota_cliente AS "NOTA"
                  FROM Cliente c, Genero g
                  WHERE c.id_genero = g.id_genero
                  AND c.estado_cliente = 'Activo'
                  ORDER BY c.nombre_cliente;
				  
CREATE OR REPLACE VIEW Vista_Clientes_Desactivados AS
SELECT c.id_cliente AS "ID CLIENTE", g.id_genero AS "ID GÉNERO", c.nombre_cliente AS "NOMBRE", 
                    c.paterno_cliente AS "APELLIDO PATERNO", c.materno_cliente AS "APELLIDO MATERNO", 
                    g.nombre_genero AS "GÉNERO", c.telefono_cliente AS "TELÉFONO", c.identificacion_cliente AS "IDENTIFICACIÓN",
                    c.estado_cliente AS "ESTADO", c.nota_cliente AS "NOTA"
                  FROM Cliente c, Genero g
                  WHERE c.id_genero = g.id_genero
                  AND c.estado_cliente = 'Desactivado'
                  ORDER BY c.nombre_cliente;
				  
CREATE OR REPLACE VIEW Vista_Clientes_CheckOut AS
SELECT c.id_cliente AS "ID CLIENTE", g.id_genero AS "ID GÉNERO",
                    c.nombre_cliente AS "NOMBRE", c.paterno_cliente AS "APELLIDO PATERNO", c.materno_cliente AS "APELLIDO MATERNO", 
                    g.nombre_genero AS "GÉNERO", c.telefono_cliente AS "TELÉFONO", c.identificacion_cliente AS "IDENTIFICACIÓN",
                    c.estado_cliente AS "ESTADO", c.nota_cliente AS "NOTA",  rh.check_in_real As "CHECK IN", rh.check_out_real AS "CHECK OUT"
                  FROM Cliente c, Genero g, Reservacion r, Reservacion_has_Habitacion rh
                  WHERE c.id_genero = g.id_genero
                  AND c.id_cliente = r.id_cliente
                  AND r.id_reservacion = rh.id_reservacion
                  AND rh.check_out_real IS NOT NULL
                  ORDER BY c.nombre_cliente;
				  
--VISTA DE TURNO
CREATE OR REPLACE VIEW Vista_Todos_Turnos AS
SELECT t.id_turno AS "ID TURNO", t.id_usuario AS "ID USUARIO", t.fecha_hora_apertura AS "APERTURA", t.fecha_hora_cierre AS "CIERRE",
u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS "ENCARGADO DE TURNO", t.cantidad_inicial_turno AS "CANTIDAD $ INICIAL", 
t.cantidad_actual_turno AS "CANTIDAD ACTUAL $", t.cantidad_cierre_turno AS "CANTIDAD CIERRE $", (cantidad_cierre_turno - cantidad_actual_turno) AS "DIFERENCIA $"
, t.nota_turno AS "NOTA DE TURNO"
FROM Turno t, Usuario u
WHERE t.id_usuario = u.id_usuario
ORDER BY t.fecha_hora_apertura ASC;

--VISTA MÉTODO DE PAGO
CREATE OR REPLACE VIEW Vista_Todos_Met_Pago AS
SELECT id_metodo_pago AS "ID", nombre_met_pago AS "NOMBRE", 
descripcion AS "DESCRIPCIÓN" 
FROM Metodo_pago 
ORDER BY nombre_met_pago ASC;

--VISTA DE TODAS LAS RESERVACIONES EN RESERVACION HAS HABITACION
CREATE OR REPLACE VIEW Vista_Todo_Reserv_Has_Hab AS
SELECT rh.id_reservacion AS "ID RESERVACIÓN", r.id_cliente AS "ID CLIENTE", r.id_usuario AS "ID USUARIO", r.fecha_hora_reservacion AS "FECHA DE LA RESERVACIÓN", 
c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS "NOMBRE DEL CLIENTE", c.telefono_cliente AS "TELÉFONO", c.identificacion_cliente AS "IDENTIFICACIÓN", c.nombre_cliente AS "NOMBRE",
rh.numero_habitacion AS "NÚMERO DE HABITACIÓN", h.precio_habitacion AS "PRECIO X NOCHE", 
h.capacidad_habitacion AS "CAPACIDAD", th.nombre_tipo_hab AS "TIPO DE HABITACIÓN", rh.check_in_prog AS "CHECK IN PROGRAMADO",
rh.check_out_prog AS "CHECK OUT PROGRAMADO", rh.check_in_real AS "CHECK IN REAL", rh.check_out_real AS "CHECK OUT REAL",  
u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS "ATENDIDO POR", 
rh.estado_reservacion AS "ESTADO RESERVACIÓN", r.nota_reservacion AS "NOTA"
FROM Reservacion_has_Habitacion rh, Reservacion r, Usuario u, Cliente c, Habitacion h, Tipo_Habitacion th
WHERE rh.numero_habitacion = h.numero_habitacion
AND h.id_tipo_hab = th.id_tipo_hab
AND rh.id_reservacion = r.id_reservacion
AND r.id_usuario = u.id_usuario
AND r.id_cliente = c.id_cliente
ORDER BY rh.check_in_prog DESC;

--VISTA DE LAS RESERVACIONES CON ESTADO ACTIVO
CREATE OR REPLACE VIEW Vista_Reserv_Has_Hab_Activa AS
SELECT rh.id_reservacion AS "ID RESERVACIÓN", r.id_cliente AS "ID CLIENTE", r.id_usuario AS "ID USUARIO", r.fecha_hora_reservacion AS "FECHA DE LA RESERVACIÓN", 
c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS "NOMBRE DEL CLIENTE", c.telefono_cliente AS "TELÉFONO", c.identificacion_cliente AS "IDENTIFICACIÓN", c.nombre_cliente AS "NOMBRE",
rh.numero_habitacion AS "NÚMERO DE HABITACIÓN", h.precio_habitacion AS "PRECIO X NOCHE", 
h.capacidad_habitacion AS "CAPACIDAD", th.nombre_tipo_hab AS "TIPO DE HABITACIÓN", rh.check_in_prog AS "CHECK IN PROGRAMADO",
rh.check_out_prog AS "CHECK OUT PROGRAMADO", rh.check_in_real AS "CHECK IN REAL", rh.check_out_real AS "CHECK OUT REAL",  
u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS "ATENDIDO POR", 
rh.estado_reservacion AS "ESTADO RESERVACIÓN", r.nota_reservacion AS "NOTA"
FROM Reservacion_has_Habitacion rh, Reservacion r, Usuario u, Cliente c, Habitacion h, Tipo_Habitacion th
WHERE rh.numero_habitacion = h.numero_habitacion
AND h.id_tipo_hab = th.id_tipo_hab
AND rh.id_reservacion = r.id_reservacion
AND r.id_usuario = u.id_usuario
AND r.id_cliente = c.id_cliente
AND rh.estado_reservacion = 'Activa'
ORDER BY rh.check_in_prog DESC;

--VISTA DE LAS RESERVACIONES CON ESTADO CANCELADO
CREATE OR REPLACE VIEW Vista_Reserv_Has_Hab_Cancelada AS
SELECT rh.id_reservacion AS "ID RESERVACIÓN", r.id_cliente AS "ID CLIENTE", r.id_usuario AS "ID USUARIO", r.fecha_hora_reservacion AS "FECHA DE LA RESERVACIÓN", 
c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS "NOMBRE DEL CLIENTE", c.telefono_cliente AS "TELÉFONO", c.identificacion_cliente AS "IDENTIFICACIÓN", c.nombre_cliente AS "NOMBRE",
rh.numero_habitacion AS "NÚMERO DE HABITACIÓN", h.precio_habitacion AS "PRECIO X NOCHE", 
h.capacidad_habitacion AS "CAPACIDAD", th.nombre_tipo_hab AS "TIPO DE HABITACIÓN", rh.check_in_prog AS "CHECK IN PROGRAMADO",
rh.check_out_prog AS "CHECK OUT PROGRAMADO", rh.check_in_real AS "CHECK IN REAL", rh.check_out_real AS "CHECK OUT REAL",  
u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS "ATENDIDO POR", 
rh.estado_reservacion AS "ESTADO RESERVACIÓN", r.nota_reservacion AS "NOTA"
FROM Reservacion_has_Habitacion rh, Reservacion r, Usuario u, Cliente c, Habitacion h, Tipo_Habitacion th
WHERE rh.numero_habitacion = h.numero_habitacion
AND h.id_tipo_hab = th.id_tipo_hab
AND rh.id_reservacion = r.id_reservacion
AND r.id_usuario = u.id_usuario
AND r.id_cliente = c.id_cliente
AND rh.estado_reservacion = 'Cancelada'
ORDER BY rh.check_in_prog DESC; 

--VISTA DE LAS RESERVACIONES CON ESTADO CANCELADO
CREATE OR REPLACE VIEW Vista_Reserv_Has_Hab_CheckOut AS
SELECT rh.id_reservacion AS "ID RESERVACIÓN", r.id_cliente AS "ID CLIENTE", r.id_usuario AS "ID USUARIO", r.fecha_hora_reservacion AS "FECHA DE LA RESERVACIÓN", 
c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS "NOMBRE DEL CLIENTE", c.telefono_cliente AS "TELÉFONO", c.identificacion_cliente AS "IDENTIFICACIÓN", c.nombre_cliente AS "NOMBRE",
rh.numero_habitacion AS "NÚMERO DE HABITACIÓN", h.precio_habitacion AS "PRECIO X NOCHE", 
h.capacidad_habitacion AS "CAPACIDAD", th.nombre_tipo_hab AS "TIPO DE HABITACIÓN", rh.check_in_prog AS "CHECK IN PROGRAMADO",
rh.check_out_prog AS "CHECK OUT PROGRAMADO", rh.check_in_real AS "CHECK IN REAL", rh.check_out_real AS "CHECK OUT REAL",  
u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS "ATENDIDO POR", 
rh.estado_reservacion AS "ESTADO RESERVACIÓN", r.nota_reservacion AS "NOTA"
FROM Reservacion_has_Habitacion rh, Reservacion r, Usuario u, Cliente c, Habitacion h, Tipo_Habitacion th
WHERE rh.numero_habitacion = h.numero_habitacion
AND h.id_tipo_hab = th.id_tipo_hab
AND rh.id_reservacion = r.id_reservacion
AND r.id_usuario = u.id_usuario
AND r.id_cliente = c.id_cliente
AND rh.estado_reservacion = 'Check Out'
ORDER BY rh.check_in_prog DESC;


--VISTA DE LAS TODAS LAS HABITACIONES
CREATE OR REPLACE VIEW Vista_Todas_Habitaciones AS
SELECT h.numero_habitacion AS "NÚMERO DE HABITACÓN", th.nombre_tipo_hab AS "TIPO HABITACIÓN",
h.precio_habitacion AS "PRECIO X NOCHE", h.capacidad_habitacion AS "CAPACIDAD", h.descripcion_habitacion AS "DESCRIPCIÓN"
FROM Habitacion h, Tipo_Habitacion th
WHERE h.id_tipo_hab = th.id_tipo_hab
ORDER BY h.numero_habitacion ASC;

--VISTA DE LAS TODAS LAS HABITACIONES con disponibilidad
CREATE OR REPLACE VIEW Vista_Habitaciones_Disponibles AS
SELECT h.numero_habitacion AS "NÚMERO DE HABITACIÓN", th.nombre_tipo_hab AS "TIPO HABITACIÓN",
h.precio_habitacion AS "PRECIO X NOCHE", h.capacidad_habitacion AS "CAPACIDAD", h.descripcion_habitacion AS "DESCRIPCIÓN"
FROM Habitacion h, Tipo_Habitacion th
WHERE h.id_tipo_hab = th.id_tipo_hab
AND estado_habitacion = 'Disponible' 
ORDER BY h.numero_habitacion ASC;

--VISTA DE TODAS LAS HABITACIONES CON RESERVACION EN CURSO, PARCIALMENTE DISPONIBLES
CREATE OR REPLACE VIEW Vista_Habitaciones_Ocupadas AS
SELECT h.numero_habitacion AS "NÚMERO DE HABITACIÓN", th.nombre_tipo_hab AS "TIPO HABITACIÓN",
h.precio_habitacion AS "PRECIO X NOCHE", h.capacidad_habitacion AS "CAPACIDAD", h.descripcion_habitacion AS "DESCRIPCIÓN",
rh.check_in_prog AS "CHECK IN PROGRAMADO", rh.check_out_prog AS "CHECK OUT PROGRAMADO"
FROM Habitacion h, Tipo_Habitacion th, Reservacion_has_Habitacion rh
WHERE h.id_tipo_hab = th.id_tipo_hab
AND rh.numero_habitacion = h.numero_habitacion
AND rh.check_in_real IS NULL
AND rh.check_out_real IS NULL
ORDER BY h.numero_habitacion ASC;

--VISTA DE TIPO HABITACION
CREATE OR REPLACE VIEW Vista_Tipo_Habitacion AS
SELECT id_tipo_hab AS "ID TIPO HABITACIÓN", nombre_tipo_hab AS "TIPO DE HABITACIÓN", descripcion_tip_hab AS "DESCRIPCIÓN DE LA HABITACIÓN"
FROM Tipo_Habitacion
ORDER BY nombre_tipo_hab ASC;

--VISTA DE HABITACIONES
CREATE OR REPLACE VIEW Vista_Todas_Habitaciones AS
SELECT h.numero_habitacion AS "NÚMERO", t.id_tipo_hab AS "ID TIPO", t.nombre_tipo_hab AS "TIPO", h.precio_habitacion AS "PRECIO", h.estado_habitacion AS "ESTADO", h.capacidad_habitacion AS "CAPACIDAD", h.descripcion_habitacion AS "DESCRIPCIÓN"
FROM Habitacion h, Tipo_Habitacion t
WHERE h.id_tipo_hab = t.id_tipo_hab
ORDER BY h.numero_habitacion;

--VISTA DE HABITACIONES
CREATE OR REPLACE VIEW Vista_Habitaciones_Limp AS
SELECT h.numero_habitacion AS "NÚMERO", t.id_tipo_hab AS "ID TIPO", t.nombre_tipo_hab AS "TIPO", h.precio_habitacion AS "PRECIO", h.estado_habitacion AS "ESTADO", h.capacidad_habitacion AS "CAPACIDAD", h.descripcion_habitacion AS "DESCRIPCIÓN"
FROM Habitacion h, Tipo_Habitacion t
WHERE h.id_tipo_hab = t.id_tipo_hab
AND estado_habitacion = 'Limpieza' 
ORDER BY h.numero_habitacion ASC;

--VISTA DE HABITACIONES
CREATE OR REPLACE VIEW Vista_Habitaciones_Inhab AS
SELECT h.numero_habitacion AS "NÚMERO", t.id_tipo_hab AS "ID TIPO", t.nombre_tipo_hab AS "TIPO", h.precio_habitacion AS "PRECIO", h.estado_habitacion AS "ESTADO", h.capacidad_habitacion AS "CAPACIDAD", h.descripcion_habitacion AS "DESCRIPCIÓN"
FROM Habitacion h, Tipo_Habitacion t
WHERE h.id_tipo_hab = t.id_tipo_hab
AND estado_habitacion = 'Inactiva' 
ORDER BY h.numero_habitacion ASC;

--VISTA DE SELECCION DE RESERVACION PARA COBRO EXTRA
CREATE OR REPLACE VIEW Vista_Todas_Reserv_Carg_Extra AS
SELECT f.id_folio AS "ID FOLIO", f.id_usuario AS "ID USUARIO", f.id_reservacion AS "NÚMERO DE RESERVACIÓN",
c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS "NOMBRE DEL CLIENTE", c.nombre_cliente, c.paterno_cliente, c.telefono_cliente AS "TELÉFONO CLIENTE", c.identificacion_cliente AS "IDENTIFICACIÓN CLIENTE",
u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS "ATENDIDO POR"
FROM Folio f, Reservacion r, Usuario u, Cliente c, Reservacion_has_Habitacion rh
WHERE f.id_reservacion = r.id_reservacion
AND f.id_usuario = u.id_usuario
AND r.id_cliente = c.id_cliente
AND rh.id_reservacion = r.id_reservacion
AND rh.estado_reservacion <> 'Cancelada'
AND rh.estado_reservacion <> 'Check Out'
GROUP BY f.id_folio, f.id_usuario, f.id_reservacion, c.nombre_cliente, c.paterno_cliente, c.materno_cliente, c.telefono_cliente, c.identificacion_cliente, u.nombre_usuario , u.paterno_usuario, u.materno_usuario , f.fecha_hora_folio
ORDER BY f.fecha_hora_folio DESC;

--VISTA DE FOLIO
CREATE OR REPLACE VIEW Vista_Todo_Folio AS
SELECT f.id_folio AS "ID FOLIO", f.id_reservacion AS "ID RESERVACIÓN", r.fecha_hora_reservacion AS "FECHA RESERVACIÓN", f.fecha_hora_folio AS "FECHA FOLIO", r.id_cliente, c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS "NOMBRE DEL CLIENTE", 
c.telefono_cliente AS "TELÉFONO CLIENTE", c.identificacion_cliente AS "IDENTIFICACIÓN CLIENTE",
u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS "ATENDIDO POR", estado_folio AS "ESTADO",
f.nota_folio AS "NOTA"
FROM Folio f, Reservacion r, Cliente c, Usuario u
WHERE f.id_reservacion = r.id_reservacion
AND r.id_cliente = c.id_cliente
AND f.id_usuario = u.id_usuario
ORDER BY r.fecha_hora_reservacion;

--VISTA DE FOLIOs activos
CREATE OR REPLACE VIEW Vista_Folios_Activo AS
SELECT f.id_folio AS "ID FOLIO", f.id_reservacion AS "ID RESERVACIÓN", r.fecha_hora_reservacion AS "FECHA RESERVACIÓN", f.fecha_hora_folio AS "FECHA FOLIO", r.id_cliente, c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS "NOMBRE DEL CLIENTE", 
c.telefono_cliente AS "TELÉFONO CLIENTE", c.identificacion_cliente AS "IDENTIFICACIÓN CLIENTE",
u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS "ATENDIDO POR", estado_folio AS "ESTADO",
f.nota_folio AS "NOTA"
FROM Folio f, Reservacion r, Cliente c, Usuario u
WHERE f.id_reservacion = r.id_reservacion
AND r.id_cliente = c.id_cliente
AND f.id_usuario = u.id_usuario
AND estado_folio = 'Activo'
ORDER BY r.fecha_hora_reservacion;

--VISTA DE FOLIOs completado
CREATE OR REPLACE VIEW Vista_Folios_Completados AS
SELECT f.id_folio AS "ID FOLIO", f.id_reservacion AS "ID RESERVACIÓN", r.fecha_hora_reservacion AS "FECHA RESERVACIÓN", f.fecha_hora_folio AS "FECHA FOLIO", r.id_cliente, c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS "NOMBRE DEL CLIENTE", 
c.telefono_cliente AS "TELÉFONO CLIENTE", c.identificacion_cliente AS "IDENTIFICACIÓN CLIENTE",
u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS "ATENDIDO POR", estado_folio AS "ESTADO",
f.nota_folio AS "NOTA"
FROM Folio f, Reservacion r, Cliente c, Usuario u
WHERE f.id_reservacion = r.id_reservacion
AND r.id_cliente = c.id_cliente
AND f.id_usuario = u.id_usuario
AND estado_folio = 'Completado'
ORDER BY r.fecha_hora_reservacion;

--VISTA DE FOLIOs pendientes
CREATE OR REPLACE VIEW Vista_Folios_Pendientes AS
SELECT f.id_folio AS "ID FOLIO", f.id_reservacion AS "ID RESERVACIÓN", r.fecha_hora_reservacion AS "FECHA RESERVACIÓN", f.fecha_hora_folio AS "FECHA FOLIO", r.id_cliente, c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS "NOMBRE DEL CLIENTE", 
c.telefono_cliente AS "TELÉFONO CLIENTE", c.identificacion_cliente AS "IDENTIFICACIÓN CLIENTE",
u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS "ATENDIDO POR", estado_folio AS "ESTADO",
f.nota_folio AS "NOTA"
FROM Folio f, Reservacion r, Cliente c, Usuario u
WHERE f.id_reservacion = r.id_reservacion
AND r.id_cliente = c.id_cliente
AND f.id_usuario = u.id_usuario
AND estado_folio = 'Pendiente'
ORDER BY r.fecha_hora_reservacion;

--VISTA DE FOLIOs cancelados
CREATE OR REPLACE VIEW Vista_Folios_Cancelados AS
SELECT f.id_folio AS "ID FOLIO", f.id_reservacion AS "ID RESERVACIÓN", r.fecha_hora_reservacion AS "FECHA RESERVACIÓN", f.fecha_hora_folio AS "FECHA FOLIO", r.id_cliente, c.nombre_cliente ||' '|| c.paterno_cliente ||' '|| c.materno_cliente AS "NOMBRE DEL CLIENTE", 
c.telefono_cliente AS "TELÉFONO CLIENTE", c.identificacion_cliente AS "IDENTIFICACIÓN CLIENTE",
u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS "ATENDIDO POR", estado_folio AS "ESTADO",
f.nota_folio AS "NOTA"
FROM Folio f, Reservacion r, Cliente c, Usuario u
WHERE f.id_reservacion = r.id_reservacion
AND r.id_cliente = c.id_cliente
AND f.id_usuario = u.id_usuario
AND estado_folio = 'Cancelada'
ORDER BY r.fecha_hora_reservacion;

--VISTA DE LA TABLA EGRESO
CREATE OR REPLACE VIEW Vista_Egreso AS
SELECT e.id_egreso AS "ID EGRESO", e.id_turno AS "TURNO", e.fecha_hora_egreso AS "FECHA DE EGRESO",
e.cantidad_egreso AS "CANTIDAD DE EGRESO $", e.concepto AS "CONCEPTO DE EGRESO",
u.nombre_usuario ||' '|| u.paterno_usuario ||' '|| u.materno_usuario AS "USUARIO QUE REALIZÓ EL RETIRO"
FROM Egreso e, Turno t, Usuario u
WHERE e.id_turno = t.id_turno
AND t.id_usuario = u.id_usuario
ORDER BY fecha_hora_egreso DESC;



-- LLENADO DE TABLAS

--TABLA DE PERMISO
INSERT INTO Permiso (nivel_permiso, descripcion_nivel_permiso)--ID 1
VALUES ('Alto', 'Administración en la BD');

INSERT INTO Permiso (nivel_permiso, descripcion_nivel_permiso)
VALUES ('Medio', 'Uso en nivel Medio en la BD');

INSERT INTO Permiso (nivel_permiso, descripcion_nivel_permiso)
VALUES ('Bajo', 'Uso en nivel Bajo en la BD');

INSERT INTO Permiso (nivel_permiso, descripcion_nivel_permiso)
VALUES ('Ninguno', 'Ningún uso en la BD');

--TABLA DE ROL
INSERT INTO Rol (id_permiso, nombre_rol, descripcion_rol)--ID 1
VALUES (1,'Administrador', 'Rol con permisos de Alto nivel en la BD');

INSERT INTO Rol (id_permiso, nombre_rol, descripcion_rol)
VALUES (1,'Encargado', 'Rol con permisos de Alto nivel en la BD');

INSERT INTO Rol (id_permiso, nombre_rol, descripcion_rol)
VALUES (2,'Recepcionista', 'Rol con permisos de Medio nivel en la BD');

INSERT INTO Rol (id_permiso, nombre_rol, descripcion_rol)
VALUES (3,'Contador', 'Rol con permisos de Bajo nivel en la BD');

INSERT INTO Rol (id_permiso, nombre_rol, descripcion_rol)
VALUES (4,'Empleado', 'Rol con ningún permiso en la BD');

--TABLA DE GÉNERO
INSERT INTO Genero(nombre_genero)--ID 1
VALUES ('Másculino');

INSERT INTO Genero(nombre_genero)
VALUES ('Femenino');

INSERT INTO Genero(nombre_genero)
VALUES ('No binario');

--TABLA DE MÉTODO DE PAGO
INSERT INTO Metodo_pago(nombre_met_pago, descripciOn)
VALUES ('Efectivo','Pago realizado con moneda nacional MX');

INSERT INTO Metodo_pago(nombre_met_pago, descripciOn)
VALUES ('Tarjeta','Pago realizado con tarjeta de crédito/débito con divisa nacional MX');

--TABLA DE USUARIO
--ID 1
INSERT INTO Usuario(id_genero, id_rol, nombre_usuario, paterno_usuario, materno_usuario, telefono_usuario, identificacion_usuario, direccion_usuario, fecha_ingreso, tiene_acceso_sistema, usuario, contrasena, estado_usuario)
VALUES (2, 3, 'Eimy Lu-ruhama', 'Cruz', 'Rodríguez', '8441012907', '0120545268512', 'CALLE 5 DE MAYO #107', SYSDATE, 'Si', 'eimy', '123', 'Activo');

INSERT INTO Usuario(id_genero, id_rol, nombre_usuario, paterno_usuario, materno_usuario, telefono_usuario, identificacion_usuario, direccion_usuario, fecha_ingreso, tiene_acceso_sistema, usuario, contrasena, estado_usuario)
VALUES (1, 4, 'Braulio Humberto', 'Dávila', 'Saucedo', '8441012902', '0120546585412', 'CALLE 5 DE MAYO #108', SYSDATE, 'Si', 'braulio', '123', 'Activo');

INSERT INTO Usuario(id_genero, id_rol, nombre_usuario, paterno_usuario, materno_usuario, telefono_usuario, identificacion_usuario, direccion_usuario, fecha_ingreso, tiene_acceso_sistema, usuario, contrasena, estado_usuario)
VALUES (1, 2, 'Mario Orlando', 'Torres', 'Salazar', '8441012903', '0125469851265', 'CALLE 5 DE MAYO #109', SYSDATE, 'Si', 'mario', '123', 'Activo');

INSERT INTO Usuario(id_genero, id_rol, nombre_usuario, paterno_usuario, materno_usuario, telefono_usuario, identificacion_usuario, direccion_usuario, fecha_ingreso, tiene_acceso_sistema, usuario, contrasena, estado_usuario)
VALUES (1, 1, 'Brandon Alexis', 'Prado', 'Castro', '8441012904', '0126596325642', 'CALLE 5 DE MAYO #110', SYSDATE, 'Si', 'brandon', '123', 'Activo');

INSERT INTO Usuario(id_genero, id_rol, nombre_usuario, paterno_usuario, materno_usuario, telefono_usuario, identificacion_usuario, direccion_usuario, fecha_ingreso, tiene_acceso_sistema, usuario, contrasena, estado_usuario)
VALUES (1, 5, 'Alexis', 'Prado', 'Castro', '8441012910', '0125654896521', 'CALLE 5 DE MAYO #111', SYSDATE, 'No', NULL, NULL, 'Desactivado');

--TABLA DE CLIENTE
--ID 1
INSERT INTO Cliente(id_genero, nombre_cliente, paterno_cliente, materno_cliente, telefono_cliente, identificacion_cliente, nota_cliente, estado_cliente)
VALUES (1, 'Pedro', 'Hernández', 'Lopéz', '8441002525', '0123256342541', NULL, 'Activo');

INSERT INTO Cliente(id_genero, nombre_cliente, paterno_cliente, materno_cliente, telefono_cliente, identificacion_cliente, nota_cliente, estado_cliente)
VALUES (2, 'Marta', 'Pérez', 'Valdez', '8441002526', '0120564126574', NULL, 'Activo');

INSERT INTO Cliente(id_genero, nombre_cliente, paterno_cliente, materno_cliente, telefono_cliente, identificacion_cliente, nota_cliente, estado_cliente)
VALUES (3, 'Juan', 'Téllez', 'Álvarez', '8441002527', '0120654428952', NULL, 'Activo');

INSERT INTO Cliente(id_genero, nombre_cliente, paterno_cliente, materno_cliente, telefono_cliente, identificacion_cliente, nota_cliente, estado_cliente)
VALUES (2, 'Andrea', 'Segovia', 'Álvarez', '8441002540', '0120654428953', NULL, 'Activo');

INSERT INTO Cliente(id_genero, nombre_cliente, paterno_cliente, materno_cliente, telefono_cliente, identificacion_cliente, nota_cliente, estado_cliente)
VALUES (1, 'Daniel', 'Gallardo', 'Cuevas', '8441022543', '0120654728953', NULL, 'Activo');

INSERT INTO Cliente(id_genero, nombre_cliente, paterno_cliente, materno_cliente, telefono_cliente, identificacion_cliente, nota_cliente, estado_cliente)
VALUES (2, 'Estefanía', 'Casas', 'Cuevas', '8441022558', '0120744728953', NULL, 'Activo');

INSERT INTO Cliente(id_genero, nombre_cliente, paterno_cliente, materno_cliente, telefono_cliente, identificacion_cliente, nota_cliente, estado_cliente)
VALUES (2, 'Nicole', 'Puente', 'Flores', '8441026258', '0120744998951', NULL, 'Activo');

INSERT INTO Cliente(id_genero, nombre_cliente, paterno_cliente, materno_cliente, telefono_cliente, identificacion_cliente, nota_cliente, estado_cliente)
VALUES (1, 'Rodrigo', 'Fuantos', 'Díaz', '8441029958', '0120744728999', NULL, 'Activo');

INSERT INTO Cliente(id_genero, nombre_cliente, paterno_cliente, materno_cliente, telefono_cliente, identificacion_cliente, nota_cliente, estado_cliente)
VALUES (3, 'Favian', 'Veléz', 'Duarte', '8421029958', '0120740289537', NULL, 'Activo');

INSERT INTO Cliente(id_genero, nombre_cliente, paterno_cliente, materno_cliente, telefono_cliente, identificacion_cliente, nota_cliente, estado_cliente)
VALUES (1, 'Nayla', 'Duarte', 'Castro', '8441022560', '0120744728966', NULL, 'Activo');



--TABLA TIPO_HABITACION
--ID 1
INSERT INTO Tipo_habitacion(nombre_tipo_hab, descripcion_tip_hab)
VALUES ('SENCILLA', 'HABITACIÓN CON UNA SOLA CAMA');

INSERT INTO Tipo_habitacion(nombre_tipo_hab, descripcion_tip_hab)
VALUES ('DOBLE', 'HABITACIÓN CON UNA CAMA Y SOFÁ CONVERTIBLE');

INSERT INTO Tipo_habitacion(nombre_tipo_hab, descripcion_tip_hab)
VALUES ('FAMILIAR', 'HABITACIÓN CON DOS CAMAS Y SOFÁ CONVERTIBLE');

INSERT INTO Tipo_habitacion(nombre_tipo_hab, descripcion_tip_hab)
VALUES ('PREMIUM', 'HABITACIÓN CON UNA CAMA KING SIZE, UNA CAMA MATRIMONIAL Y SOFÁ CONVERTIBLE');


--TABLA DE HABITACIÓN
--ID 100
INSERT INTO Habitacion(numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion)
VALUES (100, 1, 400.00, 'Disponible', 1, 'HABITACIÓN BÁSICA CON CAMA INDIVIDUAL Y BAÑO COMPARTIDO');

INSERT INTO Habitacion(numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion)
VALUES (101, 1, 400.00, 'Disponible', 1, 'HABITACIÓN BÁSICA CON CAMA INDIVIDUAL Y BAÑO COMPARTIDO');

INSERT INTO Habitacion(numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion)
VALUES (102, 1, 400.00, 'Disponible', 1, 'HABITACIÓN BÁSICA CON CAMA INDIVIDUAL Y BAÑO COMPARTIDO');

INSERT INTO Habitacion(numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion)
VALUES (103, 2, 800.00, 'Disponible', 2, 'HABITACIÓN CON CAMA INDIVIDUAL, SOFÁ CONVERTIBLE A CAMA, BAÑO Y TV');

INSERT INTO Habitacion(numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion)
VALUES (104, 2, 800.00, 'Disponible', 2, 'HABITACIÓN CON CAMA INDIVIDUAL, SOFÁ CONVERTIBLE A CAMA, BAÑO Y TV');

INSERT INTO Habitacion(numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion)
VALUES (105, 2, 800.00, 'Disponible', 2, 'HABITACIÓN CON CAMA INDIVIDUAL, SOFÁ CONVERTIBLE A CAMA, BAÑO Y TV');

INSERT INTO Habitacion(numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion)
VALUES (106, 2, 800.00, 'Disponible', 2, 'HABITACIÓN CON CAMA INDIVIDUAL, SOFÁ CONVERTIBLE A CAMA, BAÑO Y TV');

INSERT INTO Habitacion(numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion)
VALUES (107, 2, 800.00, 'Disponible', 2, 'HABITACIÓN CON CAMA INDIVIDUAL, SOFÁ CONVERTIBLE A CAMA, BAÑO Y TV');

INSERT INTO Habitacion(numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion)
VALUES (108, 3, 1200.00, 'Disponible', 4, 'HABITACIÓN CON CAMA MATRIMONIAL, CAMA INDIVIDUAL Y SOFÁ CONVERTIBLE A CAMA, BAÑO COMPLETO, TV E INTERNET');

INSERT INTO Habitacion(numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion)
VALUES (109, 3, 1200.00, 'Disponible', 4, 'HABITACIÓN CON CAMA MATRIMONIAL, CAMA INDIVIDUAL Y SOFÁ CONVERTIBLE A CAMA, BAÑO COMPLETO, TV E INTERNET');

INSERT INTO Habitacion(numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion)
VALUES (110, 3, 1200.00, 'Disponible', 4, 'HABITACIÓN CON CAMA MATRIMONIAL, CAMA INDIVIDUAL Y SOFÁ CONVERTIBLE A CAMA, BAÑO COMPLETO, TV E INTERNET');

INSERT INTO Habitacion(numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion)
VALUES (111, 3, 1200.00, 'Disponible', 4, 'HABITACIÓN CON CAMA MATRIMONIAL, CAMA INDIVIDUAL Y SOFÁ CONVERTIBLE A CAMA, BAÑO COMPLETO, TV E INTERNET');

INSERT INTO Habitacion(numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion)
VALUES (112, 4, 2000.00, 'Disponible', 5, 'HABITACIÓN CON CAMA KING SIZE, CAMA MATRIMONIAL Y SOFÁ CONVERTIBLE A CAMA, BAÑO COMPLETO CON TINA, TV E INTERNET Y OBSEQUIO TRADICIONAL');

INSERT INTO Habitacion(numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion)
VALUES (113, 4, 2000.00, 'Inactiva', 5, 'HABITACIÓN CON CAMA KING SIZE, CAMA MATRIMONIAL Y SOFÁ CONVERTIBLE A CAMA, BAÑO COMPLETO CON TINA, TV E INTERNET Y OBSEQUIO TRADICIONAL');

INSERT INTO Habitacion(numero_habitacion, id_tipo_hab, precio_habitacion, estado_habitacion, capacidad_habitacion, descripcion_habitacion)
VALUES (114, 4, 2000.00, 'Limpieza', 5, 'HABITACIÓN CON CAMA KING SIZE, CAMA MATRIMONIAL Y SOFÁ CONVERTIBLE A CAMA, BAÑO COMPLETO CON TINA, TV E INTERNET Y OBSEQUIO TRADICIONAL');


COMMIT;




---------------------
--USUARIO
--ENCRIPTAR
--UPDATE Usuario SET nombre_usuario=cryptit.encrypt_data(nombre_usuario);
--UPDATE Usuario SET paterno_usuario=cryptit.encrypt_data(paterno_usuario);
--UPDATE Usuario SET materno_usuario=cryptit.encrypt_data(materno_usuario);
--UPDATE Usuario SET telefono_usuario=cryptit.encrypt_data(telefono_usuario);
--UPDATE Usuario SET identificacion_usuario=cryptit.encrypt_data(identificacion_usuario);
--UPDATE Usuario SET direccion_usuario=cryptit.encrypt_data(direccion_usuario);
--UPDATE Usuario SET usuario=cryptit.encrypt_data(usuario);
--UPDATE Usuario SET contrasena=cryptit.encrypt_data(contrasena);
--UPDATE Usuario SET estado_usuario=cryptit.encrypt_data(estado_usuario);

--DESENCRIPTAR
--UPDATE Usuario SET nombre_usuario=cryptit.decrypt_data(nombre_usuario);
--UPDATE Usuario SET paterno_usuario=cryptit.decrypt_data(paterno_usuario);
--UPDATE Usuario SET materno_usuario=cryptit.decrypt_data(materno_usuario);
--UPDATE Usuario SET telefono_usuario=cryptit.decrypt_data(telefono_usuario);
--UPDATE Usuario SET identificacion_usuario=cryptit.decrypt_data(identificacion_usuario);
--UPDATE Usuario SET direccion_usuario=cryptit.decrypt_data(direccion_usuario);
--UPDATE Usuario SET usuario=cryptit.decrypt_data(usuario);
--UPDATE Usuario SET contrasena=cryptit.decrypt_data(contrasena);
--UPDATE Usuario SET estado_usuario=cryptit.decrypt_data(estado_usuario);


--CLIENTE
--ENCRIPTAR
--UPDATE Cliente SET nombre_cliente=cryptit.encrypt_data(nombre_cliente);
--UPDATE Cliente SET paterno_cliente=cryptit.encrypt_data(paterno_cliente);
--UPDATE Cliente SET materno_cliente=cryptit.encrypt_data(materno_cliente);
--UPDATE Cliente SET telefono_cliente=cryptit.encrypt_data(telefono_cliente);
--UPDATE Cliente SET identificacion_cliente=cryptit.encrypt_data(identificacion_cliente);
--UPDATE Cliente SET nota_cliente=cryptit.encrypt_data(nota_cliente);

--DESENCRIPTAR
--UPDATE Cliente SET nombre_cliente=cryptit.decrypt_data(nombre_cliente);
--UPDATE Cliente SET paterno_cliente=cryptit.decrypt_data(paterno_cliente);
--UPDATE Cliente SET materno_cliente=cryptit.decrypt_data(materno_cliente);
--UPDATE Cliente SET telefono_cliente=cryptit.decrypt_data(telefono_cliente);
--UPDATE Cliente SET identificacion_cliente=cryptit.decrypt_data(identificacion_cliente);
--UPDATE Cliente SET nota_cliente=cryptit.decrypt_data(nota_cliente);


--EGRESO
--ENCRIPTAR
--UPDATE Egreso SET concepto=cryptit.encrypt_data(concepto);

--DESENCRIPTAR
--UPDATE Egreso SET concepto=cryptit.decrypt_data(concepto);


--CARGOS EXTRA
--ENCRIPTAR
--UPDATE Cargo_extra SET concepto=cryptit.encrypt_data(concepto);

--DESENCRIPTAR
--UPDATE Cargo_extra SET concepto=cryptit.decrypt_data(concepto);