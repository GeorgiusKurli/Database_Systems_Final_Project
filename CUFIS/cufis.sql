-- MySQL dump 10.16  Distrib 10.1.25-MariaDB, for Win32 (AMD64)
--
-- Host: localhost    Database: cufis
-- ------------------------------------------------------
-- Server version	10.1.25-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `admins`
--

DROP TABLE IF EXISTS `admins`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `admins` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `AdminName` varchar(30) NOT NULL,
  `Password` varchar(30) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `admins`
--

LOCK TABLES `admins` WRITE;
/*!40000 ALTER TABLE `admins` DISABLE KEYS */;
INSERT INTO `admins` VALUES (1,'admin','123');
/*!40000 ALTER TABLE `admins` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `beverages`
--

DROP TABLE IF EXISTS `beverages`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `beverages` (
  `BeverageID` int(11) NOT NULL AUTO_INCREMENT,
  `BeverageName` varchar(20) NOT NULL,
  `BeveragePrice` int(11) NOT NULL,
  `MenuID` int(11) NOT NULL,
  PRIMARY KEY (`BeverageID`),
  KEY `MenuID` (`MenuID`),
  CONSTRAINT `fk_beveragesmenu` FOREIGN KEY (`MenuID`) REFERENCES `menu` (`MenuID`)
) ENGINE=InnoDB AUTO_INCREMENT=64 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `beverages`
--

LOCK TABLES `beverages` WRITE;
/*!40000 ALTER TABLE `beverages` DISABLE KEYS */;
INSERT INTO `beverages` VALUES (1,'Blast Smoothie',30000,1),(2,'Cawston Apple',24000,1),(3,'Karma Cola',20000,1),(4,'Limonata',22000,1),(5,'Nastro Azzuro',32000,1),(6,'Mella Rossa',38000,1),(7,'Recioto Tesaurio',35000,1),(8,'Aulente Bianco',33000,1),(9,'Cappucino',35000,2),(10,'Espresso',25000,2),(11,'Latte',30000,2),(12,'Sambucca',50000,2),(13,'Kahlua',50000,2),(14,'Frappucino',45000,2),(15,'Hot Chocolate',30000,2),(16,'Caffe Misto',37000,2),(17,'Chocolate Mocha',42000,2),(18,'Caramel Macchiato',46000,2),(19,'Mango Smoothie',30000,3),(20,'Cider',35000,3),(21,'Rose Wine',42000,3),(22,'Tonic and Gin',40000,3),(23,'Whiskey',45000,3),(24,'Straight Rye',43000,3),(25,'Coke',15000,4),(26,'Diet Coke',18000,4),(27,'Water Bottle',10000,4),(28,'Cold Lemonade',20000,4),(29,'Cold Tea',18000,4),(30,'Smoothie',25000,4),(31,'Milkshake',24000,4),(32,'Hot Chocolate',25000,4),(33,'Coke',13000,5),(34,'Diet Coke',15000,5),(35,'Water Bottle',8000,5),(36,'Cold Lemonade',18000,5),(37,'Turkish Coffe',32000,6),(38,'Arabic Tea',20000,6),(39,'Fruit Lassi',35000,6),(40,'Sparkling Water',15000,6),(42,'Fountain Drink',18000,7),(43,'Lemonade',18000,7),(44,'Ocha tea',16000,7),(45,'Sake',28000,7),(46,'Mango Chutney',25000,8),(47,'Achar',23000,8),(48,'Mango Lassi',20000,8),(49,'Tea',18000,8),(50,'Coffee',18000,8),(51,'Cider',30000,9),(52,'Wine',45000,9),(53,'Gin',38000,9),(54,'Whiskey',42000,9),(55,'Rye',45000,9),(56,'Lager',42000,9),(57,'Tieguanyin',20000,10),(58,'Sinkiang Beer',40000,10),(59,'Pearl Milk Tea',28000,10),(60,'Jiuniang',24000,10),(61,'Tsingtao Beer',45000,10),(62,'Yunnan Coffee',32000,10),(63,'Tea',18000,10);
/*!40000 ALTER TABLE `beverages` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `city`
--

DROP TABLE IF EXISTS `city`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `city` (
  `CityID` int(11) NOT NULL AUTO_INCREMENT,
  `CityName` varchar(15) NOT NULL,
  PRIMARY KEY (`CityID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `city`
--

LOCK TABLES `city` WRITE;
/*!40000 ALTER TABLE `city` DISABLE KEYS */;
INSERT INTO `city` VALUES (1,'Jakarta'),(2,'Bogor'),(3,'Depok'),(4,'Tangerang'),(5,'Bekasi'),(6,'Surabaya'),(7,'Medan');
/*!40000 ALTER TABLE `city` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `dishes`
--

DROP TABLE IF EXISTS `dishes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `dishes` (
  `DishID` int(11) NOT NULL AUTO_INCREMENT,
  `DishName` varchar(20) NOT NULL,
  `DishPrice` int(11) NOT NULL,
  `MenuID` int(11) NOT NULL,
  PRIMARY KEY (`DishID`),
  KEY `MenuID` (`MenuID`),
  CONSTRAINT `fk_dishesmenu` FOREIGN KEY (`MenuID`) REFERENCES `menu` (`MenuID`)
) ENGINE=InnoDB AUTO_INCREMENT=79 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `dishes`
--

LOCK TABLES `dishes` WRITE;
/*!40000 ALTER TABLE `dishes` DISABLE KEYS */;
INSERT INTO `dishes` VALUES (1,'Carbonara',55000,1),(2,'Tagliatlle Bolognese',47500,1),(3,'Gnocchi Genovese',60000,1),(4,'Affogato',45000,1),(5,'Torta di Nada',50000,1),(6,'Fritto Misto',40000,1),(7,'Tuscan Pate',45000,1),(8,'Tomato Bruschetta',45000,1),(9,'Tiramisu',55000,2),(10,'Cannoli',50000,2),(11,'Cheese Cake',50000,2),(12,'Chocolate Cake',50000,2),(13,'Gelato',60000,2),(14,'Soft Shelled Crab',60000,3),(15,'Pike',59000,3),(16,'Pork Tenderloin',62000,3),(17,'Chicken Scnitzel',55000,3),(18,'Duck Breast',53000,3),(19,'Rack of Lamb',65000,3),(20,'Trumpet Mushroom',50000,3),(21,'Crusted Banzino',65000,3),(22,'Roasted Chicken',50000,4),(23,'Wheat Berry Ragout',45000,4),(24,'Sauted Salmon',50000,4),(25,'Duo of Lamb',55000,4),(26,'Striped Bass',48000,4),(27,'Sauted Moulard Duck',52000,4),(28,'Grilled Strip Loin',58000,4),(29,'Double Burger',40000,5),(30,'French Fries',21000,5),(31,'Regular Burger',25000,5),(32,'Fried Chicken',24000,5),(33,'Cheese Burger',27000,5),(34,'Chicken Nuggets',21000,5),(35,'Taco',35000,5),(36,'Beef Shawarma',63000,6),(37,'Chicken Kebab',50000,6),(38,'Beef Kebab',55000,6),(39,'Gyro Platter',48000,6),(40,'Molokhia',58000,6),(41,'Kebseh',56000,6),(42,'Rack of Lamb',60000,6),(43,'Hummus',30000,6),(44,'Tuna Sushi',55000,7),(45,'Tuna Sashimi',62000,7),(46,'Tempura',45000,7),(47,'Teriyaki',45000,7),(48,'Eel Unaju',56000,7),(49,'Sukiyaki',50000,7),(50,'Beef Udon',40000,7),(51,'Ramen',42000,7),(52,'Mochi Cake',20000,7),(53,'Lamb Biryani',62000,8),(54,'Chicken Tikka Masala',52000,8),(55,'Chicken Vindaloo',45000,8),(56,'Crabmeat Curry',50000,8),(57,'Meat Tandoori',55000,8),(58,'Lamb Pasanda',65000,8),(59,'Chciken Saag',42000,8),(60,'Meat Shagoti',56000,8),(61,'Lobster Bisque',60000,9),(62,'Bass Fillet',74000,9),(63,'Sole Anglaise',80000,9),(64,'Turbot Comte Crust',70000,9),(65,'Canard Roasted Duck',72000,9),(66,'Veal Medallions',75000,9),(67,'Poulet Chicken',72000,9),(68,'Roasted Rack Lamb',78000,9),(69,'Hunan Beef',45000,10),(70,'Gerenal Chicken',40000,10),(71,'Kung Pao',38000,10),(72,'Jade Shrimp',45000,10),(73,'Wonton Soup',30000,10),(74,'Yu Sing Pork',55000,10),(75,'Fried Rice',45000,10),(76,'Szechwan Chicken',42000,10),(77,'Choy Mein',45000,10),(78,'Choy Suey',48000,10);
/*!40000 ALTER TABLE `dishes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `location`
--

DROP TABLE IF EXISTS `location`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `location` (
  `LocationID` int(11) NOT NULL AUTO_INCREMENT,
  `StreetName` varchar(50) NOT NULL,
  `CityID` int(11) NOT NULL,
  PRIMARY KEY (`LocationID`),
  KEY `CityID` (`CityID`),
  CONSTRAINT `fk_locationcity` FOREIGN KEY (`CityID`) REFERENCES `city` (`CityID`)
) ENGINE=InnoDB AUTO_INCREMENT=43 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `location`
--

LOCK TABLES `location` WRITE;
/*!40000 ALTER TABLE `location` DISABLE KEYS */;
INSERT INTO `location` VALUES (1,'Jl. Aries Utama IV',1),(2,'Jl. Pahlawan Kalibata',1),(3,'Jl. Kaca Jendela II',1),(4,'Jl. Rawajati Timur',1),(5,'Jl. Triloka VII',1),(6,'Jl. Pancoran Timur',1),(7,'Jl. Rasamala',1),(8,'Jl. Deposito',1),(9,'Jl. Kapten Tendean',1),(10,'Jl. Dukuh Patra',1),(11,'Jl. Taska',1),(12,'Jl. Malabar',2),(13,'Jl. Roda III',2),(14,'Jl. Lawang Saketeng',2),(15,'Jl. Paldasuka',2),(16,'Jl. Kapten Yusuf',2),(17,'Jl. Lolongok',2),(18,'Jl. Cikaret Hijau',2),(19,'Jl. Raden Saleh',2),(20,'Jl. Keadilan',3),(21,'Jl. Arip Raya',3),(22,'Jl. Sainin',3),(23,'Jl. Manggis VIII',3),(24,'Jl. Caringin II',3),(25,'Jl. Kramat Burung',3),(26,'Jl. Pitara V',3),(27,'Jl. H. Kimah',3),(28,'Jl. Raya Gardu',3),(29,'Jl. Swadaya III',3),(30,'Jl. Sukahati IV',4),(31,'Jl. Sinar Raya',4),(32,'Jl. Imam Bonjol',4),(33,'Jl. Kemerdekaan VI',4),(34,'Jl. Melam',4),(35,'Jl. Taruna V',4),(36,'Jl. Pulo Gede',5),(37,'Jl. Gabus Raya',5),(38,'Jl. Jatisari IV',5),(39,'Jl. Patriot Dalam',5),(40,'Jl. Nurul Imam Raya',5),(41,'Jl. Pemuda',6),(42,'Jl. Arip Jaya',3);
/*!40000 ALTER TABLE `location` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `main`
--

DROP TABLE IF EXISTS `main`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `main` (
  `Rating` float NOT NULL,
  `Hours` varchar(15) NOT NULL,
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `RestaurantID` int(11) NOT NULL,
  `LocationID` int(11) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `RestaurantID` (`RestaurantID`),
  KEY `LocationID` (`LocationID`),
  CONSTRAINT `fk_mainlocation` FOREIGN KEY (`LocationID`) REFERENCES `location` (`LocationID`),
  CONSTRAINT `fk_mainrestaurant` FOREIGN KEY (`RestaurantID`) REFERENCES `restaurant` (`RestaurantID`)
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `main`
--

LOCK TABLES `main` WRITE;
/*!40000 ALTER TABLE `main` DISABLE KEYS */;
INSERT INTO `main` VALUES (4.2,'12:00-22:00',1,1,1),(4.5,'07:00-21:00',2,2,2),(4.4,'10:00-22:00',3,3,3),(4.5,'10:00-22:00',4,4,4),(4.6,'10:00-22:00',5,5,5),(4.3,'09:00-21:00',6,6,6),(4,'09:00-21:00',7,7,7),(4.7,'09:00-21:00',8,8,8),(4.4,'09:00-21:00',9,9,9),(4.8,'12:00-23:00',10,10,10),(4.5,'10:00-22:00',11,11,11),(4,'12:00-22:00',12,1,12),(3.8,'07:00-21:00',13,2,13),(3.6,'10:00-22:00',14,3,14),(4,'10:00-22:00',15,4,15),(4.8,'10:00-22:00',16,5,16),(3.5,'09:00-21:00',17,6,17),(4.9,'09:00-21:00',18,7,18),(4.2,'09:00-21:00',19,8,19),(4.1,'09:00-21:00',20,9,20),(4.2,'10:00-22:00',22,11,22),(3.7,'12:00-22:00',23,1,23),(3.4,'07:00-21:00',24,2,24),(3.3,'10:00-22:00',25,3,25),(4.2,'10:00-22:00',26,4,26),(3.8,'10:00-22:00',27,5,27),(4.6,'09:00-21:00',28,6,28),(3.2,'09:00-21:00',29,7,29),(3.8,'09:00-21:00',30,8,30),(4.7,'09:00-21:00',31,9,31),(3.9,'12:00-23:00',32,10,32),(4.3,'10:00-22:00',33,11,33),(4.7,'12:00-22:00',34,1,34),(4.5,'07:00-21:00',35,2,35),(4.3,'10:00-22:00',36,3,36),(4.8,'10:00-22:00',37,4,37),(4.8,'10:00-22:00',38,5,38),(4.3,'09:00-21:00',39,6,39),(4.8,'09:00-21:00',40,7,40),(4.5,'09.00 - 21.00',41,7,22);
/*!40000 ALTER TABLE `main` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `menu` (
  `MenuID` int(11) NOT NULL AUTO_INCREMENT,
  `MenuName` varchar(25) NOT NULL,
  PRIMARY KEY (`MenuID`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` VALUES (1,'Italian Dinner'),(2,'Italian Cafe'),(3,'American Dinner'),(4,'American Casual'),(5,'American Fast Food'),(6,'Mid Eastern Casual'),(7,'Japanese Casual'),(8,'Indian Casual'),(9,'French Dinner'),(10,'Chinese Casual');
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `restaurant`
--

DROP TABLE IF EXISTS `restaurant`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `restaurant` (
  `RestaurantID` int(11) NOT NULL AUTO_INCREMENT,
  `RestaurantName` varchar(100) NOT NULL,
  `RestaurantContact` varchar(10) NOT NULL,
  `TypeID` int(11) NOT NULL,
  `MenuID` int(11) NOT NULL,
  PRIMARY KEY (`RestaurantID`),
  KEY `TypeID` (`TypeID`),
  KEY `MenuID` (`MenuID`),
  CONSTRAINT `fk_restaurantmenu` FOREIGN KEY (`MenuID`) REFERENCES `menu` (`MenuID`),
  CONSTRAINT `fk_restauranttype` FOREIGN KEY (`TypeID`) REFERENCES `type` (`TypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `restaurant`
--

LOCK TABLES `restaurant` WRITE;
/*!40000 ALTER TABLE `restaurant` DISABLE KEYS */;
INSERT INTO `restaurant` VALUES (1,'PEPeNERO','0815567892',1,1),(2,'De Luca Cafe','0817465905',1,2),(3,'Mike\'s Dine-in','0824443649',2,3),(4,'Cook Bohemian','0819948562',2,4),(5,'McWaldo','0815839772',2,5),(6,'Dandy\'s','0874677842',2,5),(7,'Al Jazeerah','0876673399',3,6),(8,'Kadoya','0876673399',4,7),(9,'Chutney Villa','0818854924',5,8),(10,'French Table','0818573544',6,9),(11,'Golden Lakes','0811850338',7,10);
/*!40000 ALTER TABLE `restaurant` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `type`
--

DROP TABLE IF EXISTS `type`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `type` (
  `TypeID` int(11) NOT NULL AUTO_INCREMENT,
  `RestaurantType` varchar(20) NOT NULL,
  PRIMARY KEY (`TypeID`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `type`
--

LOCK TABLES `type` WRITE;
/*!40000 ALTER TABLE `type` DISABLE KEYS */;
INSERT INTO `type` VALUES (1,'Italian Cuisine'),(2,'American Cuisine'),(3,'Mid Eastern Cuisine'),(4,'Japanese Cuisine'),(5,'Indian Cuisine'),(6,'French Cuisine'),(7,'Chinese Cuisine');
/*!40000 ALTER TABLE `type` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `UserName` varchar(20) NOT NULL,
  `UserStreetName` varchar(50) NOT NULL,
  `Password` varchar(6) NOT NULL,
  `CityID` int(11) NOT NULL,
  PRIMARY KEY (`UserID`),
  KEY `CityID` (`CityID`),
  CONSTRAINT `fk_usercity` FOREIGN KEY (`CityID`) REFERENCES `city` (`CityID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (1,'Fred McGee','Jl. Mahakam VII','123456',1),(2,'Bondan Prakasa','Jl. Bondan Raya','654321',2),(3,'Lucinta Luna','Jl. Taruna V','123123',4),(4,'Kevin Hendrawan','Jl. Sainin','654321',3),(5,'Tom Holland','Jl. Sainin','567890',3);
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-06-27 20:33:08
