-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 24, 2023 at 12:31 PM
-- Server version: 10.4.25-MariaDB
-- PHP Version: 8.1.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_diamond`
--

-- --------------------------------------------------------

--
-- Table structure for table `pemesandiamond`
--

CREATE TABLE `pemesandiamond` (
  `kodepembelian` int(3) NOT NULL,
  `nama` varchar(100) NOT NULL,
  `id` varchar(100) NOT NULL,
  `kodediamond` varchar(100) NOT NULL,
  `jumlahdiamond` varchar(100) NOT NULL,
  `jumlah` int(100) NOT NULL,
  `harga` varchar(100) NOT NULL,
  `pembayaran` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pemesandiamond`
--

INSERT INTO `pemesandiamond` (`kodepembelian`, `nama`, `id`, `kodediamond`, `jumlahdiamond`, `jumlah`, `harga`, `pembayaran`) VALUES
(222, 'asdasd', '1231231254', '2', 'dua ratus', 2, '400', 'Cash'),
(2222, 'asdasddas', '123123123', '4', 'empat ratus ', 2, '800', 'Cash'),
(3333, 'sadasd', '123123', '2', 'dua ratus', 2, '400', 'Cash'),
(9021, 'asd', '123123', '1', 'dua ratus', 2, '4000', 'Cashca'),
(21231, 'asdasd', '123123123', '2', 'dua ratus', 2, '400', 'Cash'),
(21232, 'asdasdasd', '123123123', '5', 'lima ratus', 4, '2000', 'Cash'),
(21233, 'asdasd', '123123', '2', 'dua ratus', 2, '400', 'Cash'),
(21234, 'reza', '123123123', '2', 'dua ratus', 2, '400', 'Cash');

-- --------------------------------------------------------

--
-- Table structure for table `tb_diamond`
--

CREATE TABLE `tb_diamond` (
  `kode` int(3) NOT NULL,
  `tujuan` varchar(100) NOT NULL,
  `harga` int(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_diamond`
--

INSERT INTO `tb_diamond` (`kode`, `tujuan`, `harga`) VALUES
(1, 'seratus', 100),
(2, 'dua ratus', 200),
(3, 'tiga ratus', 300),
(4, 'empat ratus ', 400),
(5, 'lima ratus', 500);

-- --------------------------------------------------------

--
-- Table structure for table `tb_login`
--

CREATE TABLE `tb_login` (
  `KodeUser` varchar(10) NOT NULL,
  `NamaUser` varchar(10) NOT NULL,
  `StatusUser` varchar(10) NOT NULL,
  `PasswordUser` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tb_login`
--

INSERT INTO `tb_login` (`KodeUser`, `NamaUser`, `StatusUser`, `PasswordUser`) VALUES
('1', 'Admin', 'Admin', 'Admin'),
('2', 'User', 'User', '123');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pemesandiamond`
--
ALTER TABLE `pemesandiamond`
  ADD PRIMARY KEY (`kodepembelian`);

--
-- Indexes for table `tb_diamond`
--
ALTER TABLE `tb_diamond`
  ADD PRIMARY KEY (`kode`);

--
-- Indexes for table `tb_login`
--
ALTER TABLE `tb_login`
  ADD PRIMARY KEY (`KodeUser`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pemesandiamond`
--
ALTER TABLE `pemesandiamond`
  MODIFY `kodepembelian` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21235;

--
-- AUTO_INCREMENT for table `tb_diamond`
--
ALTER TABLE `tb_diamond`
  MODIFY `kode` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=124;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
