CREATE DATABASE `carrental` /*!40100 DEFAULT CHARACTER SET utf8 */;
use carrental;
CREATE TABLE `customer` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(45) DEFAULT NULL,
  `Age` int(11) DEFAULT NULL,
  `UserName` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `Gender` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `UserName_UNIQUE` (`UserName`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

CREATE TABLE `car` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `Type` varchar(45) NOT NULL,
  `Model` varchar(45) NOT NULL,
  `Year` int(11) NOT NULL,
  `Description` varchar(500) NOT NULL,
  `Number` varchar(45) NOT NULL,
  `Prices` decimal(10,0) DEFAULT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE KEY `Number_UNIQUE` (`Number`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

CREATE TABLE `booking` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `CarId` int(11) DEFAULT NULL,
  `CustomerId` int(11) DEFAULT NULL,
  `StartDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `EndDate` datetime DEFAULT CURRENT_TIMESTAMP,
  `Status` int(11) DEFAULT '1',
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

CREATE TABLE `payment` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerId` int(11) DEFAULT NULL,
  `BookingId` int(11) DEFAULT NULL,
  `Total` varchar(45) DEFAULT NULL,
  `AddDate` datetime DEFAULT NULL,
  `CardNumber` varchar(45) DEFAULT NULL,
  `Bank` varchar(45) DEFAULT NULL,
  `Expire` datetime DEFAULT NULL,
  `Pin` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

