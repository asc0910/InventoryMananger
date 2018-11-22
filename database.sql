/*
SQLyog Professional v12.5.0 (64 bit)
MySQL - 5.7.18-log : Database - storemanager
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`storemanager` /*!40100 DEFAULT CHARACTER SET utf8 */;

USE `storemanager`;

/*Table structure for table `categories` */

DROP TABLE IF EXISTS `categories`;

CREATE TABLE `categories` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

/*Data for the table `categories` */

insert  into `categories`(`id`,`name`) values 
(1,'Sofa'),
(2,'Chair'),
(3,'Desk'),
(4,'Bed'),
(5,'Desk'),
(6,'Living Room'),
(7,'Desk'),
(8,'Desk');

/*Table structure for table `inventories` */

DROP TABLE IF EXISTS `inventories`;

CREATE TABLE `inventories` (
  `id` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `name` varchar(255) DEFAULT NULL,
  `image` varchar(255) DEFAULT NULL,
  `modelNumber` varchar(255) DEFAULT NULL,
  `price` decimal(10,0) DEFAULT NULL,
  `width` double DEFAULT NULL,
  `height` double DEFAULT NULL,
  `depth` double DEFAULT NULL,
  `description` text,
  `category` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `inventories` */

insert  into `inventories`(`id`,`name`,`image`,`modelNumber`,`price`,`width`,`height`,`depth`,`description`,`category`) values 
(1,'Brawn Sofa with one chair','\\\\dd-svr\\Users\\ASC\\test\\Brawn Sofa with one chair\\#12453\\products%2Fcoaster%2Fcolor%2Fmoxie--181734809_503995-b1.jpg','#12453',40,10,12,21,'This is suitable for the first floor',1),
(2,'Simple Black Desk','\\\\dd-svr\\Users\\ASC\\test\\Simple Black Desk\\#23123\\products%2Fcoaster%2Fcolor%2Fdesks - coaster_800899-s1.jpg','#23123',60,12,8,23,'',3),
(3,'Brown Desk','\\\\dd-svr\\Users\\ASC\\test\\Brown Desk\\#42342\\products%2Fcoaster%2Fcolor%2Fdesks - coaster_801127-s1.jpg','#42342',20,5,1,5,'This is Simple Black Desk',3);

/*Table structure for table `orderinventories` */

DROP TABLE IF EXISTS `orderinventories`;

CREATE TABLE `orderinventories` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `order` int(11) DEFAULT NULL,
  `inventory` int(11) DEFAULT NULL,
  `qty` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

/*Data for the table `orderinventories` */

insert  into `orderinventories`(`id`,`order`,`inventory`,`qty`) values 
(6,0,1,1),
(7,0,3,1),
(8,2,1,1),
(9,2,3,1),
(10,1,1,1),
(11,1,3,2);

/*Table structure for table `orders` */

DROP TABLE IF EXISTS `orders`;

CREATE TABLE `orders` (
  `id` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `deliveryDate` date DEFAULT NULL,
  `address` varchar(255) DEFAULT NULL,
  `stagerName` varchar(255) DEFAULT NULL,
  `stagerCell` varchar(255) NOT NULL,
  `term` varchar(4) DEFAULT NULL,
  `agentName` varchar(255) DEFAULT NULL,
  `agentCell` varchar(255) DEFAULT NULL,
  `sellerName` varchar(255) DEFAULT NULL,
  `sellerCell` varchar(255) DEFAULT NULL,
  `payfee` varchar(255) DEFAULT NULL,
  `lockbox` varchar(255) DEFAULT NULL,
  `orderInvoice` varchar(255) DEFAULT NULL,
  `stageDate` date DEFAULT NULL,
  `pickupDate` date DEFAULT NULL,
  `subtotal` double DEFAULT NULL,
  `tax` double DEFAULT NULL,
  `fee` double DEFAULT NULL,
  `orderProcessing` double DEFAULT NULL,
  `delivery` double DEFAULT NULL,
  `total` double DEFAULT NULL,
  `orderType` int(11) DEFAULT NULL,
  `bidFlag` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`id`,`stagerCell`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

/*Data for the table `orders` */

insert  into `orders`(`id`,`deliveryDate`,`address`,`stagerName`,`stagerCell`,`term`,`agentName`,`agentCell`,`sellerName`,`sellerCell`,`payfee`,`lockbox`,`orderInvoice`,`stageDate`,`pickupDate`,`subtotal`,`tax`,`fee`,`orderProcessing`,`delivery`,`total`,`orderType`,`bidFlag`) values 
(1,'2018-01-16','123 Any city, any town','James Yamamoto','1234.1231231.123123','','Go Lang','12347.9871231.123123','Sell Lang','1234.45631.123123','asdfasdf','asdfdf','dfsdfsd','2018-01-17','2018-01-29',80,7.8,4,150,120,361.8,0,0),
(2,'2018-01-09','345 Any town, NewYork','Ben Frank','510.895.2492','','Lib Gang','510.895.2493','Weroted','510.895.2494','gotolang','weraer','wecdafe','2018-01-10','2018-02-09',60,5.85,3,150,20,238.85,1,1);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
