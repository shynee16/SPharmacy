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

-- Dump completed on 2015-03-14  0:49:33
