-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Hostiteľ: 127.0.0.1
-- Čas generovania: St 31.Máj 2023, 22:35
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
-- Štruktúra tabuľky pre tabuľku `soci_task`
--

CREATE TABLE `soci_task` (
  `u_id` int(11) NOT NULL,
  `u_task` varchar(100) NOT NULL,
  `u_checked` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Sťahujem dáta pre tabuľku `soci_task`
--

INSERT INTO `soci_task` (`u_id`, `u_task`, `u_checked`) VALUES
(43, 'Martin ma pravdu', 0),
(48, 'Kubo je kral', 0),
(49, 'Zajo cita knihu', 0),
(50, 'Lukas nie je Ado', 0),
(51, 'Ronnie sa odpojil', 0),
(52, 'Juro is coding', 0);

--
-- Kľúče pre exportované tabuľky
--

--
-- Indexy pre tabuľku `soci_task`
--
ALTER TABLE `soci_task`
  ADD PRIMARY KEY (`u_id`),
  ADD UNIQUE KEY `u_tasks` (`u_task`);

--
-- AUTO_INCREMENT pre exportované tabuľky
--

--
-- AUTO_INCREMENT pre tabuľku `soci_task`
--
ALTER TABLE `soci_task`
  MODIFY `u_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
