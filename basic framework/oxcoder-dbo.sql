/*
Navicat SQL Server Data Transfer

Source Server         : SqlServer
Source Server Version : 100000
Source Host           : PC-201503201232:1433
Source Database       : oxcoder
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 100000
File Encoding         : 65001

Date: 2015-06-12 01:08:16
*/


-- ----------------------------
-- Table structure for accountpackage
-- ----------------------------
DROP TABLE [dbo].[accountpackage]
GO
CREATE TABLE [dbo].[accountpackage] (
[apID] int NOT NULL ,
[eID] int NULL ,
[apType] int NULL ,
[apInvoiceTitle] varchar(1) NULL ,
[apInvoiceContent] int NULL ,
[apInvoiceType] int NULL ,
[apInvoiceAddr] varchar(1) NULL ,
[apInvoiceContact] varchar(1) NULL 
)


GO

-- ----------------------------
-- Records of accountpackage
-- ----------------------------

-- ----------------------------
-- Table structure for admin
-- ----------------------------
DROP TABLE [dbo].[admin]
GO
CREATE TABLE [dbo].[admin] (
[aID] int NOT NULL ,
[aName] varchar(1) NULL ,
[aPwd] varchar(1) NULL ,
[aUserType] int NULL ,
[aState] int NULL 
)


GO

-- ----------------------------
-- Records of admin
-- ----------------------------

-- ----------------------------
-- Table structure for challenge
-- ----------------------------
DROP TABLE [dbo].[challenge]
GO
CREATE TABLE [dbo].[challenge] (
[cID] int NOT NULL ,
[cName] varchar(1) NULL ,
[cType] int NULL ,
[cPic] int NULL ,
[cSalary] int NULL ,
[cLevel] int NULL ,
[cArea] int NULL ,
[cRight] int NULL ,
[cTimeFrom] date NULL ,
[cTimeTo] date NULL ,
[cPro1] int NULL 
)


GO

-- ----------------------------
-- Records of challenge
-- ----------------------------

-- ----------------------------
-- Table structure for challengepro
-- ----------------------------
DROP TABLE [dbo].[challengepro]
GO
CREATE TABLE [dbo].[challengepro] (
[cpID] int NOT NULL ,
[cpName] varchar(1) NULL ,
[cpType] int NULL ,
[cpLevel] int NULL ,
[cpDescription] varchar(1) NULL ,
[cpAbility] varchar(1) NULL ,
[cpTime] int NULL ,
[cpPoint] varchar(1) NULL ,
[cpCodeQues] varchar(1) NULL ,
[cpCodeAll] varchar(1) NULL ,
[cpEspectPoint] varchar(1) NULL ,
[cpTarget] varchar(1) NULL 
)


GO

-- ----------------------------
-- Records of challengepro
-- ----------------------------

-- ----------------------------
-- Table structure for enterpriseaccount
-- ----------------------------
DROP TABLE [dbo].[enterpriseaccount]
GO
CREATE TABLE [dbo].[enterpriseaccount] (
[eaID] int NOT NULL ,
[eID] int NULL ,
[eaInvNum] int NULL ,
[eaChlNum] int NULL ,
[eaInvDone] int NULL ,
[eaChlDone] int NULL ,
[eaPurchaseTime] date NULL ,
[eaRechargeState] int NULL ,
[eaRechargeCode] varchar(1) NULL 
)


GO

-- ----------------------------
-- Records of enterpriseaccount
-- ----------------------------

-- ----------------------------
-- Table structure for enterprisechl
-- ----------------------------
DROP TABLE [dbo].[enterprisechl]
GO
CREATE TABLE [dbo].[enterprisechl] (
[ecID] int NOT NULL ,
[eID] int NULL ,
[cID] int NULL ,
[ecAcceptChlNum] int NULL ,
[ecDoneChlNum] int NULL 
)


GO

-- ----------------------------
-- Records of enterprisechl
-- ----------------------------

-- ----------------------------
-- Table structure for enterpriseinfor
-- ----------------------------
DROP TABLE [dbo].[enterpriseinfor]
GO
CREATE TABLE [dbo].[enterpriseinfor] (
[eID] int NOT NULL ,
[eName] varchar(1) NULL ,
[ePwd] varchar(1) NULL ,
[eEmail] varchar(1) NULL ,
[eCmpName] varchar(1) NULL ,
[eLogo] image NULL ,
[eTel] varchar(1) NULL ,
[eWebAddr] varchar(1) NULL ,
[eArea] varchar(1) NULL ,
[eScale] varchar(1) NULL ,
[eIntroduction] varchar(1) NULL ,
[eRemarkID] int NULL ,
[eAccountID] int NULL ,
[eChallengeID] int NULL ,
[eLastTime] timestamp NULL ,
[eLicense] image NULL ,
[eState] int NULL ,
[eRegisterTime] datetime2(7) NULL 
)


GO

-- ----------------------------
-- Records of enterpriseinfor
-- ----------------------------

-- ----------------------------
-- Table structure for enterpriseremark
-- ----------------------------
DROP TABLE [dbo].[enterpriseremark]
GO
CREATE TABLE [dbo].[enterpriseremark] (
[erID] int NOT NULL ,
[eID] int NULL ,
[eRemark1] int NULL ,
[eRemark2] int NULL ,
[eRemark3] int NULL ,
[erCustom1] varchar(1) NULL ,
[erCustom2] varchar(1) NULL ,
[erCustom3] varchar(1) NULL 
)


GO

-- ----------------------------
-- Records of enterpriseremark
-- ----------------------------

-- ----------------------------
-- Table structure for personalchl
-- ----------------------------
DROP TABLE [dbo].[personalchl]
GO
CREATE TABLE [dbo].[personalchl] (
[pcID] int NOT NULL ,
[pID] int NULL ,
[cID] int NULL ,
[pcState] int NULL 
)


GO

-- ----------------------------
-- Records of personalchl
-- ----------------------------

-- ----------------------------
-- Table structure for personalevaluation
-- ----------------------------
DROP TABLE [dbo].[personalevaluation]
GO
CREATE TABLE [dbo].[personalevaluation] (
[pEvlID] int NOT NULL ,
[pID] int NULL ,
[pQuality] float(53) NULL ,
[pProficiency] float(53) NULL ,
[pFocus] float(53) NULL ,
[pDeviation] float(53) NULL ,
[pResidence] float(53) NULL 
)


GO

-- ----------------------------
-- Records of personalevaluation
-- ----------------------------

-- ----------------------------
-- Table structure for personalinfor
-- ----------------------------
DROP TABLE [dbo].[personalinfor]
GO
CREATE TABLE [dbo].[personalinfor] (
[pID] int NOT NULL ,
[pName] varchar(1) NULL ,
[pPwd] varchar(1) NULL ,
[pEmail] varchar(1) NULL ,
[pAge] int NULL ,
[pSex] char(1) NULL ,
[pTel] varchar(1) NULL ,
[pChallengeID] int NULL ,
[pWorth] varchar(1) NULL ,
[pEvaluationID] int NULL ,
[pState] int NULL 
)


GO

-- ----------------------------
-- Records of personalinfor
-- ----------------------------

-- ----------------------------
-- Table structure for personalworth
-- ----------------------------
DROP TABLE [dbo].[personalworth]
GO
CREATE TABLE [dbo].[personalworth] (
[wID] int NOT NULL ,
[wLevel] int NULL ,
[wRangeRrom] int NULL ,
[wRangeTo] int NULL ,
[wDescription] varchar(1) NULL 
)


GO

-- ----------------------------
-- Records of personalworth
-- ----------------------------

-- ----------------------------
-- Table structure for remark
-- ----------------------------
DROP TABLE [dbo].[remark]
GO
CREATE TABLE [dbo].[remark] (
[rID] int NOT NULL ,
[remark] varchar(1) NULL 
)


GO

-- ----------------------------
-- Records of remark
-- ----------------------------

-- ----------------------------
-- Indexes structure for table accountpackage
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table accountpackage
-- ----------------------------
ALTER TABLE [dbo].[accountpackage] ADD PRIMARY KEY ([apID])
GO

-- ----------------------------
-- Indexes structure for table admin
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table admin
-- ----------------------------
ALTER TABLE [dbo].[admin] ADD PRIMARY KEY ([aID])
GO

-- ----------------------------
-- Indexes structure for table challenge
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table challenge
-- ----------------------------
ALTER TABLE [dbo].[challenge] ADD PRIMARY KEY ([cID])
GO

-- ----------------------------
-- Indexes structure for table challengepro
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table challengepro
-- ----------------------------
ALTER TABLE [dbo].[challengepro] ADD PRIMARY KEY ([cpID])
GO

-- ----------------------------
-- Indexes structure for table enterpriseaccount
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table enterpriseaccount
-- ----------------------------
ALTER TABLE [dbo].[enterpriseaccount] ADD PRIMARY KEY ([eaID])
GO

-- ----------------------------
-- Indexes structure for table enterprisechl
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table enterprisechl
-- ----------------------------
ALTER TABLE [dbo].[enterprisechl] ADD PRIMARY KEY ([ecID])
GO

-- ----------------------------
-- Indexes structure for table enterpriseinfor
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table enterpriseinfor
-- ----------------------------
ALTER TABLE [dbo].[enterpriseinfor] ADD PRIMARY KEY ([eID])
GO

-- ----------------------------
-- Indexes structure for table enterpriseremark
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table enterpriseremark
-- ----------------------------
ALTER TABLE [dbo].[enterpriseremark] ADD PRIMARY KEY ([erID])
GO

-- ----------------------------
-- Indexes structure for table personalchl
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table personalchl
-- ----------------------------
ALTER TABLE [dbo].[personalchl] ADD PRIMARY KEY ([pcID])
GO

-- ----------------------------
-- Indexes structure for table personalevaluation
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table personalevaluation
-- ----------------------------
ALTER TABLE [dbo].[personalevaluation] ADD PRIMARY KEY ([pEvlID])
GO

-- ----------------------------
-- Indexes structure for table personalinfor
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table personalinfor
-- ----------------------------
ALTER TABLE [dbo].[personalinfor] ADD PRIMARY KEY ([pID])
GO

-- ----------------------------
-- Indexes structure for table personalworth
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table personalworth
-- ----------------------------
ALTER TABLE [dbo].[personalworth] ADD PRIMARY KEY ([wID])
GO

-- ----------------------------
-- Indexes structure for table remark
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table remark
-- ----------------------------
ALTER TABLE [dbo].[remark] ADD PRIMARY KEY ([rID])
GO
