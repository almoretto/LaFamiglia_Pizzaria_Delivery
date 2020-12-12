-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema DB_LaFamigliaPizzeriaDelivery
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema DB_LaFamigliaPizzeriaDelivery
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery` DEFAULT CHARACTER SET utf8 ;
USE `DB_LaFamigliaPizzeriaDelivery` ;

-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`TipoUsuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`TipoUsuario` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `Descricao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `Id_TipoUsuario` INT UNSIGNED NOT NULL,
  `Nome` VARCHAR(100) NOT NULL,
  `Login` VARCHAR(45) NOT NULL,
  `Senha` VARCHAR(45) NOT NULL,
  `Situacao` TINYINT(1) NOT NULL,
  `DataAlteracao` DATETIME NOT NULL,
  `Id_Usuario_Alteracao` INT UNSIGNED NOT NULL,
  `Usuario_Id` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_Usuario_TipoUsuario_idx` (`Id_TipoUsuario` ASC) VISIBLE,
  INDEX `FK_Usuario_Usuario_idx` (`Id_Usuario_Alteracao` ASC) VISIBLE,
  CONSTRAINT `FK_Usuario_TipoUsuario`
    FOREIGN KEY (`Id_TipoUsuario`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`TipoUsuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Usuario_Usuario`
    FOREIGN KEY (`Id_Usuario_Alteracao`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`Usuario_Hst`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`Usuario_Hst` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `IdUsuario` INT UNSIGNED NOT NULL,
  `Id_TipoUsuario` INT UNSIGNED NOT NULL,
  `Nome` VARCHAR(100) NOT NULL,
  `Login` VARCHAR(45) NOT NULL,
  `Senha` VARCHAR(45) NOT NULL,
  `Situacao` TINYINT(1) NOT NULL,
  `DataAlteracao` DATETIME NOT NULL,
  `Id_Usuario_Alteracao` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_Usuario_TipoUsuario_idx` (`Id_TipoUsuario` ASC) VISIBLE,
  INDEX `FK_UsuarioHst_Usuario_idx` (`Id_Usuario_Alteracao` ASC) VISIBLE,
  INDEX `FK_UsuarioHst_Usuario_idx1` (`IdUsuario` ASC) VISIBLE,
  CONSTRAINT `FK_Usuario_TipoUsuario0`
    FOREIGN KEY (`Id_TipoUsuario`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`TipoUsuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_UsuarioHst_UsuarioAlt`
    FOREIGN KEY (`Id_Usuario_Alteracao`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_UsuarioHst_Usuario`
    FOREIGN KEY (`IdUsuario`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`Cliente`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`Cliente` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(90) NOT NULL,
  `Telefone` BIGINT(15) UNSIGNED NULL,
  `Celular` BIGINT(15) UNSIGNED NULL,
  `Situacao` TINYINT(1) NOT NULL DEFAULT 1,
  `DataAlteracao` DATETIME NOT NULL,
  `IdUsuarioAlteracao` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_Cliente_Usuario_idx` (`IdUsuarioAlteracao` ASC) VISIBLE,
  CONSTRAINT `FK_Cliente_Usuario`
    FOREIGN KEY (`IdUsuarioAlteracao`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`Endereco`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`Endereco` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `IdCliente` INT UNSIGNED NOT NULL,
  `Logradouro` VARCHAR(150) NOT NULL,
  `Numero` INT NOT NULL,
  `Complemento` VARCHAR(100) NULL,
  `Bairro` VARCHAR(50) NOT NULL,
  `Cidade` VARCHAR(80) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_Endereco_Cliente_idx` (`IdCliente` ASC) VISIBLE,
  CONSTRAINT `FK_Endereco_Cliente`
    FOREIGN KEY (`IdCliente`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Cliente` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`EnderecoPadrao`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`EnderecoPadrao` (
  `IdCliente` INT UNSIGNED NOT NULL,
  `IdEndereco` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`IdCliente`, `IdEndereco`),
  INDEX `FK_EnderecoPadrao_Endereco_idx` (`IdEndereco` ASC) VISIBLE,
  CONSTRAINT `FK_EnderecoPadrao_Cliente`
    FOREIGN KEY (`IdCliente`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Cliente` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_EnderecoPadrao_Endereco`
    FOREIGN KEY (`IdEndereco`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Endereco` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`Cliente_Hst`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`Cliente_Hst` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `IdCliente` INT UNSIGNED NOT NULL,
  `Nome` VARCHAR(90) NOT NULL,
  `Telefone` BIGINT(15) UNSIGNED NULL,
  `Celular` BIGINT(15) UNSIGNED NULL,
  `Situacao` TINYINT(1) NOT NULL DEFAULT 1,
  `DataAlteracao` DATETIME NOT NULL,
  `IdUsuarioAlteracao` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_Cliente_Hst_Cliente_idx` (`IdCliente` ASC) VISIBLE,
  INDEX `FK_Cliente_Hst_Usuario_idx` (`IdUsuarioAlteracao` ASC) VISIBLE,
  CONSTRAINT `FK_Cliente_Hst_Cliente`
    FOREIGN KEY (`IdCliente`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Cliente` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Cliente_Hst_Usuario`
    FOREIGN KEY (`IdUsuarioAlteracao`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`SaborPizza`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`SaborPizza` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `Descricao` VARCHAR(50) NOT NULL,
  `Observacao` VARCHAR(200) NULL,
  `ValorAcrescimo` DECIMAL(10,2) NOT NULL DEFAULT 0.00,
  `Situacao` TINYINT(1) NOT NULL DEFAULT 1,
  `DataAlteracao` DATETIME NOT NULL,
  `IdUsuarioAlteracao` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_SaborPizza_Usuario_idx` (`IdUsuarioAlteracao` ASC) VISIBLE,
  CONSTRAINT `FK_SaborPizza_Usuario`
    FOREIGN KEY (`IdUsuarioAlteracao`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`SaborPizza_Hst`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`SaborPizza_Hst` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `IdSaborPizza` INT UNSIGNED NOT NULL,
  `Descricao` VARCHAR(50) NOT NULL,
  `Observacao` VARCHAR(200) NULL,
  `ValorAcrescimo` DECIMAL(10,2) NOT NULL DEFAULT 0.00,
  `Situacao` TINYINT(1) NOT NULL DEFAULT 1,
  `DataAlteracao` DATETIME NOT NULL,
  `IdUsuarioAlteracao` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_SaborPizza_Usuario_idx` (`IdUsuarioAlteracao` ASC) VISIBLE,
  INDEX `FK_SaborPizza_Hst_SaborPizza_idx` (`IdSaborPizza` ASC) VISIBLE,
  CONSTRAINT `FK_SaborPizza_Hst_Usuario`
    FOREIGN KEY (`IdUsuarioAlteracao`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_SaborPizza_Hst_SaborPizza`
    FOREIGN KEY (`IdSaborPizza`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`SaborPizza` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`TamanhoPizza`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`TamanhoPizza` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `Descricao` VARCHAR(50) NOT NULL,
  `Observacao` VARCHAR(200) NULL,
  `Valor` DECIMAL(10,2) UNSIGNED NOT NULL DEFAULT 0.00,
  `Qtesabores` TINYINT NOT NULL,
  `Situacao` TINYINT(1) NOT NULL DEFAULT 1,
  `DataAlteracao` DATETIME NOT NULL,
  `IdUsuarioAlteracao` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_TamanhoPizza_Usuario_idx` (`IdUsuarioAlteracao` ASC) VISIBLE,
  CONSTRAINT `FK_TamanhoPizza_Usuario`
    FOREIGN KEY (`IdUsuarioAlteracao`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`TamanhoPizza_Hst`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`TamanhoPizza_Hst` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `IdTamanhoPizza` INT UNSIGNED NOT NULL,
  `Descricao` VARCHAR(50) NOT NULL,
  `Observacao` VARCHAR(200) NULL,
  `Valor` DECIMAL(10,2) UNSIGNED NOT NULL DEFAULT 0.00,
  `Qtesabores` TINYINT NOT NULL,
  `Situacao` TINYINT(1) NOT NULL DEFAULT 1,
  `DataAlteracao` DATETIME NOT NULL,
  `IdUsuarioAlteracao` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_TamanhoPizza_Hst_TamanhoPizza_idx` (`IdTamanhoPizza` ASC) VISIBLE,
  INDEX `FK_TamanhoPizza_Hst_Usuario_idx` (`IdUsuarioAlteracao` ASC) VISIBLE,
  CONSTRAINT `FK_TamanhoPizza_Hst_TamanhoPizza`
    FOREIGN KEY (`IdTamanhoPizza`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`TamanhoPizza` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_TamanhoPizza_Hst_Usuario`
    FOREIGN KEY (`IdUsuarioAlteracao`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`SaborBorda`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`SaborBorda` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `Descricao` VARCHAR(50) NOT NULL,
  `Observacao` VARCHAR(200) NULL,
  `ValorAcrescimo` DECIMAL(10,2) NOT NULL DEFAULT 0.00,
  `Situacao` TINYINT(1) NOT NULL,
  `DataAlteracao` DATETIME NOT NULL,
  `IdUsuarioAlteracao` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_SaborBorda_Usuario_idx` (`IdUsuarioAlteracao` ASC) VISIBLE,
  CONSTRAINT `FK_SaborBorda_Usuario`
    FOREIGN KEY (`IdUsuarioAlteracao`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`SaborBorda_Hst`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`SaborBorda_Hst` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `IdSaborBorda` INT UNSIGNED NOT NULL,
  `Descricao` VARCHAR(50) NOT NULL,
  `Observacao` VARCHAR(200) NULL,
  `ValorAcrescimo` DECIMAL(10,2) NOT NULL DEFAULT 0.00,
  `Situacao` TINYINT(1) NOT NULL,
  `DataAlteracao` DATETIME NOT NULL,
  `IdUsuarioAlteracao` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_SaborBorda_Usuario_idx` (`IdUsuarioAlteracao` ASC) VISIBLE,
  INDEX `FK_SaborBorda_Hst_SaborBorda_idx` (`IdSaborBorda` ASC) VISIBLE,
  CONSTRAINT `FK_SaborBorda_Hst_Usuario`
    FOREIGN KEY (`IdUsuarioAlteracao`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_SaborBorda_Hst_SaborBorda`
    FOREIGN KEY (`IdSaborBorda`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`SaborBorda` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`Adicional`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`Adicional` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `Descricao` VARCHAR(100) NOT NULL,
  `Observacao` VARCHAR(200) NULL,
  `Adicionalcol` VARCHAR(45) NULL,
  `Valor` DECIMAL(10,2) UNSIGNED NOT NULL DEFAULT 0.00,
  `Situacao` TINYINT(1) NOT NULL DEFAULT 1,
  `DataAlteracao` DATETIME NOT NULL,
  `IdUsuarioAlteracao` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_Adicional_Usuario_idx` (`IdUsuarioAlteracao` ASC) VISIBLE,
  CONSTRAINT `FK_Adicional_Usuario`
    FOREIGN KEY (`IdUsuarioAlteracao`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`Adicional_Hst`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`Adicional_Hst` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `IdAdicional` INT UNSIGNED NOT NULL,
  `Descricao` VARCHAR(100) NOT NULL,
  `Observacao` VARCHAR(200) NULL,
  `Adicionalcol` VARCHAR(45) NULL,
  `Valor` DECIMAL(10,2) UNSIGNED NOT NULL DEFAULT 0.00,
  `Situacao` TINYINT(1) NOT NULL DEFAULT 1,
  `DataAlteracao` DATETIME NOT NULL,
  `IdUsuarioAlteracao` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_Adicional_Hst_Usuario_idx` (`IdUsuarioAlteracao` ASC) VISIBLE,
  INDEX `FK_Adicional_Hst_Adicional_idx` (`IdAdicional` ASC) VISIBLE,
  CONSTRAINT `FK_Adicional_Hst_Usuario`
    FOREIGN KEY (`IdUsuarioAlteracao`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Adicional_Hst_Adicional`
    FOREIGN KEY (`IdAdicional`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Adicional` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`StatusPedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`StatusPedido` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `Descricao` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`Pedido`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`Pedido` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `IdCliente` INT UNSIGNED NOT NULL,
  `IdStatus` INT UNSIGNED NOT NULL,
  `ValorPedido` DECIMAL(10,2) UNSIGNED NOT NULL,
  `TeleEntrega` TINYINT NOT NULL,
  `ValorEntrega` DECIMAL(10,2) NOT NULL DEFAULT 0.00,
  `ValorTotal` DECIMAL(10,2) NOT NULL DEFAULT 0.00,
  `DataPedido` DATETIME NOT NULL,
  `IdUsuarioPedido` INT UNSIGNED NOT NULL,
  `DataAlteracao` DATETIME NOT NULL,
  `IdUsuarioAlteracao` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_Pedido_Cliente_idx` (`IdCliente` ASC) VISIBLE,
  INDEX `FK_Pedido_StatusPedido_idx` (`IdStatus` ASC) VISIBLE,
  INDEX `FK_Pedido_Usuario_idx` (`IdUsuarioPedido` ASC) VISIBLE,
  INDEX `FK_Pedido_UsuarioAlteracao_idx` (`IdUsuarioAlteracao` ASC) VISIBLE,
  CONSTRAINT `FK_Pedido_Cliente`
    FOREIGN KEY (`IdCliente`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Cliente` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Pedido_StatusPedido`
    FOREIGN KEY (`IdStatus`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`StatusPedido` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Pedido_Usuario`
    FOREIGN KEY (`IdUsuarioPedido`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Pedido_UsuarioAlteracao`
    FOREIGN KEY (`IdUsuarioAlteracao`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`Pedido_Hst`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`Pedido_Hst` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `IdPedido` INT UNSIGNED NOT NULL,
  `IdCliente` INT UNSIGNED NOT NULL,
  `IdStatus` INT UNSIGNED NOT NULL,
  `ValorPedido` DECIMAL(10,2) UNSIGNED NOT NULL,
  `TeleEntrega` TINYINT NOT NULL,
  `ValorEntrega` DECIMAL(10,2) NOT NULL DEFAULT 0.00,
  `ValorTotal` DECIMAL(10,2) NOT NULL DEFAULT 0.00,
  `DataPedido` DATETIME NOT NULL,
  `IdUsuarioPedido` INT UNSIGNED NOT NULL,
  `DataAlteracao` DATETIME NOT NULL,
  `IdUsuarioAlteracao` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_Pedido_Cliente_idx` (`IdCliente` ASC) VISIBLE,
  INDEX `FK_Pedido_StatusPedido_idx` (`IdStatus` ASC) VISIBLE,
  INDEX `FK_Pedido_Usuario_idx` (`IdUsuarioPedido` ASC) VISIBLE,
  INDEX `FK_Pedido_UsuarioAlteracao_idx` (`IdUsuarioAlteracao` ASC) VISIBLE,
  INDEX `FK_Pedido_Hst_Pedido_idx` (`IdPedido` ASC) VISIBLE,
  CONSTRAINT `FK_Pedido_Hst_Cliente`
    FOREIGN KEY (`IdCliente`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Cliente` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Pedido_Hst_StatusPedido`
    FOREIGN KEY (`IdStatus`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`StatusPedido` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Pedido_Hst_Usuario`
    FOREIGN KEY (`IdUsuarioPedido`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Pedido_Hst_UsuarioAlteracao`
    FOREIGN KEY (`IdUsuarioAlteracao`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Usuario` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_Pedido_Hst_Pedido`
    FOREIGN KEY (`IdPedido`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Pedido` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`ItemPedidoAdicional`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`ItemPedidoAdicional` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `IdPedido` INT UNSIGNED NOT NULL,
  `IdAdicional` INT UNSIGNED NOT NULL,
  `QteAdicional` TINYINT UNSIGNED NOT NULL DEFAULT 1,
  `ValorTotalItem` DECIMAL(10,2) UNSIGNED NOT NULL DEFAULT 0.00,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_ItemPedidoAdicional_Pedido_idx` (`IdPedido` ASC) VISIBLE,
  INDEX `FK_ItemPedidoAdicional_Adicional_idx` (`IdAdicional` ASC) VISIBLE,
  CONSTRAINT `FK_ItemPedidoAdicional_Pedido`
    FOREIGN KEY (`IdPedido`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Pedido` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemPedidoAdicional_Adicional`
    FOREIGN KEY (`IdAdicional`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Adicional` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`ItemPedidoAdicional_Hst`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`ItemPedidoAdicional_Hst` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `IdItemPedidoAdicional` INT UNSIGNED NOT NULL,
  `IdPedido` INT UNSIGNED NOT NULL,
  `IdAdicional` INT UNSIGNED NOT NULL,
  `QteAdicional` TINYINT UNSIGNED NOT NULL DEFAULT 1,
  `ValorTotalItem` DECIMAL(10,2) UNSIGNED NOT NULL DEFAULT 0.00,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_ItemPedidoAdicional_Pedido_idx` (`IdPedido` ASC) VISIBLE,
  INDEX `FK_ItemPedidoAdicional_Adicional_idx` (`IdAdicional` ASC) VISIBLE,
  INDEX `Fk_ItemPedidoAdicional_Hst_ItemPedidoAdicional_idx` (`IdItemPedidoAdicional` ASC) VISIBLE,
  CONSTRAINT `FK_ItemPedidoAdicional_Hst_Pedido`
    FOREIGN KEY (`IdPedido`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Pedido` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemPedidoAdicional_Hst_Adicional`
    FOREIGN KEY (`IdAdicional`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Adicional` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `Fk_ItemPedidoAdicional_Hst_ItemPedidoAdicional`
    FOREIGN KEY (`IdItemPedidoAdicional`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`ItemPedidoAdicional` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`ItemPedidoPizza`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`ItemPedidoPizza` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `IdPedido` INT UNSIGNED NOT NULL,
  `IdTamanhoPizza` INT UNSIGNED NOT NULL,
  `IdSaborBorda` INT UNSIGNED NOT NULL,
  `ValorTotal` DECIMAL(10,2) UNSIGNED NOT NULL DEFAULT 0.00,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_ItemPedidoPizza_Pedido_idx` (`IdPedido` ASC) VISIBLE,
  INDEX `FK_ItemPedidoPizza_TamanhoPizza_idx` (`IdTamanhoPizza` ASC) VISIBLE,
  INDEX `FK_ItemPedidoPizza_SaborBorda_idx` (`IdSaborBorda` ASC) VISIBLE,
  CONSTRAINT `FK_ItemPedidoPizza_Pedido`
    FOREIGN KEY (`IdPedido`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Pedido` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemPedidoPizza_TamanhoPizza`
    FOREIGN KEY (`IdTamanhoPizza`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`TamanhoPizza` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemPedidoPizza_SaborBorda`
    FOREIGN KEY (`IdSaborBorda`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`SaborBorda` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`ItemPedidoPizza_Hst`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`ItemPedidoPizza_Hst` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `IdItemPedidoPizza` INT UNSIGNED NOT NULL,
  `IdPedido` INT UNSIGNED NOT NULL,
  `IdTamanhoPizza` INT UNSIGNED NOT NULL,
  `IdSaborBorda` INT UNSIGNED NOT NULL,
  `ValorTotal` DECIMAL(10,2) UNSIGNED NOT NULL DEFAULT 0.00,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_ItemPedidoPizza_Hst_ItemPedidoPizza_idx` (`IdItemPedidoPizza` ASC) VISIBLE,
  INDEX `FK_ItemPedidoPizza_Hst_Pedido_idx` (`IdPedido` ASC) VISIBLE,
  INDEX `FK_ItemPedidoPizza_Hst_TamanhoPizza_idx` (`IdTamanhoPizza` ASC) VISIBLE,
  INDEX `FK_ItemPedidoPizza_Hst_SaborBorda_idx` (`IdSaborBorda` ASC) VISIBLE,
  CONSTRAINT `FK_ItemPedidoPizza_Hst_ItemPedidoPizza`
    FOREIGN KEY (`IdItemPedidoPizza`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`ItemPedidoPizza` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemPedidoPizza_Hst_Pedido`
    FOREIGN KEY (`IdPedido`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`Pedido` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemPedidoPizza_Hst_TamanhoPizza`
    FOREIGN KEY (`IdTamanhoPizza`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`TamanhoPizza` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemPedidoPizza_Hst_SaborBorda`
    FOREIGN KEY (`IdSaborBorda`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`SaborBorda` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`ItemPizzaSabor`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`ItemPizzaSabor` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `IdItemPedidoPizza` INT UNSIGNED NOT NULL,
  `IdSaborPizza` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_ItemPIzzaSabor_ItemPedidoPIzza_idx` (`IdItemPedidoPizza` ASC) VISIBLE,
  INDEX `FK_ItemPizzaSabor_SaborPizza_idx` (`IdSaborPizza` ASC) VISIBLE,
  CONSTRAINT `FK_ItemPIzzaSabor_ItemPedidoPIzza`
    FOREIGN KEY (`IdItemPedidoPizza`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`ItemPedidoPizza` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemPizzaSabor_SaborPizza`
    FOREIGN KEY (`IdSaborPizza`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`SaborPizza` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DB_LaFamigliaPizzeriaDelivery`.`ItemPizzaSabor_Hst`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `DB_LaFamigliaPizzeriaDelivery`.`ItemPizzaSabor_Hst` (
  `Id` INT UNSIGNED NOT NULL AUTO_INCREMENT,
  `IdItemPIzzaSabor` INT UNSIGNED NOT NULL,
  `IdItemPedidoPizza` INT UNSIGNED NOT NULL,
  `IdSaborPizza` INT UNSIGNED NOT NULL,
  PRIMARY KEY (`Id`),
  UNIQUE INDEX `Id_UNIQUE` (`Id` ASC) VISIBLE,
  INDEX `FK_ItemPIzzaSabor_ItemPedidoPizza_idx` (`IdItemPedidoPizza` ASC) VISIBLE,
  INDEX `FK_ItemPizzaSabor_Hst_ItemPizzaSabor_idx` (`IdItemPIzzaSabor` ASC) VISIBLE,
  CONSTRAINT `FK_ItemPIzzaSabor_Hst_ItemPedidoPizza`
    FOREIGN KEY (`IdItemPedidoPizza`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`ItemPedidoPizza` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemPizzaSabor_Hst_SaborPIzza`
    FOREIGN KEY (`IdItemPedidoPizza`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`SaborPizza` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `FK_ItemPizzaSabor_Hst_ItemPizzaSabor`
    FOREIGN KEY (`IdItemPIzzaSabor`)
    REFERENCES `DB_LaFamigliaPizzeriaDelivery`.`ItemPizzaSabor` (`Id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
