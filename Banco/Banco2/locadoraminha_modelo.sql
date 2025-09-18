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
-- Table structure for table `modelo`
--

DROP TABLE IF EXISTS `modelo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `modelo` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Marca_Id` int NOT NULL,
  `Categoria_Id` int NOT NULL,
  `Nome` varchar(255) DEFAULT NULL,
  `Status_Modelo` enum('Ativo','Inativo') NOT NULL DEFAULT 'Ativo',
  PRIMARY KEY (`Id`),
  KEY `FK_MODELO_MARCA` (`Marca_Id`),
  KEY `FK_MODELO_CATEGORIA` (`Categoria_Id`),
  CONSTRAINT `FK_MODELO_CATEGORIA` FOREIGN KEY (`Categoria_Id`) REFERENCES `categoria` (`Id`),
  CONSTRAINT `FK_MODELO_MARCA` FOREIGN KEY (`Marca_Id`) REFERENCES `marca` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `modelo`
--

LOCK TABLES `modelo` WRITE;
/*!40000 ALTER TABLE `modelo` DISABLE KEYS */;
INSERT INTO `modelo` VALUES (1,1,1,'Mobi','Ativo'),(2,1,1,'Argo','Ativo'),(3,1,2,'Cronos','Ativo'),(4,1,7,'Toro','Ativo'),(5,2,1,'Polo','Ativo'),(6,2,2,'Virtus','Ativo'),(7,2,5,'T-Cross','Ativo'),(8,2,7,'Saveiro','Ativo'),(9,3,1,'Onix','Ativo'),(10,3,2,'Onix Plus','Ativo'),(11,3,5,'Tracker','Ativo'),(12,3,7,'Montana','Ativo'),(13,4,1,'HB20','Ativo'),(14,4,2,'HB20S','Ativo'),(15,4,5,'Creta','Ativo'),(16,6,5,'Renegade','Ativo'),(17,6,6,'Compass','Ativo'),(18,7,1,'Kwid','Ativo'),(19,7,5,'Duster','Ativo'),(20,7,5,'Compas','Inativo');
/*!40000 ALTER TABLE `modelo` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-09-18 17:11:29
