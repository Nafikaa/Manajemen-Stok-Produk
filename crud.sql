-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 25, 2025 at 12:14 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `crud`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_crud`
--

CREATE TABLE `tbl_crud` (
  `ID` int(11) NOT NULL,
  `NOPRODUK` varchar(250) NOT NULL,
  `NAMAPRODUK` varchar(250) NOT NULL,
  `HARGA_PER_BIJI` decimal(10,2) NOT NULL,
  `GRUP` varchar(250) NOT NULL,
  `EXPDATE` date NOT NULL,
  `STATUS` varchar(250) NOT NULL,
  `HARGA_PER_KARDUS` decimal(10,2) NOT NULL,
  `ISI_PER_KARDUS` int(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_crud`
--

INSERT INTO `tbl_crud` (`ID`, `NOPRODUK`, `NAMAPRODUK`, `HARGA_PER_BIJI`, `GRUP`, `EXPDATE`, `STATUS`, `HARGA_PER_KARDUS`, `ISI_PER_KARDUS`) VALUES
(2, 'P001', 'Coklat Silverqueen1', 15000.00, 'SWEETS', '2024-06-01', 'Aktif', 0.00, 0),
(3, 'P002', 'Permen Kopiko', 12000.00, 'CANDY', '2025-07-04', 'Aktif', 0.00, 0),
(4, 'P003', 'Wafer Tango', 8000.00, 'COOKIES', '2025-08-15', 'Aktif', 0.00, 0),
(5, 'P004', 'POCARI', 7000.00, 'DRINK', '2026-01-25', 'Aktif', 0.00, 0),
(6, 'P005', 'Teh KOTAK', 10000.00, 'DRINK', '2025-08-30', 'Aktif', 0.00, 0),
(7, 'P006', 'TOP', 5000.00, 'SWEET', '2025-09-03', 'Aktif', 0.00, 0),
(8, 'P007', 'Indomie Goreng', 3500.00, 'FOOD', '2025-10-10', 'Aktif', 0.00, 0),
(9, 'P008', 'Gummy Bear', 6000.00, 'CANDY', '2025-11-08', 'Aktif', 0.00, 0),
(10, 'P009', 'Kinder Joy', 15000.00, 'SWEET', '2025-12-06', 'Aktif', 0.00, 0),
(11, 'P010', 'Ultra Milk Choco', 8000.00, 'DRINK', '2025-09-27', 'Aktif', 0.00, 0),
(12, 'P011', 'Biscuit OREO', 10000.00, 'COOKIES', '2025-10-13', 'Aktif', 0.00, 0),
(13, 'P012', 'ROMA', 10000.00, 'COOKIES', '2025-10-31', 'Aktif', 0.00, 0),
(14, 'P013', 'YAKULT', 5000.00, 'DRINK', '2025-11-15', 'Aktif', 0.00, 0);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`username`, `password`) VALUES
('admin', '12345'),
('ikaa', '123456');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_crud`
--
ALTER TABLE `tbl_crud`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_crud`
--
ALTER TABLE `tbl_crud`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
