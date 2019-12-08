-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: Dec 08, 2019 at 09:21 AM
-- Server version: 5.7.24
-- PHP Version: 7.3.7

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ella`
--

-- --------------------------------------------------------

--
-- Table structure for table `page`
--

CREATE TABLE `page` (
  `pageid` int(20) UNSIGNED NOT NULL,
  `pagetitle` varchar(225) DEFAULT 'PageTitle',
  `pagebody` mediumtext
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `page`
--

INSERT INTO `page` (`pageid`, `pagetitle`, `pagebody`) VALUES
(1, 'Oceana | Help us Protect the Ocean', 'PROTECT NORTH ATLANTIC RIGHT WHALES SAVING NORTH ATLANTIC RIGHT WHALES FROM EXTINCTION Oceana campaigns in Canada and the U.S. to protect North Atlantic right whales from their biggest threats'),
(2, 'WHAT WE DO', 'Oceana Canada seeks to make our oceans as rich, healthy and abundant as they once were. '),
(3, 'Our Campaigns', 'Oceana Canada campaigns for national policies that rebuild fisheries and return Canada’s formerly vibrant oceans to health. Fewer Canadian marine stocks can be considered healthy compared to three years ago – a worrying trend of decline. Today, less than a third are considered healthy and 17 per cent are in the critical zone, where conservation actions are crucial. This leaves the success of our once-thriving fishing industry precariously balanced on the continued availability of just a few species.'),
(4, 'Donate to Oceana', ' Support our work to protect the oceans by giving today. With your help, we can restore marine life and habitats. Your gift will help ensure the health of our oceans and the future of our planet.');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `page`
--
ALTER TABLE `page`
  ADD PRIMARY KEY (`pageid`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `page`
--
ALTER TABLE `page`
  MODIFY `pageid` int(20) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
