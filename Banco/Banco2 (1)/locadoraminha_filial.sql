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
-- Table structure for table `filial`
--

DROP TABLE IF EXISTS `filial`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `filial` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Cidade_Id` int NOT NULL,
  `CodigoFilial` int NOT NULL,
  `Nome` varchar(255) NOT NULL,
  `Endereco` varchar(255) NOT NULL,
  `Telefone` varchar(16) NOT NULL,
  `Email` varchar(255) NOT NULL,
  `CEP` varchar(8) DEFAULT NULL,
  `Status_Filial` enum('Ativo','Inativo') NOT NULL DEFAULT 'Ativo',
  PRIMARY KEY (`Id`),
  KEY `FK_FILIAL_CIDADE` (`Cidade_Id`),
  CONSTRAINT `FK_FILIAL_CIDADE` FOREIGN KEY (`Cidade_Id`) REFERENCES `cidade` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `filial`
--

LOCK TABLES `filial` WRITE;
/*!40000 ALTER TABLE `filial` DISABLE KEYS */;
INSERT INTO `filial` VALUES (1,25,101,'Localiza Aeroporto Guarulhos','Rodovia Hélio Smidt, s/nº - Aeroporto, Guarulhos','1124448888','gru@localiza.com','07190100','Ativo'),(2,19,201,'Movida Aeroporto S. Dumont','Praça Sen. Salgado Filho, s/n - Centro, Rio de Janeiro','2138146056','sdu@movida.com.br','20021340','Ativo'),(3,24,301,'Unidas Centro Florianópolis','Av. Hercílio Luz, 500 - Centro, Florianópolis','4832259000','fln_centro@unidas.com.br','88020000','Ativo'),(4,13,401,'Foco Aluguel Confins','Rodovia LMG-800, KM 7,9 - Lagoa Santa','3136898700','cnf@focoaluguel.com','33400000','Ativo'),(5,37,302,'Localiza Blumenau','R. 7 de Setembro, 1213 - Centro, Blumenau','4733268844','blumenau@localiza.com','89010200','Ativo'),(6,23,501,'locadora','R. da Fulano de Tal','4712345678','email@email.com','8905101','Inativo');
/*!40000 ALTER TABLE `filial` ENABLE KEYS */;
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
