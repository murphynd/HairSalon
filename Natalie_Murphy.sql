CREATE DATABASE `Natalie_Murphy` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */;
USE `Natalie_Murphy`;
CREATE TABLE `Clients`
(
  `ClientID` int
(11) NOT NULL AUTO_INCREMENT,
  `Description` varchar
(450) DEFAULT NULL,
  `Address` varchar
(450) DEFAULT NULL,
  `StylistID` int
(11) DEFAULT '0',
  `City` varchar
(200) DEFAULT NULL,
  `State` varchar
(3) DEFAULT NULL,
  `Email` varchar
(200) DEFAULT NULL,
  PRIMARY KEY
(`ClientID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `Stylists`
(
  `StylistId` int
(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar
(450) DEFAULT NULL,
  `Details` varchar
(450) DEFAULT NULL,
  `Image` varchar
(2000) DEFAULT NULL,
  PRIMARY KEY
(`StylistId`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
