DROP TABLE Capital;
DROP TABLE TownInCountry;
DROP TABLE Country;

CREATE TABLE Capital (
    id_capital int  NOT NULL IDENTITY,
    capitalName varchar(64)  NOT NULL,
    id_country int  NOT NULL,
    CONSTRAINT Capital_pk PRIMARY KEY  (id_capital)
);

CREATE TABLE Country (
    id_country int  NOT NULL IDENTITY,
    countryName varchar(64)  NOT NULL,
    CONSTRAINT Country_pk PRIMARY KEY  (id_country)
);

CREATE TABLE TownInCountry (
    id_townInCountry int  NOT NULL IDENTITY,
    id_country int  NOT NULL,
    CONSTRAINT TownInCountry_pk PRIMARY KEY  (id_townInCountry)
);


ALTER TABLE Capital ADD CONSTRAINT Capital_Country
    FOREIGN KEY (id_country)
    REFERENCES Country (id_country);


ALTER TABLE TownInCountry ADD CONSTRAINT TownInCountry_Country
    FOREIGN KEY (id_country)
    REFERENCES Country (id_country);


INSERT INTO Country	(countryName)
VALUES
('Poland'), ('Germany'), ('France');

INSERT INTO Capital (capitalName, id_country)
VALUES
('Warsaw', 1), ('Berlin', 2), ('Paris', 3);

INSERT INTO TownInCountry(id_country)
VALUES 
(1), (2), (3);