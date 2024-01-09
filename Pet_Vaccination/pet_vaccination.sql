-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 07, 2024 at 07:47 AM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 8.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `pet_vaccination`
--

-- --------------------------------------------------------

--
-- Table structure for table `account`
--

CREATE TABLE `account` (
  `Username` varchar(50) NOT NULL,
  `Password` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `account`
--

INSERT INTO `account` (`Username`, `Password`) VALUES
('admin', 12345);

-- --------------------------------------------------------

--
-- Table structure for table `pet_info`
--

CREATE TABLE `pet_info` (
  `Pet_Id` int(11) NOT NULL,
  `Pet_Name` varchar(50) NOT NULL,
  `Pet_Owner` varchar(50) NOT NULL,
  `Gender` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `pet_injected`
--

CREATE TABLE `pet_injected` (
  `Pet_id` int(11) NOT NULL,
  `Pet_name` varchar(50) NOT NULL,
  `Vaccine_name` varchar(50) NOT NULL,
  `Dose` int(11) NOT NULL,
  `Date_injected` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pet_injected`
--

INSERT INTO `pet_injected` (`Pet_id`, `Pet_name`, `Vaccine_name`, `Dose`, `Date_injected`) VALUES
(1, 'coby', 'antigen', 2, '0000-00-00');

-- --------------------------------------------------------

--
-- Table structure for table `vaccine`
--

CREATE TABLE `vaccine` (
  `vaccine_number` int(11) NOT NULL,
  `vaccine_name` varchar(50) NOT NULL,
  `dose` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `pet_info`
--
ALTER TABLE `pet_info`
  ADD PRIMARY KEY (`Pet_Id`);

--
-- Indexes for table `pet_injected`
--
ALTER TABLE `pet_injected`
  ADD PRIMARY KEY (`Pet_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `pet_info`
--
ALTER TABLE `pet_info`
  MODIFY `Pet_Id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `pet_injected`
--
ALTER TABLE `pet_injected`
  MODIFY `Pet_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
