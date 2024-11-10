-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Nov 10, 2024 at 11:47 AM
-- Server version: 8.0.30
-- PHP Version: 7.4.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `master_pol`
--
CREATE DATABASE IF NOT EXISTS `master_pol` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `master_pol`;

-- --------------------------------------------------------

--
-- Table structure for table `employees`
--

CREATE TABLE `employees` (
  `id` int NOT NULL,
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `birthday` date NOT NULL,
  `passport_data` varchar(11) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `bank_details` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `have_family` tinyint(1) NOT NULL,
  `health_status` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `partners`
--

CREATE TABLE `partners` (
  `partner_id` int NOT NULL,
  `partner_type_id` int DEFAULT NULL,
  `company_name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `legal_address` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `INN` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `director_name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `phone_number` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `email` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `logo` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `rating` int DEFAULT NULL,
  `created_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP,
  `updated_at` timestamp NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `partners`
--

INSERT INTO `partners` (`partner_id`, `partner_type_id`, `company_name`, `legal_address`, `INN`, `director_name`, `phone_number`, `email`, `logo`, `rating`, `created_at`, `updated_at`) VALUES
(1, 1, 'База Строитель', '652050, Кемеровская область, город Юрга, ул. Лесная, 15', '2222455179', 'Иванова Александра Ивановна', '493 123 45 67', 'aleksandraivanova@ml.ru', NULL, 10, '2024-09-17 06:55:12', '2024-11-03 14:20:13'),
(2, 2, 'Паркет 29', '164500, Архангельская область, город Северодвинск, ул. Строителей, 18', '3333888520', 'Петров Василий Петрович', '987 123 56 78', 'vppetrov@vl.ru', NULL, 7, '2024-09-17 07:00:21', '2024-09-17 09:22:22'),
(3, 3, 'Стройсервис', '188910, Ленинградская область, город Приморск, ул. Парковая, 21', '4440391035', 'Соловьев Андрей Николаевич', '812 223 32 00', 'ansolovev@st.ru', NULL, 7, '2024-09-17 07:00:21', '2024-09-17 09:22:30'),
(4, 4, 'Ремонт и отделка', '143960, Московская область, город Реутов, ул. Свободы, 51', '1111520857', 'Воробьева Екатерина Валерьевна', '444 222 33 11', 'ekaterina.vorobeva@ml.ru', NULL, 5, '2024-09-17 07:03:38', '2024-09-17 09:22:54'),
(5, 1, 'МонтажПро', '309500, Белгородская область, город Старый Оскол, ул. Рабочая, 122\r\n', '5552431140', 'Степанов Степан Сергеевич', '912 888 33 33', 'stepanov@stepan.ru', NULL, 10, '2024-09-17 07:03:38', '2024-09-17 09:23:07');

-- --------------------------------------------------------

--
-- Table structure for table `partners_types`
--

CREATE TABLE `partners_types` (
  `id` int NOT NULL,
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `partners_types`
--

INSERT INTO `partners_types` (`id`, `name`) VALUES
(1, 'ЗАО'),
(2, 'ООО'),
(3, 'ПАО'),
(4, 'ОАО');

-- --------------------------------------------------------

--
-- Table structure for table `partner_discounts`
--

CREATE TABLE `partner_discounts` (
  `discount_id` int NOT NULL,
  `partner_id` int DEFAULT NULL,
  `discount_percentage` decimal(5,2) NOT NULL,
  `start_date` date NOT NULL,
  `end_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `partner_sales_history`
--

CREATE TABLE `partner_sales_history` (
  `sales_id` int NOT NULL,
  `partner_id` int DEFAULT NULL,
  `product_id` int DEFAULT NULL,
  `quantity` int NOT NULL,
  `sales_date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `partner_sales_history`
--

INSERT INTO `partner_sales_history` (`sales_id`, `partner_id`, `product_id`, `quantity`, `sales_date`) VALUES
(17, 1, 1, 15500, '2023-03-23'),
(18, 1, 3, 12350, '2023-12-18'),
(19, 1, 4, 37400, '2024-06-07'),
(20, 2, 2, 35000, '2022-12-02'),
(21, 2, 5, 1250, '2023-05-17'),
(22, 2, 3, 1000, '2024-06-07'),
(23, 2, 1, 7550, '2024-07-01'),
(24, 3, 1, 7250, '2023-01-22'),
(25, 3, 2, 2500, '2024-07-05'),
(26, 4, 4, 59050, '2023-03-20'),
(27, 4, 3, 37200, '2024-03-12'),
(28, 4, 5, 4500, '2024-05-14'),
(29, 5, 3, 50000, '2023-09-19'),
(30, 5, 4, 670000, '2023-11-10'),
(31, 5, 1, 35000, '2024-04-15'),
(32, 5, 2, 25000, '2024-06-12');

-- --------------------------------------------------------

--
-- Table structure for table `partner_sales_places`
--

CREATE TABLE `partner_sales_places` (
  `place_id` int NOT NULL,
  `partner_id` int DEFAULT NULL,
  `place_type_id` int DEFAULT NULL,
  `sales_place_name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `address` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `products`
--

CREATE TABLE `products` (
  `product_id` int NOT NULL,
  `product_name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `article` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `product_type_id` int NOT NULL,
  `description` text CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci,
  `image` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `min_partner_price` decimal(10,2) NOT NULL,
  `package_size` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci DEFAULT NULL,
  `weight` decimal(10,2) DEFAULT NULL,
  `production_time` int DEFAULT NULL,
  `cost_price` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `products`
--

INSERT INTO `products` (`product_id`, `product_name`, `article`, `product_type_id`, `description`, `image`, `min_partner_price`, `package_size`, `weight`, `production_time`, `cost_price`) VALUES
(1, 'Паркетная доска Ясень темный однополосная 14 мм', '8758385', 1, NULL, NULL, '4456.90', NULL, NULL, NULL, NULL),
(2, 'Инженерная доска Дуб Французская елка однополосная 12 мм', '8858958\r\n', 1, NULL, NULL, '7330.99', NULL, NULL, NULL, NULL),
(3, 'Ламинат Дуб дымчато-белый 33 класс 12 мм\r\n', '7750282', 2, NULL, NULL, '1799.33', NULL, NULL, NULL, NULL),
(4, 'Ламинат Дуб серый 32 класс 8 мм с фаской\r\n', '7028748\r\n', 2, NULL, NULL, '3890.41', NULL, NULL, NULL, NULL),
(5, 'Пробковое напольное клеевое покрытие 32 класс 4 мм\n', '5012543\r\n', 3, NULL, NULL, '5450.59', NULL, NULL, NULL, NULL);

-- --------------------------------------------------------

--
-- Table structure for table `products_types`
--

CREATE TABLE `products_types` (
  `id` int NOT NULL,
  `name` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL,
  `product_type_coefficient` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `products_types`
--

INSERT INTO `products_types` (`id`, `name`, `product_type_coefficient`) VALUES
(1, 'Паркетная доска', '4.34'),
(2, 'Ламинат\r\n', '2.35'),
(3, 'Пробковое покрытие\r\n', '1.50'),
(4, 'Массивная доска\r\n', '5.15');

-- --------------------------------------------------------

--
-- Table structure for table `product_sales`
--

CREATE TABLE `product_sales` (
  `sale_id` int NOT NULL,
  `partner_id` int DEFAULT NULL,
  `product_id` int DEFAULT NULL,
  `quantity_sold` int NOT NULL,
  `sale_date` date NOT NULL,
  `sale_amount` decimal(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `sales_place_types`
--

CREATE TABLE `sales_place_types` (
  `place_type_id` int NOT NULL,
  `place_type_name` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `partners`
--
ALTER TABLE `partners`
  ADD PRIMARY KEY (`partner_id`),
  ADD UNIQUE KEY `tax_id` (`INN`),
  ADD KEY `partner_type_id` (`partner_type_id`);

--
-- Indexes for table `partners_types`
--
ALTER TABLE `partners_types`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `partner_discounts`
--
ALTER TABLE `partner_discounts`
  ADD PRIMARY KEY (`discount_id`),
  ADD KEY `partner_id` (`partner_id`);

--
-- Indexes for table `partner_sales_history`
--
ALTER TABLE `partner_sales_history`
  ADD PRIMARY KEY (`sales_id`),
  ADD KEY `partner_id` (`partner_id`),
  ADD KEY `product_id` (`product_id`);

--
-- Indexes for table `partner_sales_places`
--
ALTER TABLE `partner_sales_places`
  ADD PRIMARY KEY (`place_id`),
  ADD KEY `partner_id` (`partner_id`),
  ADD KEY `place_type_id` (`place_type_id`);

--
-- Indexes for table `products`
--
ALTER TABLE `products`
  ADD PRIMARY KEY (`product_id`),
  ADD KEY `product_type` (`product_type_id`);

--
-- Indexes for table `products_types`
--
ALTER TABLE `products_types`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `product_sales`
--
ALTER TABLE `product_sales`
  ADD PRIMARY KEY (`sale_id`),
  ADD KEY `partner_id` (`partner_id`),
  ADD KEY `product_id` (`product_id`);

--
-- Indexes for table `sales_place_types`
--
ALTER TABLE `sales_place_types`
  ADD PRIMARY KEY (`place_type_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `partners`
--
ALTER TABLE `partners`
  MODIFY `partner_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT for table `partners_types`
--
ALTER TABLE `partners_types`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `partner_discounts`
--
ALTER TABLE `partner_discounts`
  MODIFY `discount_id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `partner_sales_history`
--
ALTER TABLE `partner_sales_history`
  MODIFY `sales_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=33;

--
-- AUTO_INCREMENT for table `partner_sales_places`
--
ALTER TABLE `partner_sales_places`
  MODIFY `place_id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `products`
--
ALTER TABLE `products`
  MODIFY `product_id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `products_types`
--
ALTER TABLE `products_types`
  MODIFY `id` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `product_sales`
--
ALTER TABLE `product_sales`
  MODIFY `sale_id` int NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `sales_place_types`
--
ALTER TABLE `sales_place_types`
  MODIFY `place_type_id` int NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `partners`
--
ALTER TABLE `partners`
  ADD CONSTRAINT `partners_ibfk_1` FOREIGN KEY (`partner_type_id`) REFERENCES `partners_types` (`id`);

--
-- Constraints for table `partner_discounts`
--
ALTER TABLE `partner_discounts`
  ADD CONSTRAINT `partner_discounts_ibfk_1` FOREIGN KEY (`partner_id`) REFERENCES `partners` (`partner_id`);

--
-- Constraints for table `partner_sales_history`
--
ALTER TABLE `partner_sales_history`
  ADD CONSTRAINT `partner_sales_history_ibfk_1` FOREIGN KEY (`partner_id`) REFERENCES `partners` (`partner_id`),
  ADD CONSTRAINT `partner_sales_history_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`);

--
-- Constraints for table `partner_sales_places`
--
ALTER TABLE `partner_sales_places`
  ADD CONSTRAINT `partner_sales_places_ibfk_1` FOREIGN KEY (`partner_id`) REFERENCES `partners` (`partner_id`),
  ADD CONSTRAINT `partner_sales_places_ibfk_2` FOREIGN KEY (`place_type_id`) REFERENCES `sales_place_types` (`place_type_id`);

--
-- Constraints for table `products`
--
ALTER TABLE `products`
  ADD CONSTRAINT `products_ibfk_1` FOREIGN KEY (`product_type_id`) REFERENCES `products_types` (`id`);

--
-- Constraints for table `product_sales`
--
ALTER TABLE `product_sales`
  ADD CONSTRAINT `product_sales_ibfk_1` FOREIGN KEY (`partner_id`) REFERENCES `partners` (`partner_id`),
  ADD CONSTRAINT `product_sales_ibfk_2` FOREIGN KEY (`product_id`) REFERENCES `products` (`product_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
