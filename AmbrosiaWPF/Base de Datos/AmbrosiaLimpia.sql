
-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: localhost    Database: ambrosiapark_pro
-- ------------------------------------------------------
-- Server version	8.0.26

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `au_dtran`
--

DROP TABLE IF EXISTS `au_dtran`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `au_dtran` (
  `dtr_cont` bigint NOT NULL AUTO_INCREMENT,
  `tra_cont` bigint NOT NULL,
  `dtr_fiel` varchar(1500) DEFAULT NULL,
  `dtr_vnew` varchar(1500) DEFAULT NULL,
  `dtr_vold` varchar(1500) DEFAULT NULL,
  PRIMARY KEY (`dtr_cont`),
  KEY `tra_cont` (`tra_cont`)
) ENGINE=InnoDB AUTO_INCREMENT=1 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `au_dtran`
--

--
-- Table structure for table `au_trans`
--

DROP TABLE IF EXISTS `au_trans`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `au_trans` (
  `tra_cont` bigint NOT NULL AUTO_INCREMENT,
  `tra_tabl` varchar(500) NOT NULL,
  `tra_acci` varchar(50) NOT NULL,
  `tra_user` varchar(50) NOT NULL,
  `tra_fech` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  PRIMARY KEY (`tra_cont`)
) ENGINE=InnoDB AUTO_INCREMENT=1 ;
/*!40101 SET character_set_client = @saved_cs_client */;


--
-- Table structure for table `cl_saldo`
--

DROP TABLE IF EXISTS `cl_saldo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `cl_saldo` (
  `sal_cont` bigint NOT NULL AUTO_INCREMENT,
  `usu_Cont` bigint NOT NULL,
  `par_codi` int NOT NULL,
  `sal_Desc` varchar(150) NOT NULL,
  `sal_valor` double NOT NULL,
  `sal_fecha` datetime NOT NULL,
  `sal_abon` tinyint(1) NOT NULL DEFAULT '0',
  `emp_nusu` varchar(150) NOT NULL,
  PRIMARY KEY (`sal_cont`),
  KEY `par_codi` (`par_codi`),
  KEY `fk_usuario_sald_idx` (`usu_Cont`),
  KEY `Index_saldo` (`sal_Desc`),
  CONSTRAINT `cl_saldo_ibfk_1` FOREIGN KEY (`par_codi`) REFERENCES `em_park` (`PAR_CODI`),
  CONSTRAINT `cl_usua_fk2` FOREIGN KEY (`usu_Cont`) REFERENCES `cl_usua` (`USU_CONT`)
) ENGINE=InnoDB AUTO_INCREMENT=1 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cl_saldo`
--
-- Table structure for table `cl_tipo`
--

DROP TABLE IF EXISTS `cl_tipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `cl_tipo` (
  `TIC_CODI` int NOT NULL AUTO_INCREMENT,
  `TIC_NOMB` varchar(100) NOT NULL,
  `EMP_NUSU` varchar(150) NOT NULL,
  `tip_tesp` int NOT NULL,
  `tip_tgra` int NOT NULL,
  `tip_tobs` int NOT NULL,
  `tip_entg` int NOT NULL,
  PRIMARY KEY (`TIC_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=1 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cl_tipo`
--

LOCK TABLES `cl_tipo` WRITE;
/*!40000 ALTER TABLE `cl_tipo` DISABLE KEYS */;
INSERT INTO `cl_tipo` VALUES (1,'Particular','admin',5,0,0,0);
/*!40000 ALTER TABLE `cl_tipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cl_usua`
--

DROP TABLE IF EXISTS `cl_usua`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `cl_usua` (
  `USU_CONT` bigint NOT NULL AUTO_INCREMENT,
  `USU_CODI` varchar(15) NOT NULL,
  `TII_CODI` int NOT NULL,
  `USU_NOMB` varchar(50) NOT NULL,
  `USU_DIRE` varchar(100) NOT NULL,
  `USU_TELE` varchar(50) NOT NULL,
  `TIC_CODI` int NOT NULL,
  `USU_DEFA` tinyint(1) NOT NULL DEFAULT '0',
  `EMP_NUSU` varchar(150) NOT NULL,
  `USU_SALD` float NOT NULL DEFAULT '0',
  `USU_CARTE` tinyint(1) NOT NULL COMMENT 'SOPORTE PARA CARTERA',
  PRIMARY KEY (`USU_CONT`),
  UNIQUE KEY `USU_CONT` (`USU_CONT`),
  UNIQUE KEY `USU_CODI` (`USU_CODI`,`TII_CODI`),
  KEY `TIC_CODI_2` (`TIC_CODI`),
  KEY `TII_CODI` (`TII_CODI`),
  CONSTRAINT `CL_USUA_IBFK_1` FOREIGN KEY (`TIC_CODI`) REFERENCES `cl_tipo` (`TIC_CODI`),
  CONSTRAINT `CL_USUA_IBFK_2` FOREIGN KEY (`TII_CODI`) REFERENCES `em_tide` (`TII_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=1 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cl_usua`
--

LOCK TABLES `cl_usua` WRITE;
/*!40000 ALTER TABLE `cl_usua` DISABLE KEYS */;
INSERT INTO `cl_usua` VALUES (1,'1',1,'CLIENTE OCASIONAL','PARQUEADERO','.',1,1,'',0,0);
/*!40000 ALTER TABLE `cl_usua` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cl_usvh`
--

DROP TABLE IF EXISTS `cl_usvh`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `cl_usvh` (
  `USU_CONT` bigint NOT NULL,
  `USV_PLACA` varchar(15) NOT NULL,
  `USV_FACT` datetime NOT NULL,
  `USU_FDES` datetime DEFAULT NULL,
  `USV_ACTI` tinyint(1) NOT NULL,
  `EMP_NUSU` varchar(150) NOT NULL,
  KEY `USU_CONT` (`USU_CONT`,`USV_PLACA`),
  CONSTRAINT `CL_USVH_IBFK_1` FOREIGN KEY (`USU_CONT`) REFERENCES `cl_usua` (`USU_CONT`)
) ENGINE=InnoDB ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cl_usvh`
--


--
-- Table structure for table `co_dcmax`
--

DROP TABLE IF EXISTS `co_dcmax`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `co_dcmax` (
  `DCM_CONT` bigint NOT NULL AUTO_INCREMENT,
  `TIC_CODI` int NOT NULL,
  `TIV_CODI` int NOT NULL,
  `DCM_COST` float NOT NULL,
  `DCM_ACTI` tinyint(1) NOT NULL,
  `EMP_NUSU` varchar(150) NOT NULL,
  PRIMARY KEY (`DCM_CONT`),
  KEY `TIC_CODI` (`TIC_CODI`,`TIV_CODI`),
  KEY `TIV_CODI` (`TIV_CODI`),
  CONSTRAINT `CO_DCMAX_IBFK_1` FOREIGN KEY (`TIC_CODI`) REFERENCES `cl_tipo` (`TIC_CODI`),
  CONSTRAINT `CO_DCMAX_IBFK_2` FOREIGN KEY (`TIV_CODI`) REFERENCES `vh_tipos` (`TIV_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=1 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `co_dcmax`
--



--
-- Table structure for table `co_denva`
--

DROP TABLE IF EXISTS `co_denva`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `co_denva` (
  `DEN_CONT` bigint NOT NULL AUTO_INCREMENT,
  `ENT_CODI` bigint NOT NULL,
  `VAL_CONT` bigint NOT NULL,
  `DEN_CANT` int NOT NULL,
  `EMP_NUSU` varchar(150) NOT NULL,
  PRIMARY KEY (`DEN_CONT`),
  KEY `ENT_CODI` (`ENT_CODI`,`VAL_CONT`),
  KEY `VAL_CONT` (`VAL_CONT`),
  CONSTRAINT `CO_DENVA_IBFK_1` FOREIGN KEY (`VAL_CONT`) REFERENCES `co_valadi` (`VAL_CONT`),
  CONSTRAINT `CO_DENVA_IBFK_2` FOREIGN KEY (`ENT_CODI`) REFERENCES `co_entr` (`ENT_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=1 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `co_denva`
--



--
-- Table structure for table `co_dpeco`
--

DROP TABLE IF EXISTS `co_dpeco`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `co_dpeco` (
  `DPE_CONT` bigint NOT NULL AUTO_INCREMENT,
  `ENT_CODI` bigint NOT NULL,
  `DPE_FECHA` date NOT NULL,
  `DMC_CONT` bigint NOT NULL,
  `EMP_NUSU` varchar(150) NOT NULL,
  PRIMARY KEY (`DPE_CONT`),
  KEY `ENT_CODI` (`ENT_CODI`,`DMC_CONT`),
  KEY `DMC_CONT` (`DMC_CONT`),
  CONSTRAINT `CO_DPECO_IBFK_1` FOREIGN KEY (`DMC_CONT`) REFERENCES `co_dcmax` (`DCM_CONT`),
  CONSTRAINT `CO_DPECO_IBFK_2` FOREIGN KEY (`ENT_CODI`) REFERENCES `co_entr` (`ENT_CODI`)
) ENGINE=InnoDB ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `co_dpeco`
--

LOCK TABLES `co_dpeco` WRITE;
/*!40000 ALTER TABLE `co_dpeco` DISABLE KEYS */;
/*!40000 ALTER TABLE `co_dpeco` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `co_dpern`
--

DROP TABLE IF EXISTS `co_dpern`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `co_dpern` (
  `DPE_CONT` bigint NOT NULL AUTO_INCREMENT,
  `PAR_CODI` int NOT NULL,
  `TIC_CODI` int NOT NULL,
  `TIV_CODI` int NOT NULL,
  `DPE_COST` float NOT NULL,
  `EMP_NUSU` varchar(150) NOT NULL,
  `dpe_Acti` tinyint(1) NOT NULL,
  PRIMARY KEY (`DPE_CONT`),
  KEY `TIC_CODI` (`TIC_CODI`,`TIV_CODI`),
  KEY `PAR_CODI` (`PAR_CODI`),
  KEY `TIV_CODI` (`TIV_CODI`),
  CONSTRAINT `CO_DPERN_IBFK_1` FOREIGN KEY (`PAR_CODI`) REFERENCES `em_park` (`PAR_CODI`),
  CONSTRAINT `CO_DPERN_IBFK_2` FOREIGN KEY (`TIC_CODI`) REFERENCES `cl_tipo` (`TIC_CODI`),
  CONSTRAINT `CO_DPERN_IBFK_3` FOREIGN KEY (`TIV_CODI`) REFERENCES `vh_tipos` (`TIV_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=1 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `co_dpern`
--


--
-- Table structure for table `co_dvala`
--

DROP TABLE IF EXISTS `co_dvala`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `co_dvala` (
  `DVA_CONT` bigint NOT NULL AUTO_INCREMENT,
  `VAL_CONT` bigint NOT NULL,
  `DVA_COST` float DEFAULT NULL,
  `DVA_DMINU` int DEFAULT NULL,
  `DVA_DVALOR` float DEFAULT NULL,
  `EMP_NUSU` varchar(150) NOT NULL,
  `dva_acti` tinyint(1) NOT NULL DEFAULT '1',
  PRIMARY KEY (`DVA_CONT`),
  KEY `VAL_CONT` (`VAL_CONT`),
  CONSTRAINT `CO_DVALA_IBFK_1` FOREIGN KEY (`VAL_CONT`) REFERENCES `co_valadi` (`VAL_CONT`)
) ENGINE=InnoDB AUTO_INCREMENT=1 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `co_dvala`
--


--
-- Table structure for table `co_entr`
--

DROP TABLE IF EXISTS `co_entr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `co_entr` (
  `PAR_CODI` int NOT NULL,
  `ENT_CODI` bigint NOT NULL AUTO_INCREMENT,
  `EMP_NUSU` varchar(15) NOT NULL,
  `USU_CONT` bigint NOT NULL,
  `ENT_ENTR` datetime NOT NULL,
  `ENT_SALI` datetime DEFAULT NULL,
  `ENT_COST` bigint NOT NULL,
  `ENT_PLAC` varchar(150) NOT NULL,
  `ENT_TIME` bigint DEFAULT '0',
  `TSE_CODI` int NOT NULL,
  `TIV_CODI` int NOT NULL,
  `ENT_COMM` varchar(200) DEFAULT NULL,
  `AUD_NUSU` varchar(150) NOT NULL,
  `ent_manu` tinyint(1) NOT NULL DEFAULT '0',
  `ent_cman` tinyint(1) DEFAULT NULL,
  `ent_deta` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`ENT_CODI`),
  KEY `EMP_NUSU` (`EMP_NUSU`),
  KEY `TSE_CODI` (`TSE_CODI`),
  KEY `PAR_CODI` (`PAR_CODI`),
  KEY `TIV_CODI` (`TIV_CODI`),
  KEY `USU_CODI` (`USU_CONT`),
  KEY `USU_CONT` (`USU_CONT`),
  CONSTRAINT `CO_ENTR_IBFK_1` FOREIGN KEY (`EMP_NUSU`) REFERENCES `em_empl` (`EMP_NUSU`),
  CONSTRAINT `CO_ENTR_IBFK_4` FOREIGN KEY (`TSE_CODI`) REFERENCES `co_tser` (`TSE_CODI`),
  CONSTRAINT `CO_ENTR_IBFK_5` FOREIGN KEY (`PAR_CODI`) REFERENCES `em_park` (`PAR_CODI`),
  CONSTRAINT `CO_ENTR_IBFK_6` FOREIGN KEY (`TIV_CODI`) REFERENCES `vh_tipos` (`TIV_CODI`),
  CONSTRAINT `CO_ENTR_IBFK_7` FOREIGN KEY (`USU_CONT`) REFERENCES `cl_usua` (`USU_CONT`)
) ENGINE=InnoDB AUTO_INCREMENT=1 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `co_entr`
--


--
-- Table structure for table `co_serv`
--

DROP TABLE IF EXISTS `co_serv`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `co_serv` (
  `SER_CODI` bigint NOT NULL AUTO_INCREMENT,
  `TSE_CODI` int NOT NULL,
  `SER_FECI` datetime NOT NULL,
  `SER_FECF` datetime NOT NULL,
  `COMENTARIO` varchar(200) NOT NULL,
  `USU_CODI` bigint NOT NULL,
  `SER_ESTA` tinyint(1) NOT NULL,
  `SER_FECC` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `SER_COST` bigint NOT NULL,
  `EMP_NUSU` varchar(15) NOT NULL,
  PRIMARY KEY (`SER_CODI`),
  KEY `TSE_CODI` (`TSE_CODI`),
  KEY `EMP_NUSU` (`EMP_NUSU`),
  KEY `USU_CODI` (`USU_CODI`),
  CONSTRAINT `CO_SERV_IBFK_1` FOREIGN KEY (`TSE_CODI`) REFERENCES `co_tser` (`TSE_CODI`),
  CONSTRAINT `CO_SERV_IBFK_3` FOREIGN KEY (`EMP_NUSU`) REFERENCES `em_empl` (`EMP_NUSU`),
  CONSTRAINT `co_serv_ibfk_4` FOREIGN KEY (`USU_CODI`) REFERENCES `cl_usua` (`USU_CONT`)
) ENGINE=InnoDB AUTO_INCREMENT=1 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `co_serv`
--



--
-- Table structure for table `co_tari`
--

DROP TABLE IF EXISTS `co_tari`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `co_tari` (
  `TIC_CODI` int NOT NULL COMMENT 'TIPO DE CLIENTE',
  `PAR_CODI` int NOT NULL COMMENT 'CODIGO PARQUEADERO',
  `TIV_CODI` int NOT NULL COMMENT 'TIPO DE VEHICULO',
  `TAR_LAPS` int NOT NULL COMMENT 'TIEMPO DE LA FRACCIÓN',
  `TAR_COST` int NOT NULL COMMENT 'COSTO DE LA FRACCIÓN',
  `TAR_CODI` int NOT NULL AUTO_INCREMENT COMMENT 'LLAVE PRIMARIA DE LA TARIFA',
  `TSE_CODI` int NOT NULL COMMENT 'TIPO DE SERVICIO',
  `EMP_NUSU` varchar(150) NOT NULL COMMENT 'USUARIO - AUDITORIA',
  `TAR_ACTI` tinyint(1) NOT NULL,
  PRIMARY KEY (`TAR_CODI`),
  UNIQUE KEY `TIC_CODI` (`TIC_CODI`,`TIV_CODI`,`TAR_CODI`),
  KEY `TIV_CODI` (`TIV_CODI`),
  KEY `TSE_CODI` (`TSE_CODI`),
  KEY `PAR_CODI` (`PAR_CODI`),
  CONSTRAINT `CO_TARI_IBFK_1` FOREIGN KEY (`TIC_CODI`) REFERENCES `cl_tipo` (`TIC_CODI`),
  CONSTRAINT `CO_TARI_IBFK_2` FOREIGN KEY (`TIV_CODI`) REFERENCES `vh_tipos` (`TIV_CODI`),
  CONSTRAINT `CO_TARI_IBFK_3` FOREIGN KEY (`TSE_CODI`) REFERENCES `co_tser` (`TSE_CODI`),
  CONSTRAINT `CO_TARI_IBFK_4` FOREIGN KEY (`PAR_CODI`) REFERENCES `em_park` (`PAR_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=149 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `co_tari`
--



--
-- Table structure for table `co_tser`
--

DROP TABLE IF EXISTS `co_tser`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `co_tser` (
  `TSE_CODI` int NOT NULL AUTO_INCREMENT,
  `TSE_NOMB` varchar(150) NOT NULL,
  `tse_tgrac` int NOT NULL DEFAULT '0',
  `tse_defau` tinyint(1) NOT NULL,
  `EMP_NUSU` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`TSE_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=3 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `co_tser`
--

LOCK TABLES `co_tser` WRITE;
/*!40000 ALTER TABLE `co_tser` DISABLE KEYS */;
INSERT INTO `co_tser` VALUES (-1,'Entrada Manual',0,0,'admin'),(1,'ENTRADA PARTICULAR',0,1,NULL),(2,'Contratos',0,0,'admin');
/*!40000 ALTER TABLE `co_tser` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `co_tvala`
--

DROP TABLE IF EXISTS `co_tvala`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `co_tvala` (
  `TVA_CONT` bigint NOT NULL AUTO_INCREMENT,
  `TVA_NOMB` varchar(150) NOT NULL,
  `TVA_DESC` tinyint(1) NOT NULL,
  `TVA_DENT` tinyint(1) NOT NULL DEFAULT '1',
  `TVA_ACTI` tinyint(1) NOT NULL,
  `EMP_NUSU` varchar(150) NOT NULL,
  PRIMARY KEY (`TVA_CONT`)
) ENGINE=InnoDB AUTO_INCREMENT=1 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `co_tvala`
--


--
-- Table structure for table `co_valadi`
--

DROP TABLE IF EXISTS `co_valadi`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `co_valadi` (
  `VAL_CONT` bigint NOT NULL AUTO_INCREMENT,
  `PAR_CODI` int NOT NULL,
  `VAL_DESC` varchar(150) NOT NULL,
  `VAL_ACTI` tinyint(1) NOT NULL,
  `TVA_CONT` bigint NOT NULL,
  PRIMARY KEY (`VAL_CONT`),
  KEY `TVA_CONT` (`TVA_CONT`),
  KEY `PAR_CODI` (`PAR_CODI`),
  CONSTRAINT `CO_VALADI_IBFK_1` FOREIGN KEY (`TVA_CONT`) REFERENCES `co_tvala` (`TVA_CONT`),
  CONSTRAINT `CO_VALADI_IBFK_2` FOREIGN KEY (`PAR_CODI`) REFERENCES `em_park` (`PAR_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=5 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `co_valadi`
--


--
-- Table structure for table `em_capa`
--

DROP TABLE IF EXISTS `em_capa`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `em_capa` (
  `cap_codi` bigint NOT NULL AUTO_INCREMENT,
  `par_codi` int NOT NULL,
  `tiv_codi` int NOT NULL,
  `cap_cant` int NOT NULL,
  `cap_limi` tinyint(1) NOT NULL,
  `emp_nusu` varchar(150) NOT NULL,
  PRIMARY KEY (`cap_codi`),
  KEY `par_codi` (`par_codi`,`tiv_codi`),
  KEY `tiv_codi` (`tiv_codi`),
  CONSTRAINT `em_capa_ibfk_1` FOREIGN KEY (`par_codi`) REFERENCES `em_park` (`PAR_CODI`),
  CONSTRAINT `em_capa_ibfk_2` FOREIGN KEY (`tiv_codi`) REFERENCES `vh_tipos` (`TIV_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=10 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `em_capa`
--



--
-- Table structure for table `em_carg`
--

DROP TABLE IF EXISTS `em_carg`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `em_carg` (
  `CAR_CODI` int NOT NULL AUTO_INCREMENT,
  `CAR_NOMB` varchar(199) NOT NULL,
  `EMP_NUSU` varchar(150) NOT NULL,
  PRIMARY KEY (`CAR_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=3 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `em_carg`
--

LOCK TABLES `em_carg` WRITE;
/*!40000 ALTER TABLE `em_carg` DISABLE KEYS */;
INSERT INTO `em_carg` VALUES (1,'SISADMIN',''),(2,'RECEPCION','');
/*!40000 ALTER TABLE `em_carg` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `em_daten`
--

DROP TABLE IF EXISTS `em_daten`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `em_daten` (
  `dat_Cont` int NOT NULL AUTO_INCREMENT,
  `par_codi` int NOT NULL,
  `dia_cont` int NOT NULL,
  `dat_hini` time NOT NULL,
  `dat_hfina` time NOT NULL,
  PRIMARY KEY (`dat_Cont`),
  UNIQUE KEY `par_codi` (`par_codi`,`dia_cont`),
  KEY `dia_cont` (`dia_cont`),
  CONSTRAINT `em_daten_ibfk_1` FOREIGN KEY (`dia_cont`) REFERENCES `gn_dias` (`DIA_CONT`),
  CONSTRAINT `em_daten_ibfk_2` FOREIGN KEY (`par_codi`) REFERENCES `em_park` (`PAR_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=22 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `em_daten`
--



--
-- Table structure for table `em_dmod`
--

DROP TABLE IF EXISTS `em_dmod`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `em_dmod` (
  `MOD_CODI` int NOT NULL,
  `CAR_CODI` int NOT NULL,
  `EMP_NUSU` varchar(150) NOT NULL,
  PRIMARY KEY (`MOD_CODI`,`CAR_CODI`),
  KEY `CAR_CODI` (`CAR_CODI`),
  CONSTRAINT `EM_DMOD_IBFK_1` FOREIGN KEY (`CAR_CODI`) REFERENCES `em_carg` (`CAR_CODI`),
  CONSTRAINT `EM_DMOD_IBFK_2` FOREIGN KEY (`MOD_CODI`) REFERENCES `em_modu` (`MOD_CODI`)
) ENGINE=InnoDB ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `em_dmod`
--

LOCK TABLES `em_dmod` WRITE;
/*!40000 ALTER TABLE `em_dmod` DISABLE KEYS */;
INSERT INTO `em_dmod` VALUES (1,1,'admin'),(1,2,'admin'),(2,1,'admin'),(3,1,'admin'),(4,1,'admin'),(5,1,'admin'),(5,2,'admin'),(6,1,'admin'),(6,2,'admin'),(7,1,'admin'),(7,2,'admin');
/*!40000 ALTER TABLE `em_dmod` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `em_drpt`
--

DROP TABLE IF EXISTS `em_drpt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `em_drpt` (
  `DRP_CONT` bigint NOT NULL AUTO_INCREMENT,
  `RPT_CODI` int NOT NULL,
  `CAR_CODI` int NOT NULL,
  PRIMARY KEY (`DRP_CONT`),
  UNIQUE KEY `Unique_em_drpt` (`RPT_CODI`,`CAR_CODI`),
  KEY `CAR_CODI` (`CAR_CODI`),
  CONSTRAINT `em_drpt_ibfk_1` FOREIGN KEY (`CAR_CODI`) REFERENCES `em_carg` (`CAR_CODI`),
  CONSTRAINT `em_drpt_ibfk_2` FOREIGN KEY (`RPT_CODI`) REFERENCES `em_repo` (`RPT_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=22 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `em_drpt`
--

LOCK TABLES `em_drpt` WRITE;
/*!40000 ALTER TABLE `em_drpt` DISABLE KEYS */;
INSERT INTO `em_drpt` VALUES (5,1,1),(8,1,2),(6,2,1),(9,2,2),(7,3,1),(10,3,2),(11,4,1),(19,5,1),(17,5,2),(12,6,1),(13,6,2),(14,7,1),(15,7,2),(16,8,1),(18,8,2),(20,9,1),(21,9,2);
/*!40000 ALTER TABLE `em_drpt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `em_dtic`
--

DROP TABLE IF EXISTS `em_dtic`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `em_dtic` (
  `dti_cont` bigint NOT NULL AUTO_INCREMENT,
  `tic_codi` int NOT NULL,
  `dti_desc` varchar(150) NOT NULL,
  PRIMARY KEY (`dti_cont`),
  KEY `tic_codi` (`tic_codi`),
  CONSTRAINT `fk_tipo_cliente` FOREIGN KEY (`tic_codi`) REFERENCES `cl_tipo` (`TIC_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=1 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `em_dtic`
--



--
-- Table structure for table `em_empl`
--

DROP TABLE IF EXISTS `em_empl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `em_empl` (
  `TII_CODI` int NOT NULL,
  `EMP_CODI` varchar(15) NOT NULL,
  `EMP_NOMB` varchar(200) NOT NULL,
  `EMP_DIRE` varchar(200) NOT NULL,
  `EMP_TELE` varchar(200) NOT NULL,
  `EMP_NUSU` varchar(15) NOT NULL,
  `EMP_PASS` varchar(90) NOT NULL,
  `EMP_ESTA` tinyint(1) NOT NULL,
  `CAR_CODI` int NOT NULL,
  `emp_modi` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`EMP_NUSU`),
  UNIQUE KEY `TII_CODI` (`TII_CODI`,`EMP_CODI`),
  KEY `CAR_CODI` (`CAR_CODI`),
  CONSTRAINT `EM_EMPL_IBFK_1` FOREIGN KEY (`CAR_CODI`) REFERENCES `em_carg` (`CAR_CODI`),
  CONSTRAINT `EM_EMPL_IBFK_2` FOREIGN KEY (`TII_CODI`) REFERENCES `em_tide` (`TII_CODI`)
) ENGINE=InnoDB ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `em_empl`
--

LOCK TABLES `em_empl` WRITE;
/*!40000 ALTER TABLE `em_empl` DISABLE KEYS */;
INSERT INTO `em_empl` VALUES (1,'11205594','DANIEL FELIPE CAICEDO','CALLE 18 NO 18-69 GIRARDOT-CUNDINAMARCA','3103704949','admin','d033e22ae348aeb5660fc2140aec35850c4da997',1,1,'admin');
/*!40000 ALTER TABLE `em_empl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `em_moac`
--

DROP TABLE IF EXISTS `em_moac`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `em_moac` (
  `MOA_CONT` bigint NOT NULL AUTO_INCREMENT,
  `MOA_VALOR` float NOT NULL,
  PRIMARY KEY (`MOA_CONT`)
) ENGINE=InnoDB AUTO_INCREMENT=1 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `em_moac`
--

LOCK TABLES `em_moac` WRITE;
/*!40000 ALTER TABLE `em_moac` DISABLE KEYS */;
INSERT INTO `em_moac` VALUES (1,50),(2,100),(3,200),(4,500),(5,1000),(6,2000),(7,5000),(8,10000),(9,20000),(10,50000),(11,100000);
/*!40000 ALTER TABLE `em_moac` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `em_modu`
--

DROP TABLE IF EXISTS `em_modu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `em_modu` (
  `MOD_CODI` int NOT NULL AUTO_INCREMENT,
  `MOD_NOMB` varchar(199) NOT NULL,
  `mod_admi` tinyint(1) NOT NULL,
  PRIMARY KEY (`MOD_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=8 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `em_modu`
--

LOCK TABLES `em_modu` WRITE;
/*!40000 ALTER TABLE `em_modu` DISABLE KEYS */;
INSERT INTO `em_modu` VALUES (1,'PUNTO DE ATENCIÓN',0),(2,'GESTION COMERCIAL',0),(3,'GESTION DE EMPLEADOS',0),(4,'ADMINISTRACIÓN',1),(5,'CREACIÓN DE SERVICIOS',0),(6,'VISUALIZAR INFORMES',0),(7,'CARGA DE ARCHIVOS PLANOS',0);
/*!40000 ALTER TABLE `em_modu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `em_papt`
--

DROP TABLE IF EXISTS `em_papt`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `em_papt` (
  `PAP_CODI` bigint NOT NULL AUTO_INCREMENT,
  `RPT_CODI` int NOT NULL,
  `PAP_NOMB` varchar(199) NOT NULL,
  `TDA_CODI` int NOT NULL,
  `PAP_HELP` tinyint(1) NOT NULL DEFAULT '0',
  `PAP_TABL` varchar(100) DEFAULT NULL,
  `PAP_CAMO` varchar(100) DEFAULT NULL,
  `PAP_CAMD` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`PAP_CODI`),
  KEY `TDA_CODI` (`TDA_CODI`),
  KEY `RPT_CODI` (`RPT_CODI`),
  CONSTRAINT `EM_PAPT_IBFK_1` FOREIGN KEY (`TDA_CODI`) REFERENCES `em_tdat` (`TDA_CODI`),
  CONSTRAINT `EM_PAPT_IBFK_2` FOREIGN KEY (`RPT_CODI`) REFERENCES `em_repo` (`RPT_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=16 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `em_papt`
--

LOCK TABLES `em_papt` WRITE;
/*!40000 ALTER TABLE `em_papt` DISABLE KEYS */;
INSERT INTO `em_papt` VALUES (1,1,'Entrada',2,1,'co_entr','ent_codi','ent_codi'),(2,2,'Sal_cont',2,0,NULL,NULL,NULL),(3,3,'Salida',2,1,'co_entr','ent_codi','ent_Codi'),(4,5,'Fec_Ini',1,0,NULL,NULL,NULL),(5,5,'Fec_Fin',1,0,NULL,NULL,NULL),(6,6,'Parqueadero',2,1,'em_park','par_codi','par_nomb'),(7,6,'Fecha Inicial',1,0,NULL,NULL,NULL),(8,6,'Fecha Final',1,0,NULL,NULL,NULL),(9,7,'Parqueadero',2,1,'em_park','par_codi','par_nomb'),(10,8,'Parqueadero',2,1,'em_park','par_codi','par_nomb'),(11,8,'Fecha_Inicial',1,0,NULL,NULL,NULL),(12,8,'Fecha_Final',1,0,NULL,NULL,NULL),(13,9,'Parqueadero',2,1,'em_park','par_codi','par_nomb'),(14,9,'Fecha Inicial ',1,0,NULL,NULL,NULL),(15,9,'Fecha Final',1,0,NULL,NULL,NULL);
/*!40000 ALTER TABLE `em_papt` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `em_park`
--

DROP TABLE IF EXISTS `em_park`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `em_park` (
  `PAR_CODI` int NOT NULL AUTO_INCREMENT,
  `PAR_NOMB` varchar(200) NOT NULL,
  `PAR_DIRE` varchar(200) NOT NULL,
  `PAR_TELE` varchar(200) NOT NULL,
  `PAR_NIT` varchar(50) NOT NULL,
  `PAR_COMS` varchar(900) NOT NULL,
  `PAR_COMI` varchar(900) NOT NULL,
  `PAR_ANUL` tinyint(1) DEFAULT '1',
  `emp_nusu` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`PAR_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=1 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `em_park`
--

LOCK TABLES `em_park` WRITE;
/*!40000 ALTER TABLE `em_park` DISABLE KEYS */;
INSERT INTO `em_park` VALUES (1,'Parqueadero Prueba','Prueba','Prueba','Prueba','Horario de atencion L-V 6:00 A.M -10:30 P.M S 6:00 A-. 4:00 P.M ','Prueba',1,'admin');
/*!40000 ALTER TABLE `em_park` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `em_repo`
--

DROP TABLE IF EXISTS `em_repo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `em_repo` (
  `RPT_CODI` int NOT NULL AUTO_INCREMENT,
  `RPT_NOMB` varchar(199) NOT NULL,
  `RPT_RUTA` varchar(900) NOT NULL,
  `RPT_DESCRIPCION` varchar(900) DEFAULT NULL,
  `RPT_ENTRA` tinyint(1) NOT NULL DEFAULT '0',
  `RPT_SALID` tinyint(1) NOT NULL DEFAULT '0',
  `EMP_NUSU` varchar(150) NOT NULL,
  `rep_admin` tinyint(1) NOT NULL DEFAULT '0',
  PRIMARY KEY (`RPT_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=10 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `em_repo`
--

LOCK TABLES `em_repo` WRITE;
/*!40000 ALTER TABLE `em_repo` DISABLE KEYS */;
INSERT INTO `em_repo` VALUES (1,'Entradas','C:\\Program Files\\dfcaicedo@gmail.com\\Ambrosia Pro\\RPT\\Entradas.rpt','\'\'',1,0,'admin',1),(2,'Venta de Adicionales','C:\\Program Files\\dfcaicedo@gmail.com\\Ambrosia Pro\\RPT\\Saldos.rpt','Venta de Adicionales',0,0,'admin',1),(3,'Salidas','C:\\Program Files\\dfcaicedo@gmail.com\\Ambrosia Pro\\RPT\\Salidas.rpt','\'\'',0,1,'lestupinanr',1),(4,'Saldos Negativos','C:\\Program Files\\dfcaicedo@gmail.com\\Ambrosia Pro\\RPT\\SaldosNegativos.rpt','Reporte para sacar la lista a cobrar de los usuarios con deudas de parqueadero',0,0,'admin',0),(5,'Listado de entradas','C:\\Program Files\\dfcaicedo@gmail.com\\Ambrosia Pro\\RPT\\ResumenEntradas.rpt','Resumen_de_entradas',0,0,'admin',0),(6,'Entregas de turno','C:\\Program Files\\dfcaicedo@gmail.com\\Ambrosia Pro\\RPT\\EntradasDinero.rpt','\'\'',0,0,'admin',0),(7,'Estado Actual','C:\\Program Files\\dfcaicedo@gmail.com\\Ambrosia Pro\\RPT\\EstadoActual-soloplacas.rpt','Estado Actual Parqueadero ',0,0,'admin',0),(8,'Resumen_turno','C:\\Program Files\\dfcaicedo@gmail.com\\Ambrosia Pro\\RPT\\Resumen Turno.rpt','\'\'Resumen del turno\"',0,0,'admin',0),(9,'Entregas_dinero_tablas','C:\\Program Files\\dfcaicedo@gmail.com\\Ambrosia Pro\\RPT\\EntradasDinero_tablas.rpt','\'\'',0,0,'admin',0);
/*!40000 ALTER TABLE `em_repo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `em_tdat`
--

DROP TABLE IF EXISTS `em_tdat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `em_tdat` (
  `TDA_CODI` int NOT NULL AUTO_INCREMENT,
  `TDA_NOMB` varchar(100) NOT NULL,
  PRIMARY KEY (`TDA_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=3 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `em_tdat`
--

LOCK TABLES `em_tdat` WRITE;
/*!40000 ALTER TABLE `em_tdat` DISABLE KEYS */;
INSERT INTO `em_tdat` VALUES (1,'FECHA'),(2,'ALFANUMÉRICO');
/*!40000 ALTER TABLE `em_tdat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `em_tide`
--

DROP TABLE IF EXISTS `em_tide`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `em_tide` (
  `TII_CODI` int NOT NULL AUTO_INCREMENT,
  `TII_NOMB` varchar(100) NOT NULL,
  `TII_ABRE` varchar(3) NOT NULL,
  PRIMARY KEY (`TII_CODI`),
  UNIQUE KEY `TII_ABRE` (`TII_ABRE`)
) ENGINE=InnoDB AUTO_INCREMENT=2 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `em_tide`
--

LOCK TABLES `em_tide` WRITE;
/*!40000 ALTER TABLE `em_tide` DISABLE KEYS */;
INSERT INTO `em_tide` VALUES (1,'CEDULA DE CIUDADANIA','CC');
/*!40000 ALTER TABLE `em_tide` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Temporary view structure for view `entregaturnos`
--

DROP TABLE IF EXISTS `entregaturnos`;
/*!50001 DROP VIEW IF EXISTS `entregaturnos`*/;
SET @saved_cs_client     = @@character_set_client;

/*!50001 CREATE VIEW `entregaturnos` AS SELECT 
 1 AS `orden`,
 1 AS `Entradas`,
 1 AS `par_codi`,
 1 AS `cont`,
 1 AS `fechas`,
 1 AS `tipo`,
 1 AS `AUD_NUSU`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `gn_dias`
--

DROP TABLE IF EXISTS `gn_dias`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `gn_dias` (
  `DIA_CONT` int NOT NULL AUTO_INCREMENT,
  `DIA_DESC` varchar(150) NOT NULL,
  PRIMARY KEY (`DIA_CONT`)
) ENGINE=InnoDB AUTO_INCREMENT=8 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gn_dias`
--

LOCK TABLES `gn_dias` WRITE;
/*!40000 ALTER TABLE `gn_dias` DISABLE KEYS */;
INSERT INTO `gn_dias` VALUES (1,'Domingo'),(2,'Lunes'),(3,'Martes'),(4,'Miercoles'),(5,'Jueves'),(6,'Viernes'),(7,'Sábado');
/*!40000 ALTER TABLE `gn_dias` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `gn_paten`
--

DROP TABLE IF EXISTS `gn_paten`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `gn_paten` (
  `PAT_CONT` int NOT NULL AUTO_INCREMENT,
  `PAR_CODI` int NOT NULL,
  `PAT_DESC` varchar(150) NOT NULL,
  `PAT_EQUI` varchar(150) NOT NULL,
  `pat_nodbc` varchar(150) NOT NULL DEFAULT 'ambrosia_pro',
  `USU_CODI` varchar(150) NOT NULL,
  PRIMARY KEY (`PAT_CONT`),
  KEY `PAR_CODI` (`PAR_CODI`),
  CONSTRAINT `GN_PATEN_IBFK_1` FOREIGN KEY (`PAR_CODI`) REFERENCES `em_park` (`PAR_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=1 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `gn_paten`
--


--
-- Temporary view structure for view `rpt_salida`
--

DROP TABLE IF EXISTS `rpt_salida`;
/*!50001 DROP VIEW IF EXISTS `rpt_salida`*/;
SET @saved_cs_client     = @@character_set_client;

/*!50001 CREATE VIEW `rpt_salida` AS SELECT 
 1 AS `PAR_CODI`,
 1 AS `ENT_CODI`,
 1 AS `EMP_NUSU`,
 1 AS `USU_CONT`,
 1 AS `ENT_ENTR`,
 1 AS `ENT_SALI`,
 1 AS `ENT_COST`,
 1 AS `ENT_PLAC`,
 1 AS `ENT_TIME`,
 1 AS `TSE_CODI`,
 1 AS `TIV_CODI`,
 1 AS `ENT_COMM`,
 1 AS `AUD_NUSU`,
 1 AS `ent_manu`,
 1 AS `ent_cman`,
 1 AS `ent_deta`,
 1 AS `adici`*/;
SET character_set_client = @saved_cs_client;

--
-- Table structure for table `vh_espe`
--

DROP TABLE IF EXISTS `vh_espe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `vh_espe` (
  `ESP_CONT` bigint NOT NULL AUTO_INCREMENT,
  `TIV_CODI` int NOT NULL,
  `ESP_DESC` varchar(15) NOT NULL,
  `EMP_NUSU` varchar(50) NOT NULL,
  PRIMARY KEY (`ESP_CONT`),
  UNIQUE KEY `uNIQUE_KEY` (`TIV_CODI`,`ESP_DESC`),
  CONSTRAINT `VH_ESPE_IBFK_1` FOREIGN KEY (`TIV_CODI`) REFERENCES `vh_tipos` (`TIV_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=4 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vh_espe`
--

LOCK TABLES `vh_espe` WRITE;
/*!40000 ALTER TABLE `vh_espe` DISABLE KEYS */;
INSERT INTO `vh_espe` VALUES (1,1,'AAA###','admin'),(2,2,'AAA##','admin'),(3,2,'AAA##A','admin');
/*!40000 ALTER TABLE `vh_espe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vh_tipos`
--

DROP TABLE IF EXISTS `vh_tipos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;

CREATE TABLE `vh_tipos` (
  `TIV_CODI` int NOT NULL AUTO_INCREMENT,
  `TIV_NOMB` varchar(100) NOT NULL,
  `EMP_NUSU` varchar(150) NOT NULL,
  PRIMARY KEY (`TIV_CODI`)
) ENGINE=InnoDB AUTO_INCREMENT=5 ;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vh_tipos`
--

LOCK TABLES `vh_tipos` WRITE;
/*!40000 ALTER TABLE `vh_tipos` DISABLE KEYS */;
INSERT INTO `vh_tipos` VALUES (1,'AUTOMOVILES','admin'),(2,'MOTOCICLETAS','admin'),(4,'Bicicletas','admin');
/*!40000 ALTER TABLE `vh_tipos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Final view structure for view `entregaturnos`
--

/*!50001 DROP VIEW IF EXISTS `entregaturnos`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
CREATe  VIEW `entregaturnos` AS select 1 AS `orden`,'Entradas' AS `Entradas`,`co_entr`.`PAR_CODI` AS `par_codi`,1 AS `cont`,`co_entr`.`ENT_ENTR` AS `fechas`,(select `vh_tipos`.`TIV_NOMB` from `vh_tipos` where (`vh_tipos`.`TIV_CODI` = `co_entr`.`TIV_CODI`)) AS `tipo`,`co_entr`.`AUD_NUSU` AS `AUD_NUSU` from `co_entr` union all select 2 AS `orden`,'Salidas' AS `Salidas`,`co_entr`.`PAR_CODI` AS `par_codi`,1 AS `cont`,`co_entr`.`ENT_SALI` AS `fechas`,(select `vh_tipos`.`TIV_NOMB` from `vh_tipos` where (`vh_tipos`.`TIV_CODI` = `co_entr`.`TIV_CODI`)) AS `tipo`,`co_entr`.`AUD_NUSU` AS `AUD_NUSU` from `co_entr` where (`co_entr`.`ENT_SALI` is not null) union all select 3 AS `3`,'Recaudos' AS `Recaudos`,`cl_saldo`.`par_codi` AS `par_codi`,`cl_saldo`.`sal_valor` AS `sal_valor`,`cl_saldo`.`sal_fecha` AS `sal_fecha`,'' AS `Name_exp_20`,`cl_saldo`.`emp_nusu` AS `emp_nusu` from `cl_saldo` ;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;

--
-- Final view structure for view `rpt_salida`
--

/*!50001 DROP VIEW IF EXISTS `rpt_salida`*/;
/*!50001 SET @saved_cs_client          = @@character_set_client */;
/*!50001 SET @saved_cs_results         = @@character_set_results */;
/*!50001 SET @saved_col_connection     = @@collation_connection */;
/*!50001 SET character_set_client      = utf8 */;
/*!50001 SET character_set_results     = utf8 */;
/*!50001 SET collation_connection      = utf8_general_ci */;
CREATE VIEW `rpt_salida` AS select `co_entr`.`PAR_CODI` AS `PAR_CODI`,`co_entr`.`ENT_CODI` AS `ENT_CODI`,`co_entr`.`EMP_NUSU` AS `EMP_NUSU`,`co_entr`.`USU_CONT` AS `USU_CONT`,`co_entr`.`ENT_ENTR` AS `ENT_ENTR`,`co_entr`.`ENT_SALI` AS `ENT_SALI`,`co_entr`.`ENT_COST` AS `ENT_COST`,`co_entr`.`ENT_PLAC` AS `ENT_PLAC`,`co_entr`.`ENT_TIME` AS `ENT_TIME`,`co_entr`.`TSE_CODI` AS `TSE_CODI`,`co_entr`.`TIV_CODI` AS `TIV_CODI`,`co_entr`.`ENT_COMM` AS `ENT_COMM`,`co_entr`.`AUD_NUSU` AS `AUD_NUSU`,`co_entr`.`ent_manu` AS `ent_manu`,`co_entr`.`ent_cman` AS `ent_cman`,`co_entr`.`ent_deta` AS `ent_deta`,'' AS `adici` from `co_entr` union all select `co_entr`.`PAR_CODI` AS `PAR_CODI`,`co_entr`.`ENT_CODI` AS `ENT_CODI`,`co_entr`.`EMP_NUSU` AS `EMP_NUSU`,`co_entr`.`USU_CONT` AS `USU_CONT`,`co_entr`.`ENT_ENTR` AS `ENT_ENTR`,`co_entr`.`ENT_SALI` AS `ENT_SALI`,`co_entr`.`ENT_COST` AS `ENT_COST`,`co_entr`.`ENT_PLAC` AS `ENT_PLAC`,`co_entr`.`ENT_TIME` AS `ENT_TIME`,`co_entr`.`TSE_CODI` AS `TSE_CODI`,`co_entr`.`TIV_CODI` AS `TIV_CODI`,`co_entr`.`ENT_COMM` AS `ENT_COMM`,`co_entr`.`AUD_NUSU` AS `AUD_NUSU`,`co_entr`.`ent_manu` AS `ent_manu`,`co_entr`.`ent_cman` AS `ent_cman`,`co_entr`.`ent_deta` AS `ent_deta`,`co_valadi`.`VAL_DESC` AS `VAL_DESC` from ((`co_denva` join `co_entr`) join `co_valadi`) where ((`co_denva`.`ENT_CODI` = `co_entr`.`ENT_CODI`) and (`co_denva`.`VAL_CONT` = `co_valadi`.`VAL_CONT`)) ;
/*!50001 SET character_set_client      = @saved_cs_client */;
/*!50001 SET character_set_results     = @saved_cs_results */;
/*!50001 SET collation_connection      = @saved_col_connection */;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-09-19 11:59:44
delimiter /
CREATE TRIGGER `em_empl_insert_audit` BEFORE INSERT ON `em_empl` FOR EACH ROW begin
	SET NEW.EMP_PASS=SHA1(NEW.EMP_PASS);

 end
 /
 CREATE TRIGGER `em_empl_update_audit` BEFORE UPDATE ON `em_empl` FOR EACH ROW begin
	SET NEW.EMP_PASS=SHA1(NEW.EMP_PASS);
    end
/