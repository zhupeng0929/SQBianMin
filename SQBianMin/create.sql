CREATE DATABASE `sq_bianmin` /*!40100 DEFAULT CHARACTER SET utf8 */;
CREATE TABLE `sq_message` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `NickName` varchar(45) DEFAULT NULL,
  `HeadImg` varchar(450) DEFAULT NULL,
  `CategoryId` int(11) DEFAULT NULL,
  `Content` varchar(1000) DEFAULT NULL,
  `ContactNum` varchar(100) DEFAULT NULL,
  `ContactName` varchar(100) DEFAULT NULL,
  `CreateDate` datetime DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

