-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 07, 2025 at 03:49 PM
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
  `HARGA` decimal(10,2) NOT NULL,
  `GRUP` varchar(250) NOT NULL,
  `EXPDATE` date NOT NULL,
  `STATUS` varchar(250) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_crud`
--

INSERT INTO `tbl_crud` (`ID`, `NOPRODUK`, `NAMAPRODUK`, `HARGA`, `GRUP`, `EXPDATE`, `STATUS`) VALUES
(2, 'P001', 'Coklat Silverqueen1', 15000.00, 'SWEETS', '2024-06-01', 'Aktif'),
(3, 'P002', 'Permen Kopiko', 12000.00, 'CANDY', '2025-07-04', 'Aktif'),
(4, 'P003', 'Wafer Tango', 8000.00, 'COOKIES', '2025-08-15', 'Aktif'),
(5, 'P004', 'POCARI', 7000.00, 'DRINK', '2026-01-25', 'Aktif'),
(6, 'P005', 'Teh KOTAK', 10000.00, 'DRINK', '2025-08-30', 'Aktif'),
(7, 'P006', 'TOP', 5000.00, 'SWEET', '2025-09-03', 'Aktif'),
(8, 'P007', 'Indomie Goreng', 3500.00, 'FOOD', '2025-10-10', 'Aktif');

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
('admin', '12345');

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
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
