
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
(3, 'panadol', 65);
(4, 'nurofen' 65);
(5, 'vitamins' 100);
(6, 'moisturiser' 45);
(7, 'toothpaste' 30);
(8, 'dettol' 50);
(9, 'vicks' 45);
(10, 'mentos' 20);
(11, 'prescriptions pills' 100);
(12, 'deodorant' 40);
(13, 'condoms' 30);
(14, 'bandaids' 50);
(15, 'gloves' 40);
--
-- Dumping data for table `ordersale`
--

INSERT INTO `ordersale` (`OrderNum`, `Timestamp`) VALUES
(1, '2016-04-07 11:43:58');
(2, '2016-02-18 10:21:43');
(3, '2016-02-21 09:08:55');
(4, '2016-02-25 01:27:34');
(5, '2016-02-28 03:33:33');
(6, '2016-03-03 04:20:01');
(7, '2016-03-07 05:40:01');
(8, '2016-03-14 12:25:45');
(9, '2016-03-17 03:40:21');
(10, '2016-03-20 09:40:52');
(11, '2016-03-24 10:30:18');
(12, '2016-04-1 11:44:15');
(13, '2016-04-5 10:14:55');

--
-- Dumping data for table `orderitem`
--

INSERT INTO `orderitem` (`OrderNum`, `ItemID`, `ItemAmount`, `Price`) VALUES
(1, 1, 4, '1.00'),
(2, 2, 5, '9.99');
(3, 3, 5, '12.99');
(4, 7, 4, '15.00');
(5, 14, 5, '5.99');
(6, 11, 3, '40.00');
(7, 9, 4, '30.00');
(8, 6, 5, '25.00');
(9, 5, 3, '20.00');
(10, 1, 5, '3.00');
(11, 2, 5, '9.99');
(12, 10, 4, '15.00');
(13, 12, 2, '12.00');

