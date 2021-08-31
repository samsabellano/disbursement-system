-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 25, 2020 at 04:38 AM
-- Server version: 10.1.38-MariaDB
-- PHP Version: 7.3.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `top_efas`
--

-- --------------------------------------------------------

--
-- Table structure for table `efas_admin`
--

CREATE TABLE `efas_admin` (
  `EFAS_ADMIN_ID` int(20) NOT NULL,
  `ADMIN_FIRST_NAME` varchar(50) DEFAULT NULL,
  `ADMIN_LAST_NAME` varchar(50) DEFAULT NULL,
  `ADMIN_CONTACT_NUMBER` varchar(20) DEFAULT NULL,
  `ADMIN_ADDRESS` varchar(50) DEFAULT NULL,
  `ADMIN_EMAIL` varchar(50) DEFAULT NULL,
  `ADMIN_USERNAME` varchar(200) DEFAULT NULL,
  `ADMIN_PASSWORD` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `efas_admin`
--

INSERT INTO `efas_admin` (`EFAS_ADMIN_ID`, `ADMIN_FIRST_NAME`, `ADMIN_LAST_NAME`, `ADMIN_CONTACT_NUMBER`, `ADMIN_ADDRESS`, `ADMIN_EMAIL`, `ADMIN_USERNAME`, `ADMIN_PASSWORD`) VALUES
(4, 'Lina', 'Ng', '09225406567', '492 South St., DBP Village, Maa, Davao City', 'lina.ng.ms@gmail.com', 'a', 'a'),
(5, 'Liza Mae', 'Villora', '09334246828', 'La Vista Monte Village1, Makilig St. Blk9 Lot-8, D', 'lizamaecvillora@gmail.com', 'liza', 'villora'),
(6, 'dscsd', 'sdc', '24343445345', 'sdcbshb', 'sdcs@gmail.com', 'sam0011', 'hsbdhc'),
(7, 'sdcsd', 'sdc', '34242423423', 'sdsdss', 'as@gmail.com', 'sam0011s', 'dcsdc');

-- --------------------------------------------------------

--
-- Table structure for table `efas_beneficiary`
--

CREATE TABLE `efas_beneficiary` (
  `EFAS_BENEFICIARY_ID` int(11) NOT NULL,
  `FIRST_NAME` varchar(50) DEFAULT NULL,
  `LAST_NAME` varchar(50) DEFAULT NULL,
  `ADDRESS` varchar(80) DEFAULT NULL,
  `CONTACT_NUMBER` varchar(50) DEFAULT NULL,
  `GENDER` varchar(10) DEFAULT NULL,
  `MARITAL_STATUS` varchar(20) DEFAULT NULL,
  `SCHOOL_NAME` varchar(100) DEFAULT NULL,
  `STUDENT_YEAR_LEVEL_ID` int(11) DEFAULT NULL,
  `SCHOOL_ID` varchar(80) DEFAULT NULL,
  `EMAIL` varchar(50) DEFAULT NULL,
  `USERNAME` varchar(200) DEFAULT NULL,
  `PASSWORD` varchar(50) DEFAULT NULL,
  `EC_FIRST_NAME` varchar(30) DEFAULT NULL,
  `EC_LAST_NAME` varchar(50) DEFAULT NULL,
  `EC_CONTACT_NUMBER` varchar(50) DEFAULT NULL,
  `EC_RELATIONSHIP` varchar(50) DEFAULT NULL,
  `BENEFICIARY_STATUS` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `efas_beneficiary`
--

INSERT INTO `efas_beneficiary` (`EFAS_BENEFICIARY_ID`, `FIRST_NAME`, `LAST_NAME`, `ADDRESS`, `CONTACT_NUMBER`, `GENDER`, `MARITAL_STATUS`, `SCHOOL_NAME`, `STUDENT_YEAR_LEVEL_ID`, `SCHOOL_ID`, `EMAIL`, `USERNAME`, `PASSWORD`, `EC_FIRST_NAME`, `EC_LAST_NAME`, `EC_CONTACT_NUMBER`, `EC_RELATIONSHIP`, `BENEFICIARY_STATUS`) VALUES
(1, 'Samuel', 'Sabellano', 'Loon, Bohol', '09557095574', 'Male', 'Single', 'University of Mindanao', 3, '471254', 'samsabellano851998@gmail.com', 'sam0011', 'sam', 'Lina', 'Ng', '09225406567', 'Guardian', 'Active'),
(2, 'Francis Carlo', 'Bagas', 'Toril, Davao City', '09091905283', 'Male', 'Married', 'University of Mindanao', 3, '123456', 'tolentinoboo@gmail.com', 'francis', 'bagas', 'Lina', 'Ng', '9225406567', 'Guardian', 'Active'),
(3, 'Gavin Moses', 'Bagas', 'sdc', '23234234234', 'Male', 'Single', 'shdc', 3, 'hnsudgc', 'sdf@gmail.com', 'sdbch', 'sdu', 'sdcs', 'sdcs', '23234234234', 'Guardian', 'Active');

-- --------------------------------------------------------

--
-- Table structure for table `efas_contract`
--

CREATE TABLE `efas_contract` (
  `TERMS` varchar(500) DEFAULT NULL,
  `START_DATE` varchar(100) DEFAULT NULL,
  `END_DATE` varchar(100) DEFAULT NULL,
  `REMARKS` varchar(8000) DEFAULT NULL,
  `EFAS_BENEFICIARY_ID` int(11) NOT NULL,
  `SY_ID` int(11) NOT NULL,
  `SEM_ID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `efas_contract`
--

INSERT INTO `efas_contract` (`TERMS`, `START_DATE`, `END_DATE`, `REMARKS`, `EFAS_BENEFICIARY_ID`, `SY_ID`, `SEM_ID`) VALUES
('No failing grades', 'Monday, 25 May 2020', 'NO DATE YET', 'N/A', 1, 7, 3);

-- --------------------------------------------------------

--
-- Table structure for table `efas_disbursement`
--

CREATE TABLE `efas_disbursement` (
  `DISBURSEMENT_ID` int(50) NOT NULL,
  `CONTRACT_ID` varchar(100) DEFAULT NULL,
  `EFAS_ADMIN_ID` int(50) DEFAULT NULL,
  `SCHOOL_ID` int(20) DEFAULT NULL,
  `DISBURSEMENT_DATE` varchar(50) DEFAULT NULL,
  `PERMIT_NUMBER` varchar(200) DEFAULT NULL,
  `DISBURSE_AMOUNT` double DEFAULT NULL,
  `PURPOSE_ID` int(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `efas_disbursement`
--

INSERT INTO `efas_disbursement` (`DISBURSEMENT_ID`, `CONTRACT_ID`, `EFAS_ADMIN_ID`, `SCHOOL_ID`, `DISBURSEMENT_DATE`, `PERMIT_NUMBER`, `DISBURSE_AMOUNT`, `PURPOSE_ID`) VALUES
(1, '2019-2020/Summer/B-1', 4, 471254, 'May 19, 2020', 'NO PERMIT', 2950, 1),
(2, '2019-2020/Summer/B-1', 4, 471254, 'May 19, 2020', 'NO PERMIT', 3450, 2),
(3, '2019-2020/Summer/B-1', 4, 471254, 'May 19, 2020', 'NO PERMIT', 2459, 3),
(4, '2019-2020/Summer/B-1', 4, 471254, 'May 20, 2020', 'NO PERMIT', 5000, 5),
(5, '2019-2020/Summer/B-1', 4, 471254, 'May 20, 2020', 'NO PERMIT', 324234, 2),
(6, '2019-2020/Summer/B-1', 4, 471254, 'May 24, 2020', 'NO PERMIT', 3233, 4);

-- --------------------------------------------------------

--
-- Table structure for table `efas_month`
--

CREATE TABLE `efas_month` (
  `MONTH` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `efas_month`
--

INSERT INTO `efas_month` (`MONTH`) VALUES
('All'),
('January'),
('February'),
('March'),
('April'),
('May'),
('June'),
('July'),
('August'),
('September'),
('October'),
('November'),
('December');

-- --------------------------------------------------------

--
-- Table structure for table `efas_month_disburse_chart`
--

CREATE TABLE `efas_month_disburse_chart` (
  `MONTH` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `efas_month_disburse_chart`
--

INSERT INTO `efas_month_disburse_chart` (`MONTH`) VALUES
('Jan'),
('Feb'),
('Mar'),
('Apr'),
('May'),
('Jun'),
('Jul'),
('Aug'),
('Sep'),
('Oct'),
('Nov'),
('Dec');

-- --------------------------------------------------------

--
-- Table structure for table `efas_purpose`
--

CREATE TABLE `efas_purpose` (
  `PURPOSE_ID` int(11) NOT NULL,
  `PURPOSE_DESCRIPTION` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `efas_purpose`
--

INSERT INTO `efas_purpose` (`PURPOSE_ID`, `PURPOSE_DESCRIPTION`) VALUES
(1, '1st Exam'),
(2, '2nd Exam'),
(3, '3rd Exam'),
(4, '4th Exam'),
(5, '5th Exam'),
(6, '6th Exam'),
(7, '7th Exam'),
(8, '8th Exam'),
(9, 'Certifications');

-- --------------------------------------------------------

--
-- Table structure for table `efas_return`
--

CREATE TABLE `efas_return` (
  `RETURN_ID` int(11) NOT NULL,
  `BENEFICIARY_ID` int(11) DEFAULT NULL,
  `SCHOOL_ID` int(50) DEFAULT NULL,
  `RETURN_AMOUNT` double DEFAULT NULL,
  `DATE_RETURNED` varchar(20) DEFAULT NULL,
  `TIME_RETURNED` varchar(15) DEFAULT NULL,
  `ADMIN_ID` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `efas_return`
--

INSERT INTO `efas_return` (`RETURN_ID`, `BENEFICIARY_ID`, `SCHOOL_ID`, `RETURN_AMOUNT`, `DATE_RETURNED`, `TIME_RETURNED`, `ADMIN_ID`) VALUES
(1, 1, 471254, 4500, 'May 19, 2020', '01:38 pm', 4),
(2, 1, 471254, 300000, 'May 22, 2020', '08:46 am', 4),
(3, 1, 471254, 30000, 'May 24, 2020', '03:52 pm', 4);

-- --------------------------------------------------------

--
-- Table structure for table `efas_school_year`
--

CREATE TABLE `efas_school_year` (
  `SY_ID` int(11) NOT NULL,
  `SY_DESCRIPTION` varchar(40) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `efas_school_year`
--

INSERT INTO `efas_school_year` (`SY_ID`, `SY_DESCRIPTION`) VALUES
(1, '2013-2014'),
(2, '2014-2015'),
(3, '2015-2016'),
(4, '2016-2017'),
(5, '2017-2018'),
(6, '2018-2019'),
(7, '2019-2020'),
(8, '2020-2021'),
(9, '2021-2022');

-- --------------------------------------------------------

--
-- Table structure for table `efas_semester`
--

CREATE TABLE `efas_semester` (
  `SEM_ID` int(11) NOT NULL,
  `SEM_DESCRIPTION` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `efas_semester`
--

INSERT INTO `efas_semester` (`SEM_ID`, `SEM_DESCRIPTION`) VALUES
(1, '1st Sem'),
(2, '2nd Sem'),
(3, 'Summer'),
(4, 'ADHOC');

-- --------------------------------------------------------

--
-- Table structure for table `efas_student_year_level`
--

CREATE TABLE `efas_student_year_level` (
  `STUDENT_YEAR_LEVEL_ID` int(11) NOT NULL,
  `YEAR_LEVEL_DESCRIPTION` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `efas_student_year_level`
--

INSERT INTO `efas_student_year_level` (`STUDENT_YEAR_LEVEL_ID`, `YEAR_LEVEL_DESCRIPTION`) VALUES
(1, 'First Year'),
(2, 'Second Year'),
(3, 'Third Year'),
(4, 'Fourth Year');

-- --------------------------------------------------------

--
-- Table structure for table `efas_year`
--

CREATE TABLE `efas_year` (
  `YEAR` varchar(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `efas_year`
--

INSERT INTO `efas_year` (`YEAR`) VALUES
('All'),
('2016'),
('2018'),
('2019'),
('2020'),
('2021'),
('2022'),
('2023'),
('2024'),
('2025'),
('2026'),
('2027');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_beneficiary`
--

CREATE TABLE `tbl_beneficiary` (
  `ID` int(20) NOT NULL,
  `ID_NUMBER` int(11) DEFAULT NULL,
  `FIRST_NAME` varchar(20) DEFAULT NULL,
  `LAST_NAME` varchar(20) DEFAULT NULL,
  `CONTACT_NUMBER` varchar(100) DEFAULT NULL,
  `ADDRESS` varchar(100) DEFAULT NULL,
  `EMAIL` varchar(20) DEFAULT NULL,
  `USERNAME` varchar(20) DEFAULT NULL,
  `PASSWORD` varchar(20) DEFAULT NULL,
  `GENDER` varchar(20) DEFAULT NULL,
  `STATUS` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_beneficiary`
--

INSERT INTO `tbl_beneficiary` (`ID`, `ID_NUMBER`, `FIRST_NAME`, `LAST_NAME`, `CONTACT_NUMBER`, `ADDRESS`, `EMAIL`, `USERNAME`, `PASSWORD`, `GENDER`, `STATUS`) VALUES
(9, 471254, 'Samuel', 'Sabellano', '09557095574', 'DBP Village, Ma-a, Davao City', 'samsabellano851998@g', 'Male', 'sam0011', 'sam851998', 'Active'),
(10, 0, 'First Name', 'Last Name', 'Contact Number', 'Address', 'Email', 'Username', 'Password', '', 'Active');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `efas_admin`
--
ALTER TABLE `efas_admin`
  ADD PRIMARY KEY (`EFAS_ADMIN_ID`);

--
-- Indexes for table `efas_beneficiary`
--
ALTER TABLE `efas_beneficiary`
  ADD PRIMARY KEY (`EFAS_BENEFICIARY_ID`),
  ADD KEY `STUDENT_STATUS_ID` (`STUDENT_YEAR_LEVEL_ID`);

--
-- Indexes for table `efas_contract`
--
ALTER TABLE `efas_contract`
  ADD PRIMARY KEY (`SY_ID`,`SEM_ID`,`EFAS_BENEFICIARY_ID`),
  ADD KEY `SEM_ID` (`SEM_ID`),
  ADD KEY `EFAS_BENEFICIARY_ID` (`EFAS_BENEFICIARY_ID`);

--
-- Indexes for table `efas_disbursement`
--
ALTER TABLE `efas_disbursement`
  ADD PRIMARY KEY (`DISBURSEMENT_ID`),
  ADD KEY `CONTRACT_ID` (`CONTRACT_ID`),
  ADD KEY `PURPOSE_ID` (`PURPOSE_ID`),
  ADD KEY `EFAS_ADMIN_ID` (`EFAS_ADMIN_ID`);

--
-- Indexes for table `efas_purpose`
--
ALTER TABLE `efas_purpose`
  ADD PRIMARY KEY (`PURPOSE_ID`);

--
-- Indexes for table `efas_return`
--
ALTER TABLE `efas_return`
  ADD PRIMARY KEY (`RETURN_ID`);

--
-- Indexes for table `efas_school_year`
--
ALTER TABLE `efas_school_year`
  ADD PRIMARY KEY (`SY_ID`);

--
-- Indexes for table `efas_semester`
--
ALTER TABLE `efas_semester`
  ADD PRIMARY KEY (`SEM_ID`);

--
-- Indexes for table `efas_student_year_level`
--
ALTER TABLE `efas_student_year_level`
  ADD PRIMARY KEY (`STUDENT_YEAR_LEVEL_ID`);

--
-- Indexes for table `tbl_beneficiary`
--
ALTER TABLE `tbl_beneficiary`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `efas_admin`
--
ALTER TABLE `efas_admin`
  MODIFY `EFAS_ADMIN_ID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `efas_beneficiary`
--
ALTER TABLE `efas_beneficiary`
  MODIFY `EFAS_BENEFICIARY_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `efas_disbursement`
--
ALTER TABLE `efas_disbursement`
  MODIFY `DISBURSEMENT_ID` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `efas_purpose`
--
ALTER TABLE `efas_purpose`
  MODIFY `PURPOSE_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `efas_return`
--
ALTER TABLE `efas_return`
  MODIFY `RETURN_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `efas_school_year`
--
ALTER TABLE `efas_school_year`
  MODIFY `SY_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `efas_semester`
--
ALTER TABLE `efas_semester`
  MODIFY `SEM_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `efas_student_year_level`
--
ALTER TABLE `efas_student_year_level`
  MODIFY `STUDENT_YEAR_LEVEL_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbl_beneficiary`
--
ALTER TABLE `tbl_beneficiary`
  MODIFY `ID` int(20) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `efas_beneficiary`
--
ALTER TABLE `efas_beneficiary`
  ADD CONSTRAINT `efas_beneficiary_ibfk_1` FOREIGN KEY (`STUDENT_YEAR_LEVEL_ID`) REFERENCES `efas_student_year_level` (`STUDENT_YEAR_LEVEL_ID`);

--
-- Constraints for table `efas_contract`
--
ALTER TABLE `efas_contract`
  ADD CONSTRAINT `efas_contract_ibfk_1` FOREIGN KEY (`SY_ID`) REFERENCES `efas_school_year` (`SY_ID`),
  ADD CONSTRAINT `efas_contract_ibfk_2` FOREIGN KEY (`SEM_ID`) REFERENCES `efas_semester` (`SEM_ID`),
  ADD CONSTRAINT `efas_contract_ibfk_3` FOREIGN KEY (`EFAS_BENEFICIARY_ID`) REFERENCES `efas_beneficiary` (`EFAS_BENEFICIARY_ID`);

--
-- Constraints for table `efas_disbursement`
--
ALTER TABLE `efas_disbursement`
  ADD CONSTRAINT `efas_disbursement_ibfk_1` FOREIGN KEY (`PURPOSE_ID`) REFERENCES `efas_purpose` (`PURPOSE_ID`),
  ADD CONSTRAINT `efas_disbursement_ibfk_2` FOREIGN KEY (`EFAS_ADMIN_ID`) REFERENCES `efas_admin` (`EFAS_ADMIN_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
