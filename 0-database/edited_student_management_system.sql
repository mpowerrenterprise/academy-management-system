-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 03, 2021 at 10:03 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.2.34

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `edited_student_management_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `department_info_table`
--

CREATE TABLE `department_info_table` (
  `auto-id` int(11) NOT NULL,
  `department_id` varchar(200) NOT NULL,
  `department_name` varchar(200) NOT NULL,
  `guardian` varchar(200) NOT NULL,
  `description` varchar(600) NOT NULL,
  `income` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `department_info_table`
--

INSERT INTO `department_info_table` (`auto-id`, `department_id`, `department_name`, `guardian`, `description`, `income`) VALUES
(1, 'D-01', 'Software', 'Robin', ' It was popularised in the 1960s', '20,000'),
(2, 'D-002', 'Medicine', 'David', ' It was popularised in the area.', '50,000'),
(3, 'D-003', 'Software', 'Smith', ' Many desktop publishing packages.', '70,000');

-- --------------------------------------------------------

--
-- Table structure for table `guardian_info_table`
--

CREATE TABLE `guardian_info_table` (
  `auto-id` int(11) NOT NULL,
  `guardian_id` varchar(200) NOT NULL,
  `first_name` varchar(200) NOT NULL,
  `last_name` varchar(200) NOT NULL,
  `dob` varchar(100) NOT NULL,
  `gender` varchar(100) NOT NULL,
  `email` varchar(300) NOT NULL,
  `contact_no` varchar(100) NOT NULL,
  `department` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `guardian_info_table`
--

INSERT INTO `guardian_info_table` (`auto-id`, `guardian_id`, `first_name`, `last_name`, `dob`, `gender`, `email`, `contact_no`, `department`) VALUES
(3, 'G-01', 'Alen', 'Lee', '15/09/1988', 'female', 'alen@gmail.com', '1593574', 'Software'),
(4, 'G-002', 'Tom', 'Tayler', '08/12/1997', 'male', 'tom@gmail.com', '156985', 'Medicine'),
(5, 'G-003', 'Michel', 'William', '16/04/1980', 'male', 'mich@gmail.com', '4569321', 'IT');

-- --------------------------------------------------------

--
-- Table structure for table `login_table`
--

CREATE TABLE `login_table` (
  `auto` int(11) NOT NULL,
  `username` varchar(200) NOT NULL,
  `password` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `login_table`
--

INSERT INTO `login_table` (`auto`, `username`, `password`) VALUES
(1, 'dsa', '222');

-- --------------------------------------------------------

--
-- Table structure for table `student_info_table`
--

CREATE TABLE `student_info_table` (
  `auto-id` int(11) NOT NULL,
  `student_id` varchar(200) NOT NULL,
  `batch_no` varchar(100) NOT NULL,
  `first_name` varchar(200) NOT NULL,
  `last_name` varchar(200) NOT NULL,
  `dob` varchar(100) NOT NULL,
  `gender` varchar(100) NOT NULL,
  `email` varchar(300) NOT NULL,
  `contact_no` varchar(100) NOT NULL,
  `department` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `student_info_table`
--

INSERT INTO `student_info_table` (`auto-id`, `student_id`, `batch_no`, `first_name`, `last_name`, `dob`, `gender`, `email`, `contact_no`, `department`) VALUES
(8, 'stu-001', 'b-1', 'Rick', 'Novak', '01/06/1988', 'male', 'rick@gmail.com', '789\r\n45632178', 'Medicine'),
(9, 'stu-002', 'b-1', 'Susan', 'Cannor', '04/06/1998', 'male', 'susan@gmail.com', '1236589', 'Software'),
(10, 'stu-003', 'b-2', 'Roshel', 'Clair', '07/06/2000', 'female', 'roshel@gmai.com', '7854612', 'Medicical'),
(11, 'stu-001', 'b-1', 'Rick', 'Novak', '01/06/1988', 'male', 'rick@gmail.com', '789\r\n45632178', 'Medicical'),
(12, 'stu-004', 'b-2', 'Ann', 'Jenifer', '06/08/1997', 'female', 'jeni@gmail.com', '7896521', 'Software'),
(13, 'stu-003', 'b-2', 'Roshel', 'Clair', '07/06/2000', 'female', 'roshel@gmai.com', '7854612', 'Medicical');

-- --------------------------------------------------------

--
-- Table structure for table `subject_info_table`
--

CREATE TABLE `subject_info_table` (
  `auto-id` int(11) NOT NULL,
  `subject_id` varchar(200) NOT NULL,
  `subject_name` varchar(200) NOT NULL,
  `trainee` varchar(200) NOT NULL,
  `description` varchar(600) NOT NULL,
  `duration` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `subject_info_table`
--

INSERT INTO `subject_info_table` (`auto-id`, `subject_id`, `subject_name`, `trainee`, `description`, `duration`) VALUES
(2, 's1', 'Science', 'John', 'Lorem ipsum dolor sit amet consectetur adipisicing elit.', '14 hours'),
(3, 's2', 'IT', 'Perera', 'Donec scelerisque sollicitudin enim eu venenatis', '20 hours'),
(4, 's3', 'Science', 'Nimaal', 'Cras pharetra mi tristique sapien vestibulum', '15 hours');

-- --------------------------------------------------------

--
-- Table structure for table `trainee_info_table`
--

CREATE TABLE `trainee_info_table` (
  `auto-id` int(11) NOT NULL,
  `trainee_id` varchar(200) NOT NULL,
  `first_name` varchar(200) NOT NULL,
  `last_name` varchar(200) NOT NULL,
  `dob` varchar(100) NOT NULL,
  `gender` varchar(100) NOT NULL,
  `email` varchar(300) NOT NULL,
  `contact_no` varchar(100) NOT NULL,
  `subject` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `trainee_info_table`
--

INSERT INTO `trainee_info_table` (`auto-id`, `trainee_id`, `first_name`, `last_name`, `dob`, `gender`, `email`, `contact_no`, `subject`) VALUES
(6, 'T-001', 'Grace', 'Liya', '14/05/1996', 'female', 'liya@gmail.com', '1236589', 'Science'),
(7, 'T-002', 'Robert', 'Hill', '17/06/1997', 'male', 'rob@gmail.com', '456982', 'IT'),
(8, 'T-003', 'James', 'Steller', '25/07/1996', 'male', 'james@gmail.com', '156328', 'Science');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `department_info_table`
--
ALTER TABLE `department_info_table`
  ADD PRIMARY KEY (`auto-id`);

--
-- Indexes for table `guardian_info_table`
--
ALTER TABLE `guardian_info_table`
  ADD PRIMARY KEY (`auto-id`);

--
-- Indexes for table `login_table`
--
ALTER TABLE `login_table`
  ADD PRIMARY KEY (`auto`);

--
-- Indexes for table `student_info_table`
--
ALTER TABLE `student_info_table`
  ADD PRIMARY KEY (`auto-id`);

--
-- Indexes for table `subject_info_table`
--
ALTER TABLE `subject_info_table`
  ADD PRIMARY KEY (`auto-id`);

--
-- Indexes for table `trainee_info_table`
--
ALTER TABLE `trainee_info_table`
  ADD PRIMARY KEY (`auto-id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `department_info_table`
--
ALTER TABLE `department_info_table`
  MODIFY `auto-id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `guardian_info_table`
--
ALTER TABLE `guardian_info_table`
  MODIFY `auto-id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `login_table`
--
ALTER TABLE `login_table`
  MODIFY `auto` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `student_info_table`
--
ALTER TABLE `student_info_table`
  MODIFY `auto-id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT for table `subject_info_table`
--
ALTER TABLE `subject_info_table`
  MODIFY `auto-id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `trainee_info_table`
--
ALTER TABLE `trainee_info_table`
  MODIFY `auto-id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
