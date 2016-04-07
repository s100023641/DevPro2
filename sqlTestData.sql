
--
-- Database: `pharmacydb`
--

USE pharmacydb;


--
-- Dumping data for table `stockableitems`
--

INSERT INTO `stockableitems` (`ItemID`, `Name`, `Quantity`) VALUES
(1, 'asprin', 100),
(2, 'paracetamol', 41);

--
-- Dumping data for table `ordersale`
--

INSERT INTO `ordersale` (`OrderNum`, `Timestamp`) VALUES
(1, '2016-04-07 11:43:58');

--
-- Dumping data for table `orderitem`
--

INSERT INTO `orderitem` (`OrderNum`, `ItemID`, `ItemAmount`, `Price`) VALUES
(1, 1, 4, '1.00'),
(1, 2, 5, '9.99');

