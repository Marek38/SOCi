-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hostiteľ: 127.0.0.1
-- Čas generovania: St 31.Máj 2023, 22:37
-- Verzia serveru: 10.4.27-MariaDB
-- Verzia PHP: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databáza: `_sample`
--

-- --------------------------------------------------------

--
-- Štruktúra tabuľky pre tabuľku `soci_users`
--

CREATE TABLE `soci_users` (
  `u_id` int(10) NOT NULL,
  `u_name` varchar(50) NOT NULL,
  `u_projekt` varchar(100) NOT NULL,
  `u_mail` varchar(100) NOT NULL,
  `u_password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Sťahujem dáta pre tabuľku `soci_users`
--

INSERT INTO `soci_users` (`u_id`, `u_name`, `u_projekt`, `u_mail`, `u_password`) VALUES
(1, 'admin', 'soci', 'admin@gmail.com', 'Admin123'),
(2, 'Marek', 'tlaciaren', 'marek@gmail.com', 'Marek123');

--
-- Kľúče pre exportované tabuľky
--

--
-- Indexy pre tabuľku `soci_users`
--
ALTER TABLE `soci_users`
  ADD PRIMARY KEY (`u_id`),
  ADD UNIQUE KEY `u_mail` (`u_mail`),
  ADD UNIQUE KEY `u_name` (`u_name`);

--
-- AUTO_INCREMENT pre exportované tabuľky
--

--
-- AUTO_INCREMENT pre tabuľku `soci_users`
--
ALTER TABLE `soci_users`
  MODIFY `u_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
