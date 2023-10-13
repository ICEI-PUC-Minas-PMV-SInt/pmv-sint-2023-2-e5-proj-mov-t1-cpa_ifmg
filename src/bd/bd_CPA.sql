-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `mydb` DEFAULT CHARACTER SET utf8 ;
USE `mydb` ;

-- -----------------------------------------------------
-- Table `mydb`.`Campus`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Campus` (
  `idCampus` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(45) NULL,
  PRIMARY KEY (`idCampus`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Perfil`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Perfil` (
  `idPerfil` INT NOT NULL AUTO_INCREMENT,
  `Perfil` VARCHAR(45) NULL,
  PRIMARY KEY (`idPerfil`),
  UNIQUE INDEX `Perfil_UNIQUE` (`Perfil` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Usuário`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Usuário` (
  `idUsuário` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(200) NOT NULL,
  `CPF` BIGINT(11) NOT NULL,
  `E-mail` VARCHAR(45) NOT NULL,
  `Senha` INT NOT NULL,
  `Campus_idCampus` INT NOT NULL,
  `Perfil_idPerfil` INT NOT NULL,
  PRIMARY KEY (`idUsuário`),
  INDEX `fk_Usuário_Campus1_idx` (`Campus_idCampus` ASC) VISIBLE,
  INDEX `fk_Usuário_Perfil1_idx` (`Perfil_idPerfil` ASC) VISIBLE,
  UNIQUE INDEX `CPF_UNIQUE` (`CPF` ASC) VISIBLE,
  CONSTRAINT `fk_Usuário_Campus1`
    FOREIGN KEY (`Campus_idCampus`)
    REFERENCES `mydb`.`Campus` (`idCampus`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Usuário_Perfil1`
    FOREIGN KEY (`Perfil_idPerfil`)
    REFERENCES `mydb`.`Perfil` (`idPerfil`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Curso`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Curso` (
  `idCurso` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(45) NOT NULL,
  `Área_Atuação` VARCHAR(45) NOT NULL,
  `Eixo_Tecnológico` VARCHAR(45) NOT NULL,
  `Nível` VARCHAR(45) NOT NULL,
  `Campus_idCampus` INT NOT NULL,
  PRIMARY KEY (`idCurso`),
  INDEX `fk_Curso_Campus_idx` (`Campus_idCampus` ASC) VISIBLE,
  CONSTRAINT `fk_Curso_Campus`
    FOREIGN KEY (`Campus_idCampus`)
    REFERENCES `mydb`.`Campus` (`idCampus`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`table2`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`table2` (
)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Eixo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Eixo` (
  `idEixo` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(45) NOT NULL,
  `Número_Eixo` INT NOT NULL,
  PRIMARY KEY (`idEixo`),
  UNIQUE INDEX `Nome_UNIQUE` (`Nome` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Tipo`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Tipo` (
  `idTipo` INT NOT NULL AUTO_INCREMENT,
  `Tipo` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idTipo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Situação`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Situação` (
  `idSituação` INT NOT NULL AUTO_INCREMENT,
  `Situação` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`idSituação`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Proposta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Proposta` (
  `idProposta` INT NOT NULL AUTO_INCREMENT,
  `Data` DATETIME NOT NULL,
  `Campus_idCampus` INT NOT NULL,
  `Tipo_idTipo` INT NOT NULL,
  `Situação_idSituação` INT NOT NULL,
  PRIMARY KEY (`idProposta`),
  INDEX `fk_Proposta_Campus1_idx` (`Campus_idCampus` ASC) VISIBLE,
  INDEX `fk_Proposta_Tipo1_idx` (`Tipo_idTipo` ASC) VISIBLE,
  INDEX `fk_Proposta_Situação1_idx` (`Situação_idSituação` ASC) VISIBLE,
  CONSTRAINT `fk_Proposta_Campus1`
    FOREIGN KEY (`Campus_idCampus`)
    REFERENCES `mydb`.`Campus` (`idCampus`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Proposta_Tipo1`
    FOREIGN KEY (`Tipo_idTipo`)
    REFERENCES `mydb`.`Tipo` (`idTipo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Proposta_Situação1`
    FOREIGN KEY (`Situação_idSituação`)
    REFERENCES `mydb`.`Situação` (`idSituação`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Status`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Status` (
  `idStatus` INT NOT NULL AUTO_INCREMENT,
  `Status` VARCHAR(45) NULL,
  PRIMARY KEY (`idStatus`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Metas e Ações`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Metas e Ações` (
  `idMetas e Ações` INT NOT NULL AUTO_INCREMENT,
  `Meta` LONGTEXT NOT NULL,
  `Ação` LONGTEXT NOT NULL,
  `Responsável` VARCHAR(45) NOT NULL,
  `Data_Início` DATETIME NOT NULL,
  `Data_Fim` DATETIME NOT NULL,
  `Proposta_idProposta` INT NOT NULL,
  `Status_idStatus` INT NOT NULL,
  PRIMARY KEY (`idMetas e Ações`),
  INDEX `fk_Metas e Ações_Proposta1_idx` (`Proposta_idProposta` ASC) VISIBLE,
  INDEX `fk_Metas e Ações_Status1_idx` (`Status_idStatus` ASC) VISIBLE,
  CONSTRAINT `fk_Metas e Ações_Proposta1`
    FOREIGN KEY (`Proposta_idProposta`)
    REFERENCES `mydb`.`Proposta` (`idProposta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Metas e Ações_Status1`
    FOREIGN KEY (`Status_idStatus`)
    REFERENCES `mydb`.`Status` (`idStatus`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Dimensão`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Dimensão` (
  `idDimensão` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(45) NOT NULL,
  `Número_Dimensão` INT NOT NULL,
  `Eixo_idEixo` INT NOT NULL,
  PRIMARY KEY (`idDimensão`),
  INDEX `fk_Dimensão_Eixo1_idx` (`Eixo_idEixo` ASC) VISIBLE,
  CONSTRAINT `fk_Dimensão_Eixo1`
    FOREIGN KEY (`Eixo_idEixo`)
    REFERENCES `mydb`.`Eixo` (`idEixo`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Indicador`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Indicador` (
  `IdIndicador` INT NOT NULL AUTO_INCREMENT,
  `Código` VARCHAR(6) NOT NULL,
  `Nome` VARCHAR(200) NOT NULL,
  `Dimensão_idDimensão` INT NOT NULL,
  PRIMARY KEY (`IdIndicador`),
  INDEX `fk_Indicador_Dimensão1_idx` (`Dimensão_idDimensão` ASC) VISIBLE,
  UNIQUE INDEX `Código_UNIQUE` (`Código` ASC) VISIBLE,
  CONSTRAINT `fk_Indicador_Dimensão1`
    FOREIGN KEY (`Dimensão_idDimensão`)
    REFERENCES `mydb`.`Dimensão` (`idDimensão`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Questionário`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Questionário` (
  `idQuestionário` INT NOT NULL AUTO_INCREMENT,
  `Ano` INT NOT NULL,
  `Ciclo` INT NOT NULL,
  `Data_Início` DATE NOT NULL,
  `Data_Fim` DATE NOT NULL,
  PRIMARY KEY (`idQuestionário`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Membros`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Membros` (
  `idMembros` INT NOT NULL AUTO_INCREMENT,
  `Nome` VARCHAR(200) NOT NULL,
  `E-mail` VARCHAR(45) NOT NULL,
  `Telefone` VARCHAR(45) NOT NULL,
  `Representação` VARCHAR(45) NOT NULL,
  `Função` VARCHAR(45) NOT NULL,
  `Data_Início` DATETIME NOT NULL,
  `Data_Fim` DATETIME NULL,
  PRIMARY KEY (`idMembros`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Cronograma`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Cronograma` (
  `idCronograma` INT NOT NULL AUTO_INCREMENT,
  `Descrição_Atividades` LONGTEXT NOT NULL,
  `Responsável` VARCHAR(45) NOT NULL,
  `Data_Início` DATETIME NOT NULL,
  `Data_Fim` DATETIME NOT NULL,
  `Procedimentos` LONGTEXT NOT NULL,
  `Proposta_idProposta` INT NOT NULL,
  PRIMARY KEY (`idCronograma`),
  INDEX `fk_Cronograma_Proposta1_idx` (`Proposta_idProposta` ASC) VISIBLE,
  CONSTRAINT `fk_Cronograma_Proposta1`
    FOREIGN KEY (`Proposta_idProposta`)
    REFERENCES `mydb`.`Proposta` (`idProposta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Melhoria`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Melhoria` (
  `idMelhoria` INT NOT NULL AUTO_INCREMENT,
  `Descrição` LONGTEXT NOT NULL,
  `Observação` LONGTEXT NOT NULL,
  `Proposta_idProposta` INT NOT NULL,
  `Status_idStatus` INT NOT NULL,
  PRIMARY KEY (`idMelhoria`),
  INDEX `fk_Melhoria_Proposta1_idx` (`Proposta_idProposta` ASC) VISIBLE,
  INDEX `fk_Melhoria_Status1_idx` (`Status_idStatus` ASC) VISIBLE,
  CONSTRAINT `fk_Melhoria_Proposta1`
    FOREIGN KEY (`Proposta_idProposta`)
    REFERENCES `mydb`.`Proposta` (`idProposta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Melhoria_Status1`
    FOREIGN KEY (`Status_idStatus`)
    REFERENCES `mydb`.`Status` (`idStatus`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Membros_Proposta`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Membros_Proposta` (
  `IdMembros_Proposta` INT NOT NULL AUTO_INCREMENT,
  `Membros_idMembros` INT NOT NULL,
  `Proposta_idProposta` INT NOT NULL,
  INDEX `fk_Membros_has_Proposta_Proposta1_idx` (`Proposta_idProposta` ASC) VISIBLE,
  INDEX `fk_Membros_has_Proposta_Membros1_idx` (`Membros_idMembros` ASC) VISIBLE,
  PRIMARY KEY (`IdMembros_Proposta`),
  CONSTRAINT `fk_Membros_has_Proposta_Membros1`
    FOREIGN KEY (`Membros_idMembros`)
    REFERENCES `mydb`.`Membros` (`idMembros`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Membros_has_Proposta_Proposta1`
    FOREIGN KEY (`Proposta_idProposta`)
    REFERENCES `mydb`.`Proposta` (`idProposta`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Dimensão_Questionário`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Dimensão_Questionário` (
  `Dimensão_idDimensão` INT NOT NULL,
  `Questionário_idQuestionário` INT NOT NULL,
  PRIMARY KEY (`Dimensão_idDimensão`, `Questionário_idQuestionário`),
  INDEX `fk_Dimensão_has_Questionário_Questionário1_idx` (`Questionário_idQuestionário` ASC) VISIBLE,
  INDEX `fk_Dimensão_has_Questionário_Dimensão1_idx` (`Dimensão_idDimensão` ASC) VISIBLE,
  CONSTRAINT `fk_Dimensão_has_Questionário_Dimensão1`
    FOREIGN KEY (`Dimensão_idDimensão`)
    REFERENCES `mydb`.`Dimensão` (`idDimensão`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Dimensão_has_Questionário_Questionário1`
    FOREIGN KEY (`Questionário_idQuestionário`)
    REFERENCES `mydb`.`Questionário` (`idQuestionário`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `mydb`.`Respostas`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `mydb`.`Respostas` (
  `IdResposta` INT NOT NULL AUTO_INCREMENT,
  `Indicador_IdIndicador` INT NOT NULL,
  `Usuário_idUsuário` INT NOT NULL,
  `Dimensão_Questionário_Dimensão_idDimensão` INT NOT NULL,
  `Dimensão_Questionário_Questionário_idQuestionário` INT NOT NULL,
  `Resposta` VARCHAR(45) NOT NULL,
  `Data` DATETIME NOT NULL,
  PRIMARY KEY (`IdResposta`),
  INDEX `fk_Respostas_Indicador1_idx` (`Indicador_IdIndicador` ASC) VISIBLE,
  INDEX `fk_Respostas_Usuário1_idx` (`Usuário_idUsuário` ASC) VISIBLE,
  INDEX `fk_Respostas_Dimensão_Questionário1_idx` (`Dimensão_Questionário_Dimensão_idDimensão` ASC, `Dimensão_Questionário_Questionário_idQuestionário` ASC) VISIBLE,
  CONSTRAINT `fk_Respostas_Indicador1`
    FOREIGN KEY (`Indicador_IdIndicador`)
    REFERENCES `mydb`.`Indicador` (`IdIndicador`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Respostas_Usuário1`
    FOREIGN KEY (`Usuário_idUsuário`)
    REFERENCES `mydb`.`Usuário` (`idUsuário`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Respostas_Dimensão_Questionário1`
    FOREIGN KEY (`Dimensão_Questionário_Dimensão_idDimensão` , `Dimensão_Questionário_Questionário_idQuestionário`)
    REFERENCES `mydb`.`Dimensão_Questionário` (`Dimensão_idDimensão` , `Questionário_idQuestionário`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
