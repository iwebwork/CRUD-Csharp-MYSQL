-- --------------------------------------------------------
-- Servidor:                     127.0.0.1
-- Versão do servidor:           10.4.20-MariaDB - mariadb.org binary distribution
-- OS do Servidor:               Win64
-- HeidiSQL Versão:              11.3.0.6295
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Copiando estrutura do banco de dados para cpaction
DROP DATABASE IF EXISTS `cpaction`;
CREATE DATABASE IF NOT EXISTS `cpaction` /*!40100 DEFAULT CHARACTER SET utf8mb4 */;
USE `cpaction`;

-- Copiando estrutura para tabela cpaction.carteiras
DROP TABLE IF EXISTS `carteiras`;
CREATE TABLE IF NOT EXISTS `carteiras` (
  `ID` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `NOME` varchar(100) NOT NULL,
  `TIPO` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4;

-- Copiando dados para a tabela cpaction.carteiras: ~2 rows (aproximadamente)
/*!40000 ALTER TABLE `carteiras` DISABLE KEYS */;
INSERT IGNORE INTO `carteiras` (`ID`, `NOME`, `TIPO`) VALUES
	(3, 'teste', '2'),
	(4, 'teste', '4'),
	(5, 'OLA', '4');
/*!40000 ALTER TABLE `carteiras` ENABLE KEYS */;

/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
