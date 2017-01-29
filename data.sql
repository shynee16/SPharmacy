CREATE DATABASE  IF NOT EXISTS `sjpharmacy` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `sjpharmacy`;
-- MySQL dump 10.13  Distrib 5.6.17, for Win32 (x86)
--
-- Host: localhost    Database: sjpharmacy
-- ------------------------------------------------------
-- Server version	5.5.42-log

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
-- Table structure for table `adjustments`
--

DROP TABLE IF EXISTS `adjustments`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `adjustments` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Code` smallint(5) unsigned zerofill NOT NULL,
  `Product` int(10) unsigned zerofill NOT NULL,
  `Type` enum('add','deduct') NOT NULL,
  `Variance` tinyint(3) unsigned NOT NULL,
  `Remarks` tinytext NOT NULL,
  `Date` date NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `adjustments`
--
-- ORDER BY:  `ID`

LOCK TABLES `adjustments` WRITE;
/*!40000 ALTER TABLE `adjustments` DISABLE KEYS */;
/*!40000 ALTER TABLE `adjustments` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `categories`
--

DROP TABLE IF EXISTS `categories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `categories` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Name_UNIQUE` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `categories`
--
-- ORDER BY:  `ID`

LOCK TABLES `categories` WRITE;
/*!40000 ALTER TABLE `categories` DISABLE KEYS */;
INSERT INTO `categories` (`ID`, `Name`) VALUES (0000000008,'Generic Medications'),(0000000009,'Branded Medications'),(0000000010,'Medical Equipment'),(0000000011,'Cosmetics'),(0000000019,'Milk Products'),(0000000020,'Contraceptives');
/*!40000 ALTER TABLE `categories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `discounts`
--

DROP TABLE IF EXISTS `discounts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `discounts` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  `Value` decimal(4,2) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Name_UNIQUE` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discounts`
--
-- ORDER BY:  `ID`

LOCK TABLES `discounts` WRITE;
/*!40000 ALTER TABLE `discounts` DISABLE KEYS */;
INSERT INTO `discounts` (`ID`, `Name`, `Value`) VALUES (0000000001,'Senior Citizen',20.00),(0000000003,'Customer Card',5.00);
/*!40000 ALTER TABLE `discounts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `expiry`
--

DROP TABLE IF EXISTS `expiry`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `expiry` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Product` int(10) unsigned zerofill NOT NULL,
  `BatchNumber` varchar(20) NOT NULL,
  `ExpirationDate` date NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `unique` (`Product`,`BatchNumber`),
  KEY `expiry_prod_idx` (`Product`),
  CONSTRAINT `expiry_prod` FOREIGN KEY (`Product`) REFERENCES `products` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `expiry`
--
-- ORDER BY:  `ID`

LOCK TABLES `expiry` WRITE;
/*!40000 ALTER TABLE `expiry` DISABLE KEYS */;
INSERT INTO `expiry` (`ID`, `Product`, `BatchNumber`, `ExpirationDate`) VALUES (0000000001,0000000004,'12123asda','2017-02-16'),(0000000002,0000000013,'5866996','2015-02-22');
/*!40000 ALTER TABLE `expiry` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products`
--

DROP TABLE IF EXISTS `products`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `products` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Code` varchar(16) NOT NULL,
  `ProductName` varchar(30) NOT NULL,
  `GenericName` varchar(50) NOT NULL,
  `Subcategory` int(10) unsigned zerofill NOT NULL,
  `Unit` int(10) unsigned zerofill NOT NULL,
  `Price` decimal(6,2) NOT NULL,
  `Vatable` set('yes','no') NOT NULL,
  `Discountable` set('yes','no') NOT NULL,
  `MarkUp` decimal(4,2) NOT NULL,
  `ReOrderPoint` smallint(6) NOT NULL,
  `Stocks` smallint(6) NOT NULL,
  `SellingPrice` decimal(6,2) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Code_UNIQUE` (`Code`),
  KEY `prod_subcat` (`Subcategory`),
  KEY `prod_units` (`Unit`),
  CONSTRAINT `prod_subcat` FOREIGN KEY (`Subcategory`) REFERENCES `subcategories` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `prod_units` FOREIGN KEY (`Unit`) REFERENCES `units` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products`
--
-- ORDER BY:  `ID`

LOCK TABLES `products` WRITE;
/*!40000 ALTER TABLE `products` DISABLE KEYS */;
INSERT INTO `products` (`ID`, `Code`, `ProductName`, `GenericName`, `Subcategory`, `Unit`, `Price`, `Vatable`, `Discountable`, `MarkUp`, `ReOrderPoint`, `Stocks`, `SellingPrice`) VALUES (0000000004,'0001','Dialix','Cetrizine',0000000002,0000000001,10.00,'yes','yes',8.00,0,1026,12.96),(0000000007,'0003','Unique','',0000000027,0000000001,100.00,'yes','yes',20.00,50,1028,144.00),(0000000008,'0004','NIDO','',0000000030,0000000001,25.00,'yes','yes',2.00,100,1029,28.56),(0000000013,'00005','Flugard','Paracetamol',0000000024,0000000010,1.00,'yes','yes',2.00,500,500,1.14),(0000000014,'00006','MaxFactor','xxxxx',0000000022,0000000020,100.00,'yes','yes',20.00,10,700,134.40),(0000000017,'0002','Ceterizine','',0000000002,0000000001,7.00,'yes','yes',3.00,750,1249,8.08);
/*!40000 ALTER TABLE `products` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `purchase`
--

DROP TABLE IF EXISTS `purchase`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `purchase` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Code` int(10) unsigned zerofill NOT NULL,
  `DateTime` datetime NOT NULL,
  `Supplier` int(10) unsigned zerofill NOT NULL,
  `Product` int(10) unsigned zerofill NOT NULL,
  `Quantity` smallint(6) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `purchase_supp_idx` (`Supplier`),
  KEY `purchase_prod_idx` (`Product`),
  CONSTRAINT `purchase_prod` FOREIGN KEY (`Product`) REFERENCES `products` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `purchase_supp` FOREIGN KEY (`Supplier`) REFERENCES `suppliers` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=38 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `purchase`
--
-- ORDER BY:  `ID`

LOCK TABLES `purchase` WRITE;
/*!40000 ALTER TABLE `purchase` DISABLE KEYS */;
INSERT INTO `purchase` (`ID`, `Code`, `DateTime`, `Supplier`, `Product`, `Quantity`) VALUES (0000000031,0000000001,'2018-03-23 13:19:09',0000000001,0000000004,21),(0000000032,0000000001,'2018-03-23 13:19:09',0000000001,0000000007,21),(0000000033,0000000001,'2018-03-23 13:19:09',0000000001,0000000013,1000),(0000000034,0000000002,'2015-02-27 08:03:13',0000000007,0000000014,500),(0000000035,0000000003,'2015-03-13 09:33:38',0000000001,0000000013,500),(0000000036,0000000004,'2015-03-13 09:41:05',0000000001,0000000013,1),(0000000037,0000000005,'2015-03-14 00:39:41',0000000007,0000000017,1250);
/*!40000 ALTER TABLE `purchase` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receiptnumber`
--

DROP TABLE IF EXISTS `receiptnumber`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receiptnumber` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Start` varchar(8) NOT NULL,
  `End` varchar(8) NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receiptnumber`
--
-- ORDER BY:  `ID`

LOCK TABLES `receiptnumber` WRITE;
/*!40000 ALTER TABLE `receiptnumber` DISABLE KEYS */;
INSERT INTO `receiptnumber` (`ID`, `Start`, `End`) VALUES (0000000001,'00000001','99999999');
/*!40000 ALTER TABLE `receiptnumber` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receipts`
--

DROP TABLE IF EXISTS `receipts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receipts` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `ReceiptNumber` varchar(8) NOT NULL,
  `DateTime` datetime NOT NULL,
  `Cashier` int(10) unsigned zerofill NOT NULL,
  `Discount` int(10) unsigned zerofill DEFAULT NULL,
  `TotalDue` decimal(7,2) unsigned NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ReceiptNumber_UNIQUE` (`ReceiptNumber`),
  KEY `receipt_user_idx` (`Cashier`),
  KEY `receipt_discount_idx` (`Discount`),
  CONSTRAINT `receipt_discount` FOREIGN KEY (`Discount`) REFERENCES `discounts` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `receipt_user` FOREIGN KEY (`Cashier`) REFERENCES `users` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=28 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receipts`
--
-- ORDER BY:  `ID`

LOCK TABLES `receipts` WRITE;
/*!40000 ALTER TABLE `receipts` DISABLE KEYS */;
INSERT INTO `receipts` (`ID`, `ReceiptNumber`, `DateTime`, `Cashier`, `Discount`, `TotalDue`) VALUES (0000000017,'00000014','2015-02-21 19:07:26',0000000001,NULL,134.40),(0000000018,'00000015','2015-02-21 19:13:11',0000000001,NULL,134.40),(0000000019,'00000016','2015-02-21 19:42:28',0000000001,NULL,134.40),(0000000020,'00000017','2015-02-21 20:20:04',0000000001,NULL,134.40),(0000000021,'00000018','2015-02-22 05:28:22',0000000001,0000000001,107.52),(0000000022,'00000019','2015-03-13 08:22:48',0000000001,NULL,12.10),(0000000023,'00000020','2015-03-13 12:45:31',0000000001,NULL,12.10),(0000000024,'00000021','2015-03-13 23:20:15',0000000001,NULL,12.10),(0000000025,'00000022','2015-03-13 23:22:07',0000000001,NULL,8.08),(0000000026,'00000023','2015-03-13 23:24:21',0000000001,NULL,134.40),(0000000027,'00000024','2015-03-13 23:27:49',0000000001,NULL,1.14);
/*!40000 ALTER TABLE `receipts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receive`
--

DROP TABLE IF EXISTS `receive`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receive` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `PurchaseCode` int(10) unsigned zerofill NOT NULL,
  `DateTime` datetime NOT NULL,
  `Product` int(10) unsigned zerofill NOT NULL,
  `Quantity` smallint(6) NOT NULL,
  `Price` decimal(6,2) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `received_purchase_idx` (`PurchaseCode`),
  KEY `received_prod_idx` (`Product`),
  CONSTRAINT `received_prod` FOREIGN KEY (`Product`) REFERENCES `products` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receive`
--
-- ORDER BY:  `ID`

LOCK TABLES `receive` WRITE;
/*!40000 ALTER TABLE `receive` DISABLE KEYS */;
INSERT INTO `receive` (`ID`, `PurchaseCode`, `DateTime`, `Product`, `Quantity`, `Price`) VALUES (0000000002,0000000001,'2018-03-23 13:19:09',0000000004,20,50.00),(0000000005,0000000003,'2015-03-13 09:34:06',0000000013,500,5.00),(0000000006,0000000002,'2015-03-13 09:41:38',0000000014,600,501.00),(0000000007,0000000004,'2015-03-13 09:41:58',0000000013,1,1.00),(0000000008,0000000005,'2015-03-14 00:39:54',0000000017,1250,7.00);
/*!40000 ALTER TABLE `receive` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `return`
--

DROP TABLE IF EXISTS `return`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `return` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `DateTime` datetime NOT NULL,
  `Supplier` int(10) unsigned zerofill NOT NULL,
  `Product` int(10) unsigned zerofill NOT NULL,
  `Quantity` smallint(6) NOT NULL,
  `Remarks` varchar(30) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `return_supplier_idx` (`Supplier`),
  KEY `return_product_idx` (`Product`),
  CONSTRAINT `return_product` FOREIGN KEY (`Product`) REFERENCES `products` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `return_supplier` FOREIGN KEY (`Supplier`) REFERENCES `suppliers` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `return`
--
-- ORDER BY:  `ID`

LOCK TABLES `return` WRITE;
/*!40000 ALTER TABLE `return` DISABLE KEYS */;
/*!40000 ALTER TABLE `return` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `subcategories`
--

DROP TABLE IF EXISTS `subcategories`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `subcategories` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Category` int(10) unsigned zerofill NOT NULL,
  `Name` varchar(20) NOT NULL,
  `MarkUp` decimal(4,2) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `unique` (`Category`,`Name`),
  KEY `subcat_cat` (`Category`),
  CONSTRAINT `subcat_cat` FOREIGN KEY (`Category`) REFERENCES `categories` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=34 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `subcategories`
--
-- ORDER BY:  `ID`

LOCK TABLES `subcategories` WRITE;
/*!40000 ALTER TABLE `subcategories` DISABLE KEYS */;
INSERT INTO `subcategories` (`ID`, `Category`, `Name`, `MarkUp`) VALUES (0000000002,0000000009,'Antihistamine',3.00),(0000000007,0000000009,'Paracetamol',5.00),(0000000012,0000000009,'Antacid',1.00),(0000000013,0000000009,'Loperamide',3.00),(0000000014,0000000009,'Decongestant',6.00),(0000000015,0000000009,'Antitussives',5.00),(0000000016,0000000009,'Mucolytic',5.00),(0000000017,0000000020,'Condoms',10.00),(0000000018,0000000020,'Pills',15.00),(0000000019,0000000020,'Diaphragm',18.00),(0000000021,0000000011,'Make-Up',22.00),(0000000022,0000000011,'Eye Products',20.00),(0000000023,0000000008,'Antihistamine',4.00),(0000000024,0000000008,'Paracetamol',2.00),(0000000025,0000000008,'Mucolytic',3.00),(0000000026,0000000008,'Antibiotics',5.00),(0000000027,0000000010,'Thermometer',25.00),(0000000028,0000000010,'Gloves',8.00),(0000000029,0000000010,'Stethoscope',30.00),(0000000030,0000000019,'Powdered',15.00),(0000000031,0000000019,'Canned',15.00),(0000000032,0000000019,'Dairy',20.00),(0000000033,0000000019,'Non - Dairy',10.00);
/*!40000 ALTER TABLE `subcategories` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suppliers`
--

DROP TABLE IF EXISTS `suppliers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `suppliers` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Code` int(10) unsigned zerofill NOT NULL,
  `Name` varchar(50) NOT NULL,
  `Address` varchar(100) NOT NULL,
  `ContactPerson` varchar(50) NOT NULL,
  `CPNumber` varchar(30) NOT NULL,
  `TelNumber` varchar(20) NOT NULL,
  `FaxNumber` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Code_UNIQUE` (`Code`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliers`
--
-- ORDER BY:  `ID`

LOCK TABLES `suppliers` WRITE;
/*!40000 ALTER TABLE `suppliers` DISABLE KEYS */;
INSERT INTO `suppliers` (`ID`, `Code`, `Name`, `Address`, `ContactPerson`, `CPNumber`, `TelNumber`, `FaxNumber`) VALUES (0000000001,0000000001,'GLYCO','SJDV :)','Shyne Aquino','09173333333','02 - 982 - 0000','00001 - 22'),(0000000007,0000000002,'DOH','Mabalacat, Pampanga','Khara Feliciano','09178888888','982 - 22 - 22','');
/*!40000 ALTER TABLE `suppliers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suppliersproducts`
--

DROP TABLE IF EXISTS `suppliersproducts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `suppliersproducts` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Supplier` int(10) unsigned zerofill NOT NULL,
  `Product` int(10) unsigned zerofill NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `SupplierProduct` (`Supplier`,`Product`),
  KEY `SP_supplier_idx` (`Supplier`),
  KEY `SP_products_idx` (`Product`),
  CONSTRAINT `SP_products` FOREIGN KEY (`Product`) REFERENCES `products` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `SP_supplier` FOREIGN KEY (`Supplier`) REFERENCES `suppliers` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suppliersproducts`
--
-- ORDER BY:  `ID`

LOCK TABLES `suppliersproducts` WRITE;
/*!40000 ALTER TABLE `suppliersproducts` DISABLE KEYS */;
INSERT INTO `suppliersproducts` (`ID`, `Supplier`, `Product`) VALUES (0000000009,0000000007,0000000007),(0000000010,0000000007,0000000014),(0000000011,0000000007,0000000017),(0000000012,0000000001,0000000004),(0000000013,0000000001,0000000007),(0000000014,0000000001,0000000013);
/*!40000 ALTER TABLE `suppliersproducts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `transactionreceipts`
--

DROP TABLE IF EXISTS `transactionreceipts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `transactionreceipts` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Receipt` int(10) unsigned zerofill NOT NULL,
  `Product` int(10) unsigned zerofill NOT NULL,
  `Quantity` smallint(5) unsigned NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `tr_receipt_idx` (`Receipt`),
  KEY `tr_product_idx` (`Product`),
  CONSTRAINT `tr_product` FOREIGN KEY (`Product`) REFERENCES `products` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `tr_receipt` FOREIGN KEY (`Receipt`) REFERENCES `receipts` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `transactionreceipts`
--
-- ORDER BY:  `ID`

LOCK TABLES `transactionreceipts` WRITE;
/*!40000 ALTER TABLE `transactionreceipts` DISABLE KEYS */;
INSERT INTO `transactionreceipts` (`ID`, `Receipt`, `Product`, `Quantity`) VALUES (0000000001,0000000017,0000000014,1),(0000000002,0000000018,0000000014,1),(0000000003,0000000019,0000000014,1),(0000000004,0000000020,0000000014,1),(0000000005,0000000021,0000000007,1),(0000000006,0000000022,0000000004,1),(0000000007,0000000023,0000000004,1),(0000000008,0000000024,0000000004,1),(0000000009,0000000025,0000000017,1),(0000000010,0000000026,0000000007,1),(0000000011,0000000027,0000000013,1);
/*!40000 ALTER TABLE `transactionreceipts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `units`
--

DROP TABLE IF EXISTS `units`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `units` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Name` varchar(20) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Name_UNIQUE` (`Name`)
) ENGINE=InnoDB AUTO_INCREMENT=24 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `units`
--
-- ORDER BY:  `ID`

LOCK TABLES `units` WRITE;
/*!40000 ALTER TABLE `units` DISABLE KEYS */;
INSERT INTO `units` (`ID`, `Name`) VALUES (0000000001,'10mg'),(0000000002,'4mg'),(0000000003,'12mg'),(0000000004,'2mg'),(0000000005,'5mg'),(0000000006,'15mg'),(0000000007,'20mg'),(0000000008,'25mg'),(0000000009,'30mg'),(0000000010,'500mg'),(0000000011,'100mg'),(0000000012,'200mg'),(0000000013,'250mg'),(0000000014,'pcs'),(0000000015,'350mg'),(0000000016,'1000mg'),(0000000017,'10mL'),(0000000018,'20mL'),(0000000019,'30mL'),(0000000020,'50mL'),(0000000021,'250mL'),(0000000022,'500mL'),(0000000023,'pack');
/*!40000 ALTER TABLE `units` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Username` varchar(12) NOT NULL,
  `Password` varchar(12) NOT NULL,
  `UserType` int(10) unsigned zerofill NOT NULL,
  `LastName` varchar(30) NOT NULL,
  `GivenName` varchar(30) NOT NULL,
  `Address` varchar(45) NOT NULL,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Username_UNIQUE` (`Username`),
  KEY `users_usertype_idx` (`UserType`),
  CONSTRAINT `user_usertype` FOREIGN KEY (`UserType`) REFERENCES `usertypes` (`ID`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--
-- ORDER BY:  `ID`

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` (`ID`, `Username`, `Password`, `UserType`, `LastName`, `GivenName`, `Address`) VALUES (0000000001,'yeshai','0000',0000000004,'Cuaresma','Shyne','');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usertypes`
--

DROP TABLE IF EXISTS `usertypes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usertypes` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `UserType` varchar(15) NOT NULL,
  `FileMaintenance` tinytext,
  `Transactions` tinytext,
  `Security` tinytext,
  PRIMARY KEY (`ID`),
  UNIQUE KEY `UserType_UNIQUE` (`UserType`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usertypes`
--
-- ORDER BY:  `ID`

LOCK TABLES `usertypes` WRITE;
/*!40000 ALTER TABLE `usertypes` DISABLE KEYS */;
INSERT INTO `usertypes` (`ID`, `UserType`, `FileMaintenance`, `Transactions`, `Security`) VALUES (0000000004,'SuperAdmin','CategoriesDiscountsExpirationsProductsReceiptNumberSuppliersUnitsVAT','PointOfSalesPurchaseOrdersReceivePurchaseOrder','UsersUserTypes'),(0000000005,'Manager','CategoriesDiscountsExpirationsProductsReceiptNumberSuppliersUnitsVAT','PointOfSalesPurchaseOrdersReceivePurchaseOrder','');
/*!40000 ALTER TABLE `usertypes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vat`
--

DROP TABLE IF EXISTS `vat`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `vat` (
  `ID` int(10) unsigned zerofill NOT NULL AUTO_INCREMENT,
  `Value` decimal(4,2) unsigned NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vat`
--
-- ORDER BY:  `ID`

LOCK TABLES `vat` WRITE;
/*!40000 ALTER TABLE `vat` DISABLE KEYS */;
INSERT INTO `vat` (`ID`, `Value`) VALUES (0000000001,12.00);
/*!40000 ALTER TABLE `vat` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'sjpharmacy'
--

--
-- Dumping routines for database 'sjpharmacy'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2015-03-14  0:50:38
