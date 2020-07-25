-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 25-07-2020 a las 04:57:53
-- Versión del servidor: 10.4.13-MariaDB
-- Versión de PHP: 7.4.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `tapiceriadb`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `articulos`
--

CREATE TABLE `articulos` (
  `articulosid` int(11) NOT NULL,
  `descripcion` char(100) CHARACTER SET utf8 NOT NULL,
  `precio` decimal(18,2) NOT NULL,
  `porcentaje` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `cuerinas`
--

CREATE TABLE `cuerinas` (
  `cuerinasid` int(11) NOT NULL,
  `nombre` char(100) CHARACTER SET utf8 NOT NULL,
  `ancho` decimal(18,2) NOT NULL,
  `precio` decimal(10,4) NOT NULL,
  `porcentaje` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `poliester`
--

CREATE TABLE `poliester` (
  `poliesterid` int(11) NOT NULL,
  `nombre` char(100) CHARACTER SET utf8 NOT NULL,
  `precio` decimal(10,4) NOT NULL,
  `porcentaje` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Índices para tablas volcadas
--

--
-- Indices de la tabla `articulos`
--
ALTER TABLE `articulos`
  ADD PRIMARY KEY (`articulosid`),
  ADD KEY `ix_tmp_autoinc` (`articulosid`);

--
-- Indices de la tabla `cuerinas`
--
ALTER TABLE `cuerinas`
  ADD PRIMARY KEY (`cuerinasid`),
  ADD KEY `ix_tmp_autoinc` (`cuerinasid`);

--
-- Indices de la tabla `poliester`
--
ALTER TABLE `poliester`
  ADD PRIMARY KEY (`poliesterid`),
  ADD KEY `ix_tmp_autoinc` (`poliesterid`);

--
-- AUTO_INCREMENT de las tablas volcadas
--

--
-- AUTO_INCREMENT de la tabla `articulos`
--
ALTER TABLE `articulos`
  MODIFY `articulosid` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `cuerinas`
--
ALTER TABLE `cuerinas`
  MODIFY `cuerinasid` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de la tabla `poliester`
--
ALTER TABLE `poliester`
  MODIFY `poliesterid` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
