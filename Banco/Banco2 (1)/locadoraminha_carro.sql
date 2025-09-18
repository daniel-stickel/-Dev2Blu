-- MySQL dump 10.13  Distrib 8.0.43, for Win64 (x86_64)
--
-- Host: localhost    Database: locadoraminha
-- ------------------------------------------------------
-- Server version	8.0.43

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
-- Table structure for table `carro`
--

DROP TABLE IF EXISTS `carro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `carro` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Filial_Id` int NOT NULL,
  `Modelo_Id` int NOT NULL,
  `Placa` varchar(9) NOT NULL,
  `Capacidade_Mala` int NOT NULL,
  `Capacidade_Pessoa` int NOT NULL,
  `Motor` varchar(15) NOT NULL,
  `Ano` int NOT NULL,
  `TipoCambio` enum('Automatico','Manual') NOT NULL,
  `Valor` decimal(10,2) NOT NULL,
  `Disponivel` tinyint(1) NOT NULL,
  `Km` int DEFAULT NULL,
  `Status_Carro` enum('Ativo','Inativo') NOT NULL DEFAULT 'Ativo',
  PRIMARY KEY (`Id`),
  KEY `FK_CARRO_MODELO` (`Modelo_Id`),
  KEY `FK_CARRO_FILIAL` (`Filial_Id`),
  CONSTRAINT `FK_CARRO_FILIAL` FOREIGN KEY (`Filial_Id`) REFERENCES `filial` (`Id`),
  CONSTRAINT `FK_CARRO_MODELO` FOREIGN KEY (`Modelo_Id`) REFERENCES `modelo` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=211 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `carro`
--

LOCK TABLES `carro` WRITE;
/*!40000 ALTER TABLE `carro` DISABLE KEYS */;
INSERT INTO `carro` VALUES (1,5,9,'KJE8123',48,5,'1.8',2011,'Automatico',30000.00,0,60000,'Ativo'),(2,1,15,'FRD4B56',410,5,'1.6',2023,'Automatico',199.90,1,32000,'Ativo'),(3,1,1,'GHT7C89',290,5,'1.0',2022,'Manual',95.00,1,45000,'Ativo'),(4,1,7,'JKL0D12',437,5,'1.3 Turbo',2025,'Automatico',280.50,1,8000,'Ativo'),(5,1,12,'MNO3E45',937,5,'1.3 Turbo',2024,'Automatico',215.00,1,15000,'Ativo'),(6,1,5,'PQR6F78',313,5,'1.0 Turbo',2023,'Manual',120.80,1,28000,'Ativo'),(7,1,17,'STU9G01',580,5,'2.0',2024,'Automatico',350.00,1,19000,'Ativo'),(8,1,2,'VWX2H34',300,5,'1.0',2022,'Manual',110.00,1,55000,'Ativo'),(9,1,10,'YZA5I67',521,5,'1.0 Turbo',2025,'Automatico',160.20,1,5000,'Inativo'),(10,1,4,'BCD8J90',925,5,'2.0 Diesel',2023,'Automatico',410.70,1,38000,'Ativo'),(11,2,11,'EFG1K23',357,5,'1.0 Turbo',2024,'Automatico',185.00,1,21000,'Ativo'),(12,2,16,'HIJ4L56',470,5,'1.3 Turbo',2023,'Automatico',295.50,1,33000,'Ativo'),(13,2,3,'KLM7M89',510,5,'1.6',2022,'Manual',130.00,1,48000,'Ativo'),(14,2,8,'NOP0N12',683,2,'1.6',2025,'Manual',150.00,1,9500,'Ativo'),(15,2,13,'QRS3O45',300,5,'1.0',2024,'Manual',105.50,1,12000,'Ativo'),(16,2,6,'TUV6P78',525,5,'1.0 Turbo',2023,'Automatico',155.90,1,29000,'Ativo'),(17,2,18,'WXY9Q01',300,5,'1.0',2022,'Manual',99.00,1,58000,'Ativo'),(18,2,19,'ZAB2R34',437,5,'1.6',2024,'Automatico',240.00,1,17500,'Ativo'),(19,2,1,'CDE5S67',290,5,'1.0',2023,'Manual',98.00,1,23000,'Ativo'),(20,2,5,'FGH8T90',313,5,'1.0 Turbo',2025,'Manual',125.00,1,6000,'Ativo'),(21,3,9,'IJK1U23',300,5,'1.0 Turbo',2024,'Automatico',148.90,1,24000,'Ativo'),(22,3,15,'LMN4V56',410,5,'1.6',2023,'Automatico',205.90,1,31000,'Ativo'),(23,3,1,'OPQ7W89',290,5,'1.0',2022,'Manual',97.00,1,46000,'Ativo'),(24,3,7,'RST0X12',437,5,'1.3 Turbo',2025,'Automatico',285.50,1,7000,'Ativo'),(25,3,12,'UVW3Y45',937,5,'1.3 Turbo',2024,'Automatico',220.00,1,16000,'Ativo'),(26,3,5,'XYZ6Z78',313,5,'1.0 Turbo',2023,'Manual',123.80,1,27000,'Ativo'),(27,3,17,'ABC9A01',580,5,'2.0',2024,'Automatico',355.00,1,18000,'Ativo'),(28,3,2,'DEF2B34',300,5,'1.0',2022,'Manual',112.00,1,56000,'Ativo'),(29,3,10,'GHI5C67',521,5,'1.0 Turbo',2025,'Automatico',163.20,1,4000,'Ativo'),(30,3,4,'JKL8D90',925,5,'2.0 Diesel',2023,'Automatico',415.70,1,37000,'Ativo'),(31,4,11,'MNO1E23',357,5,'1.0 Turbo',2024,'Automatico',188.00,1,20000,'Ativo'),(32,4,16,'PQR4F56',470,5,'1.3 Turbo',2023,'Automatico',299.50,1,32000,'Ativo'),(33,4,3,'STU7G89',510,5,'1.6',2022,'Manual',133.00,1,47000,'Ativo'),(34,4,8,'VWX0H12',683,2,'1.6',2025,'Manual',153.00,1,9000,'Ativo'),(35,4,13,'YZA3I45',300,5,'1.0',2024,'Manual',108.50,1,11000,'Ativo'),(36,4,6,'BCD6J78',525,5,'1.0 Turbo',2023,'Automatico',158.90,1,28000,'Ativo'),(37,4,18,'EFG9K01',300,5,'1.0',2022,'Manual',102.00,1,57000,'Ativo'),(38,4,19,'HIJ2L34',437,5,'1.6',2024,'Automatico',243.00,1,16500,'Ativo'),(39,4,1,'KLM5M67',290,5,'1.0',2023,'Manual',101.00,1,22000,'Ativo'),(40,4,5,'NOP8N90',313,5,'1.0 Turbo',2025,'Manual',128.00,1,5500,'Ativo'),(41,5,9,'QRS1O23',300,5,'1.0 Turbo',2024,'Automatico',147.90,1,26000,'Ativo'),(42,5,15,'TUV4P56',410,5,'1.6',2023,'Automatico',202.90,1,34000,'Ativo'),(43,5,1,'WXY7Q89',290,5,'1.0',2022,'Manual',99.00,1,47000,'Ativo'),(44,5,7,'ZAB0R12',437,5,'1.3 Turbo',2025,'Automatico',288.50,1,6000,'Ativo'),(45,5,12,'CDE3S45',937,5,'1.3 Turbo',2024,'Automatico',223.00,1,17000,'Ativo'),(46,1,1,'ABC1D23',290,5,'1.0',2023,'Manual',96.50,1,35000,'Ativo'),(47,2,2,'DEF4E56',300,5,'1.0',2024,'Manual',112.50,1,18000,'Ativo'),(48,3,3,'GHI7F89',510,5,'1.6',2023,'Automatico',135.00,1,41000,'Ativo'),(49,4,5,'JKL0G12',313,5,'1.0 Turbo',2025,'Automatico',130.00,1,3000,'Ativo'),(50,5,6,'MNO3H45',525,5,'1.0 Turbo',2024,'Automatico',160.00,1,14000,'Ativo'),(51,1,2,'PHL4F06',210,5,'1600',1986,'Manual',3000.00,1,50000,'Inativo');
/*!40000 ALTER TABLE `carro` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-09-18 17:12:16
